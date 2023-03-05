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
    public partial class TeacherTakeSubject : Form
    {
        TeacherBLL teacherBLL = new TeacherBLL();
        TeacherObject teacher;
        int subject_id;
        public TeacherTakeSubject(TeacherObject teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        private void TeacherTakeSubject_Load(object sender, EventArgs e)
        {
            Load_gvSubject();
            Load_gvSubjectAccess();
        }
        private void Load_gvSubject()
        {
            int n = gvSubject.Width / 1;
            gvSubject.DataSource = teacherBLL.GetSubjectNonOfTeacher(teacher.teacher_id);
            gvSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvSubject.Columns[0].Visible = false;
            gvSubject.Columns[1].HeaderText = "Tên Môn";
            gvSubject.Columns[1].Width = n;
        }
        private void Load_gvSubjectAccess()
        {
            int n = gvSubjectAccess.Width / 1;
            gvSubjectAccess.DataSource = teacherBLL.GetSubjectOfTeacher(teacher.teacher_id);
            gvSubjectAccess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvSubjectAccess.Columns[0].Visible = false;
            gvSubjectAccess.Columns[1].HeaderText = "Tên Môn";
            gvSubjectAccess.Columns[1].Width = n;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow re = gvSubject.SelectedRows[0];
            subject_id = int.Parse(re.Cells[0].Value.ToString());
            string mess = teacherBLL.AddSubjectForTeacher(subject_id, teacher.teacher_id);
            if (mess == "success")
            {
                Load_gvSubject();
                Load_gvSubjectAccess();
            }
            else
            {
                MessageBox.Show(mess);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataGridViewRow re = gvSubjectAccess.SelectedRows[0];
            subject_id = int.Parse(re.Cells[0].Value.ToString());
            string mess = teacherBLL.RemoveSubjectForTeacher(subject_id, teacher.teacher_id);
            if (mess == "success")
            {
                Load_gvSubject();
                Load_gvSubjectAccess();
            }
            else
            {
                MessageBox.Show(mess);
            }
        }
    }
}
