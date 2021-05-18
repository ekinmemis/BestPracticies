--Section 6.2 Grouping data

USE BikeStore
GO

SELECT customer_id, YEAR(order_date),COUNT(ordeR_id) AS order_count
FROM sales.orders
GROUP BY customer_id, YEAR(order_date)
HAVING COUNT(order_id)>=2
ORDER BY customer_id

SELECT order_id, SUM(quantity*list_price*(1-discount)) AS net_value
FROM sales.order_items
GROUP BY order_id
HAVING SUM(quantity * list_price*(1-discount))>20000
ORDER BY net_value

SELECT category_id, MAX(list_price) AS max_price, MIN(list_price) AS min_price 
FROM production.products
GROUP BY category_id
HAVING MAX(list_price)>4000 OR MIN(list_price)<500

SELECT category_id, AVG(list_price) AS avg_list_price
FROM production.products
GROUP BY category_id
HAVING AVG(list_price) BETWEEN 500 AND 1000