CREATE DATABASE EmployeeDB
GO

USE EmployeeDB
GO

CREATE TABLE Employees
(
	ID INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50),
	LastName NVARCHAR(50),
	Gender NVARCHAR(50),
	Salary INT
)
GO

INSERT INTO Employees VALUES ('Mark', 'Hastings', 'Male', 60000)
INSERT INTO Employees VALUES ('Steve', 'Pound', 'Male', 90000)
INSERT INTO Employees VALUES ('Ben', 'Hoskins', 'Male', 70000)
INSERT INTO Employees VALUES ('Philip', 'Hastings', 'Male', 350000)
INSERT INTO Employees VALUES ('Mary', 'Lanbeth', 'Female', 15000)
INSERT INTO Employees VALUES ('Valarie', 'Vikings', 'Feale', 4000)
INSERT INTO Employees VALUES ('John', 'Stanmore', 'Male', 950000)
INSERT INTO Employees VALUES ('Ann', 'Andrade', 'Feale', 80000)
