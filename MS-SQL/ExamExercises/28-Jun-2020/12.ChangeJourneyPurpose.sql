
CREATE PROC usp_ChangeJourneyPurpose(@JourneyId INT, @NewPurpose VARCHAR(11))
AS
	IF (SELECT COUNT(*) FROM Journeys WHERE Id = @JourneyId) = 0
		THROW 50011, 'The journey does not exist!', 1

	IF (SELECT Purpose FROM Journeys WHERE Id = @JourneyId) = @NewPurpose
		THROW 50012, 'You cannot change the purpose!', 1

	UPDATE Journeys
	SET Purpose = @NewPurpose
	WHERE Id = @JourneyId
GO