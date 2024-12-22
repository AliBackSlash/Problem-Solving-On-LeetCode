/* Write your T-SQL query statement below */
select name from employee where id in(select managerId as countid from employee group by managerId having count(managerId) >=5)