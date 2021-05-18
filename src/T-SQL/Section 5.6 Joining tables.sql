--Section 5.6 Joining tables

USE BikeStore
GO

SELECT product_id, product_name, store_id, 0 AS quantity FROM production.products CROSS JOIN sales.stores ORDER BY product_name, store_id

SELECT s.store_id,    p.product_id,    ISNULL(sales, 0) sales FROM sales.stores s 
CROSS JOIN production.products p 
LEFT JOIN (SELECT s.store_id, p.product_id, SUM (quantity * i.list_price) sales 
FROM sales.orders o
	INNER JOIN sales.order_items i ON o.order_id = i.order_id
	INNER JOIN  sales.stores s ON s.store_id= o.store_id
	INNER JOIN  production.products p ON p.product_id = i.product_id
	) c  ON c.store_id = s.store_id AND c.product_id = p.product_id
WHERE sales IS NULL
ORDER BY product_id, store_id;