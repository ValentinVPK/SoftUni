CREATE TABLE Logs
(
	LogId INT IDENTITY PRIMARY KEY,
	AccountId INT NOT NULL FOREIGN KEY REFERENCES Accounts(Id),
	OldSum MONEY NOT NULL,
	NewSum MONEY NOT NULL
)

CREATE TRIGGER tr_AddToLogsOnAccountUpdate
ON Accounts FOR UPDATE
AS
	INSERT INTO Logs(AccountId, OldSum, NewSum)
	SELECT  d.Id AS AccountId, d.Balance AS OldSum, i.Balance AS NewSum
		FROM deleted AS d
		JOIN inserted AS i ON i.Id = d.Id
		WHERE d.Balance != i.Balance
GO

UPDATE Accounts
SET Balance -= 10
WHERE Id = 1

SELECT * FROM Logs
