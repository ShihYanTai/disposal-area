-- DB 查詢
select * from sysdatabases;

-----------------------------------------------------------
-- DB table name
select * from sysobjects where xtype='U';
-- xtype='U':表示所有使用者表，xtype='S':表示所有系統表。
