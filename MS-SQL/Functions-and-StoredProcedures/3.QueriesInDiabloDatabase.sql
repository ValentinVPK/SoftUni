
--13. *Cash in User Games Odd Rows

CREATE FUNCTION  ufn_CashInUsersGames(@GameName VARCHAR(MAX))
RETURNS TABLE AS
RETURN
(
	SELECT SUM(Cash) AS [SumCash] FROM 
	(SELECT g.Id, 
			g.Name, 
			ug.Cash, 
			ROW_NUMBER() OVER (ORDER BY ug.Cash DESC) AS [Ranked]
		FROM Games AS g
		JOIN UsersGames AS ug ON ug.GameId = g.Id
		WHERE g.Name = @GameName) AS k
	WHERE k.Ranked % 2 = 1
)

SELECT * FROM dbo.ufn_CashInUsersGames('Love in a mist')
