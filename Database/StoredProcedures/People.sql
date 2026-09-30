use DVLD;
go


create or alter procedure usp_GetAllPeople
as
begin
	set nocount on;
	select PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
	case Gender
		when 0 then 'Male'
		when 1 then 'Female'
		else 'Unknown'
	end as Gender,
	DateOfBirth, Countries.CountryName, Phone, Email
	from People inner join Countries
	on People.NationalityCountryID = Countries.CountryID;
end

go

create or alter procedure usp_FindPersonByID
@PersonID int
as
begin
	set nocount on;
	select * from People where PersonID = @PersonID;
end

go


create or alter procedure usp_FindPersonByNationalNo
@NationalNo varchar(50)
as
begin
	set nocount on;
	select * from People where NationalNo = @NationalNo;
end

go

create or alter procedure usp_AddNewPerson
@NationalNo varchar(50),
@FirstName nvarchar(50),
@SecondName nvarchar(50),
@ThirdName nvarchar(50), 
@LastName nvarchar(50),
@BirthDate datetime,
@Gender tinyint,
@Address nvarchar(max),  
@Phone nvarchar(50),
@Email varchar(200),
@NationalityCountryID int,
@ImagePath varchar(500),
@NewPersonID int output
as
begin
	set nocount on;

	insert into People 
    (NationalNo, FirstName, SecondName, ThirdName, LastName, 
     DateOfBirth, Gender, Address, 
     Phone, Email, NationalityCountryID, ImagePath)
	values 
    (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, 
     @BirthDate, @Gender, @Address, 
     @Phone, @Email, @NationalityCountryID, @ImagePath);

	set @NewPersonID = SCOPE_IDENTITY();
end

go

create or alter procedure usp_UpdatePerson
@PersonID int,
@NationalNo varchar(50),
@FirstName nvarchar(50),
@SecondName nvarchar(50),
@ThirdName nvarchar(50), 
@LastName nvarchar(50),
@BirthDate datetime,
@Gender tinyint,
@Address nvarchar(max),  
@Phone nvarchar(50),
@Email varchar(200),
@NationalityCountryID int,
@ImagePath varchar(500)
as
begin
	update People
    set NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName, DateOfBirth = @BirthDate, 
    Gender = @Gender, Address = @Address, Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath
    where PersonID = @PersonID;
end

go

create or alter procedure usp_DeletePersonByID
@PersonID int
as
begin
	delete from People where PersonID = @PersonID;
end

go

create or alter procedure usp_DoesPersonExistByID
@PersonID int,
@isFound bit output
as
begin
	set nocount on;
	
	if exists(select 1 from People where PersonID = @PersonID)
		set @isFound = 1;
	else
		set @isFound = 0;
end

go

create or alter procedure usp_DoesPersonExistByNationalNo
@NationalNo varchar(50),
@isFound bit output
as
begin
	set nocount on;
	if exists(select 1 from People where NationalNo = @NationalNo)
		set @isFound = 1;
	else
		set @isFound = 0;
end