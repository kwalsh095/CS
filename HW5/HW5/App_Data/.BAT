@ECHO off
SET DBFILENAME=HW5.mdf
SET DBLOGFILENAME=HW5_log.ldf
SET INITSCRIPT=initDB.sql

sqlcmd -S "(localdb)\MSSQLLocalDB" -v dbdir="%CD%" -i %INITSCRIPT% -b
pause