use DVLD;
go


create or alter procedure usp_FindUserByUsername
@Username int
as
begin
	set nocount on;
	select * from Users where UserName = @Username;
end

go


create or alter procedure usp_FindUserByUserID
@UserID int
as
begin
	set nocount on;
	select * from Users where UserID = @UserID;
end

go


create or alter procedure usp_AddNewUser
@PersonID int,
@Username varchar(200),
@Password varchar(300),
@IsActive bit,
@Permissions int,
@PasswordSalt varchar(300),
@NewUserID int output
as
begin
	set nocount on;
	insert into Users 
    values (@PersonID, @Username, @Password, @IsActive, @Permissions, @PasswordSalt);
    set @NewUserID = scope_identity();
end

go


create or alter procedure usp_UpdateUser
@UserID int,
@Username varchar(200),
@Password varchar(300),
@IsActive bit,
@Permissions int,
@PasswordSalt varchar(300)
as
begin
	update Users 
    set UserName = @Username, Password = @Password, IsActive = @IsActive, Permissions = @Permissions, PasswordSalt = @PasswordSalt
    where UserID = @UserID;
end

go


create or alter procedure usp_ChangePassword
@UserID int,
@NewPassword varchar(300)
as
begin
	update Users 
    set Password = @NewPassword
    where UserID = @UserID;
end

go


create or alter procedure usp_DeleteUser
@UserID int
as
begin
	delete from Users where UserID = @UserID;
end

go


create or alter procedure usp_DoesUsernameExist
@Username varchar(200),
@DoesExists bit output
as
begin
	set nocount on;
	if exists (select 1 from Users where Username = @Username)
		set @DoesExists = 1;
	else
		set @DoesExists = 0;
end

go


create or alter procedure usp_DoesUserExistByPersonID
@PersonID varchar(200),
@DoesExists bit output
as
begin
	set nocount on;
	if exists (select 1 from Users where PersonID = @PersonID)
		set @DoesExists = 1;
	else
		set @DoesExists = 0;
end

go


create or alter procedure usp_DoesUserExistByNationalNo
@NationalNo varchar(200),
@DoesExists bit output
as
begin
	set nocount on;
	if exists (select Found = 1
			   from Users inner join People
			   on Users.PersonID = People.PersonID
			   where NationalNo = @NationalNo)
		set @DoesExists = 1;
	else
		set @DoesExists = 0;
end

go


create or alter procedure usp_GetAllUsers
as
begin
	set nocount on;
	select Users.UserID, Users.PersonID,People.FirstName +
	' ' + People.SecondName + 
	' ' + isnull(People.ThirdName + ' ', '')
	+ People.LastName as FullName,
    Users.UserName, Users.IsActive
    from Users inner join People
	on Users.PersonID = People.PersonID
    order by UserID asc;
end