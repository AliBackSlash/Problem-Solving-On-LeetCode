/* Write your T-SQL query statement below */
select firstName,lastName,city,state from person left join Address on address.personid = Person.Personid