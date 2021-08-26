CREATE TABLE People
(
	Id INT IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARCHAR(MAX) NULL,
	Height DECIMAL(10,2) NULL,
	[Weight] DECIMAL(10,2) NULL,
	Gender VARCHAR(1) NOT NULL CHECK (Gender = 'm' OR Gender = 'f'),
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX) NULL
)

INSERT INTO People ([Name], Picture, Height, [Weight], Gender, Birthdate, Biography) VALUES
('Valio', 'https://avatars.githubusercontent.com/u/76089718?v=4', 1.75, 75.5, 'm', '8/24/2001', 'Cool guy'),
('Vesi', 'https://avatars.githubusercontent.com/u/76089718?v=4', 1.85, 80, 'm', '10/8/2001', 'Cool guy'),
('Iva', 'https://avatars.githubusercontent.com/u/76089718?v=4', 1.60, 50, 'f', '8/29/2001', 'Cool gal'),
('Dimitar', 'https://avatars.githubusercontent.com/u/76089718?v=4', 1.95, 90, 'm', '1/24/2001', 'Tall guy'),
('Mimi', 'https://avatars.githubusercontent.com/u/76089718?v=4', 1.70, 60, 'f', '2/24/2001', 'Cool gal')

SELECT * FROM People