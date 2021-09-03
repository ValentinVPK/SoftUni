--12. Countries Holding 'A'

SELECT CountryName, IsoCode FROM Countries
WHERE LEN(CountryName) - LEN(REPLACE(REPLACE(CountryName, 'A' , ''), 'a', '')) >= 3
ORDER BY IsoCode

--13. Mix of Peak and River Names

SELECT PeakName, RiverName, LOWER(LEFT(PeakName, LEN(PeakName) - 1) + RiverName) AS Mix  FROM Peaks, Rivers
WHERE RIGHT(PeakName, 1) = LOWER(LEFT(RiverName, 1))
ORDER BY Mix