using BusinessLogicLayer;
using DataAccessLayer;
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

namespace QL_DiemHSTieuHoc.Forms.SubUserForms
{
    public partial class UpdateAccount : Form
    {
        private string userName;
        private UserAccount user;
        UserBLL userBLL = new UserBLL();
        public UpdateAccount(string userName)
        {
            InitializeComponent();
            this.userName = userName;

        }
        private void UpdateAccount_Load(object sender, EventArgs e)
        {
            user = userBLL.GetUser(userName);
            txtUserName.Text = user.UserName;
            //txtPass.Text = user.Pass;
            txtEmail.Text = user.Email;
            this.txtUserName.Enabled = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (user != null)
            {
                user.Email = txtEmail.Text;
                user.Pass = txtPass.Text;
                string userUdate = userBLL.UpdateUser(user);
                switch (userUdate)
                {
                    case "requeid_email":
                        MessageBox.Show("Email không hợp lệ");
                        return;
                    case "exist_username_email":
                        MessageBox.Show("Email đã tồn tại");
                        return;
                    case "Fail":
                        MessageBox.Show("Thất Bại");
                        return;
                }
                MessageBox.Show("Đã sửa");
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
