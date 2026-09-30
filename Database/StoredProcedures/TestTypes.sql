use DVLD;
go


create or alter procedure usp_FindTestTypeByID
@TestTypeID int
as
begin
	set nocount on;
	select * from TestTypes where TestTypeID = @TestTypeID;
end

go

create or alter procedure usp_UpdateTestType
@TestTypeID int,
@TestTypeTitle varchar(200),
@TestTypeDescription varchar(max),
@TestTypeFees decimal(10,2)

as
begin
	update TestTypes
    set TestTypeTitle = @TestTypeTitle, TestTypeDescription = @TestTypeDescription, TestTypeFees = @TestTypeFees
    where TestTypeID = @TestTypeID;
end

go

create or alter procedure usp_GetAllTestTypes
as
begin
	set nocount on;
	select * from TestTypes;
end

go