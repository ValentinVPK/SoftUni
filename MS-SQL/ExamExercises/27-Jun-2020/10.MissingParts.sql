
SELECT p.PartId, 
		p.Description,  
		pn.Quantity AS [Required],
		p.StockQty AS [In Stock],
		IIF(op.Quantity IS NULL, 0, op.Quantity) AS [Ordered]
	FROM Parts AS p
	LEFT JOIN PartsNeeded AS pn ON pn.PartId = p.PartId
	LEFT JOIN Jobs AS j ON j.JobId = pn.JobId
	LEFT JOIN Orders AS o ON o.JobId = j.JobId
	LEFT JOIN OrderParts AS op ON op.OrderId = o.OrderId
WHERE j.Status != 'Finished' AND IIF(op.Quantity IS NULL, 0, op.Quantity) + p.StockQty < pn.Quantity
ORDER BY p.PartId

