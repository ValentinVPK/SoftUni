

--01. Employees with Salary Above 35000

CREATE PROC usp_GetEmployeesSalaryAbove35000 
AS
	SELECT FirstName, LastName FROM Employees
	WHERE Salary > 35000
GO

EXEC usp_GetEmployeesSalaryAbove35000

--02. Employees with Salary Above Number

CREATE PROC usp_GetEmployeesSalaryAboveNumber (@Param DECIMAL(18,4))
AS
	SELECT FirstName, LastName FROM Employees
		WHERE Salary >= @Param
GO

EXEC usp_GetEmployeesSalaryAboveNumber 48100

--03. Town Names Starting With

CREATE PROC usp_GetTownsStartingWith (@Param NVARCHAR(MAX))
AS
	SELECT [Name] FROM Towns
		WHERE LEFT([Name], LEN(@Param)) = @Param
GO

EXEC usp_GetTownsStartingWith 'b'

--04. Employees from Town

CREATE PROC usp_GetEmployeesFromTown (@Param NVARCHAR(MAX))
AS
	SELECT e.FirstName, e.LastName FROM Employees AS e
		LEFT JOIN Addresses AS a ON a.AddressID = e.AddressID
		LEFT JOIN Towns AS t ON t.TownID = a.TownID
		WHERE t.Name = @Param
GO

EXEC usp_GetEmployeesFromTown 'Sofia'

--05. Salary Level Function

CREATE OR ALTER FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @Result VARCHAR(50)
	IF @salary < 30000
		SET @Result = 'Low'
	ELSE IF @salary BETWEEN 30000 AND 50000
		SET @Result = 'Average'
	ELSE 
		SET @Result = 'High'

	RETURN @Result
END

SELECT Salary, dbo.ufn_GetSalaryLevel(Salary) AS [Level] FROM Employees

--06. Employees by Salary Level

CREATE PROC usp_EmployeesBySalaryLevel (@SalaryLevel VARCHAR(50))
AS
	SELECT FirstName, LastName FROM Employees
		WHERE dbo.ufn_GetSalaryLevel(Salary) = @SalaryLevel
GO

EXEC usp_EmployeesBySalaryLevel 'High'

--07. Define Function

CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
	DECLARE @Index INT = 1;

	WHILE @Index <= LEN(@word)
	BEGIN
		IF CHARINDEX(SUBSTRING(@word, @Index, 1), @setOfLetters) = 0
			RETURN 0

		SET @Index = @Index + 1
	END

	RETURN 1
END

SELECT dbo.ufn_IsWordComprised('pppp', 'Guy') AS Result

--08. Delete Employees and Departments

CREATE PROC usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS
	--1.

	DELETE FROM EmployeesProjects
	WHERE EmployeeID IN (SELECT EmployeeID FROM Employees WHERE DepartmentID = @departmentId)
	
	--2.
	ALTER TABLE Departments
	ALTER COLUMN ManagerID INT NULL
	
	UPDATE Employees
	SET ManagerID = NULL
	WHERE DepartmentID = @departmentId
	
	UPDATE Employees
	SET ManagerID = NULL
	WHERE ManagerID IN (SELECT EmployeeID FROM Employees WHERE DepartmentID = @departmentId)
	
	UPDATE Departments
	SET ManagerID = NULL
	WHERE DepartmentID = @departmentId
	
	UPDATE Departments
	SET ManagerID = NULL
	WHERE ManagerID IN (SELECT EmployeeID FROM Employees WHERE DepartmentID = @departmentId)
	
	--3.
	
	DELETE FROM Employees
	WHERE DepartmentID = @departmentId
	
	DELETE FROM Departments
	WHERE DepartmentID = @departmentId

	SELECT COUNT(*) FROM Employees
	WHERE DepartmentID = @departmentId
GO

EXEC usp_DeleteEmployeesFromDepartment 3

