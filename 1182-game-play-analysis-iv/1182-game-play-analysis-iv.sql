/* Write your T-SQL query statement below */

with dataIWant as 
(
	select player_id,ROW_NUMBER() over (partition by player_id order by event_date) as times,event_date as currentDay,lead(event_date,1) over (partition by player_id order by event_date) as nextDay from Activity
)

select cast(cast(count(case when dateadd(day,1,currentDay)=nextDay  then 1 end)as float)/cast(count(1)as float)as decimal(10,2)) as fraction  from dataIWant where times =1
