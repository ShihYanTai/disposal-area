-----------------開始: 在發行者 'CEMS_BACKUP\TESTMACHINE' 端執行的指令碼-----------------
use [CEMS_3IQS007_P001]
exec sp_addsubscription @publication = N'test_3IQS007', @subscriber = N'JACKY-PC\SUDO', @destination_db = N'CEMS_3IQS007_P001', @subscription_type = N'Push', @sync_type = N'automatic', @article = N'all', @update_mode = N'read only', @subscriber_type = 0
exec sp_addpushsubscription_agent @publication = N'test_3IQS007', @subscriber = N'JACKY-PC\SUDO', @subscriber_db = N'CEMS_3IQS007_P001', @job_login = N'cems_backup\myuser', @job_password = null, @subscriber_security_mode = 0, @subscriber_login = N'sa', @subscriber_password = null, @frequency_type = 64, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 20220628, @active_end_date = 99991231, @enabled_for_syncmgr = N'False', @dts_package_location = N'Distributor'
GO
-----------------結束: 在發行者 'CEMS_BACKUP\TESTMACHINE' 端執行的指令碼-----------------

