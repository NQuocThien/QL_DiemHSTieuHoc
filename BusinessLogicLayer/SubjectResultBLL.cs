using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ValueObject;

namespace BusinessLogicLayer
{
    
    public class  SubjectResultBLL
    {
        SubjectResultAccess sra = new SubjectResultAccess();

        public string InsertSubjectResult(SubjectResultObject sr)
        {
            if(sr.report_id == 0)
            {
                return "require_report";
            }    
            if(sr.subject_id == 0)
            {
                return "require_subject";
            }    
            if(sr.lever == "")
            {
                return "require_lever";
            }  
            if(sr.scores > 10 || sr.scores < 0)
            {
                return "require_scores";
            }

            return sra.InsertSubjectResult(sr);
        }
        public string UpdateSubjectResult(SubjectResultObject sr)
        {
            if(sr.lever == "")
            {
                return "require_lever";
            }  
            if(sr.scores > 10 || sr.scores < 0)
            {
                return "Điểm nhỏ hơn hoặc bằng 10 và lớn hơn hoặc bằng 0";
            }

            return sra.UpdateSubjectResult(sr);
        }

        public string DeleteSubjectResult(SubjectResultObject sr)
        {
            return sra.DeleteSubjectResult(sr);
        }

    }
}
