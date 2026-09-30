use DVLD;
go

create or alter procedure usp_FindApplicationTypeByID
@applicationTypeID int
as
begin
	set nocount on;

	select ApplicationTypeTitle, ApplicationFees
	from ApplicationTypes 
	where ApplicationTypeID = @applicationTypeID
end

go

create or alter procedure usp_UpdateApplicationTypeByID
@applicationTypeID int,
@applicationTypeTitle varchar(500),
@applicationTypeFees decimal(10, 2),
@rowsAffected int output
as
begin
	update ApplicationTypes
	set ApplicationTypeTitle = @applicationTypeTitle,
	ApplicationFees = @applicationTypeFees
	where ApplicationTypeID = @applicationTypeID;
end

go

create or alter procedure usp_GetAllApplicationTypes
as
begin
	set nocount on;
	select * from ApplicationTypes;
end

go

--scalar function for reusability
create or alter function dbo.GetApplicationFeesByTypeID
(@ApplicationTypeID int) returns decimal(10, 2)
as
begin
	declare @Fees decimal(10, 2) = -1;

	select @Fees = ApplicationFees 
	from ApplicationTypes
	where ApplicationTypeID = @ApplicationTypeID;

	return @Fees;
end

