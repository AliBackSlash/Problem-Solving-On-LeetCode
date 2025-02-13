/* Write your T-SQL query statement below */

with dataIwant as 
(
	select customer_id,ROW_NUMBER() over(partition by customer_id order by order_date )
	as Time,order_date,customer_pref_delivery_date from Delivery
)
select cast(cast(count(case when (Time=1 and order_date=customer_pref_delivery_date) then 1 end)as float)
/cast((select count(case when Time=1 then 1 end) from dataIwant)as float)*100.00 as decimal(10,2)) as immediate_percentage  from dataIwant 


