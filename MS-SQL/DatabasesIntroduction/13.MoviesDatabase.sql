CREATE DATABASE Movies

USE Movies

CREATE TABLE Directors
(
	Id INT PRIMARY KEY IDENTITY,
	DirectorName VARCHAR(MAX) NOT NULL,
	Notes VARCHAR(MAX) NULL
)

CREATE TABLE Genres
(
	Id INT PRIMARY KEY IDENTITY,
	GenreName VARCHAR(MAX) NOT NULL,
	Notes VARCHAR(MAX) NULL
)

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName VARCHAR(MAX) NOT NULL,
	Notes VARCHAR(MAX) NULL
)

CREATE TABLE Movies
(
	Id INT PRIMARY KEY IDENTITY,
	Title VARCHAR(MAX) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
	CopyrightYear INT NOT NULL,
	[Length] DECIMAL(10,2) NOT NULL,
	GenreId INT FOREIGN KEY REFERENCES Genres(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Rating DECIMAL(10,2) NULL,
	Notes VARCHAR(MAX) NULL
)


INSERT INTO Directors (DirectorName, Notes) VALUES
('Gosho', 'Hello'),
('Pesho', 'Hello'),
('Traqn', 'Hello'),
('Dragan', 'Hello'),
('Petkan', 'Hello')

INSERT INTO Genres (GenreName, Notes) VALUES
('Horror', 'Honor*'),
('Comedy', 'Yes'),
('Romance', 'Boring'),
('Adventure', 'Best'),
('Documentary', 'Interesting')

INSERT INTO Categories (CategoryName, Notes) VALUES
('Best', NULL),
('Good', 'Below best'),
('Average', 'Middle'),
('Bad', 'Below Average'),
('Worst', NULL)

INSERT INTO Movies (Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes) VALUES
('Friday the 13th', 5, 2009, 2.10,1,3,4.5,'Its scaryy'),
('Titanic', 3, 2001, 1.50,3,4,3.10,'Its booring'),
('Malcolm', 4, 2005, 0.50,2,1,10,'Its the bestt'),
('The Predator', 2, 1987, 2.30,4,2,7.3,'Its fun'),
('Killers', 1, 2010, 1.20,5,5,2.30,'Its worst')

SELECT * FROM Movies



