/* Write your T-SQL query statement below */


select p.product_id as product_id,COALESCE(cast(cast(sum(p.price*u.units) as float)/sum(u.units)as decimal(10,2)),0) as average_price  from Prices p left join UnitsSold u
on p.product_id = u.product_id and u.purchase_date  between p.start_date  and p.end_date group by p.product_id