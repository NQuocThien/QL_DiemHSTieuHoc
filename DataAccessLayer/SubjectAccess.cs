using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SubjectAccess:DatabaseAccess
    {
        public DataTable GetSubjectHaveNotScore(int report_id)
        {
            return GetSubjectHaveNotScoreDAO(report_id);
        }
    }
}
