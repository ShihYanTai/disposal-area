/****** SSMS 中 SelectTopNRows 命令的指令碼  ******/
SELECT *
  FROM [CEMS_3IQS007_P001].[dbo].[logRATA]
  order by 2 desc

  -----------------------------------------------------------------
  -- 新增 -- id 74 未顯示新增的值 依然為01-18 
  
  set identity_insert [CEMS_3IQS007_P001].[dbo].[logRATA] ON

  insert into [CEMS_3IQS007_P001].[dbo].[logRATA]( Id, CreateDate, PipeSID, ItemSID,isBackDevice, BackDeviceCode,ExecuteDate,GetReportDate,isValidate,[Value],Water,Remark)
  values(74, '2022-03-01 00:00:01.000', 'CEMS_3IQS007_P001', 'A22', 0, 'A', '2022-03-01 00:00:00.000', '2022-04-05 00:00:00.000',1,9.99,18.88,Null)

  set identity_insert [CEMS_3IQS007_P001].[dbo].[logRATA] OFF

  ------------------------------------------------------------------
  -- 新增id 92
  set identity_insert [CEMS_3IQS007_P001].[dbo].[logRATA] ON

  insert into [CEMS_3IQS007_P001].[dbo].[logRATA]( Id, CreateDate, PipeSID, ItemSID,isBackDevice, BackDeviceCode,ExecuteDate,GetReportDate,isValidate,[Value],Water,Remark)
  values(92, '2022-03-01 00:00:01.000', 'CEMS_3IQS007_P001', 'A22', 0, 'A', '2022-03-01 00:00:00.000', '2022-04-05 00:00:00.000',1,9.99,18.88,Null)

  set identity_insert [CEMS_3IQS007_P001].[dbo].[logRATA] OFF


  ------------------------------------------------------------------
  -- id 排序
  select *
  from [CEMS_3IQS007_P001].[dbo].[logRATA]
  order by Id desc


  ------------------------------------------------------------------

  -- 刪除

  delete from [CEMS_3IQS007_P001].[dbo].[logRATA]
  where id = 91

  -------------------------------------------------------------------
  -- 新增 getReportDate

  set identity_insert [CEMS_3IQS007_P001].[dbo].[logRATA] ON

  insert into [CEMS_3IQS007_P001].[dbo].[logRATA]( Id, CreateDate, PipeSID, ItemSID,isBackDevice, BackDeviceCode,ExecuteDate,GetReportDate,isValidate,[Value],Water,Remark)
  values(91, '2022-02-16 13:24:50.000', 'CEMS_3IQS007_P001', 'F48', 0, 'A', '2022-03-01 00:00:00.000', '2022-03-05 00:00:00.000',1,9.99,18.88,Null)

  set identity_insert [CEMS_3IQS007_P001].[dbo].[logRATA] OFF