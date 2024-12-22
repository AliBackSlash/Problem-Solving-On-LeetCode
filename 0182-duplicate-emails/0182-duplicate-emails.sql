/* Write your T-SQL query statement below */
select distinct email as Email from Person as CurrentPerson where email in (select email from Person where Person.id <> CurrentPerson.id) 