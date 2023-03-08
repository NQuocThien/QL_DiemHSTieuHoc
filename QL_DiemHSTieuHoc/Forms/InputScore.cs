using BusinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
using QL_DiemHSTieuHoc.Forms.SubInputScoreFoms;
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

namespace QL_DiemHSTieuHoc.Forms
{
    public partial class InputScore : Form
    {
        ReportBLL reportBLL = new ReportBLL();
        BlockBLL blockBll = new BlockBLL();
        StudentBLL stBll = new StudentBLL();
        StudentObject student = new StudentObject();
        UserBLL userBll = new UserBLL();
        UserAccount user = new UserAccount();
        string currentUser;
        int class_id;
        int student_id;
        public InputScore(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }
        private void Load_CurrentUser()
        {
            user = userBll.GetUser(currentUser);
            Law l = userBll.GetLaw(currentUser);
            if (l.law_name == "admin" || l.law_name == "manager")
            {
                // Load_ControlUnLock();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbClass.Checked)
            {
                class_id = int.Parse(cbClass.SelectedValue.ToString());
                Load_gvStudent(class_id);
            }
            else
            {
                Load_gvStudent(txtName.Text);
            }
        }

        private void InputScore_Load(object sender, EventArgs e)
        {
            Load_cbClass();
            this.cbClass.Enabled = false;
            this.txtName.Enabled = false;
        }
        private void Load_cbClass()
        {
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.DataSource = blockBll.GetClasscb();
            cbClass.DisplayMember = "nameClass";
            cbClass.ValueMember = "class_id";
            class_id = int.Parse(cbClass.SelectedValue.ToString());
            // Load_gvStudent(class_id);
        }

        // by Name
        private void Load_gvStudent(string name)
        {
            int n = gvStudent.Width / 5;

            DataTable dt = stBll.GetStudent1(name);
            if (dt == null)
                return;
            gvStudent.DataSource = dt;
            gvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvStudent.Columns[0].HeaderText = "Tên Học Sinh";
            gvStudent.Columns[0].Width = n;

            gvStudent.Columns[1].HeaderText = "SĐT";
            gvStudent.Columns[1].Width = n;

            gvStudent.Columns[2].HeaderText = "Ngày Sinh";
            gvStudent.Columns[2].Width = n;

            gvStudent.Columns[3].HeaderText = "Giới Tính";
            gvStudent.Columns[3].Width = n;

            gvStudent.Columns[4].HeaderText = "Địa Chỉ";
            gvStudent.Columns[4].Width = n;

            gvStudent.Columns[5].Visible = false;
            gvStudent.Columns[6].Visible = false;

        }
        // by class_id
        private void Load_gvStudent(int class_id)
        {
            int n = gvStudent.Width / 5;

            DataTable dt = stBll.GetStudent1(class_id);
            if (dt == null)
                return;
            gvStudent.DataSource = dt;
            gvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvStudent.Columns[0].HeaderText = "Tên Học Sinh";
            gvStudent.Columns[0].Width = n;

            gvStudent.Columns[1].HeaderText = "SĐT";
            gvStudent.Columns[1].Width = n;

            gvStudent.Columns[2].HeaderText = "Ngày Sinh";
            gvStudent.Columns[2].Width = n;

            gvStudent.Columns[3].HeaderText = "Giới Tính";
            gvStudent.Columns[3].Width = n;

            gvStudent.Columns[4].HeaderText = "Địa Chỉ";
            gvStudent.Columns[4].Width = n;

            gvStudent.Columns[5].Visible = false;
            gvStudent.Columns[6].Visible = false;


        }

        private void rdbName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbName.Checked == true)
            {
                this.cbClass.Enabled = false;
                this.txtName.Enabled = true;
            }
        }

        private void rdbClass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbClass.Checked == true)
            {

                this.cbClass.Enabled = true;
                this.txtName.Enabled = false;
            }
        }

        private void btn_importScore(object sender, EventArgs e)
        {
            DataGridViewRow re = gvStudent.SelectedRows[0];
            if (re == null)
            {
                return;
            }
            string namestudent = re.Cells[0].Value.ToString();
            //  new InputCoreReportForm(namestudent, blockBll.GetNameClass(class_id)).ShowDialog(); ;
        }
        private void Load_gvReport()
        {

            int n = gvReport.Width / 3;
            DataTable dt = reportBLL.GetReportOfStudent(student_id);
            if (dt == null)
                return;
            gvReport.DataSource = dt;
            gvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvReport.Columns[0].HeaderText = "Mã Phiếu";
            gvReport.Columns[0].Width = n;

            gvReport.Columns[1].Visible = false;
            gvReport.Columns[2].Visible = false;

            gvReport.Columns[3].HeaderText = "Học Kỳ";
            gvReport.Columns[3].Width = n;

            gvReport.Columns[4].HeaderText = "Năm Học";
            gvReport.Columns[4].Width = n;

            gvReport.Columns[5].Visible = false;
            gvReport.Columns[6].Visible = false;
            gvReport.Columns[7].Visible = false;
            
        }

        private void gvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void load_id()
        {
            try
            {
                DataGridViewRow re = gvStudent.SelectedRows[0];
                if (re == null) { return; }
                student_id = int.Parse(re.Cells[5].Value.ToString());
                class_id = int.Parse(re.Cells[6].Value.ToString());
                Load_gvReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            load_id();
            Load_gvReport();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            ReportObject report = new ReportObject();
            report.student_id = student_id;
            report.class_id = class_id;
            report.semester = cbSemester.Text;
            string mess = reportBLL.CreateReport(report);
            if (mess == "requeid_semester")
            {
                MessageBox.Show("Chọn học kỳ");
                return;
            }
            Load_gvReport();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            ReportObject report = new ReportObject();
            DataGridViewRow re = gvReport.SelectedRows[0];
            if (re == null) { return; }
            report.report_id = int.Parse(re.Cells[0].Value.ToString());


            if (MessageBox.Show("Xóa Phiếu Đánh Giá ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string mess = reportBLL.DeleteReport(report);
                MessageBox.Show(mess);
                Load_gvReport();
            }
        }

        private void btnImportReportSubject_Click(object sender, EventArgs e)
        {
            DataGridViewRow reSt = gvStudent.SelectedRows[0];
            DataGridViewRow reRp = gvReport.SelectedRows[0];
            StudentObject st = new StudentObject();
            ReportObject rp = new ReportObject();
            Class cl = new Class();

            cl.class_id = int.Parse(reSt.Cells["class_id"].Value.ToString());
            cl.nameClass = blockBll.GetClassNameByStudentID(student_id);

            st.student_id = int.Parse(reSt.Cells["student_id"].Value.ToString());
            st.studentName = reSt.Cells[0].Value.ToString();

            rp.report_id = int.Parse(reRp.Cells["report_id"].Value.ToString());


            new InputCoreReportForm(st, cl, rp).ShowDialog();
        }
    }
}
