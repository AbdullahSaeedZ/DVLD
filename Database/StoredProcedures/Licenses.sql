use DVLD;
go

create or alter procedure usp_FindLicenseByLicenseID
@LicenseID int
as
begin
	set nocount on;
	select * from Licenses where LicenseID = @LicenseID ;
end

go

create or alter procedure usp_AddNewLicense
@ApplicationID int,
@DriverID int,
@LicenseClassID int,
@IssueDate datetime,
@ExpirationDate datetime,
@PaidFees decimal(10, 2),
@IsActive bit,
@IssueReason int,
@CreatedByUserID int,
@Notes nvarchar(max),
@NewLicenseID int output
as
begin
	set nocount on;
	set xact_abort on;
	begin try
	    -- prepareing variables before transaction
		declare @PersonID int = -1;
		declare @ApplicationFees decimal(10, 2) = -1;
		set @NewLicenseID = -1;
		declare @ErrorMessage nvarchar(2048);

		-- if driver id is provided, then it is not first time license issuance
		if @DriverID <> -1
		begin 
			select @PersonID = PersonID from Drivers where DriverID = @DriverID;

			if @PersonID = -1
			begin
				set @ErrorMessage = 'Could not find PersonID';
				throw 50000, @ErrorMessage, 1;
			end
		end
		
		-- moved from transaction block to make transactoin as short as possible
		if @ApplicationID = -1
			begin

				set @ApplicationFees = dbo.GetApplicationFeesByTypeID(@IssueReason);

				if @ApplicationFees = -1
				begin
					set @ErrorMessage = 'Could not find application fees';
					throw 50000, @ErrorMessage, 1;
				end
			end

		begin transaction
			-- if no application id provided, it means this isnt a first time license
			-- otherwise application id of first time type will be sent for first time license 
			if @ApplicationID = -1
				begin
					-- creating a new application, type is matching the issue reason 
					exec usp_AddNewApplication @PersonID, @IssueDate, @IssueReason, 3, @IssueDate, 
					@ApplicationFees, @CreatedByUserID, @ApplicationID output;
				
					if @ApplicationID <= 0
					begin
						set @ErrorMessage = 'Could not create a new application for license issuance';
						throw 50000, @ErrorMessage, 1;
					end
				end
			else
				begin
				-- when application id is provided, which is of first time type, we update to completed 
				-- then get needed info to issue the license
					update Applications set ApplicationStatus = 3, LastStatusDate = @IssueDate
					where ApplicationID = @ApplicationID;
					if @@ROWCOUNT = 0
					begin
						set @ErrorMessage = concat('Could not update application with ID', @ApplicationID);
						throw 50000, @ErrorMessage, 1;
					end

					-- get personID from applications
					select @PersonID = ApplicantPersonID from Applications where ApplicationID = @ApplicationID;
					-- if no driver record, create new before issuing a new first time license
					select @DriverID = DriverID from Drivers where PersonID = @PersonID
					if  @DriverID = -1
					begin
						exec usp_AddNewDriver @PersonID, @CreatedByUserID, @IssueDate, @DriverID output
					end
			end

			-- if renewal-replacement, then we deactivate existing license
			update Licenses set IsActive = 0 
			where DriverID = @DriverID and LicenseClass = @LicenseClassID and IsActive = 1;

			insert into Licenses 
			(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes,
			PaidFees, IsActive, IssueReason, CreatedByUserID)
			values 
			(@ApplicationID, @DriverID, @LicenseClassID, @IssueDate, @ExpirationDate, @Notes,
			@PaidFees, @IsActive, @IssueReason, @CreatedByUserID);

			set @NewLicenseID = scope_identity();
		commit transaction;
	end try
	begin catch
		
		if @@TRANCOUNT > 0
			rollback transaction;

		throw;
	end catch
end

go


create or alter procedure usp_UpdateLicense
@LicenseID int,
@ApplicationID int,
@DriverID int,
@LicenseClassID int,
@IssueDate datetime,
@ExpirationDate datetime,
@PaidFees decimal(10, 2),
@IsActive bit,
@IssueReason int,
@CreatedByUserID int,
@Notes nvarchar(max)
as
begin
	update Licenses 
    set ApplicationID = @ApplicationID, DriverID = @DriverID, LicenseClass = @LicenseClassID, IssueDate = @IssueDate, 
    ExpirationDate = @ExpirationDate, Notes = @Notes, PaidFees = @PaidFees, IsActive = @IsActive, IssueReason = @IssueReason, CreatedByUserID = @CreatedByUserID
    where LicenseID = @LicenseID;
end

go

create or alter procedure usp_DidPersonIssueLicense
@PersonID int,
@LicenseClassID int,
@didIssue bit output
as
begin
	set nocount on;

	if exists (select 1 from Licenses
    inner join Drivers on Drivers.DriverID = Licenses.DriverID
    where Drivers.PersonID = @PersonID and Licenses.LicenseClass = @LicenseClassID)
		set @didIssue = 1;
	else
		set @didIssue = 0;
end

go

create or alter procedure usp_DeactivateLicense
@LicenseID int
as
begin
	update Licenses set IsActive = 0 where LicenseID = @LicenseID;
end

go

create or alter procedure usp_GetActiveLicenseIDByPersonID
@PersonID int,
@LicenseClassID int,
@ActiveLicenseID int output
as
begin
	set nocount on;
	set @ActiveLicenseID = -1;

	select @ActiveLicenseID = Licenses.LicenseID
    from Licenses 
    inner join Drivers on Licenses.DriverID = Drivers.DriverID
    where Licenses.LicenseClass = @LicenseClassID and Drivers.PersonID = @PersonID and IsActive = 1;
	
end

go

create or alter procedure usp_GetLicenseIDbyLocalApplicationID
@LocalApplicationID int,
@LicenseID int output
as
begin
	set nocount on;
	set @LicenseID = -1;

	select @LicenseID = Licenses.LicenseID 
    from Licenses
    inner join LocalDrivingLicenseApplications as LA on LA.ApplicationID = Licenses.ApplicationID
    where LA.LocalDrivingLicenseApplicationID = @LocalApplicationID;
	
end

go

create or alter procedure usp_GetAllLicenses
@DetainID int
as
begin
	set nocount on;
	select * from Licenses;
end

go

create or alter procedure usp_GetAllLocalLicensesByPersonID
@PersonID int
as
begin
	set nocount on;
	select Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
    from Licenses 
    inner join Drivers on Drivers.DriverID = Licenses.DriverID
    inner join LicenseClasses on LicenseClasses.LicenseClassID = Licenses.LicenseClass
    where Drivers.PersonID = @PersonID;
	
end