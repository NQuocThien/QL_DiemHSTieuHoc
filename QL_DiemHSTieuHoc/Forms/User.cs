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
using System.Data.SqlClient;
using QL_DiemHSTieuHoc.Forms.SubUserForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QL_DiemHSTieuHoc.Forms
{
    public partial class User : Form
    {
        private string currentUser = null;
        UserAccount user = new UserAccount();
        UserAccount userClick = new UserAccount();
        UserBLL userBll = new UserBLL();

        public User(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.ControlBox = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            Load_Control();
            Load_CurrentUser();
            Load_ListUserAccess();
            Load_cbLaw();

        }

        private void Load_ListUserAccess()
        {
            int n = gvListUser.Width / 3;

            DataTable dt = userBll.GetListUserAccess();
            gvListUser.DataSource = dt;
            gvListUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvListUser.Columns[0].HeaderText = "User Name";
            gvListUser.Columns[0].Width = n;

            gvListUser.Columns[1].HeaderText = "Email";
            gvListUser.Columns[1].Width = n;

            gvListUser.Columns[2].HeaderText = "Quyền";
            gvListUser.Columns[2].Width = n;
        }
        private void Load_CurrentUser()
        {
            user = userBll.GetUser(currentUser);
            Law l = userBll.GetLaw(currentUser);

            if (user != null)
            {
                txtPass.Text = user.Pass;
                txtEmail.Text = user.Email;
                txtType.Text = l.law_name.ToString();
            }
            txtName.Text = currentUser;
            if (l.law_name == "admin")
            {
                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnUpdate.Enabled = true;
            }
        }

        private void Load_Control()
        {
            this.txtName.Enabled = false;
            this.txtPass.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtType.Enabled = false;
            this.cbLaw.Enabled = false;
            this.cbLaw.DropDownStyle = ComboBoxStyle.DropDownList;
            Load_adminConTrol();
        }
        private void Load_adminConTrol()
        {
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnUpdate.Enabled = false;
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            this.txtPass.Enabled = true;

        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            this.txtEmail.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Load_Control();
            UserAccount us = new UserAccount();
            us.UserName = user.UserName;
            us.Pass = txtPass.Text;
            us.Email = txtEmail.Text;
            if (userBll.UpdateUser(us) == "success")
            {
                MessageBox.Show("Lưu thành công");
                Load_CurrentUser();
            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Register regis = new Register();
            regis.ShowDialog();
            Load_ListUserAccess();

        }

        private void Load_cbLaw()
        {
            cbLaw.DataSource = userBll.GetLawDataTB();
            cbLaw.DisplayMember = "law_name";
            cbLaw.ValueMember = "law_id";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void gvListUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvListUser.CurrentRow.Index;
            if (i != null)
            {
                cbLaw.Enabled = true;
                userClick.UserName = gvListUser.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            string name = cbLaw.Text;
            string test = userBll.ProvideLawUser(userClick, name);
            if (test == "fail")
            {
                MessageBox.Show("Fail");
            }
            else
            {
                Load_ListUserAccess();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Register regis = new Register();
            regis.ShowDialog();
            Load_ListUserAccess();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateAccount udc = new UpdateAccount(userClick.UserName);
                udc.ShowDialog();
                Load_ListUserAccess();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn user cần sử");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userBll.DeleteUser(userClick.UserName) == "success")
            {
                MessageBox.Show("Đã xóa");
                Load_ListUserAccess();
            }
            else
            {
                MessageBox.Show("Lỗi");

            }
        }
    }
}
