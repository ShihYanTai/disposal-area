---- 新增索引 ----

USE [CEMS_1IQS001]
GO

SET ANSI_PADDING ON
GO

CREATE NONCLUSTERED INDEX [NonClusteredIndex-20220706-153451] ON [dbo].[dataRawOP]
([Id] ASC, [CreateDate] ASC, [EPAcode] ASC, [UpdateDate] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)

GO


----- T-SQL 新增排程 -----

USE [CEMS_1IQS001]
GO
ALTER INDEX [NonClusteredIndex-20220706-153415] ON [dbo].[dataRawOP] REBUILD PARTITION = ALL WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
GO
USE [CEMS_1IQS001]
GO
ALTER INDEX [PK__dataRawO__3214EC0724EC521E] ON [dbo].[dataRawOP] REBUILD PARTITION = ALL WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
GO