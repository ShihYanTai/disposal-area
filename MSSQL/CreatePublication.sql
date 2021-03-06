use [CEMS_3IQS007_P001]
exec sp_replicationdboption @dbname = N'CEMS_3IQS007_P001', @optname = N'publish', @value = N'true'
GO
use [CEMS_3IQS007_P001]
exec [CEMS_3IQS007_P001].sys.sp_addlogreader_agent @job_login = N'cems_backup\myuser', @job_password = null, @publisher_security_mode = 0, @publisher_login = N'sa', @publisher_password = N' ', @job_name = null
GO
-- 正在加入交易式發行集
use [CEMS_3IQS007_P001]
exec sp_addpublication @publication = N'test_3IQS007', @description = N'來自發行者 ''CEMS_BACKUP\TESTMACHINE'' 的資料庫 ''CEMS_3IQS007_P001'' 交易式發行集。', @sync_method = N'concurrent', @retention = 0, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @repl_freq = N'continuous', @status = N'active', @independent_agent = N'true', @immediate_sync = N'true', @allow_sync_tran = N'false', @autogen_sync_procs = N'false', @allow_queued_tran = N'false', @allow_dts = N'false', @replicate_ddl = 1, @allow_initialize_from_backup = N'false', @enabled_for_p2p = N'false', @enabled_for_het_sub = N'false'
GO


exec sp_addpublication_snapshot @publication = N'test_3IQS007', @frequency_type = 1, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = N'cems_backup\myuser', @job_password = null, @publisher_security_mode = 0, @publisher_login = N'sa', @publisher_password = N''


