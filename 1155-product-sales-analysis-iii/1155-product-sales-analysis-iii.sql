SELECT s.product_id, s.year as first_year , s.quantity, s.price
FROM Sales s
WHERE s.year = (SELECT MIN(year) FROM Sales WHERE product_id = s.product_id);
