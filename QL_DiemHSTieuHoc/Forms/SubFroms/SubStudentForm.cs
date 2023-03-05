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

namespace QL_DiemHSTieuHoc.Forms.SubFroms
{
    public partial class SubStudentForm : Form
    {
        StudentBLL stBll = new StudentBLL();
        StudentObject st;
        BlockBLL blockBll = new BlockBLL();


        public SubStudentForm(StudentObject st)
        {
            InitializeComponent();
            this.st = st;
            Load_control();
        }
        private void Load_control()
        {

            txtName.Text = st.studentName;
            txtAdress.Text = st.adress;
            txtSdt.Text = st.numberPhone;
            dateBirth.Text = st.dateOfBirth;
            MessageBox.Show(st.studentName + ", " + st.numberPhone + "," + st.dateOfBirth);

            foreach (var item in cbSex.Items)
            {
                if (item.ToString() == st.sex)
                {
                    cbSex.SelectedItem = item;
                    break;
                }
            }
            Load_cbClass();
        }
        private void Load_cbClass()
        {
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.DataSource = blockBll.GetClasscb();
            cbClass.DisplayMember = "nameClass";
            cbClass.ValueMember = "class_id";
            cbClass.SelectedValue = st.class_id.ToString();

            //Load_gvStudent(class_id);
        }
        private void SubStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            st.studentName = txtName.Text;
            st.adress = txtAdress.Text;
            st.numberPhone = txtSdt.Text;
            st.dateOfBirth = dateBirth.Text;
            st.sex = cbSex.Text;
            try
            {
                st.class_id = int.Parse(cbClass.SelectedValue.ToString());
            }
            catch
            {
                MessageBox.Show("chọn lớp");
                return;
            }

            switch (stBll.UpdateStudent(st))
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
            MessageBox.Show("Đã sửa!!!");
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa HS : " + st.studentName, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(stBll.DeleteStudent(st) == "success")
                {
                    MessageBox.Show("đã xóa học sinh " + st.studentName);
                    this.Close();
                    return;
                }
                MessageBox.Show("lỗi");
            }
        }
    }
}
