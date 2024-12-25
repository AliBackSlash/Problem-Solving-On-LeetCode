/* Write your T-SQL query statement below */
select query_name, round((avg(cast (rating as float)/position )*1.0),2) as quality ,round(count(case when rating < 3  then 1 else null end)*100.0/count(1),2) as poor_query_percentage from Queries group by query_name
