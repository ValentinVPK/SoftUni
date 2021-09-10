
CREATE PROC usp_AssignProject(@emloyeeId INT, @projectID INT)
AS
BEGIN TRANSACTION
	IF (SELECT COUNT(ProjectID) FROM EmployeesProjects WHERE EmployeeID = @emloyeeId) >= 3
	BEGIN
		ROLLBACK;
		THROW 50001, 'The employee has too many projects!', 1
	END

	INSERT INTO EmployeesProjects(EmployeeID, ProjectID) VALUES
	(@emloyeeId, @projectID)
COMMIT
GO

EXEC usp_AssignProject 2,1
EXEC usp_AssignProject 2,2
EXEC usp_AssignProject 2,3
BEGIN TRY  
 EXEC usp_AssignProject 2,4
END TRY  
BEGIN CATCH  
   SELECT error_message()
END CATCH;
