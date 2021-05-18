--Section 4.2 Filtering data

USE BikeStore
GO

SELECT product_id, product_name, category_id, model_year, list_price FROM production.products WHERE category_id = 1 ORDER BY list_price DESC

SELECT product_id, product_name, category_id, model_year, list_price FROM production.products WHERE category_id = 1 AND model_year = 2018 ORDER BY list_price DESC

SELECT product_id, product_name, category_id, model_year, list_price FROM production.products WHERE list_price > 3000 OR model_year = 2018 ORDER BY list_price DESC

SELECT product_id, product_name, category_id, model_year, list_price FROM production.products WHERE list_price BETWEEN 1000 AND 2000 ORDER BY list_price DESC

SELECT product_id, product_name, category_id, model_year, list_price FROM production.products WHERE list_price IN (299.99,369.99,489.99) ORDER BY list_price DESC

SELECT product_id, product_name, category_id, model_year, list_price FROM production.products WHERE product_name LIKE '%Cruiser%' ORDER BY list_price DESC