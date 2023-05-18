using BusinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
using QL_DiemHSTieuHoc.Forms.SubBlockFroms;
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
using System.Xml.Linq;
using ValueObject;

namespace QL_DiemHSTieuHoc.Forms
{
    public partial class BlockAndClass : Form
    {
        BlockBLL blockBll = new BlockBLL();
        string currentUser;
        UserAccount user = new UserAccount();
        UserBLL userBll = new UserBLL();
        Block blockClick = new Block();
        Class clClick = new Class();
        public BlockAndClass(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }
        private void Load_CurrentUser()
        {
            user = userBll.GetUser(currentUser);
            Law l = userBll.GetLaw(currentUser);

            if (l.law_name == "admin" || l.law_name == "manager")
            {
                UnLock_Control();
            }
            if (l.law_name == "teacher")
            {
                this.btnAddClass.Enabled = true;
                this.btnDeleteClass.Enabled = true;
                this.btnUdateClass.Enabled = true;
            }
        }
        private void BlockAndClass_Load(object sender, EventArgs e)
        {
            Lock_Control();
            Load_CurrentUser();
            Load_gvVBlock();
            Load_gvClass();
        }

        private void Lock_Control()
        {
            this.btnAddBlock.Enabled = false;
            this.btnAddClass.Enabled = false;
            this.btnDeleteBlock.Enabled = false;
            this.btnDeleteClass.Enabled = false;
            this.btnUdateClass.Enabled = false;
            this.btnUpdateBlock.Enabled = false;
        }
        private void UnLock_Control()
        {
            this.btnAddBlock.Enabled = true;
            this.btnAddClass.Enabled = true;
            this.btnDeleteBlock.Enabled = true;
            this.btnDeleteClass.Enabled = true;
            this.btnUdateClass.Enabled = true;
            this.btnUpdateBlock.Enabled = true;
        }

        private void Load_gvVBlock()
        {
            int n = gvBlock.Width / 2;

            DataTable dt = blockBll.BlockClass();
            gvBlock.DataSource = dt;
            gvBlock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvBlock.Columns[0].HeaderText = "Mã Khối ";
            gvBlock.Columns[0].Width = n;

            gvBlock.Columns[1].HeaderText = "Tên Khối";
            gvBlock.Columns[1].Width = n;
        }
        private void Load_gvClass(string search)
        {
            int n = gvClass.Width / 4;

            DataTable dt = blockBll.GetClass(search);
            gvClass.DataSource = dt;
            gvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvClass.Columns[0].HeaderText = "Mã Lớp ";
            gvClass.Columns[0].Width = n;

            gvClass.Columns[1].HeaderText = "Tên Lớp";
            gvClass.Columns[1].Width = n;

            gvClass.Columns[2].HeaderText = "Tên Khối";
            gvClass.Columns[2].Width = n;

            gvClass.Columns[3].HeaderText = "Niên Khóa";
            gvClass.Columns[3].Width = n;

            gvClass.Columns[4].Visible = false;
        }
        private void Load_gvClass()
        {
            int n = gvClass.Width / 5;

            DataTable dt = blockBll.GetClass();
            gvClass.DataSource = dt;
            gvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvClass.Columns[0].HeaderText = "Mã Lớp ";
            gvClass.Columns[0].Width = n;

            gvClass.Columns[1].HeaderText = "Tên Lớp";
            gvClass.Columns[1].Width = n;

            gvClass.Columns[2].HeaderText = "Tên Khối";
            gvClass.Columns[2].Width = n;

            gvClass.Columns[3].HeaderText = "Niên Khóa";
            gvClass.Columns[3].Width = n;        
            
            gvClass.Columns[5].HeaderText = "Mã Chủ Nhiệm";
            gvClass.Columns[5].Width = n;

            gvClass.Columns[4].Visible = false;
        }

        private void btnAddBlock_Click(object sender, EventArgs e)
        {
            BlockAddFrom block = new BlockAddFrom();
            block.ShowDialog();
            Load_gvVBlock();
        }

        private void btnUpdateBlock_Click(object sender, EventArgs e)
        {
            BlockUpdateForm bl = new BlockUpdateForm(blockClick);
            bl.ShowDialog();
            Load_gvVBlock();
        }

        private void gvBlock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow re = gvBlock.SelectedRows[0];
            blockClick.block_id = re.Cells[0].Value.ToString();
            blockClick.block_name = re.Cells[1].Value.ToString();
        }

        private void btnDeleteBlock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Khối: " + blockClick.block_name, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                switch (blockBll.DeleteBlock(blockClick))
                {
                    case "success":
                        MessageBox.Show("Đã xóa");
                        break;
                    case "fail":
                        MessageBox.Show("không xóa đưzơc");
                        break;
                }
                Load_gvVBlock();
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ClassAddForm cl = new ClassAddForm();
            cl.ShowDialog();
            Load_gvClass();
        }

        private void btnUdateClass_Click(object sender, EventArgs e)
        {
            ClassUpdateForm cl = new ClassUpdateForm(clClick);
            cl.ShowDialog();
            Load_gvClass();

        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Lơp: " + clClick.nameClass, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                switch (blockBll.DeleteClass(clClick))
                {
                    case "success":
                        MessageBox.Show("Đã xóa");
                        break;
                    case "fail":
                        MessageBox.Show("không xóa đưzơc");
                        break;
                }
                Load_gvClass();
            }
        }

        private void gvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow gr = gvClass.SelectedRows[0];
            clClick.block_id = int.Parse(gr.Cells[4].Value.ToString());
            clClick.nameClass = gr.Cells[1].Value.ToString();
            clClick.schoolYear = gr.Cells[3].Value.ToString();
            clClick.class_id = int.Parse(gr.Cells[0].Value.ToString());
            string teacher_id = gr.Cells[5].Value.ToString();
            if(teacher_id != "")
            {
                clClick.teacher_id = int.Parse(teacher_id);
            }else 
                clClick.teacher_id = 0;

        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            Load_gvClass(search);
        }
    }
}
