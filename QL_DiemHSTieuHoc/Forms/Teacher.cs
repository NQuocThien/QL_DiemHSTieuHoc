using BusinessLogicLayer;
using QL_DiemHSTieuHoc.Forms.SubTeacherForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;

namespace QL_DiemHSTieuHoc.Forms
{
    public partial class Teacher : Form
    {
        TeacherBLL teacherBLL = new TeacherBLL();
        TeacherObject currentTeacher = new TeacherObject();
        UserAccount currentUser = new UserAccount();
        UserBLL userBll = new UserBLL();
        SubjectBLL subjectBLL = new SubjectBLL();
        string currentUserName;
        public Teacher(string currentUserName)
        {
            InitializeComponent();
            this.currentUserName = currentUserName;
        }
        private void Load_CurrentUser()
        {
            currentUser = userBll.GetUser(currentUserName);
            Law l = userBll.GetLaw(currentUserName);
            if (l.law_name == "admin" || l.law_name == "manager")
            {
                Load_ControlUnLock();
            }


        }

        private void Load_ControlUnLock()
        {
            this.btnSearch.Enabled = true;
            this.btnTakeSubject.Enabled = true;
            this.bttnTakeClass.Enabled = true;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            Load_lockControl();
            Load_CurrentUser();
            Load_gvTeacher();
            Load_gvListSubject();
        }

        private void Load_gvListSubject()
        {
            int n = gv_ListSubject.Width / 2;
            gv_ListSubject.DataSource = subjectBLL.GetAllSubject();
            gv_ListSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv_ListSubject.ReadOnly = true;

            gvTeacher.Columns[0].HeaderText = "Mã Môn";
            gvTeacher.Columns[0].Width = n;

            gvTeacher.Columns[1].HeaderText = "Tên Môn";
            gvTeacher.Columns[1].Width = n;
        }

        private void Load_gvTeacher()
        {
            if (teacherBLL.GetTeacher() != null)
            {
                int n = gvTeacher.Width / 5;
                gvTeacher.DataSource = teacherBLL.GetTeacher();
                gvTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                gvTeacher.Columns[0].Visible = false;

                gvTeacher.Columns[1].HeaderText = "Tên GV";
                gvTeacher.Columns[1].Width = n;

                gvTeacher.Columns[2].HeaderText = "SDT";
                gvTeacher.Columns[2].Width = n;

                gvTeacher.Columns[3].HeaderText = "Ngày Sinh";
                gvTeacher.Columns[3].Width = n;

                gvTeacher.Columns[4].HeaderText = "Giới Tính";
                gvTeacher.Columns[4].Width = n;

                gvTeacher.Columns[5].HeaderText = "Địa Chỉ";
                gvTeacher.Columns[5].Width = n;

            }
        }
        private void Load_lockControl()
        {
            this.btnSearch.Enabled = false;
            this.btnTakeSubject.Enabled = false;
            this.bttnTakeClass.Enabled = false;
        }

        private void gvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = gvTeacher.SelectedRows[0];
            currentTeacher.teacher_id = int.Parse(dr.Cells[0].Value.ToString());
            currentTeacher.name_teacher = dr.Cells[1].Value.ToString();
            currentTeacher.numberPhone = dr.Cells[2].Value.ToString();
            currentTeacher.sex = dr.Cells[4].Value.ToString();
            currentTeacher.adress = dr.Cells[5].Value.ToString();
            currentTeacher.dateOfBirth = dr.Cells[3].Value.ToString();
            Load_gvSubject();
            Load_gvClass();

        }

        private void Load_gvClass()
        {
            int n = gvClass.Width / 2;
            gvClass.DataSource = teacherBLL.GetClassOfTeacher(currentTeacher.teacher_id);
            gvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            gvClass.Columns[0].Visible = false;
            gvClass.Columns[1].Visible = false;

            gvClass.Columns[2].HeaderText = "Tên Lớp";
            gvClass.Columns[2].Width = n;

            gvClass.Columns[3].HeaderText = "Niên Khóa";
            gvClass.Columns[3].Width = n;
        }
        private void Load_gvSubject()
        {
            int n = gvSubject.Width / 1;
            gvSubject.DataSource = teacherBLL.GetSubjectOfTeacher(currentTeacher.teacher_id);
            gvSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvSubject.Columns[0].Visible = false;
            gvSubject.Columns[1].HeaderText = "Tên Môn";
            gvSubject.Columns[1].Width = n;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
        private TeacherObject GetTeacherClicked()
        {
            TeacherObject teacher = new TeacherObject();
            DataGridViewRow re = gvTeacher.SelectedRows[0];
            teacher.teacher_id = int.Parse(re.Cells[0].Value.ToString());
            teacher.name_teacher = re.Cells[1].Value.ToString();
            teacher.numberPhone = re.Cells[2].Value.ToString();
            teacher.dateOfBirth = re.Cells[3].Value.ToString();
            teacher.sex = re.Cells[4].Value.ToString();
            teacher.adress = re.Cells[5].Value.ToString();
            return teacher;
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {

            new TeacherAboutForm(GetTeacherClicked()).ShowDialog();
            Load_gvTeacher();
        }

        private void bttnTakeSubject_Click(object sender, EventArgs e)
        {
            new TeacherTackeClass(GetTeacherClicked()).ShowDialog();
            Load_gvClass();
        }

        private void btnTakeSubject_Click(object sender, EventArgs e)
        {
            new TeacherTakeSubject(GetTeacherClicked()).ShowDialog();
            Load_gvSubject();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            SubjectObject subject = new SubjectObject();
            subject.subject_name = txtSubjectName.Text;
            string insert = subjectBLL.InsertSubject(subject);
            if (insert == "require_name")
            {
                MessageBox.Show("Chưa Nhập Tên", "Lỗi");
                txtSubjectName.Focus();
            }
            else
            {
                MessageBox.Show(" " + insert, "Thông báo!!!");
            }
            Load_gvListSubject();
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            SubjectObject subject = new SubjectObject();

            subject.subject_id = int.Parse(gv_ListSubject.SelectedRows[0].Cells[0].Value.ToString());
            string delete = subjectBLL.DeleteSubject(subject);
            MessageBox.Show("" + delete, "Thông Báo!!");
            Load_gvListSubject();
        }

        private void gv_ListSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSubjectName.Text = gv_ListSubject.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SubjectObject subject = new SubjectObject();
            subject.subject_id = int.Parse(gv_ListSubject.SelectedRows[0].Cells[0].Value.ToString());
            subject.subject_name = txtSubjectName.Text;
            string delete = subjectBLL.UpdateSubject(subject);
            MessageBox.Show("" + delete, "Thông Báo!!");
            Load_gvListSubject();
        }

        private void btnBossOfClass_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            new TeacherAddFrom().ShowDialog();
            Load_gvTeacher();
        }
    }
}
