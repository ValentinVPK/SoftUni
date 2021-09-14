--11. Hours to Complete

CREATE FUNCTION udf_HoursToComplete(@StartDate DATETIME, @EndDate DATETIME)
RETURNS INT
AS
BEGIN
	IF @EndDate IS NULL
		RETURN 0

	RETURN DATEDIFF(HOUR,@StartDate, @EndDate)
END

SELECT dbo.udf_HoursToComplete(OpenDate, CloseDate) AS TotalHours
   FROM Reports


--12. Assign Employee

CREATE PROC usp_AssignEmployeeToReport(@EmployeeId INT, @ReportId INT)
AS
	DECLARE @employeeDepartmentId INT = (SELECT DepartmentId FROM Employees WHERE Id = @EmployeeId)

	DECLARE @reportCategoryDepartmentId INT= (SELECT c.DepartmentId FROM Reports AS r
													JOIN Categories AS c ON c.Id = r.CategoryId
													WHERE r.Id = @ReportId)

	IF @employeeDepartmentId != @reportCategoryDepartmentId
		THROW 50001, 'Employee doesn''t belong to the appropriate department!', 1

	UPDATE Reports
	SET EmployeeId = @EmployeeId
	WHERE Id = @ReportId
GO

EXEC usp_AssignEmployeeToReport 30, 1