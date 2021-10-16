
CREATE PROC usp_SearchByTaste(@taste VARCHAR(20))
AS
	SELECT ci.CigarName,
		   CONCAT('$', ci.PriceForSingleCigar) AS Price,
		   t.TasteType,
		   b.BrandName,
		   CONCAT(s.[Length], ' cm') AS CigarLength,
		   CONCAT(s.RingRange, ' cm') AS CigarRingRange
	  FROM Cigars AS ci
	    JOIN Brands AS b ON b.Id = ci.BrandId
		JOIN Sizes AS s ON s.Id = ci.SizeId
		JOIN Tastes AS t ON t.Id = ci.TastId
	WHERE t.TasteType = @taste
	ORDER BY CigarLength ASC, CigarRingRange DESC
GO

EXEC usp_SearchByTaste 'Woody'