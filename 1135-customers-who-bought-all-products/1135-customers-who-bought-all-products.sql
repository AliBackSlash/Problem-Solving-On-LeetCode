/* Write your T-SQL query statement below */
select customer_id from Customer group by customer_id having count(distinct product_Key) = (select count(1) from Product)