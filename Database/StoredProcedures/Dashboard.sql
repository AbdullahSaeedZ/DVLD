use DVLD;
go

create or alter procedure usp_GetDashboardData
as
begin
	set nocount on;
	select * from Dashboard_View;
end