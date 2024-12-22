SELECT DISTINCT   
    machine_id,  
    ROUND(  
        (  
            (SELECT SUM(timestamp) FROM Activity a1 WHERE a1.machine_id = A.machine_id AND activity_type = 'End')  
            - (SELECT SUM(timestamp) FROM Activity a2 WHERE a2.machine_id = A.machine_id AND activity_type = 'Start')  
        ) / (SELECT COUNT(machine_id) / 2 FROM Activity WHERE machine_id = A.machine_id),   
        3   
    ) AS processing_time   
FROM Activity A   
GROUP BY A.machine_id;  