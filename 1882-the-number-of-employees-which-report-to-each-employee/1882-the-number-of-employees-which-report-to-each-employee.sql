/* Write your T-SQL query statement below */

select E.employee_id , E.name  ,count(1) as reports_count ,round(cast(AVG(E2.age*1.0) as decimal),0) as average_age from
Employees E inner join Employees E2 on E2.reports_to = E.employee_id group by  E.employee_id , E.name  
order by E.employee_id 