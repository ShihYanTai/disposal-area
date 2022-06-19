/****** SSMS 中 SelectTopNRows 命令的指令碼  ******/
with t1 as(
SELECT *
  FROM [CEMS_3IQS007_P001].[dbo].[dataFix60]
  where CreateDate >= '2022-05-15' and CreateDate < '2022-5-17' 
  )
  select *
  from t1
  where A22_st Like '%11'
  ---------------------------------------------------------------
  /* 查詢整點數量是否超過2個*/

  WITH T1 AS( 
  select CreateDate ,A22_st ,CONVERT(VARCHAR(12), CreateDate, 5) AS DateDisplayStyle3
  from CEMS_3IQS007_P001.dbo.dataFix60
  where (A22_st like '%11' )AND CreateDate BETWEEN '2022-05-01' AND '2022-06-01'
  GROUP BY A22_st ,CreateDate)
  SELECT DateDisplayStyle3,COUNT(DateDisplayStyle3) AS NUB, CreateDate
  FROM T1
  where RIGHT(CONVERT(varchar(19),CreateDate,120),5) = '00:00'
  GROUP BY DateDisplayStyle3,CreateDate

  ------------------------------------------
	/* 確認語法*/

  select *
  from CEMS_3IQS007_P001.dbo.dataFix60
  where CreateDate  BETWEEN '2022-05-01' AND '2022-06-01' and (A22_st like '%11')