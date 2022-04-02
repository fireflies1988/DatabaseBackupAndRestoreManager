using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupManager
{
    class QueryString
    {   
        public const string TEMP_BACKUP_LOG = @"D:\TempBackupLog.bak";
        
        public const string DEFAULT_BACKUP_LOCATION = @"DECLARE @BackupDirectory nvarchar(100) 
            EXEC master.dbo.xp_instance_regread @rootkey = 'HKEY_LOCAL_MACHINE', @key = 'Software\Microsoft\MSSQLServer\MSSQLServer', @value_name = 'BackupDirectory', @BackupDirectory = @BackupDirectory OUTPUT
            SELECT @BackupDirectory";
        public const string NEW_BACKUP_DEVICE =
            "EXEC sp_addumpdevice @devtype = 'disk', @logicalname = N'{0}', @physicalname = N'{1}'";
        /// <summary>
        /// {0} - Database name
        /// {1} - Backup device
        /// </summary>
        public const string BACKUP = 
            "BACKUP DATABASE [{0}] TO [{1}] WITH NAME = N'{2}', DESCRIPTION = N'{3}', STATS = 1";
        /// <summary>
        /// {0} - Database name
        /// {1} - Backup device
        /// </summary>
        public const string BACKUP_WITH_INIT = 
            "BACKUP DATABASE [{0}] TO [{1}] WITH NAME = N'{2}', DESCRIPTION = N'{3}', INIT, STATS = 1";
        /// <summary>
        /// {0} Database name
        /// {1} Backup device
        /// {2} Position
        /// </summary>
        public const string RESTORE = @"USE [master]
            ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
            RESTORE DATABASE [{0}] FROM [{1}] WITH FILE = {2}, REPLACE, STATS = 1
            ALTER DATABASE [{0}] SET MULTI_USER";
        /// <summary>
        /// {0} Database name
        /// {1} Backup device
        /// {2} Last position
        /// {3} Date and time
        /// </summary>
        public const string RESTORE_TO_SPECIFIC_TIME = @"USE [master]
            ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
            BACKUP LOG [{0}] TO DISK = '" + TEMP_BACKUP_LOG + @"' WITH INIT, NORECOVERY, STATS = 1
            RESTORE DATABASE [{0}] FROM [{1}] WITH FILE = {2}, NORECOVERY, STATS = 1
            RESTORE LOG [{0}] FROM DISK = '" + TEMP_BACKUP_LOG + @"' WITH STOPAT = '{3}', NORECOVERY, STATS = 1
            RESTORE DATABASE [{0}] WITH RECOVERY
            ALTER DATABASE [{0}] SET MULTI_USER";
    }
}
