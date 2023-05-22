using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DatabaseBLL
    {
        BackupRestoreDatabase database = new BackupRestoreDatabase();
        public  string Backup(string DuongDan)
        {
            return database.Backup(DuongDan);
        }
        public  string Retore(string DuongDan)
        {
            return database.Restore(DuongDan);
        }
    }
}
