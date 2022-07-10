WITH ABC AS(
	SELECT *, RN= ROW_NUMBER()OVER(PARTITION BY email order by id) 
	from Person
	)
DELETE FROM ABC WHERE RN>1

----------------------

/* Write your T-SQL query statement below */
select id
from Weather w
where exists (select 1 
				from Weather w2 
				where w2.recordDate = dateadd(d,-1,w.recordDate) and w.temperature > w2.temperature)

-- I assume that EXISTS (or IN) works faster than inner join, but I might be wrong


----------------

-- swap f to m, otherwise.
update Salary set sex = (case when sex = 'f' then 'm' else 'f' end)

------------------------------------
-- add new item RN sort of class to delete > 1.

WITH ABC AS(SELECT *, RN = ROW_NUMBER()OVER(PARTITION BY email order by id) from Person) DELETE FROM ABC WHERE RN>1

-------------------------------------
-- # design schem in temp
CREATE TABLE #temp (  
    emp_name NVARCHAR(200) NOT NULL,  
    emp_middlename NVARCHAR(200) NULL,  
    emp_lastname NVARCHAR(200) NOT NULL  
);  
INSERT INTO #temp VALUES( 'Name', NULL, 'Lastname' );  
SELECT CONCAT( emp_name, emp_middlename, emp_lastname ) AS Result  
FROM #temp;  


-------------------------------------

select
user_id,
concat(upper(left(name,1)),lower(right(name,len(name)-1))) as name
from
Users
order by user_id