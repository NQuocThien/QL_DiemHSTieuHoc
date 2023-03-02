using BusinessLogicLayer;
using ValueObject;

namespace QL_DiemHSTieuHoc
{
    public partial class Login : Form
    {
        UserAccount ac = new UserAccount();
        UserBLL acBll = new UserBLL();
        public Login()
        {
            InitializeComponent();
        }
        private void reset()
        {
            txtUserName.Clear();
            txtPass.Clear();
            txtUserName.Focus();    
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
                case "user_not_accepted":
                    MessageBox.Show("Tài khoản chưa được duyệt!");
                    return;
            }
            reset();
            MessageBox.Show("Xin chúc mừng bạn đã đăng nhập thành công hệ thống với quyền");
            Main main = new Main(ac.UserName);
            main.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblFogotPass_Click(object sender, EventArgs e)
        {
            FogotPass fr = new FogotPass();
            fr.ShowDialog();
        }

        private void lblCreateUserAccout_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            re.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}