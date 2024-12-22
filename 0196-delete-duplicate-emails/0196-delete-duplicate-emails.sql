/* Write your T-SQL query statement below */
WITH NumberedRows AS (
    SELECT id, email,
           ROW_NUMBER() OVER (PARTITION BY email ORDER BY id) AS RowNum
    FROM Person
)
DELETE FROM Person
WHERE id IN (
    SELECT id
    FROM NumberedRows
    WHERE RowNum > 1
);
