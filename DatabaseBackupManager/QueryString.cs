﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupManager
{
    class QueryString
    {
        public const string DEFAULT_BACKUP_LOCATION =
            "DECLARE @BackupDirectory nvarchar(100) " +
            @"EXEC master.dbo.xp_instance_regread @rootkey = 'HKEY_LOCAL_MACHINE', @key = 'Software\Microsoft\MSSQLServer\MSSQLServer', @value_name = 'BackupDirectory', @BackupDirectory = @BackupDirectory OUTPUT " +
            "SELECT @BackupDirectory";
        public const string NEW_BACKUP_DEVICE =
                "EXEC sp_addumpdevice @devtype = 'disk', @logicalname = '{0}', @physicalname = '{1}'";
    }
}
