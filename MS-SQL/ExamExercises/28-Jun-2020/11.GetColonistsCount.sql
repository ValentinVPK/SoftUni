

CREATE FUNCTION dbo.udf_GetColonistsCount(@PlanetName VARCHAR (30))
RETURNS INT
AS
BEGIN
	DECLARE @result INT = (SELECT COUNT(*) FROM Journeys AS j
									JOIN Spaceports AS s ON s.Id = j.DestinationSpaceportId
									JOIN Planets AS p ON p.Id = s.PlanetId
									JOIN TravelCards AS tc ON tc.JourneyId = j.Id
									JOIN Colonists AS c ON c.Id = tc.ColonistId
								WHERE p.Name = @PlanetName)

	RETURN @result
END


SELECT dbo.udf_GetColonistsCount('Otroyphus')