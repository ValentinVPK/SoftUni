
CREATE TABLE Persons
(
	PersonID INT IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	Salary DECIMAL(10,2) NOT NULL,
	PassportID INT UNIQUE 
)

CREATE TABLE Passports
(
	PassportID INT IDENTITY(101,1) PRIMARY KEY,
	PassportNumber VARCHAR(50) NOT NULL
)

INSERT INTO Passports(PassportNumber) VALUES
('N34FG21B'),
('K65LO4R7'),
('ZE657QP2')


INSERT INTO Persons(FirstName, Salary, PassportId) VALUES
('Roberto', 43300.00, 102),
('Tom', 56100.00, 103),
('Yana', 60200.00, 101)

ALTER TABLE Persons
ADD CONSTRAINT PK_PersonId PRIMARY KEY (PersonId)


ALTER TABLE Persons
ADD CONSTRAINT FK_PersonsPassports
FOREIGN KEY (PassportID) REFERENCES Passports(PassportID)