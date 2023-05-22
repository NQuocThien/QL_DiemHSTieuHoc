using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using ValueObject;

namespace QL_DiemHSTieuHoc
{
    public partial class FogotPass : Form
    {
        public FogotPass()
        {
            InitializeComponent();
        }
        UserBLL user = new UserBLL();
        string email = "";
        bool status = false;
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if(!status)
            {
                email = txtEmail.Text;
                string mess = user.CheckEmail(email);
                if (mess == "success")
                {
                    status = true;
                    
                    btnResetPass.Text = "Đổi mật khẩu";
                    txtEmail.Clear();
                    txtEmail.Focus();
                    lblTitle.Text = "Nhập Mật Khẩu Mới";
                }
                else
                {
                    MessageBox.Show("Email không hợp lệ");
                }
            }
            else
            {
                string newPass = txtEmail.Text;
                UserAccount us = new UserAccount();
                us.Email = email;
                us.Pass = newPass;
                string mess = user.UpdateUser(us);
                //string mess = us.Pass;
                if(mess == "success")
                {
                    this.Close();
                    MessageBox.Show("Đổi thành công!!!");
                }
                else
                {
                    MessageBox.Show(mess + ", " + us.Email);
                    status = false;
                    btnResetPass.Text = "Đổi mật khẩu";
                    txtEmail.Clear();
                    txtEmail.Focus();
                    lblTitle.Text = "Nhập Mật Khẩu Mới";
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
