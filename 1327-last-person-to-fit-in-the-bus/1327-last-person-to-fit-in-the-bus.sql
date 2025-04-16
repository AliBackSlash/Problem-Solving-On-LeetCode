/* Write your T-SQL query statement below */
with cte as 
(
	select person_name, sum(weight)over (order by turn) as sum from queue
)select top 1 person_name from cte where sum <= 1000 order by sum desc