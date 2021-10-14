

SELECT k.JobDuringJourney, c.FirstName + ' ' + c.LastName AS FullName, k.JobRank FROM
(SELECT tc.JobDuringJourney,
			tc.ColonistId,
			DENSE_RANK() OVER (PARTITION BY tc.JobDuringJourney ORDER BY c.BirthDate ASC) AS JobRank
		FROM TravelCards AS tc
	JOIN Colonists AS c ON c.Id = tc.ColonistId
	GROUP BY tc.JobDuringJourney, c.BirthDate, tc.ColonistId) AS k
JOIN Colonists AS c ON c.Id = k.ColonistId
WHERE k.JobRank = 2
ORDER BY k.JobDuringJourney
