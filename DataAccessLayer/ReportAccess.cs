using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class ReportAccess:DatabaseAccess
    {
        public string CreateReportIfNotExist(int student_id)
        {
            return "";
        }
        public DataTable TestStusentExistReport(int student_id)
        {
            return TestStusentExistReportDAO(student_id);
        }
        public string CreateReport(int student_id,int class_id)
        {
            return CreateReportDAO( student_id,  class_id);
        }
        public string CreateReport(ReportObject re)
        {
            return CreateReportDAO(re);
        }
        public string DeleteReport(ReportObject re)
        {
            return DeleteReportDAO(re);
        }
        public string CreatePractice(int report_id)
        {
            return CreatePractiseDAO(report_id);
        }
        public DataTable GetReport()
        {
            return GetReportDAO();
        }
        public DataTable GetReportOfStudent(int student_id)
        {
            return GetReportOfStudentDAO(student_id);
        }
        public DataTable GetSubjectNotHaveImported(int report_id)
        {
            return GetSubjectNotHaveImportedDAO(report_id);
        }
        public DataTable GetSubjectImported(int report_id)
        {
            return GetSubjectImportedDAO(report_id);
        }  
        public string CheckOrCreateCapacityAndQuality(int report_id)
        {
            return CheckOrCreateCapacityAndQualityDAO(report_id);
        }
        public DataTable GetQuality(int report_id)
        {
            return GetQualityDAO(report_id);
        } public DataTable GetCapacity(int report_id)
        {
            return GetCapacityDAO(report_id);
        }
        public string SetCappacityAndQualityByReportID(CapacityObject cp, QualityObject ql, string cmt)
        {
            return SetCappacityAndQualityByReportIDDAO(cp, ql, cmt);
        }
        public DataTable GetReportByID(int id)
        {
            return GetReportByIDDAO(id);
        }
    }
}
