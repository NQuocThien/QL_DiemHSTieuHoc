﻿using BusinessLogicLayer;
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
            this.btnAdd.Enabled = true;
            this.btnSearch.Enabled = true;
            this.btnTakeSubject.Enabled = true;
            this.bttnTakeClass.Enabled = true;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            Load_lockControl();
            Load_CurrentUser();
            Load_gvTeacher();
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
            this.btnAdd.Enabled = false;
            this.btnSearch.Enabled = false;
            this.btnTakeSubject.Enabled = false;
            this.bttnTakeClass.Enabled = false;
            this.cbSex.DropDownStyle = ComboBoxStyle.DropDownList;
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
            TeacherObject teacher = new TeacherObject();
            teacher.name_teacher = txtName.Text;
            teacher.numberPhone = txtSdt.Text;
            teacher.dateOfBirth = dateBirth.Text;
            teacher.sex = cbSex.Text;
            teacher.adress = txtAdress.Text;
            switch (teacherBLL.CreateTeacher(teacher))
            {
                case "requeid_name":
                    MessageBox.Show("Nhập Tên");
                    return;
                case "requeid_adress":
                    MessageBox.Show("Nhập địa chỉ");
                    return;
                case "requeid_numberphone":
                    MessageBox.Show("Nhập nhập số điện thoại");
                    return;
            }
            MessageBox.Show("Đã thêm giáo viên");
            Load_gvTeacher();
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
    }
}