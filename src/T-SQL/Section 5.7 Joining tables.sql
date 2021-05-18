--Section 5.7 Joining tables

USE BikeStore
GO

SELECT e.first_name+' '+e.last_name employee, m.first_name+' '+m.last_name manager FROM sales.staffs e
INNER JOIN  sales.staffs m ON e.staff_id = m.manager_id
ORDER BY manager


SELECT e.first_name+' '+e.last_name employee, m.first_name+' '+m.last_name manager FROM sales.staffs e
LEFT JOIN  sales.staffs m ON e.staff_id = m.manager_id
ORDER BY manager


SELECT c1.city,c1.first_name+' '+c1.last_name AS customer1
	,c2.city, c2.first_name+' '+c2.last_name AS customer2
FROM sales.customers c1 
INNER JOIN sales.customers c2 ON c1.customer_id>c2.customer_id AND c1.city = c2.city


SELECT c1.city,c1.first_name+' '+c1.last_name AS customer1
	,c2.city, c2.first_name+' '+c2.last_name AS customer2
FROM sales.customers c1 
INNER JOIN sales.customers c2 ON c1.customer_id<>c2.customer_id AND c1.city = c2.city
ORDER BY c2.city, customer1,customer2


SELECT customer_id, first_name+' '+last_name AS full_name, city FROM sales.customers
WHERE city = 'Albany'
ORDER  BY full_name


SELECT c1.city, c1.first_name + ' '+ c1.last_name AS customer1,
		c2.city, c2.first_name + ' '+c2.last_name AS customer2
FROM sales.customers c1
INNER JOIN sales.customers c2 ON c1.customer_id>c2.customer_id
AND c1.city = c2.city
WHERE c1.city = 'Albany'
ORDER BY c1.city, customer1, customer2

SELECT c1.city,c1.first_name + ' ' + c1.last_name AS customer1,
		c2.city, c2.first_name + ' ' + c2.last_name AS customer2
FROM sales.customers c1
INNER JOIN sales.customers c2 ON c1.customer_id <> c2.customer_id
WHERE c1.city = 'Albany'
ORDER BY c1.city,customer1,customer2