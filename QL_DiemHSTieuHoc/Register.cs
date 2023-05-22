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

namespace QL_DiemHSTieuHoc
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        UserAccount user = new UserAccount();
        UserBLL userBLL = new UserBLL();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            user.UserName = txtUserName.Text;
            user.Pass = txtPass.Text;
            user.Email = txtEmail.Text;
            string test = userBLL.CheckLogicRegister(user, txtRePass.Text);
            switch (test)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "pass_not_match":
                    MessageBox.Show("Mật khẩu không trùng khớp");
                    return;

                case "requeid_email":
                    MessageBox.Show("Email không hợp lệ!");
                    return;

                case "exist_username_email":
                    MessageBox.Show("Tài khoản hoặc Email đã tồn tại");
                    return;
            }
            MessageBox.Show(test);
            if (test == "success")
                this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
