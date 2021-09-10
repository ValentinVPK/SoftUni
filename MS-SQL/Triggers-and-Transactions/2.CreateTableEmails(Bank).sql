

CREATE TABLE NotificationEmails
(
	Id INT IDENTITY PRIMARY KEY,
	Recipient INT FOREIGN KEY REFERENCES Accounts(Id) NOT NULL,
	[Subject] VARCHAR(200) NOT NULL,
	Body VARCHAR(300) NOT NULL
)

CREATE TRIGGER tr_AddNotificationEmailWhenAccountUpdated
ON Accounts FOR UPDATE
AS
	INSERT INTO NotificationEmails(Recipient, [Subject], Body)
	SELECT d.Id,
			'Balance change for account: ' + CONVERT(VARCHAR,d.Id),
			'On ' + CONVERT(VARCHAR,GETDATE(), 0) + ' your balance was changed from ' + CONVERT(VARCHAR,d.Balance) + ' to ' + CONVERT(VARCHAR,i.Balance) + '.'
		FROM deleted AS d
		JOIN inserted AS i ON i.Id = d.Id
		WHERE d.Balance != i.Balance
GO

UPDATE Accounts
SET Balance -= 10
WHERE Id = 1

SELECT * FROM NotificationEmails

