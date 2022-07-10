/****** SSMS 中 SelectTopNRows 命令的指令碼  ******/
SELECT *
  FROM [CEMS_3IQS007_P001].[dbo].[log4BAF]
  order by id desc

  ---------------------------------------------
  -- 新增 三月的 BAF

  set identity_insert [CEMS_3IQS007_P001].[dbo].[log4BAF] ON

  insert into [CEMS_3IQS007_P001].[dbo].[log4BAF]( Id, CreateDate, PipeSID, ItemSID,isBackDevice, BackDeviceCode,ExecuteDate,GetReportDate,[Value],BAF,Remark)
  values(99, '2022-02-16 13:24:50.000', 'CEMS_3IQS007_P001', 'F48', 0, 'A', '2022-03-01 00:00:00.000', '2022-03-05 00:00:00.000',2.0,18.88,Null)

  set identity_insert [CEMS_3IQS007_P001].[dbo].[log4BAF] OFF