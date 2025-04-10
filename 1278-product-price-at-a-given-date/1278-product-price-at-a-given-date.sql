/* Write your T-SQL query statement below */
with cte as
(
	select *,ROW_NUMBER() over (partition by product_id order by change_date desc) rn from Products where change_date <= '2019-08-16' 
)select distinct p.product_id ,case when product_id in (select t.product_id from cte t where t.rn = 1) then (select t2.new_price from cte t2
where t2.rn = 1 and t2.product_id = P.product_id) else 10 end as price from Products P