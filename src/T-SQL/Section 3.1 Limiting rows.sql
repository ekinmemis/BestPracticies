--Section 3.1. Limiting rows
USE BikeStore
GO

SELECT product_name, list_price FROM production.products ORDER BY list_price DESC, product_name;

SELECT product_name, list_price FROM production.products ORDER BY list_price, product_name OFFSET 10 ROWS

SELECT product_name, list_price FROM production.products ORDER BY list_price, product_name OFFSET 10 ROWS FETCH NEXT 10 ROWS ONLY