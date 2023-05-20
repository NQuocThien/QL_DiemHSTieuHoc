using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
        public string CheckOrCreateCapacityAndQuality(int report_id)
        {
            return  reportAs.CheckOrCreateCapacityAndQuality(report_id);
            
        }
        public CapacityObject GetCapacityObject (int report_id)
        {
            CapacityObject cp = new CapacityObject();
            DataTableReader dt = reportAs.GetCapacity(report_id).CreateDataReader();
            if(dt.HasRows)
            {
                while (dt.Read())
                {
                    cp.selftSeviceAndManage = dt.GetString(1);
                    cp.cooperate = dt.GetString(2);
                    cp.selfStudyAndreslove = dt.GetString(3);
                }
                return cp;
            }
            return null;
        }  
        public QualityObject GetQualityObject (int report_id)
        {
            QualityObject qo = new QualityObject();
            DataTableReader dt = reportAs.GetQuality(report_id).CreateDataReader();
            if(dt.HasRows)
            {
                while (dt.Read())
                {
                    qo.hardWorking = dt.GetString(1);
                    qo.confidenceAndResponsibility = dt.GetString(2);
                    qo.honestAndDiscipline = dt.GetString(3);
                    qo.unite = dt.GetString(4);
                }
                return qo;
            }
            return null;
        }
        public string SetCappacityAndQualityByReportID(CapacityObject cp, QualityObject ql,string comment)
        {
            if (cp.cooperate == null)
                return "Chưa Đánh Giá khản năng hợp tác";
            if (cp.selftSeviceAndManage == null)
                return "Chưa Đánh Giá khản năng Tự Phục Vụ Quản Lý";
            if (cp.selfStudyAndreslove == null)
                return "Chưa Đánh Giá khản năng Tự Học Tự Giải Quyết";
            if  (ql.confidenceAndResponsibility == null)
                return "Chưa Đánh Giá khản năng Tự Tin Trách Nhiệm";
            if (ql.hardWorking == null)
                return "Chưa Đánh Giá khản năng siêng năng";
            if (ql.honestAndDiscipline == null)
                return "Chưa Đánh Giá khản năng Trung Thực Kỹ Luật";
            if (ql.unite == null)
                return "Chưa Đánh Giá khản năng Đoàn Kết Yêu Thương";
            return reportAs.SetCappacityAndQualityByReportID(cp, ql,comment);
        }
        public ReportObject GetReportCommentByID(int id)
        {
            DataTableReader dt = reportAs.GetReportByID(id).CreateDataReader();
            ReportObject r = new ReportObject();
            string cmt = "";
            if(dt.HasRows)
            {
                while(dt.Read())
                {
                    r.comment = dt.GetString("comment");
                }
                return r;
            }
            return null;
        }
    }
}
