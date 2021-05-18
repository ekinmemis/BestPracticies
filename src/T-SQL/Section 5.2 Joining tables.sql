

USE BikeStore
GO

SELECT * FROM production.products ORDER BY product_name DESC

SELECT * FROM production.products p
INNER JOIN production.categories c ON p.category_id= c.category_id
ORDER BY p.product_name DESC

SELECT * FROM production.products p
INNER JOIN  production.categories c ON c.category_id = p.category_id
INNER JOIN  production.brands b ON b.brand_id = p.brand_id
--daha fazla tablo eklenebilir.
ORDER BY p.product_name


