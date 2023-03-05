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
using ValueObject;

namespace QL_DiemHSTieuHoc.Forms.SubTeacherForms
{
    public partial class TeacherAboutForm : Form
    {
        TeacherObject teacher;
        TeacherBLL tcBll = new TeacherBLL();
        public TeacherAboutForm(TeacherObject teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        private void TeacherAboutForm_Load(object sender, EventArgs e)
        {
            Load_control();
        }
        private void Load_control()
        {

            txtName.Text = teacher.name_teacher;
            txtAdress.Text = teacher.adress;
            txtSdt.Text = teacher.numberPhone;
            dateBirth.Text = teacher.dateOfBirth;

            foreach (var item in cbSex.Items)
            {
                if (item.ToString() == teacher.sex)
                {
                    cbSex.SelectedItem = item;
                    break;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TeacherObject tc = new TeacherObject();
            tc.name_teacher = txtName.Text;
            tc.numberPhone = txtSdt.Text;
            tc.dateOfBirth = dateBirth.Text;
            tc.sex = cbSex.Text;
            tc.adress = txtAdress.Text;
            tc.teacher_id = teacher.teacher_id;
            MessageBox.Show(tc.teacher_id + ", " + tc.name_teacher + ", " + tc.numberPhone + ", " + tc.dateOfBirth + ", " + tc.sex + ", " + tc.adress);
            switch (tcBll.UpdateTeacher(tc))
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
                case "success":
                    MessageBox.Show("Đã sửa giáo viên");
                    this.Close();
                    return;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa GV : " + teacher.name_teacher + ", " + teacher.teacher_id, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (tcBll.DeleteTeacher(teacher) == "success")
                {
                    MessageBox.Show(" Đã Xóa GV : " + teacher.name_teacher);
                    this.Close();
                    return;
                }
                MessageBox.Show(tcBll.DeleteTeacher(teacher));
            }
        }
    }
}
