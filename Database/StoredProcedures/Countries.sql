use DVLD;
go

create or alter procedure usp_GetAllCountries
as
begin
	set nocount on;
	select * from Countries;
end

go

create or alter procedure usp_GetCountryByID
@CountryID int,
@CountryName varchar(100) output
as
begin
	set nocount on;
	select @CountryName = CountryName from Countries where CountryID = @CountryID;
end

go

create or alter procedure usp_GetCountryByName
@CountryName varchar(100),
@CountryID int output
as
begin
	set nocount on;
	select @CountryID = CountryID from Countries where CountryName = @CountryName;
end

go

