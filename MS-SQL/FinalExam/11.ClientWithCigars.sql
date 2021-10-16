
CREATE OR ALTER FUNCTION udf_ClientWithCigars(@name VARCHAR(30))
RETURNS INT
AS
BEGIN
	DECLARE @resultFromSelect INT = (SELECT COUNT(*) FROM Cigars AS ci
											JOIN ClientsCigars AS cc ON cc.CigarId = ci.Id
											JOIN Clients AS cl ON cl.Id = cc.ClientId
											WHERE cl.FirstName = @name )

	RETURN @resultFromSelect
END

SELECT dbo.udf_ClientWithCigars('Jason')


