namespace QL_DiemHSTieuHoc.Forms
{
    partial class BlockAndClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockAndClass));
            imgTitle = new ImageList(components);
            panel1 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            groupBox10 = new GroupBox();
            btnDeleteBlock = new Button();
            btnUpdateBlock = new Button();
            btnAddBlock = new Button();
            panel17 = new Panel();
            groupBox11 = new GroupBox();
            gvBlock = new DataGridView();
            label6 = new Label();
            panel18 = new Panel();
            label8 = new Label();
            panel3 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            groupBox7 = new GroupBox();
            groupBox12 = new GroupBox();
            btnFind = new Button();
            txtSearch = new TextBox();
            groupBox8 = new GroupBox();
            btnDeleteClass = new Button();
            btnUdateClass = new Button();
            btnAddClass = new Button();
            panel13 = new Panel();
            groupBox9 = new GroupBox();
            gvClass = new DataGridView();
            panel14 = new Panel();
            label3 = new Label();
            imgIcon = new ImageList(components);
            panel1.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            groupBox10.SuspendLayout();
            panel17.SuspendLayout();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvBlock).BeginInit();
            panel18.SuspendLayout();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox8.SuspendLayout();
            panel13.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvClass).BeginInit();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // imgTitle
            // 
            imgTitle.ColorDepth = ColorDepth.Depth32Bit;
            imgTitle.ImageStream = (ImageListStreamer)resources.GetObject("imgTitle.ImageStream");
            imgTitle.TransparentColor = Color.Transparent;
            imgTitle.Images.SetKeyName(0, "programmer.png");
            imgTitle.Images.SetKeyName(1, "checklist.png");
            // 
            // panel1
            // 
            panel1.Controls.Add(panel15);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 488);
            panel1.TabIndex = 4;
            // 
            // panel15
            // 
            panel15.Controls.Add(panel16);
            panel15.Controls.Add(panel17);
            panel15.Controls.Add(panel18);
            panel15.Dock = DockStyle.Left;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(420, 488);
            panel15.TabIndex = 1;
            // 
            // panel16
            // 
            panel16.BackColor = SystemColors.ButtonFace;
            panel16.Controls.Add(groupBox10);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 391);
            panel16.Name = "panel16";
            panel16.Size = new Size(420, 97);
            panel16.TabIndex = 2;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(btnDeleteBlock);
            groupBox10.Controls.Add(btnUpdateBlock);
            groupBox10.Controls.Add(btnAddBlock);
            groupBox10.Dock = DockStyle.Fill;
            groupBox10.Location = new Point(0, 0);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(420, 97);
            groupBox10.TabIndex = 0;
            groupBox10.TabStop = false;
            // 
            // btnDeleteBlock
            // 
            btnDeleteBlock.Anchor = AnchorStyles.None;
            btnDeleteBlock.BackColor = Color.NavajoWhite;
            btnDeleteBlock.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteBlock.ImageAlign = ContentAlignment.MiddleRight;
            btnDeleteBlock.ImageIndex = 1;
            btnDeleteBlock.ImageList = imgIcon;
            btnDeleteBlock.Location = new Point(282, 23);
            btnDeleteBlock.Name = "btnDeleteBlock";
            btnDeleteBlock.Size = new Size(104, 61);
            btnDeleteBlock.TabIndex = 0;
            btnDeleteBlock.Text = "Xóa ";
            btnDeleteBlock.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteBlock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteBlock.UseVisualStyleBackColor = false;
            btnDeleteBlock.Click += btnDeleteBlock_Click;
            // 
            // btnUpdateBlock
            // 
            btnUpdateBlock.Anchor = AnchorStyles.None;
            btnUpdateBlock.BackColor = Color.NavajoWhite;
            btnUpdateBlock.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateBlock.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdateBlock.ImageIndex = 4;
            btnUpdateBlock.ImageList = imgIcon;
            btnUpdateBlock.Location = new Point(159, 23);
            btnUpdateBlock.Name = "btnUpdateBlock";
            btnUpdateBlock.Size = new Size(104, 60);
            btnUpdateBlock.TabIndex = 0;
            btnUpdateBlock.Text = "Sửa ";
            btnUpdateBlock.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateBlock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateBlock.UseVisualStyleBackColor = false;
            btnUpdateBlock.Click += btnUpdateBlock_Click;
            // 
            // btnAddBlock
            // 
            btnAddBlock.Anchor = AnchorStyles.None;
            btnAddBlock.BackColor = Color.NavajoWhite;
            btnAddBlock.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddBlock.ImageAlign = ContentAlignment.MiddleRight;
            btnAddBlock.ImageIndex = 2;
            btnAddBlock.ImageList = imgIcon;
            btnAddBlock.Location = new Point(25, 23);
            btnAddBlock.Name = "btnAddBlock";
            btnAddBlock.Size = new Size(115, 61);
            btnAddBlock.TabIndex = 0;
            btnAddBlock.Text = "Thêm";
            btnAddBlock.TextAlign = ContentAlignment.MiddleLeft;
            btnAddBlock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddBlock.UseVisualStyleBackColor = false;
            btnAddBlock.Click += btnAddBlock_Click;
            // 
            // panel17
            // 
            panel17.BackColor = SystemColors.ButtonHighlight;
            panel17.Controls.Add(groupBox11);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 44);
            panel17.Name = "panel17";
            panel17.Size = new Size(420, 347);
            panel17.TabIndex = 1;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(gvBlock);
            groupBox11.Controls.Add(label6);
            groupBox11.Dock = DockStyle.Fill;
            groupBox11.Location = new Point(0, 0);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(420, 347);
            groupBox11.TabIndex = 0;
            groupBox11.TabStop = false;
            // 
            // gvBlock
            // 
            gvBlock.AllowUserToAddRows = false;
            gvBlock.BackgroundColor = Color.Bisque;
            gvBlock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvBlock.Dock = DockStyle.Fill;
            gvBlock.Location = new Point(3, 19);
            gvBlock.Name = "gvBlock";
            gvBlock.ReadOnly = true;
            gvBlock.RowTemplate.Height = 25;
            gvBlock.Size = new Size(414, 325);
            gvBlock.TabIndex = 1;
            gvBlock.CellClick += gvBlock_CellClick;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(122, 376);
            label6.Name = "label6";
            label6.Size = new Size(137, 18);
            label6.TabIndex = 0;
            label6.Text = "Loại Tài Khoản:";
            // 
            // panel18
            // 
            panel18.BackColor = Color.NavajoWhite;
            panel18.Controls.Add(label8);
            panel18.Dock = DockStyle.Top;
            panel18.Location = new Point(0, 0);
            panel18.Name = "panel18";
            panel18.Size = new Size(420, 44);
            panel18.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.ImageIndex = 0;
            label8.ImageList = imgTitle;
            label8.Location = new Point(71, 0);
            label8.Name = "label8";
            label8.Size = new Size(222, 41);
            label8.TabIndex = 0;
            label8.Text = "Danh Sách Khối";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel11);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(420, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(661, 488);
            panel3.TabIndex = 5;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.GradientInactiveCaption;
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(panel14);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(658, 488);
            panel11.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ButtonFace;
            panel12.Controls.Add(groupBox7);
            panel12.Controls.Add(groupBox8);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 397);
            panel12.Name = "panel12";
            panel12.Size = new Size(658, 100);
            panel12.TabIndex = 3;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(groupBox12);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new Point(287, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(371, 100);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(btnFind);
            groupBox12.Controls.Add(txtSearch);
            groupBox12.Dock = DockStyle.Fill;
            groupBox12.ImeMode = ImeMode.On;
            groupBox12.Location = new Point(3, 19);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(365, 78);
            groupBox12.TabIndex = 8;
            groupBox12.TabStop = false;
            groupBox12.Text = "Tiềm Kiếm";
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.ActiveCaption;
            btnFind.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFind.Location = new Point(265, 18);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(81, 36);
            btnFind.TabIndex = 5;
            btnFind.Text = "Tiềm Kiếm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(24, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(224, 29);
            txtSearch.TabIndex = 7;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btnDeleteClass);
            groupBox8.Controls.Add(btnUdateClass);
            groupBox8.Controls.Add(btnAddClass);
            groupBox8.Dock = DockStyle.Left;
            groupBox8.Location = new Point(0, 0);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(287, 100);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            // 
            // btnDeleteClass
            // 
            btnDeleteClass.BackColor = SystemColors.ActiveCaption;
            btnDeleteClass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteClass.ImageIndex = 0;
            btnDeleteClass.ImageList = imgIcon;
            btnDeleteClass.Location = new Point(168, 14);
            btnDeleteClass.Name = "btnDeleteClass";
            btnDeleteClass.Size = new Size(94, 66);
            btnDeleteClass.TabIndex = 5;
            btnDeleteClass.Text = "Xóa";
            btnDeleteClass.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteClass.UseVisualStyleBackColor = false;
            btnDeleteClass.Click += btnDeleteClass_Click;
            // 
            // btnUdateClass
            // 
            btnUdateClass.BackColor = SystemColors.ActiveCaption;
            btnUdateClass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUdateClass.ImageIndex = 5;
            btnUdateClass.ImageList = imgIcon;
            btnUdateClass.Location = new Point(86, 14);
            btnUdateClass.Name = "btnUdateClass";
            btnUdateClass.Size = new Size(95, 66);
            btnUdateClass.TabIndex = 6;
            btnUdateClass.Text = "Sửa ";
            btnUdateClass.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUdateClass.UseVisualStyleBackColor = false;
            btnUdateClass.Click += btnUdateClass_Click;
            // 
            // btnAddClass
            // 
            btnAddClass.BackColor = SystemColors.ActiveCaption;
            btnAddClass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddClass.ImageIndex = 2;
            btnAddClass.ImageList = imgIcon;
            btnAddClass.Location = new Point(3, 14);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(96, 66);
            btnAddClass.TabIndex = 7;
            btnAddClass.Text = "Thêm ";
            btnAddClass.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddClass.UseVisualStyleBackColor = false;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.ButtonHighlight;
            panel13.Controls.Add(groupBox9);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(0, 44);
            panel13.Name = "panel13";
            panel13.Size = new Size(658, 353);
            panel13.TabIndex = 2;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(gvClass);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.Location = new Point(0, 0);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(658, 353);
            groupBox9.TabIndex = 0;
            groupBox9.TabStop = false;
            // 
            // gvClass
            // 
            gvClass.AllowUserToAddRows = false;
            gvClass.BackgroundColor = SystemColors.ControlLight;
            gvClass.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            gvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvClass.Dock = DockStyle.Fill;
            gvClass.Location = new Point(3, 19);
            gvClass.Name = "gvClass";
            gvClass.ReadOnly = true;
            gvClass.RowTemplate.Height = 25;
            gvClass.Size = new Size(652, 331);
            gvClass.TabIndex = 0;
            gvClass.CellClick += gvClass_CellClick;
            // 
            // panel14
            // 
            panel14.BackColor = SystemColors.ActiveCaption;
            panel14.Controls.Add(label3);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(658, 44);
            panel14.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.ImageIndex = 1;
            label3.ImageList = imgTitle;
            label3.Location = new Point(215, 0);
            label3.Name = "label3";
            label3.Size = new Size(255, 41);
            label3.TabIndex = 0;
            label3.Text = "Danh Sách Lớp Học";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imgIcon
            // 
            imgIcon.ColorDepth = ColorDepth.Depth32Bit;
            imgIcon.ImageStream = (ImageListStreamer)resources.GetObject("imgIcon.ImageStream");
            imgIcon.TransparentColor = Color.Transparent;
            imgIcon.Images.SetKeyName(0, "delete (1).png");
            imgIcon.Images.SetKeyName(1, "delete.png");
            imgIcon.Images.SetKeyName(2, "import.png");
            imgIcon.Images.SetKeyName(3, "insert.png");
            imgIcon.Images.SetKeyName(4, "refresh.png");
            imgIcon.Images.SetKeyName(5, "update.png");
            // 
            // BlockAndClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 488);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "BlockAndClass";
            Text = "BlockAndClass";
            Load += BlockAndClass_Load;
            panel1.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            panel17.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvBlock).EndInit();
            panel18.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox8.ResumeLayout(false);
            panel13.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvClass).EndInit();
            panel14.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imgTitle;
        private Panel panel1;
        private Panel panel3;
        private Panel panel11;
        private ComboBox comboBox2;
        private Button button6;
        private Panel panel13;
        private GroupBox groupBox9;
        private DataGridView gvClass;
        private Panel panel14;
        private Label label3;
        private Panel panel15;
        private Panel panel16;
        private GroupBox groupBox10;
        private Button btnDeleteBlock;
        private Button btnUpdateBlock;
        private Button btnAddBlock;
        private Panel panel17;
        private GroupBox groupBox11;
        private DataGridView gvBlock;
        private Label label6;
        private Panel panel18;
        private Label label8;
        private Panel panel12;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private Button btnDeleteClass;
        private Button btnUdateClass;
        private Button btnAddClass;
        private GroupBox groupBox12;
        private Button btnFind;
        private TextBox txtSearch;
        private ImageList imgIcon;
    }
}