--Section 4.1 Filtering data

USE BikeStore
GO

SELECT city FROM sales.customers ORDER BY city

SELECT DISTINCT city FROM sales.customers ORDER BY city

SELECT city, state FROM sales.customers ORDER BY city, state

SELECT DISTINCT city, state FROM sales.customers ORDER BY city, state

SELECT DISTINCT phone FROM sales.customers ORDER BY phone

SELECT city, state, zip_code FROM sales.customers GROUP BY city,state,zip_code ORDER BY city,state,zip_code 

SELECT DISTINCT city, state, zip_code FROM sales.customers