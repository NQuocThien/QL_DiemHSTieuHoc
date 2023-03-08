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
    public class ReportBLL
    {
        ReportAccess reportAs = new ReportAccess();
        
        public DataTable TestStusentExistReport(int student_id)
        {
            return reportAs.TestStusentExistReport(student_id);
        }
        public DataTable GetReport ()
        {
            return reportAs.GetReport();
        }
        public DataTable GetReportOfStudent(int student_id)
        {
            return reportAs.GetReportOfStudent(student_id);
        }
        public string CreateReport(int class_id, int sudent_id)
        {
            return reportAs.CreateReport(class_id, sudent_id);  
        }
        public string CreateReport(ReportObject re)
        {
            if (re.semester == "")
                return "requeid_semester";
            return reportAs.CreateReport(re);
        }
        public string DeleteReport(ReportObject re)
        {
            return reportAs.DeleteReport(re);
        }
        public string CreateReportIfNotExist(int student_id, int class_id)
        {
            // kiểm tra report
            bool isExist = false;
            
            DataTableReader re = TestStusentExistReport(student_id).CreateDataReader();
            if(! re.HasRows)
            { // không có thì tạo 
                int report_id = -1 ;
                reportAs.CreateReport(student_id,class_id);
                DataTableReader dtr = GetReport().CreateDataReader();
                if(dtr.HasRows) {
                    while(dtr.Read())
                    {
                        report_id = dtr.GetInt32(0);
                    }
                    reportAs.CreatePractice(report_id);
                }
                else
                {
                    return "cannotgetreport";
                }
            }else
            {
                return "existreport";
            }

            return "success";
        }

        public DataTable GetSubjectNotHaveImported(int report_id)
        {
            return reportAs.GetSubjectNotHaveImported(report_id);
        }
        public DataTable GetSubjectImported(int report_id)
        {
            return reportAs.GetSubjectImported(report_id);
        }
    }
}
