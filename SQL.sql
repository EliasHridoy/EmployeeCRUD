CREATE DATABASE EmployeeRecords;
USE EmployeeRecords;
CREATE TABLE Employee(
Id int not null PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(50) NOT NULL,
MiddleName VARCHAR(50) NULL,
LastName  VARCHAR(50) NULL
)
