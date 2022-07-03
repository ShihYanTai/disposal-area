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