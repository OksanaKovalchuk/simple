use EmployeeDB
go

create table Users
(
	Id int identity primary key,
	Username nvarchar(50),
	Password nvarchar(100)
)

Insert into Users values ('user','user')
Insert into Users values ('person', 'person')

select * from Users
Select * from Employees