/* Write your T-SQL query statement below */
select Employee.Name as Employee from Employee inner join employee as Employee2 on employee.managerid = Employee2.id and Employee.salary > Employee2.salary 
