
SELECT * FROM Cigars
UPDATE Cigars
SET PriceForSingleCigar = PriceForSingleCigar + 0.2 * PriceForSingleCigar
WHERE TastId = 1

UPDATE Brands
SET BrandDescription = 'New description'
WHERE BrandDescription IS NULL