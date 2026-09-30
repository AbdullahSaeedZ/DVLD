use DVLD;
go

create or alter procedure usp_FindInternationalLicenseByID
@InternationalLicenseID int
as
begin
	set nocount on;
	select * from InternationalLicenses where InternationalLicenseID = @InternationalLicenseID ;
end

go





create or alter procedure usp_AddNewInternationalLicense
@DriverID int,
@IssuedUsingLicenseID int,
@IssueDate datetime,
@ExpirationDate datetime,
@IsActive bit,
@CreatedByUserID int,
@NewInterNationalLicenseID int output
as
begin
	set nocount on;
	set xact_abort on;
	begin try
	    -- prepareing variables before transaction
		declare @PersonID int = -1;
		declare @InternationalApplicationTypeID int = 6;
		declare @InternationalApplicationFees decimal(10, 2) = -1;
		declare @NewInternationlApplicationID int = -1;
		set @NewInterNationalLicenseID = -1;
		declare @ErrorMessage nvarchar(2048);

		select @PersonID = PersonID from Drivers where DriverID = @DriverID;

		if @PersonID = -1
		begin
			set @ErrorMessage = 'Could not find PersonID';
			throw 50000, @ErrorMessage, 1;
		end

		set @InternationalApplicationFees = dbo.GetApplicationFeesByTypeID(@InternationalApplicationTypeID);

		if @InternationalApplicationFees = -1
		begin
			set @ErrorMessage = 'Could not find application fees';
			throw 50000, @ErrorMessage, 1;
		end

		begin transaction
			-- creating a new application of new international type as complete
			exec usp_AddNewApplication @PersonID, @IssueDate, @InternationalApplicationTypeID, 3, @IssueDate, 
			@InternationalApplicationFees, @CreatedByUserID, @NewInternationlApplicationID output;
				
			if @NewInternationlApplicationID <= 0
			begin
				set @ErrorMessage = 'Could not create new internationl application';
				throw 50000, @ErrorMessage, 1;
			end

			-- deactivating any other international license (one active per driver allowed)
			update InternationalLicenses set IsActive = 0 where DriverID = @DriverID;
	
			insert into InternationalLicenses 
			(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate,
			ExpirationDate, IsActive, CreatedByUserID)
			values
			(@NewInternationlApplicationID, @DriverID, @IssuedUsingLicenseID, @IssueDate,
			@ExpirationDate, @IsActive, @CreatedByUserID);

			set @NewInterNationalLicenseID = scope_identity();
		commit transaction;
	end try
	begin catch
		
		if @@TRANCOUNT > 0
			rollback transaction;

		throw;
	end catch
end

go




create or alter procedure usp_UpdateInternationalLicense
@InternationalLicenseID int,
@ApplicationID int,
@DriverID int,
@IssuedUsingLicenseID int,
@IssueDate datetime,
@ExpirationDate datetime,
@IsActive bit,
@CreatedByUserID int

as
begin
	update InternationalLicenses 
    set ApplicationID = @ApplicationID, DriverID = @DriverID, IssuedUsingLocalLicenseID = @IssuedUsingLicenseID, IssueDate = @IssueDate, 
    ExpirationDate = @ExpirationDate, IsActive = @IsActive, CreatedByUserID = @CreatedByUserID
    where InternationalLicenseID = @InternationalLicenseID;
end

go

create or alter procedure usp_GetActiveInternationalLicenseIDByPersonID
@PersonID int,
@InterNationalLicenseID int output
as
begin
	set nocount on;
	set @InterNationalLicenseID = -1;

	select @InterNationalLicenseID = InternationalLicenses.InternationalLicenseID
    from InternationalLicenses 
    inner join Drivers on InternationalLicenses.DriverID = Drivers.DriverID
    where Drivers.PersonID = @PersonID and IsActive = 1;
end

go

create or alter procedure usp_GetAllInternationalLicenses
as
begin
	set nocount on;
	select InternationalLicenseID, ApplicationID, DriverID, 
	IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
    from InternationalLicenses order by IssueDate desc;
end

go

create or alter procedure usp_GetAllInternationalLicensesByPersonID
@PersonID int
as
begin
	set nocount on;
	select InternationalLicenses.InternationalLicenseID, InternationalLicenses.ApplicationID, InternationalLicenses.IssuedUsingLocalLicenseID,
    InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive
    from InternationalLicenses 
    inner join Drivers on Drivers.DriverID = InternationalLicenses.DriverID
    where Drivers.PersonID = @PersonID
	
end
