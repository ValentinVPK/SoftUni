

CREATE DATABASE CarRental
USE CarRental


CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName VARCHAR(MAX) NOT NULL,
	DailyRate DECIMAL(10,2) NULL,
	WeeklyRate DECIMAL(10,2) NULL,
	MonthlyRate DECIMAL(10,2) NULL,
	WeekendRate DECIMAL(10,2) NULL
)

INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
('Basic', 5.5,10.5,15.5,20.5),
('High', 10.5,15.5,20.5,25.5),
('VIP',20.5,25.5,30.5,40.5)

CREATE TABLE Cars
(
	Id INT PRIMARY KEY IDENTITY,
	PlateNumber VARCHAR(MAX) NOT NULL,
	Manufacturer VARCHAR(MAX) NOT NULL,
	Model VARCHAR(MAX) NOT NULL,
	CarYear INT NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Doors SMALLINT NULL,
	Picture VARCHAR(MAX) NULL,
	Condition VARCHAR(MAX) NULL,
	Available BIT NOT NULL
)

INSERT INTO Cars(PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) VALUES
('24453', 'BMW', 'X3', 2005, 2, 5,'https://avatars.githubusercontent.com/u/76089718?v=4', 'Okay', 1),
('24548', 'FIAT', 'Punto', 2001, 1, 5,'https://avatars.githubusercontent.com/u/76089718?v=4', 'Good', 0),
('13452', 'Chevrolet', 'Kalos', 2004, 3, 5,'https://avatars.githubusercontent.com/u/76089718?v=4', 'BEST', 0)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(MAX) NOT NULL,
	LastName VARCHAR(MAX) NOT NULL,
	Title VARCHAR(MAX) NOT NULL,
	Notes VARCHAR(MAX) NULL,
)

INSERT INTO Employees(FirstName, LastName, Title, Notes) VALUES
('Gancho', 'Dragancho', 'Uchitel', 'AAAAAAA'),
('Valio', 'Krumov', 'Shef', 'Cool guy'),
('Stefan', 'Krastev', 'Bolen mozuk', NULL)

CREATE TABLE Customers
(
	Id INT PRIMARY KEY IDENTITY,
	DriverLicenceNumber VARCHAR(MAX) NOT NULL,
	FullName VARCHAR(MAX) NOT NULL,
	[Address] VARCHAR(MAX) NOT NULL,
	City VARCHAR(MAX) NOT NULL,
	ZIPCode INT NOT NULL,
	Notes VARCHAR(MAX) NULL,
)

INSERT INTO Customers(DriverLicenceNumber, FullName, [Address], City, ZIPCode, Notes) VALUES
('42141', 'Ivo Ivov', 'Nqkoq ulica', 'Pleven', 5800, NULL),
('32435', 'Georgi Gogov', 'Nqkoq druga ulica', 'Sofia', 5353, NULL),
('64643', 'Dimitur Dimitrov', 'Nqkoq treta ulica', 'Razgrad', 5454, NULL)

CREATE TABLE RentalOrders
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
	CarId INT FOREIGN KEY REFERENCES Cars(Id),
	TankLevel DECIMAL(10,2) NOT NULL,
	KilometrageStart INT NOT NULL,
	KilometrageEnd INT NOT NULL,
	TotalKilometrage INT NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	TotalDays INT NOT NULL,
	RateApplied BIT NOT NULL,
	TaxRate INT NOT NULL,
	OrderStatus VARCHAR(MAX) NULL,
	Notes VARCHAR(MAX) NULL
)


INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes) VALUES
(1, 3, 2,50.50, 200, 1000, 800,'10/12/2001', '12/12/2001',50,1,30.5,'Ordered',NULL),
(2, 2, 1, 50.50, 200, 1000, 800,'10/12/2001', '12/12/2001',50,1,30.5,'Ordered',NULL),
(3, 1, 3, 50.50, 200, 1000, 800,'10/12/2001', '12/12/2001',50,1,30.5,'Ordered',NULL)

SELECT * FROM RentalOrders
