/****** SSMS 中 SelectTopNRows 命令的指令碼  ******/
SELECT *
  FROM [CEMS_1IBS010_P002].[dbo].[dataRaw]
  order by 2 desc
  ---------------------------------------
  update [dbo].[dataRaw]
  set [A23] = 9999, [F48] = 9999, [T59]=9999, [E36]=9999,[W01]=10.370
  where CreateDate = '2022-04-02 21:24:00.000'


SELECT * 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = N'dataRaw'

EXEC sp_columns @table_name = N'dataRaw',  
   @table_owner = N'sa';
if exists
(
SELECT * 
FROM sys.columns 
WHERE object_id = OBJECT_ID('dataRaw')
)
begin
	PRINT 'Column found'
end


select * from dataRaw where 1=2