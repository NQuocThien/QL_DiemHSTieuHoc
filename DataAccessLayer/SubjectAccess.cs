using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class SubjectAccess:DatabaseAccess
    {
        public DataTable GetSubjectHaveNotScore(int report_id)
        {
            return GetSubjectHaveNotScoreDAO(report_id);
        }
        public DataTable GetAllSubject()
        {
            return GetAllSubjectDAO();
        }
        public string InsertSubject(string SubjectName)
        {
            return InsertSubjectDAO(SubjectName);
        }public string DeletetSubject(int SubjectId)
        {
            return DeleteSubjectDAO(SubjectId);
        }public string UpdateSubject(SubjectObject subject)
        {
            return UpdateSubjectDAO(subject);
        }
    }
}
