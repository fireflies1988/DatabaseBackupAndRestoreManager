SELECT * FROM msdb.dbo.backupset
SELECT * FROM msdb.dbo.backupmediafamily
SELECT * FROM sys.backup_devices
SELECT * FROM msdb.dbo.restorehistory
SELECT * FROM msdb.dbo.backupfile
SELECT * FROM msdb.dbo.backupfilegroup
SELECT * FROM msdb.dbo.backupmediaset
SELECT * FROM master.dbo.sysdevices

-- Backup sets of a backup device
SELECT bs.database_name, logical_device_name, backup_set_id, bs.media_set_id, position, backup_start_date, backup_finish_date, user_name, description
FROM msdb.dbo.backupset bs JOIN msdb.dbo.backupmediafamily bmf 
	ON bs.media_set_id = bmf.media_set_id
WHERE logical_device_name = 'bd_VPP' AND database_name = 'VPP'
	AND backup_set_id >= (SELECT MAX(backup_set_id) FROM msdb.dbo.backupset WHERE position = 1 AND media_set_id = bs.media_set_id)

SELECT     position, name, backup_start_date , user_name FROM  msdb.dbo.backupset 
   WHERE     database_name = 'VPP' AND type='D' AND 
     backup_set_id >= 
        (  SELECT  MAX(backup_set_id) 
        FROM msdb.dbo.backupset  
         WHERE database_name = 'VPP' AND type='D'
                  AND position=1  
        )

SELECT position, backup_set_id, media_set_id, backup_start_date, backup_finish_date, database_name
FROM msdb.dbo.backupset WHERE database_name = 'VPP'

--Find the backup device name which a backup belongs to
SELECT backup_set_id, bs.media_set_id, logical_device_name, position
FROM msdb.dbo.backupset bs JOIN msdb.dbo.backupmediafamily bmf 
	ON bs.media_set_id = bmf.media_set_id
WHERE database_name = 'VPP'

SELECT MAX(backup_set_id) FROM msdb.dbo.backupset

/***	read the current SQL Server default backup location	***/  
DECLARE @BackupDirectory NVARCHAR(100)   
EXEC master..xp_instance_regread @rootkey = 'HKEY_LOCAL_MACHINE',  
    @key = 'Software\Microsoft\MSSQLServer\MSSQLServer',  
    @value_name = 'BackupDirectory', @BackupDirectory = @BackupDirectory OUTPUT ;  
SELECT @BackupDirectory AS [SQL Server default backup Value]

-- Backup
BACKUP DATABASE VPP TO bd_VPP WITH NAME = 'test', DESCRIPTION = 'hello', INIT, STATS = 1

--Restore
USE [master]
ALTER DATABASE [VPP] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
RESTORE DATABASE [VPP] FROM  [bd_VPP] WITH  FILE = 3,  REPLACE,  STATS = 1
ALTER DATABASE [VPP] SET MULTI_USER

--Restore to specific time
USE [master]
ALTER DATABASE [VPP] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
BACKUP LOG [VPP] TO DISK = 'D:\TempBackupLog.bak' WITH INIT, NORECOVERY, STATS = 1
RESTORE DATABASE [VPP] FROM [bd_VPP] WITH FILE = 3, NORECOVERY, STATS = 1
RESTORE LOG [VPP] FROM DISK = 'D:\TempBackupLog.bak' WITH STOPAT = '4/3/2022 1:09 AM', NORECOVERY, STATS = 1
RESTORE DATABASE [VPP] WITH RECOVERY
ALTER DATABASE [VPP] SET MULTI_USER

RESTORE LOG [VPP] FROM DISK = 'D:\TempBackupLog.bak' WITH RECOVERY

--Delete a backup device
EXEC sp_dropdevice 'bd_SaleDb', 'delfile'
--Clean up resources
EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'SaleDb'

--Backup device location
SELECT physical_name FROM sys.backup_devices WHERE name = 'bd_VPP'