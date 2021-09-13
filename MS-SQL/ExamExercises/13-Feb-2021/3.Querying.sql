
--5.Commits

SELECT Id,
		Message,
		RepositoryId,ContributorId
	FROM Commits
	ORDER BY Id,
			Message,
			RepositoryId,ContributorId

--6. Front-end

SELECT Id, Name, Size FROM Files
	WHERE Size > 1000 AND CHARINDEX('html', Name) != 0
	ORDER BY Size DESC,
			  Id,
			  Name

--7. Issue Assignment

SELECT i.Id, 
		u.Username + ' : ' + i.Title AS IssueAssignee 
	FROM Issues AS i
	JOIN Users AS u ON u.Id = i.AssigneeId
	ORDER BY i.Id DESC, u.Username

--8. Single Files

SELECT Id, Name, CONVERT(VARCHAR,Size) + 'KB' FROM Files
	WHERE Id NOT IN (SELECT ParentId FROM Files
						WHERE ParentId IS NOT NULL
						GROUP BY ParentId)
	ORDER BY Id, Name, Size DESC

--9. Commits in Repositories

SELECT TOP(5) r.Id, r.Name, k.Commits FROM
(SELECT RepositoryId, COUNT(*) AS Commits FROM Commits
	GROUP BY RepositoryId) AS k
	JOIN Repositories AS r ON r.Id = k.RepositoryId
	ORDER BY k.Commits DESC,r.Id, r.Name 

--10. Average Size

SELECT u.Username, AVG(f.Size) AS Size FROM Users AS u
	JOIN Commits AS c ON c.ContributorId = u.Id
	JOIN Files AS f ON f.CommitId = c.Id
	GROUP BY u.Id, u.Username
	ORDER BY Size DESC, u.Username