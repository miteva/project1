CREATE DATABASE Registar

--create schema [data]

If not exists (select * from sys.sysobjects where name='BikeOwners' and xtype='U')
Begin
CREATE TABLE data.BikeOwners(BikeOwnerId INT IDENTITY(1,1) NOT NULL,
						FirsName nvarchar(50) Not Null,
						LastName nvarchar(100) Not Null
						)
End


If not exists (select * from sys.sysobjects where name='PK_BikeOwners' and xtype='PK')
Begin
Alter table data.BikeOwners
ADD Constraint PK_BikeOwners
PRIMARY KEY (BikeOwnerId)
End

 drop table data.Bikes

 If OBJECT_ID('data.Bikes' )IS NULL
 Begin
create table data.Bikes(Id int Not Null Identity(1,1),
				   BikeOwnerId int Not Null,
				   RegNumber nvarchar(20) Not Null,
				   Producer nvarchar(20)  Null,
				   Model nvarchar(20)  Null,
				   Colour nvarchar(20)  Null,
				   City nvarchar(20)  Null,
				   SppedCount int NULL,
				   TStamp TimeStamp Not Null
				   )
End

IF OBJECT_ID('data.PK_Bikes',N'PK') IS NULL
Begin
Alter table data.Bikes 
ADD Constraint PK_Bikes 
Primary Key (Id)
End

IF OBJECT_ID('data.FK_Bikes_BikeOwnerId_X_BikeOwners_BikeOwnerId',N'F') IS NULL
Begin
Alter table data.Bikes
Add Constraint FK_Bikes_BikeOwnerId_X_BikeOwners_BikeOwnerId
Foreign Key (BikeOwnerId) 
References data.BikeOwners(BikeOwnerId) 
End

select * from sys.syscolumns c
join sys.sysobjects o on c.id=o.id

select * from data.BikeOwners
select * from data.Bikes
insert into data.BikeOwners values('Katerina','Miteva')

insert into data.Bikes(data.BikeOwnerId,data.RegNumber,data.Producer,data.Model,data.Colour,data.City,data.SppedCount) values (1, '007', 'JB','JB007','Metalic','Skopje',15)

insert into data.Bikes(data.BikeOwnerId,data.RegNumber,data.Producer,data.Model,data.Colour,data.City,data.SppedCount) values (1,'008','JS', 'JS008','Grey','Skopje',21);
insert into data.Bikes(data.BikeOwnerId,data.RegNumber,data.Producer,data.Model,data.Colour,data.City,data.SppedCount) values (1, '009','LN', 'LN009','Blue','Skopje',15);
insert into data.Bikes(data.BikeOwnerId,data.RegNumber,data.Producer,data.Model,data.Colour,data.City,data.SppedCount)values (1,'010' ,'AG', 'AG010','Red','Skopje',18);