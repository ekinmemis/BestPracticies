--Section 6.3 Grouping data

USE BikeStore
GO

SELECT order_id, order_date, customer_id 
FROM sales.orders
WHERE customer_id IN (SELECT customer_id 
						FROM sales.customers 
							WHERE city = 'New York')
ORDER BY order_date DESC

SELECT product_name, list_price 
FROM production.products
WHERE list_price > (SELECT AVG(list_price) AS list_price 
						FROM production.products 
							WHERE brand_id IN (SELECT brand_id 
													FROM production.brands 
														WHERE brand_name = 'Strider' OR brand_name = 'Trek'))
ORDER BY list_price

SELECT AVG(list_price) AS avg_list_price 
FROM production.products
WHERE brand_id IN (1,2)

SELECT order_id, order_date, (SELECT MAX(list_price) 
								FROM sales.order_items i 
									WHERE i.order_id = o.order_id) AS max_list_price 
FROM sales.orders o


SELECT product_id, product_name 
FROM production.products
WHERE category_id IN (SELECT category_id 
						FROM production.categories 
							WHERE category_name = 'Mountain Bikes'
								OR category_name = 'Road Bikes')

SELECT product_name, list_price
FROM production.products
WHERE list_price >= ANY (SELECT AVG(list_price) 
							FROM production.products 
								GROUP BY brand_id)

SELECT product_name, list_price
FROM production.products
WHERE list_price >= ALL (SELECT AVG(list_price) 
							FROM production.products 
								GROUP BY brand_id)

SELECT customer_id, first_name, last_name 
FROM sales.customers c
WHERE EXISTS(SELECT customer_id 
				FROM sales.orders o 
					WHERE o.customer_id = c.customer_id AND YEAR(order_date)=2017)
ORDER BY c.first_name, c.last_name


SELECT customer_id, first_name, last_name 
FROM sales.customers c
WHERE NOT EXISTS(SELECT customer_id 
					FROM sales.orders o 
						WHERE o.customer_id = c.customer_id AND YEAR(order_date)=2017)
ORDER BY c.first_name, c.last_name

SELECT staff_id, COUNT(order_id) order_count
FROM sales.orders
GROUP BY staff_id;

SELECT AVG(order_count) average_order_count_by_staff
FROM (SELECT staff_id, COUNT(order_id) order_count
		 FROM sales.orders
			GROUP BY staff_id) t;