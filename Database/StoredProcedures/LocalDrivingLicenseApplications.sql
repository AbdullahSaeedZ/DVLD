use DVLD;
go

create or alter procedure usp_FindLocalLicenseApplicationByID
@LocalApplicationID int
as
begin
	set nocount on;
	
	select LocalDrivingLicenseApplications.*, 
    Vision  = max(case when TestAppointments.TestTypeID = 1 and Tests.TestResult = 1 then 1 else 0 end),
	Written = max(case when TestAppointments.TestTypeID = 2 and Tests.TestResult = 1 then 1 else 0 end),
	Street  = max(case when TestAppointments.TestTypeID = 3 and Tests.TestResult = 1 then 1 else 0 end)
    from LocalDrivingLicenseApplications
    left join TestAppointments on TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
    left join Tests on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
    where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalApplicationID
    group by LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, 
	LocalDrivingLicenseApplications.ApplicationID,LocalDrivingLicenseApplications.LicenseClassID;
end

go

create or alter procedure usp_FindLocalLicenseApplicationByApplicationID
@baseApplicationID int
as
begin
	set nocount on;
	
	select LocalDrivingLicenseApplications.*, 
    Vision  = max(case when TestAppointments.TestTypeID = 1 and Tests.TestResult = 1 then 1 else 0 end),
	Written = max(case when TestAppointments.TestTypeID = 2 and Tests.TestResult = 1 then 1 else 0 end),
	Street  = max(case when TestAppointments.TestTypeID = 3 and Tests.TestResult = 1 then 1 else 0 end)
    from LocalDrivingLicenseApplications
    left join TestAppointments on TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
    left join Tests on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
    where LocalDrivingLicenseApplications.ApplicationID = @baseApplicationID
    group by LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
	LocalDrivingLicenseApplications.ApplicationID,LocalDrivingLicenseApplications.LicenseClassID;
end

go


create or alter procedure usp_AddLocalLicenseApplication
@baseApplicationID int,
@licenseClassID int,
@NewLocalLicenseApplicationID int output
as
begin
	set nocount on;

	insert into LocalDrivingLicenseApplications
	( ApplicationID, LicenseClassID)
    values
	( @baseApplicationID, @LicenseClassID);

    set @NewLocalLicenseApplicationID = scope_identity();
end

go

create or alter procedure usp_UpdateLocalLicenseApplication
@LicenseClassID int,
@LocalApplicationID int
as
begin
	update LocalDrivingLicenseApplications
    set LicenseClassID = @LicenseClassID
    where LocalDrivingLicenseApplicationID = @LocalApplicationID;
end




go

create or alter procedure usp_DeleteLocalDrivingLicenseApplication
@LocalApplicationID int
as
begin
	set nocount on;
	set xact_abort on;
	begin try
		declare @baseApplicationID int = -1;
		declare @ErrorMessage nvarchar(2048);

		select @baseApplicationID = ApplicationID 
		from LocalDrivingLicenseApplications 
		where LocalDrivingLicenseApplicationID = @LocalApplicationID;

		if @baseApplicationID = -1
		begin
			set @ErrorMessage = concat('Could not find Base Application ID of Local Application ID', @LocalApplicationID);
			throw 50000, @ErrorMessage, 1;
		end

		begin transaction
			delete from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalApplicationID;
			delete from Applications where ApplicationID = @baseApplicationID;
		commit transaction
	end try
	begin catch
		if @@TRANCOUNT > 0
			rollback transaction;

		throw;
	end catch
end

go





create or alter procedure usp_GetAllLocalDrivingLicenseApplications
as
begin
	set nocount on;
	select * from LocalDrivingLicenseApplications_View order by ApplicationDate desc;
end

go

create or alter procedure usp_GetActiveLocalApplicationID
@ApplicantPersonID int,
@LicenseClassID int,
@ActiveLocalApplicationID int output
as
begin
	set nocount on;
	set @ActiveLocalApplicationID = -1;

	select @ActiveLocalApplicationID = LocalDrivingLicenseApplicationID
    from LocalDrivingLicenseApplications 
    inner join Applications on LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
    where LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID and 
	Applications.ApplicantPersonID = @ApplicantPersonID and Applications.ApplicationStatus = 1;
end

go

create or alter procedure usp_GetTotalTestTrialsPerTestType
@LocalApplicationID int,
@TestTypeID int,
@TotalTrials int output
as
begin
	set nocount on;
	set @TotalTrials = 0;

	select @TotalTrials = count(TestAppointmentID)
    from TestAppointments 
    where LocalDrivingLicenseApplicationID = @LocalApplicationID and 
	TestTypeID = @TestTypeID and IsLocked = 1;
end

go

create or alter procedure usp_IsThereActiveTestAppointment
@LocalApplicationID int,
@TestTypeID int,
@isThereActiveAppointment bit output
as
begin
	set nocount on;
	if exists
	(
		select top 1 Found = 1 from TestAppointments
        where LocalDrivingLicenseApplicationID = @LocalApplicationID and
		TestTypeID = @TestTypeID and IsLocked = 0
        order by TestAppointments.TestAppointmentID desc
	)
		set @isThereActiveAppointment = 1;
	else
		set @isThereActiveAppointment = 0;

end

go

create or alter procedure usp_DoesHaveAnyAppointmentsRecords
@LocalApplicationID int,
@hasAnyAppointment bit output
as
begin
	set nocount on;
	 
	 if exists
	(
		select top 1 Found = 1 from TestAppointments
        where LocalDrivingLicenseApplicationID = @LocalApplicationID
	)
		set @hasAnyAppointment = 1;
	else
		set @hasAnyAppointment = 0;
end

go

create or alter procedure usp_DidAttendAppointmentOfTestType
@LocalApplicationID int,
@TestTypeID int,
@didAttend bit output
as
begin
	set nocount on;

	 if exists
	(
		select top 1 Found = 1 from TestAppointments
        where LocalDrivingLicenseApplicationID = @LocalApplicationID 
		and TestTypeID = @TestTypeID
	)
		set @didAttend = 1;
	else
		set @didAttend = 0;
	 
end