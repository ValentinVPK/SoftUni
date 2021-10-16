
SELECT c.Id, 
		c.FirstName + ' ' + c.LastName AS ClientName,
		c.Email
	FROM Clients AS c
WHERE c.Id NOT IN (SELECT ClientId FROM ClientsCigars)
ORDER BY ClientName 