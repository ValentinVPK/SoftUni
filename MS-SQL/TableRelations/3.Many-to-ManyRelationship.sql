
CREATE TABLE Students
(
	StudentID INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(30) NOT NULL
)

INSERT INTO Students ([Name]) VALUES
('Mila'),
('Toni'),
('Ron')

CREATE TABLE Exams
(
	ExamID INT IDENTITY(101,1) PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL
)

INSERT INTO Exams ([Name]) VALUES
('SpringMVC'),
('Neo4j'),
('Oracle 11g')

CREATE TABLE StudentsExams
(
	StudentID INT NOT NULL,
	ExamID INT NOT NULL,
	CONSTRAINT PK_StudentIdExamId
	PRIMARY KEY (StudentID, ExamID),
	CONSTRAINT FK_StudentsExams_Students
	FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
	CONSTRAINT FK_StudentsExams_Exams
	FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
)

INSERT INTO StudentsExams (StudentID, ExamID) VALUES
(1,101),
(1,102),
(2,101),
(3,103),
(2,102),
(2,103)







