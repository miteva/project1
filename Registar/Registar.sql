CREATE DATABASE Registar


create table Bikes(Id int Not Null Primary Key Identity,
				   RegNumber nvarchar(20) Not Null,
				   Producer nvarchar(20) Not Null,
				   Model nvarchar(20) Not Null,
				   Colour nvarchar(20) Not Null,
				   City nvarchar(20) Not Null,
				  );



insert into Bikes values ('007', 'JB', 'JB007','Metalic','Skopje');
insert into Bikes values ('008', 'JS', 'JB008','Grey','Skopje');
insert into Bikes values ('009', 'LN', 'JB009','Blue','Skopje');
insert into Bikes values ('010', 'AG', 'JB010','Red','Skopje');