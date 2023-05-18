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
namespace QL_DiemHSTieuHoc.Forms.SubBlockFroms
{
    public partial class ClassUpdateForm : Form
    {
        Class cl;
        BlockBLL bll = new BlockBLL();
        TeacherBLL teacherBLL = new TeacherBLL();
        public ClassUpdateForm(Class cl)
        {
            InitializeComponent();
            this.cl = cl;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClassUpdateForm_Load(object sender, EventArgs e)
        {
            cbBlockName.DataSource = bll.BlockClass();
            cbBlockName.DisplayMember = "block_name";
            cbBlockName.ValueMember = "block_id";
            cbBlockName.SelectedValue = cl.block_id;
            txtName.Text = cl.nameClass;
            txtSchoolYear.Text = cl.schoolYear;
            cbBlockName.SelectedItem = cl.block_id;
            cbTeacherBoss.DataSource = teacherBLL.GetTeacherIsNotBoss();
            cbTeacherBoss.DisplayMember = "name_teacher";
            cbTeacherBoss.ValueMember = "teacher_id";
            cbTeacherBoss.SelectedValue = cl.teacher_id;
            string teacherName = teacherBLL.GetNameByID(cl.teacher_id);
            lblBoss.Text += teacherName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cl.nameClass = txtName.Text;
            cl.schoolYear = txtSchoolYear.Text;
            cl.block_id = int.Parse(cbBlockName.SelectedValue.ToString());
            cl.teacher_id = int.Parse(cbTeacherBoss.SelectedValue.ToString());
            switch (bll.UpdateClass(cl))
            {
                case "requeid_blockname":
                    MessageBox.Show("nhập Tên lớp");
                    return;
                case "requeid_schoolyear":
                    MessageBox.Show("nhập niên khóa");
                    return;
            }
            MessageBox.Show("đã sửa");
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