use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'asHourRecord', @source_owner = N'dbo', @source_object = N'asHourRecord', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'asHourRecord', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboasHourRecord', @del_cmd = N'CALL sp_MSdel_dboasHourRecord', @upd_cmd = N'SCALL sp_MSupd_dboasHourRecord'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'asRecord', @source_owner = N'dbo', @source_object = N'asRecord', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'asRecord', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboasRecord', @del_cmd = N'CALL sp_MSdel_dboasRecord', @upd_cmd = N'SCALL sp_MSupd_dboasRecord'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'dataCalibrate', @source_owner = N'dbo', @source_object = N'dataCalibrate', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'dataCalibrate', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbodataCalibrate', @del_cmd = N'CALL sp_MSdel_dbodataCalibrate', @upd_cmd = N'SCALL sp_MSupd_dbodataCalibrate'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'dataFix', @source_owner = N'dbo', @source_object = N'dataFix', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'dataFix', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbodataFix', @del_cmd = N'CALL sp_MSdel_dbodataFix', @upd_cmd = N'SCALL sp_MSupd_dbodataFix'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'dataFix15', @source_owner = N'dbo', @source_object = N'dataFix15', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'dataFix15', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbodataFix15', @del_cmd = N'CALL sp_MSdel_dbodataFix15', @upd_cmd = N'SCALL sp_MSupd_dbodataFix15'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'dataFix60', @source_owner = N'dbo', @source_object = N'dataFix60', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'dataFix60', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbodataFix60', @del_cmd = N'CALL sp_MSdel_dbodataFix60', @upd_cmd = N'SCALL sp_MSupd_dbodataFix60'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'dataFixOP', @source_owner = N'dbo', @source_object = N'dataFixOP', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'dataFixOP', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbodataFixOP', @del_cmd = N'CALL sp_MSdel_dbodataFixOP', @upd_cmd = N'SCALL sp_MSupd_dbodataFixOP'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'dataFixOP6', @source_owner = N'dbo', @source_object = N'dataFixOP6', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'dataFixOP6', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbodataFixOP6', @del_cmd = N'CALL sp_MSdel_dbodataFixOP6', @upd_cmd = N'SCALL sp_MSupd_dbodataFixOP6'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'dataRaw', @source_owner = N'dbo', @source_object = N'dataRaw', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'dataRaw', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbodataRaw', @del_cmd = N'CALL sp_MSdel_dbodataRaw', @upd_cmd = N'SCALL sp_MSupd_dbodataRaw'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'dataRawOP', @source_owner = N'dbo', @source_object = N'dataRawOP', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'dataRawOP', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbodataRawOP', @del_cmd = N'CALL sp_MSdel_dbodataRawOP', @upd_cmd = N'SCALL sp_MSupd_dbodataRawOP'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'infoCalibrate', @source_owner = N'dbo', @source_object = N'infoCalibrate', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'infoCalibrate', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboinfoCalibrate', @del_cmd = N'CALL sp_MSdel_dboinfoCalibrate', @upd_cmd = N'SCALL sp_MSupd_dboinfoCalibrate'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'InfoCalibrationGas', @source_owner = N'dbo', @source_object = N'InfoCalibrationGas', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'InfoCalibrationGas', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboInfoCalibrationGas', @del_cmd = N'CALL sp_MSdel_dboInfoCalibrationGas', @upd_cmd = N'SCALL sp_MSupd_dboInfoCalibrationGas'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'infoItem', @source_owner = N'dbo', @source_object = N'infoItem', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'infoItem', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboinfoItem', @del_cmd = N'CALL sp_MSdel_dboinfoItem', @upd_cmd = N'SCALL sp_MSupd_dboinfoItem'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'infoItemDetail', @source_owner = N'dbo', @source_object = N'infoItemDetail', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'infoItemDetail', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboinfoItemDetail', @del_cmd = N'CALL sp_MSdel_dboinfoItemDetail', @upd_cmd = N'SCALL sp_MSupd_dboinfoItemDetail'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'infoMonFuel', @source_owner = N'dbo', @source_object = N'infoMonFuel', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'infoMonFuel', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboinfoMonFuel', @del_cmd = N'CALL sp_MSdel_dboinfoMonFuel', @upd_cmd = N'SCALL sp_MSupd_dboinfoMonFuel'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'infoMonOpCalibration', @source_owner = N'dbo', @source_object = N'infoMonOpCalibration', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'infoMonOpCalibration', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboinfoMonOpCalibration', @del_cmd = N'CALL sp_MSdel_dboinfoMonOpCalibration', @upd_cmd = N'SCALL sp_MSupd_dboinfoMonOpCalibration'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'infoMonRecorder', @source_owner = N'dbo', @source_object = N'infoMonRecorder', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'infoMonRecorder', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboinfoMonRecorder', @del_cmd = N'CALL sp_MSdel_dboinfoMonRecorder', @upd_cmd = N'SCALL sp_MSupd_dboinfoMonRecorder'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'infoPipe', @source_owner = N'dbo', @source_object = N'infoPipe', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'infoPipe', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboinfoPipe', @del_cmd = N'CALL sp_MSdel_dboinfoPipe', @upd_cmd = N'SCALL sp_MSupd_dboinfoPipe'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'infoRata', @source_owner = N'dbo', @source_object = N'infoRata', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'infoRata', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboinfoRata', @del_cmd = N'CALL sp_MSdel_dboinfoRata', @upd_cmd = N'SCALL sp_MSupd_dboinfoRata'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'log4BAF', @source_owner = N'dbo', @source_object = N'log4BAF', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'log4BAF', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbolog4BAF', @del_cmd = N'CALL sp_MSdel_dbolog4BAF', @upd_cmd = N'SCALL sp_MSupd_dbolog4BAF'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'LogBAF', @source_owner = N'dbo', @source_object = N'LogBAF', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'LogBAF', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboLogBAF', @del_cmd = N'CALL sp_MSdel_dboLogBAF', @upd_cmd = N'SCALL sp_MSupd_dboLogBAF'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'logCGA', @source_owner = N'dbo', @source_object = N'logCGA', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'logCGA', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbologCGA', @del_cmd = N'CALL sp_MSdel_dbologCGA', @upd_cmd = N'SCALL sp_MSupd_dbologCGA'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'logCorrection4Opacity', @source_owner = N'dbo', @source_object = N'logCorrection4Opacity', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'logCorrection4Opacity', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbologCorrection4Opacity', @del_cmd = N'CALL sp_MSdel_dbologCorrection4Opacity', @upd_cmd = N'SCALL sp_MSupd_dbologCorrection4Opacity'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'logFixedDevice', @source_owner = N'dbo', @source_object = N'logFixedDevice', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'logFixedDevice', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbologFixedDevice', @del_cmd = N'CALL sp_MSdel_dbologFixedDevice', @upd_cmd = N'SCALL sp_MSupd_dbologFixedDevice'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'logMaintDevice', @source_owner = N'dbo', @source_object = N'logMaintDevice', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'logMaintDevice', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbologMaintDevice', @del_cmd = N'CALL sp_MSdel_dbologMaintDevice', @upd_cmd = N'SCALL sp_MSupd_dbologMaintDevice'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'logNOxConverterEfficiency', @source_owner = N'dbo', @source_object = N'logNOxConverterEfficiency', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'logNOxConverterEfficiency', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbologNOxConverterEfficiency', @del_cmd = N'CALL sp_MSdel_dbologNOxConverterEfficiency', @upd_cmd = N'SCALL sp_MSupd_dbologNOxConverterEfficiency'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'logOperate', @source_owner = N'dbo', @source_object = N'logOperate', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'logOperate', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbologOperate', @del_cmd = N'CALL sp_MSdel_dbologOperate', @upd_cmd = N'SCALL sp_MSupd_dbologOperate'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'logParallel', @source_owner = N'dbo', @source_object = N'logParallel', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'logParallel', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbologParallel', @del_cmd = N'CALL sp_MSdel_dbologParallel', @upd_cmd = N'SCALL sp_MSupd_dbologParallel'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'logRAA', @source_owner = N'dbo', @source_object = N'logRAA', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'logRAA', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbologRAA', @del_cmd = N'CALL sp_MSdel_dbologRAA', @upd_cmd = N'SCALL sp_MSupd_dbologRAA'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'logRATA', @source_owner = N'dbo', @source_object = N'logRATA', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'logRATA', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbologRATA', @del_cmd = N'CALL sp_MSdel_dbologRATA', @upd_cmd = N'SCALL sp_MSupd_dbologRATA'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'logVerify', @source_owner = N'dbo', @source_object = N'logVerify', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'logVerify', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbologVerify', @del_cmd = N'CALL sp_MSdel_dbologVerify', @upd_cmd = N'SCALL sp_MSupd_dbologVerify'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'LogWater', @source_owner = N'dbo', @source_object = N'LogWater', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'LogWater', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboLogWater', @del_cmd = N'CALL sp_MSdel_dboLogWater', @upd_cmd = N'SCALL sp_MSupd_dboLogWater'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'NOxConverterEfficiency', @source_owner = N'dbo', @source_object = N'NOxConverterEfficiency', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'NOxConverterEfficiency', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboNOxConverterEfficiency', @del_cmd = N'CALL sp_MSdel_dboNOxConverterEfficiency', @upd_cmd = N'SCALL sp_MSupd_dboNOxConverterEfficiency'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'overRecordExplain', @source_owner = N'dbo', @source_object = N'overRecordExplain', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'overRecordExplain', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dbooverRecordExplain', @del_cmd = N'CALL sp_MSdel_dbooverRecordExplain', @upd_cmd = N'SCALL sp_MSupd_dbooverRecordExplain'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'PkgDIOAIO', @source_owner = N'dbo', @source_object = N'PkgDIOAIO', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'PkgDIOAIO', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboPkgDIOAIO', @del_cmd = N'CALL sp_MSdel_dboPkgDIOAIO', @upd_cmd = N'SCALL sp_MSupd_dboPkgDIOAIO'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'PkgModbus', @source_owner = N'dbo', @source_object = N'PkgModbus', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'PkgModbus', @destination_owner = N'dbo', @vertical_partition = N'false', @ins_cmd = N'CALL sp_MSins_dboPkgModbus', @del_cmd = N'CALL sp_MSdel_dboPkgModbus', @upd_cmd = N'SCALL sp_MSupd_dboPkgModbus'
GO




use [CEMS_3IQS007_P001]
exec sp_addarticle @publication = N'test_3IQS007', @article = N'Func_GetOldStatus', @source_owner = N'dbo', @source_object = N'Func_GetOldStatus', @type = N'func schema only', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_table = N'Func_GetOldStatus', @destination_owner = N'dbo'
GO




