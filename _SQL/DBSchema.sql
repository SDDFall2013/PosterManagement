
create table dbo.Poster(
	Id int identity(1,1) not null,
	Name varchar(100) not null,
	CreateDatetime datetime2(7) not null,
	ModifyDatetime datetime2(7) not null,
	constraint PK_Poster primary key(Id),
)
go

--User Creation
--create login PosterManagementUser with password = 'T07aLD0m1nat1oN'
--go

create user PosterManagementUser for login PosterManagementUser;
go

exec sp_addrolemember 'db_datareader', 'PosterManagementUser'
exec sp_addrolemember 'db_datawriter', 'PosterManagementUser'