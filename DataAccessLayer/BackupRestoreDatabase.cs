using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BackupRestoreDatabase:DatabaseAccess
    {
        public string Backup(string patch)
        {
            return BackupDAO(patch);
        } 
        public string Restore(string patch)
        {
            return BackupDAO(patch);
        }
    }
}
