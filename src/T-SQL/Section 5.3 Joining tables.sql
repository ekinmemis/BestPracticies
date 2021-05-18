USE BikeStore
GO

SELECT * FROM production.products p
LEFT JOIN sales.order_items o ON p.product_id = o.product_id
ORDER BY o.order_id

SELECT * FROM production.products p 
LEFT JOIN sales.order_items o ON o.product_id = p.product_id WHERE o.order_id IS NULL
ORDER BY o.order_id

SELECT * FROM production.products p
LEFT JOIN sales.order_items i ON i.product_id = p.product_id
LEFT JOIN sales.orders o ON o.order_id = i.order_id

SELECT * FROM production.products p
LEFT JOIN sales.order_items o ON o.product_id = p.product_id
WHERE o.order_id = 100
ORDER BY o.order_id

SELECT * FROM production.products p 
LEFT JOIN sales.order_items o ON o.product_id = p.product_id AND o.order_id=100
ORDER BY o.order_id DESC