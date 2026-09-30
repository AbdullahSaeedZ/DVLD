use DVLD;
go


create or alter procedure usp_FindByTestID
@TestID int
as
begin
	set nocount on;
	select * from Tests where TestID = @TestID ;
end

go

create or alter procedure usp_FindTestByTestAppointmentID
@TestAppointmentID int
as
begin
	set nocount on;
	select * from Tests where TestAppointmentID = @TestAppointmentID;
end

go


create or alter procedure usp_FindLastTestPerPersonAndLicenseClass
@ApplicantPersonID int,
@LicenseClassID int,
@TestTypeID int
as
begin
	set nocount on;
	select top 1 Tests.* from Tests
    inner join TestAppointments TA on TA.TestAppointmentID = Tests.TestAppointmentID 
    inner join LocalDrivingLicenseApplications LA on LA.LocalDrivingLicenseApplicationID =  TA.LocalDrivingLicenseApplicationID
    inner join Applications on Applications.ApplicationID = LA.ApplicationID
    where ApplicantPersonID = @ApplicantPersonID and LA.LicenseClassID = @LicenseClassID and TA.TestTypeID = @TestTypeID 
    order by TestID desc;
	
end

go

create or alter procedure usp_AddNewTest
@TestAppointmentID int,
@TestResult int,
@CreatedByUserID int,
@Notes varchar(max),
@NewTestID int output
as
begin
	set nocount on;
	set xact_abort on;
	begin try
		declare @ErrorMessage nvarchar(2048);

		begin transaction
		update TestAppointments 
		set IsLocked=1 where TestAppointmentID = @TestAppointmentID;

		if @@ROWCOUNT = 0
		begin
			set @ErrorMessage = concat('Could not update appointment with ID', @TestAppointmentID, ' to locked');
			throw 50000, @ErrorMessage, 1;
		end;

		-- if the test was created on a retake application, then we set it to completed
		-- test can be on retake application, or without retake application
		update Applications
		set ApplicationStatus = 3 from Applications 
		inner join TestAppointments on TestAppointments.ReTakeTestApplicationID = Applications.ApplicationID
		where TestAppointments.TestAppointmentID = @TestAppointmentID;

		insert into Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
		values (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);

		set @NewTestID = scope_identity();
		commit transaction;
	end try
	begin catch
		if @@TRANCOUNT > 0
			rollback transaction;

			throw;
	end catch
end

go


create or alter procedure usp_UpdateTest
@TestAppointmentID int,
@TestResult bit,
@Notes varchar(max),
@CreatedByUserID int,
@TestID int
as
begin
	update Tests 
    set TestAppointmentID = @TestAppointmentID, TestResult = @TestResult, 
	Notes = @Notes, CreatedByUserID = @CreatedByUserID
    where TestID = @TestID;
end

go


create or alter procedure usp_GetAllTests
as
begin
	set nocount on;
	select * from Tests;
end

go


create or alter procedure usp_IsTestPassedByAppointmentId
@TestAppointmentID int,
@IsPassed bit output
as
begin
	set nocount on;

    if exists(
		select Tests.TestResult from Tests 
		inner join TestAppointments on Tests.TestAppointmentID = TestAppointments.TestAppointmentID 
		where TestAppointments.TestAppointmentID = @TestAppointmentID and Tests.TestResult = 1
	)
		set @IsPassed = 1;
	else
		set @IsPassed = 0;
end

go


create or alter procedure usp_GetTestIDByAppointmentID
@TestAppointmentID int,
@TestID int output
as
begin
	set nocount on;
	set @TestID = -1;
	select @TestID = TestID from Tests where TestAppointmentID = @TestAppointmentID;
end