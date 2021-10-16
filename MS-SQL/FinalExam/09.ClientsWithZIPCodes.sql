SELECT k.FullName,
       k.Country,
	   k.ZIP,
	   CONCAT('$', k.PriceForSingleCigar) AS CigarPrice
	FROM (SELECT   cl.FirstName + ' ' + cl.LastName AS FullName,
		  a.Country,
	      a.ZIP,
		  ci.PriceForSingleCigar,
		  RANK() OVER (PARTITION BY cl.FirstName + ' ' + cl.LastName ORDER BY ci.PriceForSingleCigar DESC) AS [PriceRank]
		FROM Clients AS cl
			JOIN Addresses AS a ON a.Id = cl.AddressId
			JOIN ClientsCigars AS cc ON cc.ClientId = cl.Id
			JOIN Cigars AS ci ON ci.Id = cc.CigarId
		WHERE a.ZIP NOT LIKE '%[^0-9]%') AS k
WHERE k.PriceRank = 1
ORDER BY k.FullName