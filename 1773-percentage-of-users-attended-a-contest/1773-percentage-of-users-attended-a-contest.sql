/* Write your PL/SQL query statement below */

select r.contest_id, round((count(u.user_id)*100.0/(select count(1) from Users)*1.00),2) as percentage from
Users u join Register r on r.user_id = u.user_id group by r.contest_id order by  percentage desc , r.contest_id 

