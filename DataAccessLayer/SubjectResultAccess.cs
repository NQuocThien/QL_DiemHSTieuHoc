using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class SubjectResultAccess:DatabaseAccess
    {
        public string InsertSubjectResult(SubjectResultObject sr)
        {
            return InsertSubjectResultDAO(sr);
        } 
        public string UpdateSubjectResult(SubjectResultObject sr)
        {
            return UpdateSubjectResultDAO(sr);
        }  
        public string DeleteSubjectResult(SubjectResultObject sr)
        {
            return DeleteSubjectResultDAO(sr);
        }
    }
}
