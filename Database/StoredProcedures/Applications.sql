use DVLD;
go


create or alter procedure usp_FindApplicationByID
@ApplicationID int
as
begin
	set nocount on;
	select * from Applications where ApplicationID = @ApplicationID;
end

go


create or alter procedure usp_AddNewApplication
@ApplicantPersonID int,
@ApplicationDate datetime,
@ApplicationTypeID int,
@ApplicationStatus tinyint,
@LastStatusDate datetime,
@PaidFees decimal(10, 2),
@CreatedByUserID int,
@NewApplicationID int output
as
begin
	set nocount on;
	 insert into Applications 
	 (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,
	 LastStatusDate, PaidFees, CreatedByUserID)
     values
	 ( @ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus,
	 @LastStatusDate, @PaidFees, @CreatedByUserID);

     set @NewApplicationID = scope_identity();
end

go


create or alter procedure usp_DeleteBaseApplication
@ApplicationID int
as
begin
	 delete Applications where ApplicationID = @ApplicationID;
end

go


create or alter procedure usp_GetAllApplications
as
begin
	set nocount on;
	select * from Applications;
end

go


create or alter procedure usp_UpdateApplicationStatus
@ApplicationID int, 
@UpdateDate datetime,
@NewStatus tinyint
as
begin
	update Applications 
    set ApplicationStatus = @NewStatus, LastStatusDate = @UpdateDate
    where ApplicationID = @ApplicationID;
end

go


create or alter procedure usp_GetActiveApplicationID
@ApplicantPersonID int,
@ApplicationTypeID int,
@ActiveApplicationID int output
as
begin
	set nocount on;
	-- if the query returns 0 rows, then it will never assign a value to the variable, so we give it this default
	set @ActiveApplicationID = -1;

	select @ActiveApplicationID = ApplicationID
    from Applications 
    where ApplicantPersonID = @ApplicantPersonID and ApplicationTypeID = @ApplicationTypeID 
	and ApplicationStatus = 1
end

go


create or alter procedure usp_UpdateApplication
@ApplicationID int,
@ApplicantPersonID int,
@ApplicationDate datetime,
@ApplicationTypeID int,
@ApplicationStatus tinyint,
@LastStatusDate datetime,
@PaidFees decimal(10, 2),
@CreatedByUserID int
as
begin
	update Applications
    set ApplicantPersonID = @ApplicantPersonID, ApplicationDate = @ApplicationDate, ApplicationTypeID = @ApplicationTypeID, ApplicationStatus = @ApplicationStatus,
    LastStatusDate = @LastStatusDate, PaidFees = @PaidFees, CreatedByUserID = @CreatedByUserID
    where ApplicationID = @ApplicationID;
end

go

-- created this table to log deleted applications
create table DeletedApplicationsLog
(
    LogID int identity(1,1) primary key,
    ApplicationID int not null,
    ApplicantPersonID int not null,
    ApplicationDate datetime not null,
    ApplicationTypeID int not null,
    ApplicationStatus tinyint not null,
    LastStatusDate datetime not null,
    PaidFees decimal(10, 2) not null,
    CreatedByUserID int not null,
    
    DeletedDate datetime not null constraint DF_DeletedApplicationsLog_DeletedDate default GETDATE(),
    DeletedByDbUser nvarchar(128) not null constraint DF_DeletedApplicationsLog_User default SUSER_SNAME(),
    ComputerName nvarchar(128) not null constraint DF_DeletedApplicationsLog_ComputerName default HOST_NAME()
);

go

select * from DeletedApplicationsLog;

-- after delete trigger to log deleted applications
create or alter trigger trg_AfterApplicationDelete
on Applications after delete
as
begin
	set nocount on;
	if not exists (select 1 from deleted)
        return;

	insert into DeletedApplicationsLog
	(ApplicationID,ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,
	 LastStatusDate, PaidFees, CreatedByUserID)
	select d.ApplicationID, d.ApplicantPersonID, d.ApplicationDate, d.ApplicationTypeID, d.ApplicationStatus,
	 d.LastStatusDate, d.PaidFees, d.CreatedByUserID
	 from deleted as d;
end