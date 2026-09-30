use DVLD;
go

create or alter procedure usp_FindByDetainID
@DetainID int
as
begin
	set nocount on;
	select * from DetainedLicenses where DetainID = @DetainID;
end

go

create or alter procedure usp_FindDetainedLicenseByLicenseID
@LicenseID int
as
begin
	set nocount on;
	select top 1 * from DetainedLicenses where LicenseID = @LicenseID order by DetainID desc;
end

go


create or alter procedure usp_AddNewDetainLicense
@LicenseID int,
@DetainDate datetime,
@FineFees decimal(10, 2),
@CreatedByUserID int,
@NewDetainID int output
as
begin
	set nocount on;
	insert into DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased)
    values (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0);

    set @NewDetainID = scope_identity();
end

select * from DetainedLicenses;

go


create or alter procedure usp_UpdateDetainedLicense
@DetainID int,
@IsReleased bit,
@ReleaseDate datetime,
@ReleasedByUserID int,
@ReleaseApplicationID int
as
begin
	update DetainedLicenses 
    set IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID
    where DetainID = @DetainID;
end

go

create or alter procedure usp_ReleaseDetainedLicense
@LicenseID int,
@ReleaseDate datetime,
@ReleasedByUserID int,
@NewReleaseApplicationID int output
as
begin
	set nocount on;
	set xact_abort on;
	begin try
	    -- prepareing variables before transaction
		declare @PersonID int = -1;
		declare @ReleaseApplicationTypeID int = 5;
		declare @ReleaseApplicationFees decimal(10, 2) = -1;
		set @NewReleaseApplicationID = -1;
		declare @ErrorMessage nvarchar(2048);

		select @PersonID = d.PersonID
		from Drivers as d inner join Licenses as l on l.DriverID = d.DriverID
		where l.LicenseID = @LicenseID;
	
		if @PersonID = -1
		begin
			set @ErrorMessage = concat('Could not PersonID of License with ID', @LicenseID);
			throw 50000, @ErrorMessage, 1;
		end

		select @ReleaseApplicationFees = dbo.GetApplicationFeesByTypeID(@ReleaseApplicationTypeID);

		if @ReleaseApplicationFees = -1
		begin
			set @ErrorMessage = 'Could not find release application fees';
			throw 50000, @ErrorMessage, 1;
		end

		begin transaction
			-- creating a new application of release type as complete
			exec usp_AddNewApplication @PersonID, @ReleaseDate, @ReleaseApplicationTypeID, 3, @ReleaseDate, 
			@ReleaseApplicationFees, @ReleasedByUserID, @NewReleaseApplicationID output;
				
			if @NewReleaseApplicationID <= 0
			begin
				set @ErrorMessage = concat('Could not create release application for license with ID',@LicenseID);
				throw 50000, @ErrorMessage, 1;
			end

			-- releasing the detained license
			update DetainedLicenses 
			set IsReleased = 1, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID,
			ReleaseApplicationID = @NewReleaseApplicationID
			where LicenseID = @LicenseID and IsReleased = 0;

			if @@ROWCOUNT = 0
			begin
				set @ErrorMessage = concat('Could not update detained license with ID', @LicenseID, ' to released');
				throw 50000, @ErrorMessage, 1;
			end

		commit transaction;
	end try
	begin catch
		
		if @@TRANCOUNT > 0
			rollback transaction;

		throw;
	end catch
end

go


create or alter procedure usp_IsLicenseDetained
@LicenseID int,
@IsDetained bit output
as
begin
	set nocount on;
	if exists(select 1 from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0)
		set @IsDetained = 1;
	else
		set @IsDetained = 0;
end

go


create or alter procedure usp_GetAllDetainedLicenses
as
begin
	set nocount on;
	select DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.FineFees,
    DetainedLicenses.IsReleased, DetainedLicenses.ReleaseDate, People.NationalNo,
    FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName, '') + People.LastName, DetainedLicenses.ReleaseApplicationID
    from DetainedLicenses
    inner join Licenses on Licenses.LicenseID = DetainedLicenses.LicenseID
    inner join Drivers on Drivers.DriverID = Licenses.DriverID
    inner join People on People.PersonID = Drivers.PersonID
    order by DetainDate desc;
end