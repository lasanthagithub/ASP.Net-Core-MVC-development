--To gel list of data bases

SELECT name FROM master.dbo.sysdatabases
--or
EXEC sp_databases

--Use the database
use "aspnet-MS4App-2FC4767B-C2EE-4F06-968C-C7B2D552ADE5"

--View tables
sp_tables

SELECT * FROM CnItems;