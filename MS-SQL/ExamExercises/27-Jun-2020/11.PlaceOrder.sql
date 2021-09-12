
CREATE PROC usp_PlaceOrder (@jobId INT, @serialNumber VARCHAR(50), @quantity INT) 
AS
	IF @quantity <= 0 
		THROW 50012 , 'Part quantity must be more than zero!', 1

	IF (SELECT [Status] FROM Jobs WHERE JobId = @jobId) = 'Finished'
		THROW 50011 , 'This job is not active!', 1

	IF (SELECT COUNT(*) FROM Jobs WHERE JobId = @jobId) = 0
		THROW 50013, 'Job not found!', 1

	IF (SELECT COUNT(*) FROM Parts WHERE SerialNumber = @serialNumber) = 0
		THROW 50014, 'Part not found!', 1


	--Checking if order exists
	DECLARE @existingPartId INT = (SELECT PartId FROM Parts WHERE SerialNumber = @serialNumber)

	IF (SELECT COUNT(*) FROM Jobs AS j
			JOIN Orders AS o ON o.JobId = j.JobId
			WHERE j.JobId = @jobId AND o.IssueDate IS NULL) > 0
	BEGIN
		DECLARE @existingOrderId  INT = (SELECT o.OrderId FROM Jobs j
										JOIN Orders o ON o.JobId = j.JobId
										WHERE j.JobId = @jobId AND o.IssueDate IS NULL)

		IF (SELECT COUNT(*) FROM OrderParts 
				WHERE OrderId = @existingOrderId AND PartId = @existingPartId) > 0
		BEGIN
			UPDATE OrderParts
			SET Quantity += 1
			WHERE PartId = @existingPartId AND OrderId = @existingOrderId
		END
		ELSE
		BEGIN
			INSERT INTO OrderParts(OrderId, PartId) VALUES
			(@existingOrderId, @existingPartId)
		END
	END
	ELSE
	BEGIN
		INSERT INTO Orders (JobId, IssueDate) VALUES
		(@jobId, NULL)

		DECLARE @newOrderId INT = (SELECT OrderId FROM Orders WHERE JobId = @jobId AND IssueDate IS NULL)

		INSERT INTO OrderParts(OrderId, PartId) VALUES
		(@newOrderId, @existingPartId)
	END
COMMIT
GO


