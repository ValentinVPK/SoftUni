
SELECT m.FirstName + ' ' + m.LastName AS [Available] FROM Mechanics AS m
	LEFT JOIN Jobs AS j ON j.MechanicId = m.MechanicId
	WHERE J.JobId IS NULL OR m.MechanicId NOT IN (SELECT MechanicId FROM Jobs WHERE Status IN ('In Progress', 'Pending'))
	GROUP BY m.MechanicId, (m.FirstName + ' ' + m.LastName)
