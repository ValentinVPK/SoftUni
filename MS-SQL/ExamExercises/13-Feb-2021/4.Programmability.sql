
--11. All User Commits

CREATE FUNCTION udf_AllUserCommits(@username VARCHAR(30))
RETURNS INT
AS
BEGIN
	DECLARE @result INT =  (SELECT ISNULL(COUNT(c.Id), 0) FROM Users AS u
				LEFT JOIN Commits AS c ON c.ContributorId  = u.Id
				WHERE u.Username = @username
				GROUP BY u.Id);

	RETURN @result;
END

SELECT dbo.udf_AllUserCommits('UnderSinduxrein')

--12. Search for Files

CREATE PROC usp_SearchForFiles(@fileExtension VARCHAR(10))
AS
	SELECT Id,Name, CONVERT(VARCHAR(100), Size) + 'KB' AS Size FROM Files
		WHERE CHARINDEX(@fileExtension, Name) != 0
		ORDER BY Id,Name,Size
GO

EXEC usp_SearchForFiles 'txt'