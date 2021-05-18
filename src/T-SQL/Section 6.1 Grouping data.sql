--Section 6. Grouping data

USE BikeStore
GO

SELECT customer_id ,YEAR(order_date) AS order_year FROM sales.orders
WHERE customer_id IN (1,2)
ORDER BY customer_id

SELECT customer_id, YEAR(order_date) AS order_year FROM sales.orders
WHERE customer_id IN (1,2)
GROUP BY customer_id, YEAR(order_date)
ORDER BY customer_id

SELECT DISTINCT customer_id, YEAR(order_date) AS order_year FROM sales.orders
WHERE customer_id IN (1,2)
ORDER BY customer_id

SELECT customer_id, YEAR(order_date) AS order_year, COUNT(customer_id) order_placed
FROM sales.orders
WHERE customer_id IN (1,2)
GROUP BY customer_id,YEAR(order_date)
ORDER BY customer_id

SELECT *,COUNT(*) AS customer_count FROM sales.customers
GROUP BY city 
ORDER BY city

SELECT city, state, COUNT(customer_id) AS customer_count FROM sales.customers
GROUP BY state,city
ORDER BY city, state

SELECT b.brand_name, MAX(list_price) AS max_price, MIN(list_price) AS min_price 
FROM production.products p
INNER JOIN production.brands b ON b.brand_id = p.brand_id
WHERE model_year = 2018
GROUP BY b.brand_name
ORDER BY b.brand_name

SELECT b.brand_name, AVG(list_price) AS avg_price FROM production.products p
INNER JOIN production.brands b ON b.brand_id = p.brand_id
WHERE p.model_year = 2018
GROUP BY b.brand_name
ORDER BY b.brand_name


SELECT order_id, SUM(quantity* list_price*(1-discount)) AS net_value FROM sales.order_items
GROUP BY order_id
ORDER BY order_id