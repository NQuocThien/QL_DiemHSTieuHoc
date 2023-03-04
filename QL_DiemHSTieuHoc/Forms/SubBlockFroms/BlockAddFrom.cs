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
    public partial class BlockAddFrom : Form
    {
        BlockBLL blockBLL = new BlockBLL();
        Block block = new Block();
        public BlockAddFrom()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            block.block_name = txtName.Text;
            switch (blockBLL.CreateBlock(block))
            {
                case "requeid_blockname":
                    MessageBox.Show("Nhập Tên Khối");
                    return;
                case "exist_block_name":
                    MessageBox.Show("Nhập Tên Đã Tồn Tại");
                    txtName.Clear();
                    return;
            }
            MessageBox.Show("Đã thêm!");
            this.Close();
        }

        private void BlockAddFrom_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
