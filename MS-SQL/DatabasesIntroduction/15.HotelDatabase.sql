CREATE DATABASE Hotel

USE Hotel

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(MAX) NOT NULL,
	LastName VARCHAR(MAX) NOT NULL,
	Title VARCHAR(MAX) NOT NULL,
	Notes VARCHAR(MAX) NULL
)

INSERT INTO Employees (FirstName, LastName, Title, Notes) VALUES
('Gosho', 'Georgiev', 'Boss', 'Cool guy'),
('Pesho', 'Peshev', 'Rob', 'Not cool'),
('Petko', 'Petkov', 'Nikakuv', NULL)

CREATE TABLE Customers
(
	AccountNumber INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(MAX) NOT NULL,
	LastName VARCHAR(MAX) NOT NULL,
	PhoneNumber VARCHAR(MAX) NOT NULL,
	EmergencyName VARCHAR(MAX) NULL,
	EmergencyNumber VARCHAR(MAX) NULL,
	Notes VARCHAR(MAX) NULL
)

AlTER TABLE Customers
ADD CHECK (LEN(PhoneNumber) = 10); 

INSERT INTO Customers(FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes) VALUES
('Gosho', 'Georgiev', '0899885057', 'Ne znam', '112', 'Cool guy'),
('Valio', 'Petrov', '0898850349', 'Valkata', '112', 'Best guy'),
('Ivo', 'Ivov', '0883460987', NULL, '112', NULL);


CREATE TABLE RoomStatus
(
	RoomStatus BIT NOT NULL,
	Notes VARCHAR(MAX) NULL
)

INSERT INTO RoomStatus(RoomStatus, Notes) VALUES
(0, 'Best Room'),
(1, 'Free'),
(0, 'Okay');

CREATE TABLE RoomTypes
(
	RoomType VARCHAR(30) NOT NULL,
	Notes VARCHAR(MAX) NULL
)

INSERT INTO RoomTypes(RoomType, Notes) VALUES
('Two beds', 'Some notes'),
('Family', 'Big'),
('Single', NULL);

CREATE TABLE BedTypes
(
	BedType VARCHAR(30) NOT NULL,
	Notes VARCHAR(MAX) NULL
)

INSERT INTO BedTypes(BedType, Notes) VALUES
('Two people', 'Some notes'),
('Kid', 'Some notes'),
('Single', NULL);


CREATE TABLE Rooms 
(
	RoomNumber INT PRIMARY KEY NOT NULL,
	RoomType VARCHAR(30) NOT NULL,
	BedType VARCHAR(30) NOT NULL,
	Rate SMALLINT NOT NULL,
	RoomStatus BIT NOT NULL,
	Notes VARCHAR(MAX) NULL
)

INSERT INTO Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes) VALUES
(101, 'Family', 'Kid', 8, 0,'Some notes'),
(102, 'Two People', 'Big', 7, 1,'Some notes'),
(103, 'Single', 'Small', 6, 0,'Some other notes');


CREATE TABLE Payments 
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	PaymentDate DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	FirstDateOccupied DATE NULL,
	LastDateOccupied DATE NULL,
	TotalDays INT NULL,
	AmountCharged DECIMAL(10,2) NULL,
	TaxRate DECIMAL(10,2) NULL,
	TaxAmount DECIMAL(10,2) NULL,
	PaymentTotal DECIMAL(10,2) NULL,
	Notes VARCHAR(MAX) NULL
)

INSERT INTO Payments (EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes) VALUES
(1, '10/12/2000', 3, '12/1/2000', '12/3/2000',2, 100.50,15.5,20,120.50,'Some notes'),
(2, '10/12/2000', 2, '12/1/2000', '12/3/2000',2, 100.50,15.5,20,120.50,'Some notes'),
(3, '10/12/2000', 1, '12/1/2000', '12/3/2000',2, 100.50,15.5,20,120.50,'Some notes')


CREATE TABLE Occupancies 
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	DateOccupied DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber),
	RateApplied BIT NOT NULL,
	PhoneCharge DECIMAL(10,2) NULL,
	Notes VARCHAR(MAX) NULL,
)

INSERT INTO Occupancies (EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes) VALUES
(1, '10/12/2000', 3, 101,1,20.5,'Some Notes'),
(2, '10/12/2000', 2, 102,1,20.5,'Some Notes'),
(3, '10/12/2000', 1, 103,0,20.5,'Some Notes')