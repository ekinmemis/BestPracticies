USE BikeStore
GO

SELECT * FROM sales.order_items o
RIGHT JOIN production.products p ON o.product_id = p.product_id
ORDER BY o.order_id

SELECT * FROM sales.order_items o
RIGHT JOIN production.products p ON o.product_id = p.product_id
WHERE o.order_id IS NULL
ORDER BY o.order_id