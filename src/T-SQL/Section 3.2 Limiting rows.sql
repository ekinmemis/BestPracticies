--Section 3.2. Limiting rows

USE BikeStore
GO

SELECT TOP 1 * FROM production.products ORDER BY list_price DESC

SELECT TOP 1 PERCENT * FROM production.products ORDER BY list_price DESC

SELECT TOP 1 WITH TIES * FROM production.products ORDER BY list_price DESC

SELECT TOP 1 PERCENT WITH TIES * FROM BikeStore.production.products ORDER BY list_price DESC