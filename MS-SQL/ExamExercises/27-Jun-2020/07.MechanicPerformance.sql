


SELECT m.FirstName + ' ' + m.LastName AS [Mechanic], 
		k.[Average Days] 
	FROM (SELECT j.MechanicId, 
			CEILING(AVG(DATEDIFF(DAY,j.IssueDate, j.FinishDate))) AS [Average Days] 
		FROM Jobs AS j
		WHERE j.FinishDate IS NOT NULL
		GROUP BY j.MechanicId) AS k
	JOIN Mechanics AS m ON m.MechanicId = k.MechanicId
	ORDER BY k.MechanicId

