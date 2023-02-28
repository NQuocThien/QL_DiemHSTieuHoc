using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace QL_DiemHSTieuHoc
{
    public partial class FogotPass : Form
    {
        public FogotPass()
        {
            InitializeComponent();
        }
        UserBLL user = new UserBLL();
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string getPass = user.CheckEmail(email);
            switch (getPass)
            {
                case "Email không hợp lệ":
                    MessageBox.Show("Email không hợp lệ");
                    return;

                case null:
                    MessageBox.Show("Email không tồn tại trong hệ thống");
                    return;
            }
            MessageBox.Show("Mật Khẩu là: " + getPass);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
