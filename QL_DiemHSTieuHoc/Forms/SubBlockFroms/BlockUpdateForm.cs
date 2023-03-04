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
    public partial class BlockUpdateForm : Form
    {
        Block block;
        BlockBLL blockBLL = new BlockBLL();

        public BlockUpdateForm(Block block)
        {
            InitializeComponent();
            this.block = block;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            block.block_name = txtName.Text;
            switch (blockBLL.UpdateBlock(block))
            {
                case "requeid_blockname":
                    MessageBox.Show("Nhập Tên Khối");
                    return;
                case "exist_block_name":
                    MessageBox.Show("Tên Đã Tồn Tại");
                    txtName.Clear();
                    return;
            }
            MessageBox.Show("Đã Sửa!");
            this.Close();
        }

        private void BlockUpdateForm_Load(object sender, EventArgs e)
        {
            this.txtID.Text = block.block_id;
            this.txtName.Text = block.block_name;
        }
    }
}
