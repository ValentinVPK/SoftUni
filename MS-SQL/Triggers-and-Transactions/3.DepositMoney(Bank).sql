
CREATE OR ALTER PROC usp_DepositMoney (@AccountId INT, @MoneyAmount DECIMAL(20,4)) 
AS
BEGIN TRANSACTION
	IF @MoneyAmount <= 0
	BEGIN
		ROLLBACK;
		THROW 50001, 'Invalid money amount!', 1
	END

	UPDATE Accounts
	SET Balance += @MoneyAmount
	WHERE Id = @AccountId

	SELECT Id AS AccountId,
			AccountHolderId,
			CONVERT(DECIMAL(20,4), Balance) AS Balance
	FROM Accounts
	WHERE Id = @AccountId
COMMIT
GO

EXEC usp_DepositMoney 1, 10