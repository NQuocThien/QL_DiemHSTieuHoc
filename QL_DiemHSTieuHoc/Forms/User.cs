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

namespace QL_DiemHSTieuHoc.Forms
{
    public partial class User : Form
    {
        private string currentUser = null;
        UserAccount user = new UserAccount();
        UserBLL userBll = new UserBLL();

        public User(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            Load_Control();
            Load_CurrentUser();
            Load_ListUser();

        }

        private void Load_ListUser()
        {
            int n = gvListUser.Width / 3;

            DataTable dt = userBll.GetListUser();
            gvListUser.DataSource = dt;
            DataTableReader re = dt.CreateDataReader();
            if (re.HasRows)
            {
                while (re.Read())
                {
                    MessageBox.Show(re.GetString(0));
                }
            }

            
            gvListUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

            gvListUser.Columns[0].HeaderText = "User Name";
            gvListUser.Columns[0].Width = n;

            gvListUser.Columns[1].HeaderText = "Email";
            gvListUser.Columns[1].Width = n;

            gvListUser.Columns[2].HeaderText = "Quyền";
            gvListUser.Columns[2].Width = n;

            
           
        }

        private void List_GridView()
        {
            int n = gvListUser.Width/3;
            gvListUser.ReadOnly = true;
            gvListUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvListUser.ColumnCount = 3;

            gvListUser.Columns[0].HeaderText = "User Name";
            gvListUser.Columns[0].Width = n ;

            gvListUser.Columns[1].HeaderText = "Email";
            gvListUser.Columns[1].Width = n ;

            gvListUser.Columns[2].HeaderText = "Quyền";
            gvListUser.Columns[2].Width = n ;

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
                this.btnProvideLaw.Enabled = true;
                this.btnUpdate.Enabled = true;
            }
        }

        private void Load_Control()
        {
            this.txtName.Enabled = false;
            this.txtPass.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtType.Enabled = false;
            Load_adminConTrol();
        }
        private void Load_adminConTrol()
        {
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnProvideLaw.Enabled = false;
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
            };


        }
    }
}
