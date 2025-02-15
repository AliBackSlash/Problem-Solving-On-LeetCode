/* Write your T-SQL query statement below */

with DataIWant as 
(
	select teacher_id,subject_id,ROW_NUMBER() over (partition by teacher_id,subject_id order by teacher_id) cnt from teacher 
)select teacher_id,count(case when cnt = 1 then 1 end) cnt from DataIWant group by teacher_id

