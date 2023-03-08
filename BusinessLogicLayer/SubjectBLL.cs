using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    
    public class SubjectBLL
    {
         SubjectAccess subjectAccess = new SubjectAccess();
        public DataTable GetSubjectHaveNotScore(int report_id)
        {
            return subjectAccess.GetSubjectHaveNotScore(report_id);
        }
    }
}
