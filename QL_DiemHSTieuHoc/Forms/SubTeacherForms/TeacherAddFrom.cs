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
    public partial class TeacherAddFrom : Form
    {
        public TeacherAddFrom()
        {
            InitializeComponent();
        }
        TeacherBLL teacherBLL = new TeacherBLL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TeacherObject teacher = new TeacherObject();
            teacher.name_teacher = txtName.Text;
            teacher.numberPhone = txtSdt.Text;
            teacher.dateOfBirth = dateBirth.Text;
            teacher.sex = cbSex.Text;
            teacher.adress = txtAdress.Text;
            string mess = teacherBLL.CreateTeacher(teacher);
            switch (mess)
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
            if (mess == "success")
            {
                MessageBox.Show("Đã thêm giáo viên");
                this.Close();
            }
            else
                MessageBox.Show(mess);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
