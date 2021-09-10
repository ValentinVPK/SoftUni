
CREATE PROC usp_TransferMoney (@SenderId INT, @ReceiverId INT, @Amount DECIMAL(20,4))
AS
BEGIN TRANSACTION
	IF @Amount <= 0
	BEGIN
		ROLLBACK;
		THROW 50001, 'Invalid Money Amount!', 1
	END

	UPDATE Accounts
	SET Balance -= @Amount
	WHERE Id = @SenderId

	UPDATE Accounts
	SET Balance += @Amount
	WHERE Id = @ReceiverId

COMMIT
GO