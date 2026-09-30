use DVLD;
go


create or alter procedure usp_FindAppointmentByTestAppointmentID
@TestAppointmentID int
as
begin
	set nocount on;
	select * from TestAppointments where TestAppointmentID = @TestAppointmentID;
end

go

create or alter procedure usp_AddNewTestAppointment
@TestTypeID int,
@LocalDrivingLicenseApplicationID int,
@AppointmentDate datetime,
@PaidFees decimal(10, 2),
@CreatedByUserID int,
@IsLocked bit,
@isRetakeAppointment bit,
@NewID int output
as
begin
	set nocount on;
	set xact_abort on;
	-- preparing needed variables
	declare @NewRetakeApplicationID int = -1;
	declare @NewRetakeApplicationFees decimal(10, 2);
	declare @PersonID int = -1;
	declare @CurrentDate datetime = getdate();
	declare @ErrorMessage nvarchar(2048);

	begin try
		if @isRetakeAppointment = 1
		begin
			set @NewRetakeApplicationFees = dbo.GetApplicationFeesByTypeID(7);
			
			if @NewRetakeApplicationFees = -1
				begin
					set @ErrorMessage = 'Could not find application fees';
					throw 50000, @ErrorMessage, 1;
				end

			select @PersonID = base.ApplicantPersonID from Applications as base
			inner join LocalDrivingLicenseApplications as local
			on local.ApplicationID = base.ApplicationID
			where local.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;
			
			if @PersonID = -1
			begin
				set @ErrorMessage = 'Could not find PersonID using local application ID';
				throw 50000, @ErrorMessage, 1;
			end
			-- creating retake application THEN the test appointment
			begin transaction

				exec usp_AddNewApplication @PersonID, @CurrentDate, 7, 3, @CurrentDate, 
					@NewRetakeApplicationFees, @CreatedByUserID, @NewRetakeApplicationID output;

				insert into TestAppointments 
				(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees,
				CreatedByUserID, IsLocked, RetakeTestApplicationID)
				values 
				(@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees,
				@CreatedByUserID, @IsLocked, @NewRetakeApplicationID);

			set @NewID = scope_identity();
			commit transaction;
			end
		else
			begin
				insert into TestAppointments 
				(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees,
				CreatedByUserID, IsLocked, RetakeTestApplicationID)
				values 
				(@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees,
				@CreatedByUserID, @IsLocked, null);

				set @NewID = scope_identity();
		end
	end try
	begin catch 
	if @@TRANCOUNT > 0
		rollback transaction;

	throw;
	end catch
end

go


create or alter procedure usp_UpdateTestAppointment
@TestAppointmentID int,
@TestTypeID int,
@LocalDrivingLicenseApplicationID int,
@AppointmentDate datetime,
@PaidFees decimal(10, 2),
@CreatedByUserID int,
@IsLocked bit,
@RetakeTestApplicationID int

as
begin
	update TestAppointments 
    set TestTypeID = @TestTypeID, LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID, AppointmentDate = @AppointmentDate, PaidFees = @PaidFees,
    CreatedByUserID = @CreatedByUserID, IsLocked = @IsLocked, RetakeTestApplicationID = @RetakeTestApplicationID
    where TestAppointmentID = @TestAppointmentID;
end

go


create or alter procedure usp_GetAllTestAppointments
as
begin
	set nocount on;
	select * from TestAppointments order by AppointmentDate desc;
end

go


create or alter procedure usp_GetTodaysAppointments
as
begin
	set nocount on;
	select TestAppointmentID, AppointmentDate, IsLocked, IsTestTaken = 
    cast(
	    case 
            when EXISTS (select foud = 1 from Tests where Tests.TestAppointmentID = TestAppointments.TestAppointmentID) 
            then 1 
            else 0 
        end as bit)
    from TestAppointments 
    where cast(AppointmentDate as date) = cast(GETDATE() as date)
    order by TestAppointmentID desc;
end

go


create or alter procedure usp_GetAllTestAppointmentsByTestTypeID
@LocalDrivingLicenseApplicationID int,
@TestTypeID int
as
begin
	set nocount on;
	select TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, TestAppointments.PaidFees, TestAppointments.IsLocked
    from TestAppointments
    where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID
    order by TestAppointments.AppointmentDate desc;
end

go


create or alter procedure usp_GetLastTestAppointmentByTestTypeID
@LocalDrivingLicenseApplicationID int,
@TestTypeID int
as
begin
	set nocount on;
    select top 1 * from TestAppointments
    where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID 
    order by TestAppointmentID desc;
end

go


create or alter procedure usp_IsTestAppointmentLocked
@TestAppointmentID int,
@IsLocked bit output
as
begin
	set nocount on;
	
	if exists(select Found = 1 from TestAppointments where TestAppointmentID = @TestAppointmentID and IsLocked = 1)
		set @IsLocked = 1;
	else
		set @IsLocked = 0;
end