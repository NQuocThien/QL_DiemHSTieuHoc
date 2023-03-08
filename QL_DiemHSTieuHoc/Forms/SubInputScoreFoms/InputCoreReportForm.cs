using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ValueObject;

namespace QL_DiemHSTieuHoc.Forms.SubInputScoreFoms
{
    public partial class InputCoreReportForm : Form
    {
        SubjectBLL SubjectBLL = new SubjectBLL();
        ReportBLL reportBLL = new ReportBLL();

        StudentObject st = new StudentObject();
        ReportObject rp = new ReportObject();
        Class cl = new Class();
        public InputCoreReportForm(StudentObject st, Class cl, ReportObject rp)
        {
            InitializeComponent();
            this.st = st;
            this.rp = rp;
            this.cl = cl;
        }

        private void InputCoreReportForm_Load(object sender, EventArgs e)
        {
            lblNamSudent.Text += st.studentName;
            lblClass.Text += cl.nameClass;
            Load_gvSubject();
            Load_gvScoreImported();
        }
        private void Load_gvSubject()
        {

            int n = gvSuject.Width / 2;
            DataTable dt = reportBLL.GetSubjectNotHaveImported(rp.report_id);
            if (dt == null)
                return;
            gvSuject.DataSource = dt;
            gvSuject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvSuject.Columns[0].HeaderText = "Mã Môn";
            gvSuject.Columns[0].Width = n;
            gvSuject.Columns[1].HeaderText = "Tên Môn";
            gvSuject.Columns[1].Width = n;
        }
        private void Load_gvScoreImported()
        { 
            int n = gvScoreImported.Width / 3;
            DataTable dt = reportBLL.GetSubjectImported(rp.report_id);
            if (dt == null)
                return;
            gvSuject.DataSource = dt;
            gvSuject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvScoreImported.Columns[0].Visible = false;
            gvScoreImported.Columns[1].Visible = false;
            gvScoreImported.Columns[2].Visible = false;

            gvScoreImported.Columns[3].HeaderText = "Tên Môn";
            gvScoreImported.Columns[3].Width = n;
            gvScoreImported.Columns[4].HeaderText = "Đánh Giá";
            gvScoreImported.Columns[4].Width = n;
            gvScoreImported.Columns[5].HeaderText = "Điểm";
            gvScoreImported.Columns[5].Width = n;
        }

    }
}
