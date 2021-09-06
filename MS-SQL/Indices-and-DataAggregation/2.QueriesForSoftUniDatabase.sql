
--13. Departments Total Salaries

SELECT DepartmentID, SUM(Salary) AS TotalSalary FROM Employees
	GROUP BY DepartmentID
	ORDER BY DepartmentID

--14. Employees Minimum Salaries

SELECT DepartmentID, MIN(Salary) FROM Employees
	WHERE DepartmentID IN (2,5,7) AND HireDate > '2000-01-01'
	GROUP BY DepartmentID

--15. Employees Average Salaries

SELECT * INTO NewTable
	FROM Employees
  WHERE Salary > 30000

DELETE FROM NewTable
WHERE ManagerID = 42

UPDATE NewTable
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID, AVG(Salary) FROM NewTable
GROUP BY DepartmentID


--16. Employees Maximum Salaries

SELECT DepartmentID, MAX(Salary) AS MaxSalary FROM Employees
	GROUP BY DepartmentID
	HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

--17. Employees Count Salaries

SELECT COUNT(*) AS [Count] FROM Employees
	GROUP BY ManagerID
	HAVING ManagerID IS NULL

--18. 3rd Highest Salary

SELECT k.DepartmentID, k.Salary AS [ThirdHighestSalary] FROM
(SELECT DepartmentID,
	   Salary, 
	   DENSE_RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) AS [Ranked]
	FROM Employees
	GROUP BY DepartmentID, Salary) AS k
WHERE Ranked = 3
ORDER BY DepartmentID

--19. Salary Challenge

SELECT TOP(10) e.FirstName, e.LastName, e.DepartmentID FROM Employees AS e
	JOIN (SELECT DepartmentID, AVG(Salary) AS AverageSalary FROM Employees
			GROUP BY DepartmentID) AS k ON k.DepartmentID = e.DepartmentID
	WHERE e.Salary > k.AverageSalary
	ORDER BY e.DepartmentID


	
	 