using BusinessLogicLayer;
using DataAccessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using QL_DiemHSTieuHoc.Forms.SubFroms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;

namespace QL_DiemHSTieuHoc.Forms
{
    public partial class Student : Form
    {
        string currentUser;
        UserBLL userBll = new UserBLL();
        StudentObject stClick = new StudentObject();
        UserAccount user = new UserAccount();
        StudentObject st = new StudentObject();
        BlockBLL blockBll = new BlockBLL();
        StudentBLL stBll = new StudentBLL();
        FamilyBLL familyBLL = new FamilyBLL();
        int class_id;
        int tmp = 0;
        private void Load_CurrentUser()
        {
            user = userBll.GetUser(currentUser);
            Law l = userBll.GetLaw(currentUser);
            if (l.law_name == "admin" || l.law_name == "manager")
            {
                Load_ControlUnLock();
            }
        }
        public Student(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            Load_cbClass();
            Load_Control();
            Load_CurrentUser();
            // Load_gvParent();
        }

        private void Load_gvParent()
        {
            StudentObject student = GetCurrentStudent();


            int n = gvParent.Width / 2;

            DataTable dt = familyBLL.GetFamilyForStudent(student);
            if (dt == null)
                return;
            gvParent.DataSource = dt;
            gvParent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvParent.Columns[0].Visible = false;
            gvParent.Columns[1].Width = n;

            gvParent.Columns[1].HeaderText = "Quan Hệ";

            gvParent.Columns[2].Visible = false;

            gvParent.Columns[3].Visible = false;

            gvParent.Columns[4].HeaderText = "Họ Tên";
            gvParent.Columns[4].Width = n;

        }

        private void Load_Control()
        {
            this.btnAbout.Enabled = false;
            this.btnReport.Enabled = false;
            this.btnSearch.Enabled = false;
            this.btnAdd.Enabled = false;
            this.cbSex.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Load_ControlUnLock()
        {
            this.btnAbout.Enabled = true;
            this.btnReport.Enabled = true;
            this.btnSearch.Enabled = true;
            this.btnAdd.Enabled = true;
        }
        private void Load_cbClass()
        {
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.DataSource = blockBll.GetClasscb();
            cbClass.DisplayMember = "nameClass";
            cbClass.ValueMember = "class_id";
            class_id = int.Parse(cbClass.SelectedValue.ToString());
            Load_gvStudent(class_id);
        }
        private void Load_gvStudent(int class_id)
        {
            int n = gvStudent.Width / 5;

            DataTable dt = stBll.GetStudent(class_id);
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

        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tmp > 1)
            {
                class_id = int.Parse(cbClass.SelectedValue.ToString());
                Load_gvStudent(class_id);
            }
            tmp++;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            st.studentName = txtName.Text;
            st.numberPhone = txtSdt.Text;
            st.dateOfBirth = dateBirth.Text;
            st.adress = txtAdress.Text;
            st.sex = cbSex.Text;
            st.class_id = int.Parse(cbClass.SelectedValue.ToString());
            switch (stBll.CreateStudent(st))
            {
                case "requeid_name":
                    MessageBox.Show("Nhập tên:");
                    return;
                case "requeid_adress":
                    MessageBox.Show("Nhập địa chỉ:");
                    return;
                case "requeid_numberphone":
                    MessageBox.Show("Nhập số điện thoại:");
                    return;
            }
            MessageBox.Show("Đã Nhập!!!");
            Load_gvStudent(class_id);
        }
        private StudentObject GetCurrentStudent()
        {
            try
            {
                DataGridViewRow dr = gvStudent.SelectedRows[0];
                st.studentName = dr.Cells[0].Value.ToString();
                st.numberPhone = dr.Cells[1].Value.ToString();
                st.dateOfBirth = dr.Cells[2].Value.ToString();
                st.sex = dr.Cells[3].Value.ToString();
                st.adress = dr.Cells[4].Value.ToString();
                st.student_id = int.Parse(dr.Cells[5].Value.ToString());
                return st;
            }
            catch
            {
                return null;
            }

        }
        private void btnAbout_Click(object sender, EventArgs e)
        {

            if (GetCurrentStudent() != null)
            {
                SubStudentForm f = new SubStudentForm(st);
                f.ShowDialog();
                Load_gvStudent(class_id);
            }
        }

        private void gvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_gvParent();
        }
    }
}
