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
        SubjectResultBLL srll = new SubjectResultBLL();
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
            btnImport.Enabled = false;
            lblNamSudent.Text += st.studentName;
            lblClass.Text += cl.nameClass;
            lblSemester.Text += cl.semerter;
            btnDeleteResult.Enabled = false;
            txtScore.Text = "";
            Load_gvSubject();
            Load_gvScoreImported();
            Load_CapacityAndQuality();
        }

        private void Load_CapacityAndQuality()
        {
            // kiểm tra xem có report đã có tồn tại hai bản con chưa
            string mess = reportBLL.CheckOrCreateCapacityAndQuality(rp.report_id);
            if (mess == "success")
            {
                CapacityObject cp = reportBLL.GetCapacityObject(rp.report_id);
                QualityObject ql = reportBLL.GetQualityObject(rp.report_id);
                //MessageBox.Show(cp.selftSeviceAndManage+ " " +cp.cooperate + cp.selfStudyAndreslove);
                //MessageBox.Show(ql.hardWorking+ " " +ql.confidenceAndResponsibility + ql.honestAndDiscipline + ql.unite);
                load_capcity(cp);
                load_quality(ql);
                Load_cmt();
            }
            else
            {
                MessageBox.Show("Lỗi Kiểm Tra " + mess);
            }
        }
        private void Load_cmt()
        {
            txtComment.Text = reportBLL.GetReportCommentByID(rp.report_id).comment;
        }
        private void load_quality(QualityObject ql)
        {
            if (ql.hardWorking == "Tốt")
                rdbHardWork1.Checked = true;
            else
                    if (ql.hardWorking == "Đạt")
                rdbHardWork2.Checked = true;
            else
                         if (ql.hardWorking == "CCG")
                rdbHardWork3.Checked = true;
            //---------------------------------------------
            if (ql.confidenceAndResponsibility == "Tốt")
                rdbReponsibilty1.Checked = true;
            else
                if (ql.confidenceAndResponsibility == "Đạt")
                rdbReponsibilty2.Checked = true;
            else
                    if (ql.confidenceAndResponsibility == "CCG")
                rdbReponsibilty3.Checked = true;
            //------------------------------------
            if (ql.honestAndDiscipline == "Tốt")
                rdbHonest1.Checked = true;
            else
                    if (ql.honestAndDiscipline == "Đạt")
                rdbHonest2.Checked = true;
            else
                        if (ql.honestAndDiscipline == "CCG")
                rdbHonest3.Checked = true;
            //------------------------------------

            if (ql.unite == "Tốt")
                rdbUnite1.Checked = true;
            else
                    if (ql.unite == "Đạt")
                rdbUnite2.Checked = true;
            else
                        if (ql.unite == "CCG")
                rdbUnite3.Checked = true;
            //------------------------------------

        }
        private void load_capcity(CapacityObject cp)
        {
            if (cp.selfStudyAndreslove == "Tốt")
                rdbSelfStudy1.Checked = true;
            else
                if (cp.selfStudyAndreslove == "Đạt")
            {
                rdbSelfStudy2.Checked = true;
            }
            else
                    if (cp.selfStudyAndreslove == "CCG")
                rdbSelfStudy3.Checked = true;
            //------------------------------------
            if (cp.cooperate == "Tốt")
                rdbContact1.Checked = true;
            else
                    if (cp.cooperate == "Đạt")
                rdbContact2.Checked = true;
            else
                        if (cp.cooperate == "CCG")
                rdbContact3.Checked = true;
            //--------------------------------------------
            if (cp.selftSeviceAndManage == "Tốt")
                rdbSelfManager1.Checked = true;
            else
                    if (cp.selftSeviceAndManage == "Đạt")
                rdbSelfManager2.Checked = true;
            else
                        if (cp.selftSeviceAndManage == "CCG")
                rdbSelfManager3.Checked = true;
        }
        private QualityObject read_quality()
        {
            QualityObject ql = new QualityObject();

            if (rdbHardWork1.Checked == true)
                ql.hardWorking = "Tốt";
            else
                    if (rdbHardWork2.Checked == true)
                ql.hardWorking = "Đạt";
            else
                         if (rdbHardWork3.Checked == true)
                ql.hardWorking = "CCG";

            //---------------------------------------------
            if (rdbReponsibilty1.Checked == true)
                ql.confidenceAndResponsibility = "Tốt";
            else
                if (rdbReponsibilty2.Checked == true)
                ql.confidenceAndResponsibility = "Đạt";
            else
                    if (rdbReponsibilty3.Checked == true)
                ql.confidenceAndResponsibility = "CCG";
            //------------------------------------
            if (rdbHonest1.Checked == true)
                ql.honestAndDiscipline = "Tốt";
            else
                    if (rdbHonest2.Checked == true)
                ql.honestAndDiscipline = "Đạt";
            else
                        if (rdbHonest3.Checked == true)
                ql.honestAndDiscipline = "CCG";
            //------------------------------------

            if (rdbUnite1.Checked == true)
                ql.unite = "Tốt";
            else
                    if (rdbUnite2.Checked == true)
                ql.unite = "Đạt";
            else
                        if (rdbUnite3.Checked == true)
                ql.unite = "CCG";
            return ql;
        }

        private CapacityObject read_capacity()
        {
            CapacityObject ql = new CapacityObject();

            if (rdbSelfStudy1.Checked == true)
                ql.selfStudyAndreslove = "Tốt";
            else
                    if (rdbSelfStudy2.Checked == true)
                ql.selfStudyAndreslove = "Đạt";
            else
                         if (rdbSelfStudy3.Checked == true)
                ql.selfStudyAndreslove = "CCG";

            //---------------------------------------------
            if (rdbContact1.Checked == true)
                ql.cooperate = "Tốt";
            else
                if (rdbContact2.Checked == true)
                ql.cooperate = "Đạt";
            else
                    if (rdbContact3.Checked == true)
                ql.cooperate = "CCG";
            //-------------------------------
            if (rdbSelfManager1.Checked == true)

                ql.selftSeviceAndManage = "Tốt";
            else
                    if (rdbSelfManager2.Checked == true)
                ql.selftSeviceAndManage = "Đạt";
            else
                        if (rdbSelfManager3.Checked == true)
                ql.selftSeviceAndManage = "CCG";
            //------------------------------------
            return ql;

        }
        private void Load_gvSubject()
        {

            int n = gvSuject.Width;
            DataTable dt = SubjectBLL.GetAllSubject();
            if (dt == null)
                return;
            gvSuject.DataSource = dt;
            gvSuject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvSuject.ReadOnly = true;
            gvSuject.Columns[0].Visible = false;
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
            gvScoreImported.ReadOnly = true;
            gvScoreImported.Columns[0].Visible = false;
            gvScoreImported.Columns[1].Visible = false;
            gvScoreImported.Columns[2].Visible = false;

            gvScoreImported.Columns[3].HeaderText = "Môn Học";
            gvScoreImported.Columns[3].Width = n;

            gvScoreImported.Columns[4].HeaderText = "Điểm";
            gvScoreImported.Columns[4].Width = n;

            gvScoreImported.Columns[5].HeaderText = "Đánh Giá";
            gvScoreImported.Columns[5].Width = n;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (buttonType)
            {
                // Nhập
                SubjectObject subject = new SubjectObject();
                SubjectResultObject result = new SubjectResultObject();
                result.subject_id = int.Parse(gvSuject.SelectedRows[0].Cells[0].Value.ToString());
                result.lever = cbScore.Text;
                result.report_id = rp.report_id;
                
                result.scores = txtScore.Text!= ""?(float)Math.Round(float.Parse(txtScore.Text), 2) : float.NaN;
                //MessageBox.Show("" + result.scores);
                string mess = srll.InsertSubjectResult(result);
                MessageBox.Show("" + mess, "Thông Báo!!!");
                Load_gvScoreImported();
            }
            else
            {
                // Sửa
                SubjectResultObject result = new SubjectResultObject();
                result.subjectresult_id = int.Parse(gvScoreImported.SelectedRows[0].Cells[0].Value.ToString());
                result.lever = cbScore.Text;
                result.scores = (float)Math.Round(float.Parse(txtScore.Text), 2);
                string mess = srll.UpdateSubjectResult(result);
                MessageBox.Show("" + mess, "Thông Báo!!!");
                Load_gvScoreImported();
            }
        }
        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím được nhấn có phải là số thực hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Kiểm tra xem phím "." đã được sử dụng chưa
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void gvSuject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnImport.Enabled = true;
            buttonType = true;
            btnDeleteResult.Enabled = false;
            btnImport.Text = "Nhập Điểm";
        }
        private void gvScoreImported_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonType = false;
            btnDeleteResult.Enabled = true;
            btnImport.Text = "Sửa điểm";
            cbScore.Text = gvScoreImported.SelectedRows[0].Cells[5].Value.ToString();
            txtScore.Text = gvScoreImported.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void btnDeleteResult_Click(object sender, EventArgs e)
        {
            SubjectResultObject result = new SubjectResultObject();
            result.subjectresult_id = int.Parse(gvScoreImported.SelectedRows[0].Cells[0].Value.ToString());
            string mess = srll.DeleteSubjectResult(result);
            MessageBox.Show("" + mess, "Thông Báo!!!");
            Load_gvScoreImported();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            CapacityObject cp = read_capacity();
            QualityObject ql = read_quality();
            string comment = txtComment.Text;
            ql.report_id = rp.report_id;
            cp.report_id = rp.report_id;
            string mess = reportBLL.SetCappacityAndQualityByReportID(cp, ql, comment);
            MessageBox.Show(mess);
        }
    }
}
