/* Write your T-SQL query statement below */
--select distinct  player_id ,event_date  as first_login from Activity where event_date = (select top 1 event_date from Activity as SubActivity where SubActivity.player_id = Activity.player_id order by event_date asc) 
WITH cte AS (SELECT *,
ROW_NUMBER() OVER(PARTITION BY player_id ORDER BY event_date ASC) as rn
FROM Activity) 
SELECT player_id,event_date AS first_login
FROM cte 
WHERE rn=1;