use DVLD;
go

create or alter procedure usp_FindByDriverID
@DriverID int
as
begin
	set nocount on;
	select * from Drivers where DriverID = @DriverID;
end

go

create or alter procedure usp_FindByPersonID
@PersonID int
as
begin
	set nocount on;
	select * from Drivers where PersonID = @PersonID;
end

go

create or alter procedure usp_AddNewDriver
@PersonID int,
@CreatedByUserID int,
@CreatedDate datetime,
@NewDriverID int output
as
begin
	set nocount on;

	insert into Drivers (PersonID, CreatedByUserID, CreatedDate)
	values (@PersonID, @CreatedByUserID, @CreatedDate);

	set @NewDriverID = SCOPE_IDENTITY();
end

go

create or alter procedure usp_UpdateDriver
@DriverID int,
@PersonID int,
@CreatedByUserID int,
@CreatedDate datetime
as
begin
	update Drivers
	set PersonID = @PersonID, CreatedByUserID = @CreatedByUserID, CreatedDate = @CreatedDate
	where DriverID = @DriverID;
end

go

create or alter procedure usp_GetAllDrivers
as
begin
	set nocount on;
	select * from Drivers_View;
end