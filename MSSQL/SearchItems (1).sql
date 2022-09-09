USE Atlas SELECT * FROM sys.all_columns dataCalibrate
USE Atlas;  
GO  
EXEC sp_columns @table_name = N'dataCalibrate',  
   @table_owner = N'sa';



SELECT * 
FROM sys.columns 
WHERE object_id = OBJECT_ID('ACCOUNT')

SELECT  SCHEMA_NAME(o.schema_id) SchemaName, o.Name, c.Name
FROM     sys.columns c 
         JOIN sys.objects o ON o.object_id = c.object_id 
WHERE    o.type = 'U' AND c.name = N'dataCalibrate'
ORDER BY o.Name, c.Name

sp_help N'dataCalibrate'