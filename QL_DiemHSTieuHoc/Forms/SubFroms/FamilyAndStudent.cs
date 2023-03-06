using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;

namespace QL_DiemHSTieuHoc.Forms.SubFroms
{
    public partial class FamilyAndStudent : Form
    {
        BlockBLL blockBll = new BlockBLL();
        StudentBLL stBll = new StudentBLL();
        StudentObject st = new StudentObject();
        int class_id;
        int student_id;
        Family family;
        int tmp = 0;
        public FamilyAndStudent(Family family)
        {
            InitializeComponent();
            this.family = family;
        }

        private void FamilyAndStudent_Load(object sender, EventArgs e)
        {
            Load_Control();
            Load_gvStudentAccess();
        }

        private void Load_Control()
        {
            this.cbClass.Enabled = false;
            this.txtName.Enabled = false;
            this.rdbClass.Checked = false;
            this.rdbName.Checked = false;
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Load_cbClass()
        {
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.DataSource = blockBll.GetClasscb();
            cbClass.DisplayMember = "nameClass";
            cbClass.ValueMember = "class_id";
            class_id = int.Parse(cbClass.SelectedValue.ToString());
            // Load_gvStudent(class_id);
        }
        private void Load_gvStudent(int class_id)
        {
            int n = gvStudent.Width / 5;

            DataTable dt = stBll.GetStudentNonOfFamily(family.family_id, class_id);
            if (dt == null)
                return;
            gvStudent.DataSource = dt;
            gvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvStudent.Columns[0].HeaderText = "Tên Học Sinh";
            gvStudent.Columns[0].Width = n;

            gvStudent.Columns[1].HeaderText = "SĐT";
            gvStudent.Columns[1].Width = n;

            gvStudent.Columns[2].HeaderText = "Ngày Sinh";
            gvStudent.Columns[2].Width = n;

            gvStudent.Columns[3].HeaderText = "Giới Tính";
            gvStudent.Columns[3].Width = n;

            gvStudent.Columns[4].HeaderText = "Địa Chỉ";
            gvStudent.Columns[4].Width = n;

            gvStudent.Columns[5].Visible = false;

        }
        private void Load_gvStudent(string name)
        {
            int n = gvStudent.Width / 5;

            DataTable dt = stBll.GetStudentNonOfFamily(family.family_id, name);
            if (dt == null)
                return;
            gvStudent.DataSource = dt;
            gvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvStudent.Columns[0].HeaderText = "Tên Học Sinh";
            gvStudent.Columns[0].Width = n;

            gvStudent.Columns[1].HeaderText = "SĐT";
            gvStudent.Columns[1].Width = n;

            gvStudent.Columns[2].HeaderText = "Ngày Sinh";
            gvStudent.Columns[2].Width = n;

            gvStudent.Columns[3].HeaderText = "Giới Tính";
            gvStudent.Columns[3].Width = n;

            gvStudent.Columns[4].HeaderText = "Địa Chỉ";
            gvStudent.Columns[4].Width = n;

            gvStudent.Columns[5].Visible = false;

        }
        private void Load_gvStudentAccess()
        {
            int n = gvSubjectAccess.Width / 5;

            DataTable dt = stBll.GetStudentOfFamily(family.family_id);
            if (dt == null)
                return;
            gvSubjectAccess.DataSource = dt;
            gvSubjectAccess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvSubjectAccess.Columns[0].HeaderText = "Tên Học Sinh";
            gvSubjectAccess.Columns[0].Width = n;

            gvSubjectAccess.Columns[1].HeaderText = "SĐT";
            gvSubjectAccess.Columns[1].Width = n;

            gvSubjectAccess.Columns[2].HeaderText = "Ngày Sinh";
            gvSubjectAccess.Columns[2].Width = n;

            gvSubjectAccess.Columns[3].HeaderText = "Giới Tính";
            gvSubjectAccess.Columns[3].Width = n;

            gvSubjectAccess.Columns[4].HeaderText = "Địa Chỉ";
            gvSubjectAccess.Columns[4].Width = n;

            gvSubjectAccess.Columns[5].Visible = false;

        }
        private void rdbClass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbClass.Checked == true)
            {
                this.txtName.Enabled = false;
                this.cbClass.Enabled = true;
                Load_cbClass();
            }
        }
        private void rdbName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbName.Checked == true)
            {
                this.cbClass.Enabled = false;
                this.txtName.Enabled = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (rdbName.Checked)
            {
                Load_gvStudent(txtName.Text);
                this.txtName.Clear();
            }
            else
            {
                class_id = int.Parse(cbClass.SelectedValue.ToString());
                Load_gvStudent(class_id);
            }
        }
        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow re = gvStudent.SelectedRows[0];
            if (re == null) { return; }
            student_id = int.Parse(re.Cells[5].Value.ToString());

            string mess = stBll.AddStudentForFamily(student_id, family.family_id);
            if (mess == "success")
            {
                if (rdbClass.Checked)
                {
                    Load_gvStudent(class_id);
                }
                else
                {
                    Load_gvStudent(txtName.Text);
                }
                Load_gvStudentAccess();
            }
            else
            {
                MessageBox.Show(mess);
            }
        }

        private void gvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow re = gvStudent.SelectedRows[0];
            if (re == null) { return; }
            student_id = int.Parse(re.Cells[5].Value.ToString());

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataGridViewRow re = gvSubjectAccess.SelectedRows[0];
            if (re == null) { return; }
            student_id = int.Parse(re.Cells[5].Value.ToString());

            string mess = stBll.RemoveStudentForFamily(student_id, family.family_id);
            if (mess == "success")
            {
                if (rdbClass.Checked)
                {
                    Load_gvStudent(class_id);
                }
                else
                {
                    Load_gvStudent(txtName.Text);
                }
                Load_gvStudentAccess();
            }
            else
            {
                MessageBox.Show(mess);
            }
        }
    }
}
