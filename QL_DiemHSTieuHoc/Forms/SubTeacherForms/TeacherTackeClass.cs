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

namespace QL_DiemHSTieuHoc.Forms.SubTeacherForms
{
    public partial class TeacherTackeClass : Form
    {
        BlockBLL blockBll = new BlockBLL();
        TeacherBLL teacherBLL = new TeacherBLL();
        TeacherObject teacher;
        int class_id;
        public TeacherTackeClass(TeacherObject teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeacherTackeClass_Load(object sender, EventArgs e)
        {
            Load_Title();
            Load_gvClass();
            Load_gvClassAccess();
        }

        private void Load_Title()
        {
            lblTitle.Text = "Phân Công Cho Giáo Viên " + teacher.name_teacher;
        }

        private void Load_gvClass()
        {
            int n = gvClass.Width / 2;
            gvClass.DataSource = teacherBLL.GetClassNonOfTeacher(teacher.teacher_id);
            gvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            gvClass.Columns[0].Visible = false;
            gvClass.Columns[1].Visible = false;

            gvClass.Columns[2].HeaderText = "Tên Lớp";
            gvClass.Columns[2].Width = n;

            gvClass.Columns[3].HeaderText = "Niên Khóa";
            gvClass.Columns[3].Width = n;
        }
        private void Load_gvClassAccess()
        {
            int n = gvClassAccess.Width / 2;
            gvClassAccess.DataSource = teacherBLL.GetClassOfTeacher(teacher.teacher_id);
            gvClassAccess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            gvClassAccess.Columns[0].Visible = false;
            gvClassAccess.Columns[1].Visible = false;

            gvClassAccess.Columns[2].HeaderText = "Tên Lớp";
            gvClassAccess.Columns[2].Width = n;

            gvClassAccess.Columns[3].HeaderText = "Niên Khóa";
            gvClassAccess.Columns[3].Width = n;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow re = gvClass.SelectedRows[0];
            class_id = int.Parse(re.Cells[0].Value.ToString());
            string mess = teacherBLL.AddClassForTeacher(class_id, teacher.teacher_id);
            if (mess == "success")
            {
                Load_gvClassAccess();
                Load_gvClass();
            }
            else
            {
                MessageBox.Show(mess);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataGridViewRow re = gvClassAccess.SelectedRows[0];
            class_id = int.Parse(re.Cells[0].Value.ToString());
            string mess = teacherBLL.RemoveClassForTeacher(class_id, teacher.teacher_id);
            if (mess == "success")
            {
                Load_gvClassAccess();
                Load_gvClass();
            }
            else
            {
                MessageBox.Show(mess);
            }
        }
    }
}
