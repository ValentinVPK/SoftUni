

--5. Unassigned Reports
 
SELECT [Description],FORMAT(OpenDate, 'dd-MM-yyyy') AS OpenDate FROM Reports AS r
	WHERE EmployeeId IS NULL
	ORDER BY r.OpenDate, [Description]

--6. Reports & Categories

SELECT r.[Description], c.[Name] AS CategoryName FROM Reports AS r
	JOIN Categories AS c ON c.Id = r.CategoryId
	WHERE r.CategoryId IS NOT NULL
	ORDER BY r.[Description], c.[Name]

--7. Most Reported Category

SELECT TOP(5) c.[Name], k.ReportsNumber FROM 
(SELECT CategoryId, COUNT(*) AS ReportsNumber FROM Reports
	GROUP BY CategoryId) AS k
	JOIN Categories AS c ON c.Id = k.CategoryId
	ORDER BY k.ReportsNumber DESC, c.[Name]

--8. Birthday Report

SELECT u.Username, c.[Name] FROM Users AS u
	JOIN Reports AS r ON r.UserId = u.Id
	JOIN Categories AS c ON c.Id = r.CategoryId
	WHERE DATEPART(MONTH, u.Birthdate) = DATEPART(MONTH, r.OpenDate) AND 
					DATEPART(DAY, u.Birthdate) = DATEPART(DAY, r.OpenDate)
	ORDER BY u.Username, c.[Name]

--9. User per Employee

SELECT e.FirstName + ' ' + e.LastName AS FullName, ISNULL(COUNT(u.Id),0) AS UsersCount FROM Employees AS e
	LEFT JOIN Reports AS r ON r.EmployeeId = e.Id
	LEFT JOIN Users AS u ON u.Id = r.UserId
	GROUP BY e.Id, e.FirstName + ' ' + e.LastName
	ORDER BY UsersCount DESC, FullName

--10. Full Info

SELECT  ISNULL(e.FirstName + ' ' + e.LastName, 'None') AS Employee, 
		ISNULL(d.[Name], 'None') AS Department,
		ISNULL(c.[Name], 'None') AS Category,
		r.[Description],
		FORMAT(r.OpenDate, 'dd.MM.yyyy') AS OpenDate,
		s.[Label] AS [Status],
		ISNULL(u.[Name], 'None') AS [User]
	FROM Reports AS r 
	LEFT JOIN [Status] AS s ON s.Id = r.StatusId
	LEFT JOIN Users AS u ON u.Id = r.UserId
	LEFT JOIN Employees AS e ON e.Id = r.EmployeeId
	LEFT JOIN Departments AS d ON d.Id = e.DepartmentId
	LEFT JOIN Categories AS c ON c.Id = r.CategoryId
	ORDER BY e.FirstName DESC, e.LastName DESC, d.[Name],c.[Name],r.[Description],r.OpenDate,s.[Label],
			u.[Name]

