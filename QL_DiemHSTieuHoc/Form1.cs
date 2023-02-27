using BusinessLogicLayer;
using ValueObject;

namespace QL_DiemHSTieuHoc
{
    public partial class Form1 : Form
    {
        UserAccount ac = new UserAccount();
        UserBLL acBll= new UserBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ac.UserName = txtUserName.Text;
            ac.Pass = txtPass.Text;

            string getuser = acBll.CheckLogic(ac);

            // Thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }

            MessageBox.Show("Xin chúc mừng bạn đã đăng nhập thành công hệ thống!");
        }
    }
}