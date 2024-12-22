/* Write your T-SQL query statement below */
SELECT 
  S.student_id,
  S.student_name,
  Sub.subject_name,
  COALESCE(E.attended_exams, 0) AS attended_exams
FROM 
  Students S
  CROSS JOIN Subjects Sub
  LEFT JOIN (
    SELECT 
      student_id, 
      subject_name, 
      COUNT(*) AS attended_exams
    FROM 
      Examinations
    GROUP BY 
      student_id, 
      subject_name
  ) E ON S.student_id = E.student_id AND Sub.subject_name = E.subject_name
ORDER BY 
  S.student_id, 
  Sub.subject_name;
