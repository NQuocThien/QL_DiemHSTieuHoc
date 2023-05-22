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
    public partial class ClassAddForm : Form
    {
        BlockBLL bLL = new BlockBLL();
        Class classs = new Class();
        public ClassAddForm()
        {
            InitializeComponent();
            Load_cbName();


        }

        private void Load_cbName()
        {
            if (bLL.BlockClass() != null)
            {
                cbBlockName.DataSource = bLL.BlockClass();
                cbBlockName.DisplayMember = "block_name";
                cbBlockName.ValueMember = "block_id";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            classs.block_id = int.Parse(cbBlockName.SelectedValue.ToString());
            classs.nameClass = txtName.Text;
            classs.schoolYear = txtSchoolYear.Text;
            string mess = bLL.CreateClass(classs);
            switch (mess)
            {
                case "requeid_nameclass":
                    MessageBox.Show("nhập tên lớp");
                    return;
                case "requeid_schoolyear":
                    MessageBox.Show("Nhập niên khóa");
                    return;
            }
            MessageBox.Show(mess);
            this.Close();
        }

        private void cbBlockName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClassAddForm_Load(object sender, EventArgs e)
        {
            cbBlockName.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
