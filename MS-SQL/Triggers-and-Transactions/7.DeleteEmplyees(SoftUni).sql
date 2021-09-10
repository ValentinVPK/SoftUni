

CREATE TABLE Deleted_Employees
(
	EmployeeId INT PRIMARY KEY NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50),
	JobTitle VARCHAR(50) NOT NULL,
	DepartmentId INT FOREIGN KEY REFERENCES Departments(DepartmentId) NOT NULL,
	Salary MONEY NOT NULL
)

CREATE TRIGGER tr_AddToDeletedEmployeesWhenEmployeeIsDeleted
ON Employees FOR DELETE
AS
	INSERT INTO Deleted_Employees(EmployeeId, FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary)
	SELECT EmployeeId, FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary FROM deleted
GO