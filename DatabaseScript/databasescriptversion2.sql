Create table databaseversion (
id bigint identity(1,1),
[version] varchar (500),
[date] datetime,
[description] varchar(max)
)
GO
insert into databaseversion values('databasescriptversion1',GETDATE(),'This is the first script to create a talbe databaseversion.This table is use to store the database releted chage releted to this project')
GO
