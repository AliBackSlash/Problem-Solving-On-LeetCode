/* Write your T-SQL query statement below */
select Name as Customers from Customers where Customers.id not in(select customerId  from Orders)