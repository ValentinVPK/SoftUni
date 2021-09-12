
CREATE FUNCTION udf_GetCost(@jobId INT)
RETURNS DECIMAL(15,2)
AS
BEGIN
	DECLARE @result DECIMAL(15,2) = ISNULL((SELECT SUM(p.Price * op.Quantity) FROM Jobs AS j
											LEFT JOIN Orders AS o ON o.JobId = j.JobId
											LEFT JOIN OrderParts AS op ON op.OrderId = o.OrderId
											LEFT JOIN Parts AS p ON p.PartId = op.PartId
											WHERE j.JobId = @jobId
											GROUP BY j.JobId), 0);

	RETURN @result;
END

SELECT dbo.udf_GetCost(3)