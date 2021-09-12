--18. Orders Table

CREATE TABLE Orders
(
	Id INT IDENTITY PRIMARY KEY,
	ProductName VARCHAR(50) NOT NULL,
	OrderDate DATETIME NOT NULL
)

INSERT INTO Orders(ProductName, OrderDate) VALUES
('Butter',	'2016-09-19 00:00:00.000'),
('Milk',	'2016-09-30 00:00:00.000'),
('Cheese',	'2016-09-04 00:00:00.000'),
('Bread',	'2015-12-20 00:00:00.000'),
('Tomatoes',	'2015-12-30 00:00:00.000')

SELECT ProductName, OrderDate,
DATEADD(DAY, 3, OrderDate) AS [Pay Due],
DATEADD(MONTH, 1, OrderDate) AS [Deliver Due]
FROM Orders

--19.People Table

CREATE TABLE People
(
	Id INT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL,
	Birthdate DATETIME NOT NULL
)

INSERT INTO People([Name], Birthdate) VALUES
('Victor','2000-12-07 00:00:00.000'),
('Steven','1992-09-10 00:00:00.000'),
('Stephen','1910-09-19 00:00:00.000'),
('John','2010-01-06 00:00:00.000')

SELECT [Name],
DATEDIFF(YEAR, Birthdate, GETDATE()) AS [Age in Years],
DATEDIFF(MONTH, Birthdate, GETDATE())  AS [Age in Months],
DATEDIFF(DAY, Birthdate, GETDATE()) AS [Age in Days],
DATEDIFF(MINUTE, Birthdate, GETDATE()) AS [Age in Minutes]
FROM People