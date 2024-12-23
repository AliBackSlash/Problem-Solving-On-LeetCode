/* Write your T-SQL query statement below */
  select project_id, round(avg(experience_years*1.0), 2) as average_years
from Project t1 left join Employee t2 on t1.employee_id = t2.employee_id
GROUP BY project_id