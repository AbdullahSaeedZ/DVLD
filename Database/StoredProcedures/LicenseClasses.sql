use DVLD;
go


create or alter procedure usp_GetLicenseClassInfoByID
@LicenseClassID int
as
begin
	set nocount on;
	select * from LicenseClasses where LicenseClassID = @LicenseClassID;
end

go

create or alter procedure usp_GetLicenseClassInfoByClassName
@ClassName varchar(500)
as
begin
	set nocount on;
	select * from LicenseClasses where ClassName = @ClassName;
end

go

create or alter procedure usp_UpdateLicenseClass
@LicenseClassID int,
@ClassName varchar(500), 
@ClassDescription varchar(max),
@MinimumAllowedAge int, 
@DefaultValidityLength int,
@ClassFees decimal(10, 2)
as
begin
	update LicenseClasses
    set ClassName = @ClassName, ClassDescription = @ClassDescription, MinimumAllowedAge = @MinimumAllowedAge, 
	DefaultValidityLength = @DefaultValidityLength, ClassFees = @ClassFees                                  
    where LicenseClassID = @LicenseClassID;
end

go

create or alter procedure usp_GetAllLicenseClasses
as
begin
	set nocount on;
	select * from LicenseClasses;
end

go