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
        bool buttonType = true;
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
            DataTable dt = SubjectBLL.GetAllSubject();
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
            gvScoreImported.DataSource = dt;
            gvScoreImported.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(buttonType)
            {
                // Nhập
                SubjectObject subject = new SubjectObject();
                SubjectResultObject result = new SubjectResultObject();
                subject.subject_id = int.Parse(gvSuject.SelectedRows[0].Cells[0].Value.ToString());
                btnImport.Text = "Nhập";
                result.lever = cbScore.Text;
                result.scores = int.Parse(txtScore.Text);
                result.report_id = rp.report_id;
                MessageBox.Show("report: " + result.report_id + ", lever: " + result.lever + ",scores: " + result.scores + ", subject: " + result.subject_id);


            }
            else
            {
                // Sửa
                btnImport.Text = "Sửa";
                MessageBox.Show("asdasd");

            }
        }
    }
}
