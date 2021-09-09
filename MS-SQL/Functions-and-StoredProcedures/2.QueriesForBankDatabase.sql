
--09. Find Full Name

CREATE PROC usp_GetHoldersFullName
AS
	SELECT FirstName + ' ' + LastName AS [Full Name] FROM AccountHolders
GO

EXEC usp_GetHoldersFullName

--10. People with Balance Higher Than



CREATE PROC usp_GetHoldersWithBalanceHigherThan(@InputNumber MONEY)
AS	
 
	SELECT ah.FirstName, ah.LastName FROM AccountHolders AS ah
	WHERE ah.Id IN (SELECT AccountHolderId FROM Accounts
		GROUP BY AccountHolderId
		HAVING SUM(Balance) > @InputNumber)
	ORDER BY FirstName, LastName
GO

EXEC usp_GetHoldersWithBalanceHigherThan 500000

--11. Future Value Function

CREATE FUNCTION ufn_CalculateFutureValue(@Sum DECIMAL(18,2), @Rate FLOAT, @Years INT)
RETURNS DECIMAL(20,4)
AS
BEGIN
	DECLARE @Result DECIMAL(20,4) = @Sum * (POWER((1 + @Rate), @Years))

	RETURN @Result
END

SELECT dbo.ufn_CalculateFutureValue(1000,0.1,5)

--12. Calculating Interest

CREATE PROC usp_CalculateFutureValueForAccount (@AccountId INT, @InterestRate FLOAT)
AS
	DECLARE @Years INT = 5;

	SELECT a.Id AS [Account Id], 
			ah.FirstName, 
			ah.LastName,
			a.Balance AS [Current Balance],
			dbo.ufn_CalculateFutureValue(a.Balance, @InterestRate, @Years) AS [Balance in 5 years]
		FROM AccountHolders AS ah
		JOIN Accounts AS a ON a.AccountHolderId = ah.Id
		WHERE a.Id = @AccountId
GO

EXEC usp_CalculateFutureValueForAccount 1, 0.1
	