/* Write your T-SQL query statement below */
select category, accounts_count
from (
    select 'Low Salary' as category, count(1) as accounts_count, 1 as sort_order from Accounts where income < 20000 
    union
    select 'High Salary', count(1), 3 from Accounts where income > 50000
    union
    select 'Average Salary', count(1), 2 from Accounts where income between 20000 and 50000
) as salary_data
order by sort_order
