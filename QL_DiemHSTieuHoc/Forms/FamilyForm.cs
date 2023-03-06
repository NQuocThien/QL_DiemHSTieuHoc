using BusinessLogicLayer;
using DataAccessLayer;
using Microsoft.VisualBasic.ApplicationServices;
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
using BusinessLogicLayer;
namespace QL_DiemHSTieuHoc.Forms.SubFroms
{
    public partial class FamilyForm : Form
    {
        UserBLL userBll = new UserBLL();
        string currentUser;
        FamilyBLL familyBLL = new FamilyBLL();
        UserAccount user = new UserAccount();
        Family currentfamily = new Family();
        Family family = new Family();
        public FamilyForm(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            Load_CurrentUser();
            Load_gvParent();
        }
        private void Load_CurrentUser()
        {
            user = userBll.GetUser(currentUser);
            Law l = userBll.GetLaw(currentUser);
            if (l.law_name == "admin" || l.law_name == "manager")
            {
                Load_ControlUnLock();
            }
        }
        private void Load_gvParent()
        {
            int n = gvParent.Width / 4;

            DataTable dt = familyBLL.GetFamily();
            if (dt == null)
                return;
            gvParent.DataSource = dt;
            gvParent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvParent.Columns[0].Visible = false;

            gvParent.Columns[1].HeaderText = "Quan Hệ";
            gvParent.Columns[1].Width = n;

            gvParent.Columns[2].HeaderText = "SDT";
            gvParent.Columns[2].Width = n;

            gvParent.Columns[3].HeaderText = "Năm Sinh";
            gvParent.Columns[3].Width = n;

            gvParent.Columns[4].HeaderText = "Họ Tên";
            gvParent.Columns[4].Width = n;

        }
        private void Load_ControlUnLock()
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void clean()
        {
            this.txtName.Clear();
            this.txtRelationShip.Clear();
            this.txtSdt.Clear();
            this.txtName.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            family.nameRelationShip = txtRelationShip.Text;
            family.yearOfBirth = dateBirth.Text;
            family.parent_name = txtName.Text;
            family.numberPhone = txtSdt.Text;
            string mess = familyBLL.CreateFamily(family);
            switch (mess)
            {
                case "requeid_name":
                    MessageBox.Show("Nhập Tên");
                    return;
                case "requeid_relationShip":
                    MessageBox.Show("Nhập mối quan hệ");
                    return;
                case "requeid_numberphone":
                    MessageBox.Show("Nhập nhập số điện thoại");
                    return;
                case "success":
                    MessageBox.Show("Đã Thêm thông tin người thân");
                    Load_gvParent();
                    clean();
                    return;

            }
            MessageBox.Show(mess);
        }
        private void GetCurrentFamily()
        {
            try
            {
                DataGridViewRow re = gvParent.SelectedRows[0];
                currentfamily.family_id = int.Parse(re.Cells[0].Value.ToString());
                currentfamily.nameRelationShip = re.Cells[1].Value.ToString();
                currentfamily.numberPhone = re.Cells[2].Value.ToString();
                currentfamily.yearOfBirth = re.Cells[3].Value.ToString();
                currentfamily.parent_name = re.Cells[4].Value.ToString();
            }
            catch (Exception ex) { }
        }
        private void gvParent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           Load_Control();
        }

        private void Load_Control()
        {
            txtName.Text = currentfamily.parent_name;
            txtRelationShip.Text = currentfamily.nameRelationShip;
            txtSdt.Text = currentfamily.numberPhone;
            dateBirth.Text = currentfamily.yearOfBirth;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            currentfamily.parent_name = txtName.Text;
            currentfamily.nameRelationShip = txtRelationShip.Text;
            currentfamily.numberPhone = txtSdt.Text;
            currentfamily.yearOfBirth = dateBirth.Text;
            string mess = familyBLL.UpdateFamily(currentfamily);
            switch (mess)
            {
                case "requeid_name":
                    MessageBox.Show("Nhập Tên");
                    return;
                case "requeid_relationShip":
                    MessageBox.Show("Nhập mối quan hệ");
                    return;
                case "requeid_numberphone":
                    MessageBox.Show("Nhập nhập số điện thoại");
                    return;
                case "success":
                    MessageBox.Show("Đã Sữa thông tin người thân");
                    Load_gvParent();
                    clean();
                    return;
            }
            MessageBox.Show(mess);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Phụ Huynh : " + currentfamily.parent_name, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (familyBLL.DeleteFamily(currentfamily) == "success")
                {
                    MessageBox.Show("Đã Xóa Phụ Huynh: " + currentfamily.parent_name);
                    return;
                }
                MessageBox.Show(familyBLL.DeleteFamily(currentfamily));
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            GetCurrentFamily();
            MessageBox.Show("" + currentfamily.family_id);
            new FamilyAndStudent(currentfamily).ShowDialog();
        }
    }
}
