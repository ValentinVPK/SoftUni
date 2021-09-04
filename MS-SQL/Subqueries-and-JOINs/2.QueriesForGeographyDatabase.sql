
--12. Highest Peaks in Bulgaria

SELECT c.CountryCode,
	   m.MountainRange,
	   p.PeakName,
	   p.Elevation
FROM Peaks AS p
	JOIN Mountains AS m ON m.Id = p.MountainId
	JOIN MountainsCountries AS mc ON mc.MountainId = m.Id
	JOIN Countries AS c ON c.CountryCode = mc.CountryCode
WHERE c.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY p.Elevation DESC

--13. Count Mountain Ranges

SELECT mc.CountryCode,
	   COUNT(*) AS MountainRanges
	   FROM Mountains AS m
	JOIN MountainsCountries AS mc ON mc.MountainId = m.Id
WHERE mc.CountryCode IN ('BG', 'RU', 'US')
GROUP BY mc.CountryCode

--14. Countries With or Without Rivers

SELECT TOP(5) c.CountryName, r.RiverName FROM Countries AS c
	LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
	LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName

--15. Continents and Currencies

SELECT ContinentCode, CurrencyCode, CurrencyUsage FROM
(SELECT ContinentCode,
		CurrencyCode,
	    COUNT(CurrencyCode) AS CurrencyUsage,
	    DENSE_RANK() OVER (PARTITION BY ContinentCode ORDER BY COUNT(CurrencyCode) DESC) AS Ranked
FROM Countries
GROUP BY ContinentCode,CurrencyCode) AS [FirstSelect]
WHERE Ranked = 1 AND CurrencyUsage > 1
ORDER BY ContinentCode

--16. Countries Without any Mountains

SELECT COUNT([Total]) AS [Count] FROM 
(SELECT c.CountryCode, COUNT(mc.CountryCode) AS [Total]
	FROM Countries AS c
	LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
GROUP BY c.CountryCode) AS FirstSelect
WHERE [Total] = 0

--17. Highest Peak and Longest River by Country

SELECT TOP(5) CountryName, 
	   MAX(p.Elevation) AS HighestPeakElevation, 
	   MAX(r.Length) AS LongestRiverLength
FROM Countries AS c
	LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
	LEFT JOIN Mountains AS m ON m.Id = mc.MountainId
	LEFT JOIN Peaks AS p ON p.MountainId = m.Id
	LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
	LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY CountryName
ORDER BY HighestPeakElevation DESC,
		 LongestRiverLength DESC,
		 c.CountryName

--18. Highest Peak Name and Elevation by Country

SELECT TOP(5) k.CountryName AS Country, 
			  k.PeakName AS [Highest Peak Name], 
			  k.HighestPeak AS [Highest Peak Elevation],
			  k.MountainRange AS [Mountain]
FROM
(SELECT CountryName, 
	   ISNULL(p.PeakName, '(no highest peak)') AS PeakName,
	   ISNULL(m.MountainRange, '(no mountain)') AS MountainRange,
	   ISNULL(MAX(p.Elevation), 0) AS HighestPeak,
	   DENSE_RANK() OVER (PARTITION BY c.CountryName ORDER BY MAX(p.Elevation) DESC) AS Ranked
FROM Countries AS c
	LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
	LEFT JOIN Mountains AS m ON m.Id = mc.MountainId
	LEFT JOIN Peaks AS p ON p.MountainId = m.Id
GROUP BY CountryName,p.PeakName, m.MountainRange) AS k
WHERE RANKED = 1
ORDER BY CountryName, PeakName




