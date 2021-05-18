--Section 5. Joining tables

USE BikeStore
GO

SELECT first_name, last_name FROM sales.customers ORDER BY first_name

SELECT first_name + ' ' + last_name FROM sales.customers ORDER BY first_name

SELECT first_name + ' ' + last_name full_name FROM sales.customers ORDER BY first_name
SELECT first_name + ' ' + last_name 'full_name' FROM sales.customers ORDER BY first_name
SELECT first_name + ' ' + last_name AS full_name FROM sales.customers ORDER BY first_name
SELECT first_name + ' ' + last_name AS [full_name] FROM sales.customers ORDER BY first_name

SELECT sales.customers.customer_id, first_name, last_name, order_id FROM sales.customers
INNER JOIN sales.orders ON sales.orders.customer_id = sales.customers.customer_id


SELECT [C].customer_id, first_name, last_name, order_id FROM sales.customers AS [C]
INNER JOIN  sales.orders AS [O] ON c.customer_id = o.customer_id
