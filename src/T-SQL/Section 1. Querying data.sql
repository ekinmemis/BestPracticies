--Section 1. Querying data
USE BikeStore;
GO

SELECT first_name, last_name FROM sales.customers;

SELECT first_name, last_name, email FROM sales.customers;

SELECT * FROM sales.customers;

SELECT * FROM sales.customers WHERE state = 'CA';

SELECT * FROM sales.customers WHERE state = 'CA' ORDER BY first_name;

SELECT city, COUNT(*) FROM sales.customers WHERE state = 'CA' GROUP BY city ORDER BY city;

SELECT city, COUNT(*) FROM sales.customers WHERE state = 'CA' GROUP BY city HAVING COUNT(*) > 10 ORDER BY city;