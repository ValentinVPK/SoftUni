
SELECT cl.LastName,
	   AVG(s.[Length]) AS CiagrLength, 
	   CEILING(AVG(s.RingRange)) AS CiagrRingRange
	  FROM Clients AS cl
	JOIN ClientsCigars AS cc ON cc.ClientId = cl.Id
	JOIN Cigars AS ci ON ci.Id = cc.CigarId
	JOIN Sizes AS s ON s.Id = ci.SizeId
GROUP BY cl.LastName
ORDER BY CiagrLength DESC
