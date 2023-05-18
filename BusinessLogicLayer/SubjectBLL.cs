using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    
    public class SubjectBLL
    {
         SubjectAccess subjectAccess = new SubjectAccess();
        public DataTable GetSubjectHaveNotScore(int report_id)
        {
            return subjectAccess.GetSubjectHaveNotScore(report_id);
        }
        public DataTable GetAllSubject()
        {
            return subjectAccess.GetAllSubject();
        }
        public string InsertSubject(SubjectObject subject)
        {
            if (subject.subject_name == "")
                return "require_name";
            return subjectAccess.InsertSubject(subject.subject_name);
        }  
        public string DeleteSubject(SubjectObject subject)
        {
            return subjectAccess.DeletetSubject(subject.subject_id);
        }    
        public string UpdateSubject(SubjectObject subject)
        {
            if (subject.subject_name == "")
                return "requie_name";
            return subjectAccess.UpdateSubject(subject);
        }
    }
}
