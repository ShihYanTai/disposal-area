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

----------------------------------------------

USE AdventureWorks2012;  
GO  
SELECT p.FirstName, p.LastName , DATEDIFF(day, ROW_NUMBER() OVER (ORDER BY a.PostalCode), SYSDATETIME()) AS 'Row Number'  
FROM Sales.SalesPerson s   
    INNER JOIN Person.Person p ON s.BusinessEntityID = p.BusinessEntityID  
    INNER JOIN Person.Address a ON a.AddressID = p.BusinessEntityID  
WHERE TerritoryID IS NOT NULL  AND SalesYTD <> 0;

----------------------------------------------

SELECT TOP(1) customer_number FROM Orders GROUP BY customer_number HAVING count(order_number) > 1 ORDER BY count(order_number) DESC

---Using CTE fast than font sentence -----

with t1 as (select class, count(class) as num from Courses group by class )
select class from t1 where num >=5

--------------------------------------------------------------


with temp as (
select  month(sale_date) mon, product_id, seller_id
	from sales
	-- where year(sale_date) = 2019
)

,temp1 as (
select distinct product_id, case when mon < 4 then 1 when mon < 7 then 2 when mon < 10 then 3 else 4 end as qtr,  seller_id
	from temp
)

, temp2 as (
	select distinct p.product_id, p.product_name, t.qtr, t.seller_id
	from product p join temp1 t
	on p.product_id = t.product_id
)


select distinct product_id, product_name
from temp2 t1
where qtr = 1 
except 
select distinct product_id, product_name
from temp2 t1
where qtr <> 1

----------------------------------------------------------------------------

SELECT P.product_id, product_name
FROM Product P
JOIN Sales S ON S.product_id = P.product_id
GROUP BY P.product_id, product_name
HAVING MAX(sale_date) <= CAST('2019-03-31' AS DATE)
    AND MIN(sale_date) >= CAST('2019-01-01' AS DATE)

-----------------------------------------------------------------------------
Select Product.product_id, Product.product_name from Product

/* select IDs which belong to the first 3 months*/
where product_id IN (Select product_id from Sales where sale_date between '2019-01-01' and '2019-03-31')
AND
/* drop IDs which belong to rest of the months */
product_id NOT IN (Select product_id from Sales where sale_date not between '2019-01-01' and '2019-03-31')

------------------------------------------------------------------------------

with t1 as(select player_id, device_id, event_date, games_played , RANK() OVER   
    (PARTITION BY player_id ORDER BY event_date ) AS Rankfrom from Activity)
select player_id, event_date as first_login from t1 where Rankfrom =1

-------------------------------------------------------------------------------

select x.day, count(x.active_users) active_users
from 
(select activity_date day, user_id active_users
  from activity
 where activity_date between dateadd(dd, -30, '2019-07-28') and '2019-07-28'
 group by activity_date, user_id) x
group by x.day


------------------------------------------------------------------------------------

WITH TMP1 AS (
SELECT DISTINCT sell_date, product
FROM Activities)

SELECT
sell_date,
COUNT(product) AS num_sold,
STRING_AGG(product, ',') WITHIN GROUP (ORDER BY PRODUCT) AS products
FROM TMP1
GROUP BY sell_date

--------------------------------------------------------------------------------------
with t1 as(select  account, sum(amount) balance
from Transactions t 
group by account
having sum(amount) > 10000)
select Users.name, t1.balance
from t1 join Users on (t1.account = Users.account)

------------------------------------
select user_id ,max(time_stamp) as last_stamp
from Logins
where year(time_stamp) = 2020
group by user_id