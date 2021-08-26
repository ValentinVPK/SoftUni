CREATE TABLE Users
(
	Id BIGINT PRIMARY KEY IDENTITY,
	Username NVARCHAR(30) NOT NULL UNIQUE,
	[Password] NVARCHAR(26) NOT NULL,
	ProfilePicture NVARCHAR(MAX),
	LastLoginTime DATETIME,
	IsDeleted BIT
)

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted) VALUES
('User1', 'somepass123', 'https://avatars.githubusercontent.com/u/76089718?v=4', '6/30/2021', 0),
('User2', 'somepass124', 'https://avatars.githubusercontent.com/u/76089718?v=4', '12/1/2021', 0),
('User3', 'somepass125', 'https://avatars.githubusercontent.com/u/76089718?v=4', '10/15/2021', 0),
('User4', 'somepass126', 'https://avatars.githubusercontent.com/u/76089718?v=4', '7/13/2021', 0),
('User5', 'somepass127', 'https://avatars.githubusercontent.com/u/76089718?v=4', '9/2/2021', 0)


SELECT * FROM Users




-- unique identifier	