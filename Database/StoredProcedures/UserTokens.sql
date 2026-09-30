use DVLD;
go


create or alter procedure usp_FindTokenByUserID
@UserID int
as
begin
	set nocount on;
	select * from UserTokens where UserID = @UserID;
end

go

create or alter procedure usp_FindTokenByTokenID
@TokenID int
as
begin
	set nocount on;
	select * from UserTokens where TokenID = @TokenID;
end

go


create or alter procedure usp_FindTokenByTokenValue
@TokenValue varchar(300)
as
begin
	set nocount on;
	select * from UserTokens where TokenValue = @TokenValue and (getdate() < ExpirationDate);
end

go


create or alter procedure usp_AddNewToken
@UserID int,
@TokenValue nvarchar(300),  
@CreatedDate datetime,
@ExpirationDate datetime,
@NewTokenID int output

as
begin
	set nocount on;
	insert into UserTokens (UserID, TokenValue, CreatedDate, ExpirationDate)
    values (@UserID, @TokenValue, @CreatedDate, @ExpirationDate);

    set @NewTokenID = scope_identity();
end

go


create or alter procedure usp_SetTokenExpired
@TokenValue varchar(300)
as
begin
	update UserTokens 
    set ExpirationDate = getdate()
    where TokenValue = @TokenValue;
end

go

