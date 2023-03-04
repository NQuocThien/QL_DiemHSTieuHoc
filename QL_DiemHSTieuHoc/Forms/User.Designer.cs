namespace QL_DiemHSTieuHoc.Forms
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            panel1 = new Panel();
            panel5 = new Panel();
            groupBox4 = new GroupBox();
            btnSave = new Button();
            btnUpdateEmail = new Button();
            btnUpdatePass = new Button();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            txtType = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel8 = new Panel();
            groupBox3 = new GroupBox();
            btnLaw = new Button();
            cbLaw = new ComboBox();
            groupBox5 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel7 = new Panel();
            groupBox2 = new GroupBox();
            gvListUser = new DataGridView();
            panel6 = new Panel();
            label2 = new Label();
            imgTitle = new ImageList(components);
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            groupBox4.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            panel7.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvListUser).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 488);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.Controls.Add(groupBox4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 391);
            panel5.Name = "panel5";
            panel5.Size = new Size(379, 97);
            panel5.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSave);
            groupBox4.Controls.Add(btnUpdateEmail);
            groupBox4.Controls.Add(btnUpdatePass);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(379, 97);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.NavajoWhite;
            btnSave.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(269, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 61);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdateEmail
            // 
            btnUpdateEmail.Anchor = AnchorStyles.None;
            btnUpdateEmail.BackColor = Color.NavajoWhite;
            btnUpdateEmail.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateEmail.Location = new Point(146, 25);
            btnUpdateEmail.Name = "btnUpdateEmail";
            btnUpdateEmail.Size = new Size(104, 60);
            btnUpdateEmail.TabIndex = 0;
            btnUpdateEmail.Text = "Đổi Email";
            btnUpdateEmail.UseVisualStyleBackColor = false;
            btnUpdateEmail.Click += btnUpdateEmail_Click;
            // 
            // btnUpdatePass
            // 
            btnUpdatePass.Anchor = AnchorStyles.None;
            btnUpdatePass.BackColor = Color.NavajoWhite;
            btnUpdatePass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdatePass.Location = new Point(12, 25);
            btnUpdatePass.Name = "btnUpdatePass";
            btnUpdatePass.Size = new Size(115, 61);
            btnUpdatePass.TabIndex = 0;
            btnUpdatePass.Text = "Đổi Mật Khẩu";
            btnUpdatePass.UseVisualStyleBackColor = false;
            btnUpdatePass.Click += btnUpdatePass_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(379, 347);
            panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtType);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 347);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtType
            // 
            txtType.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtType.Location = new Point(46, 282);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(275, 27);
            txtType.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(46, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(46, 143);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(275, 27);
            txtPass.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(46, 71);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(275, 27);
            txtName.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(12, 253);
            label6.Name = "label6";
            label6.Size = new Size(137, 18);
            label6.TabIndex = 0;
            label6.Text = "Loại Tài Khoản:";
            label6.Click += label3_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(12, 182);
            label5.Name = "label5";
            label5.Size = new Size(60, 18);
            label5.TabIndex = 0;
            label5.Text = "Email:";
            label5.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(92, 18);
            label4.TabIndex = 0;
            label4.Text = "Mật Khẩu:";
            label4.Click += label3_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 40);
            label3.Name = "label3";
            label3.Size = new Size(141, 18);
            label3.TabIndex = 0;
            label3.Text = "Tên Đăng Nhập:";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.NavajoWhite;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 44);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.ImageIndex = 0;
            label1.ImageList = imgTitle;
            label1.Location = new Point(56, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 41);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Tài Khoản";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(379, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(658, 488);
            panel2.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonFace;
            panel8.Controls.Add(groupBox3);
            panel8.Controls.Add(groupBox5);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 397);
            panel8.Name = "panel8";
            panel8.Size = new Size(658, 100);
            panel8.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLaw);
            groupBox3.Controls.Add(cbLaw);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(249, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(409, 100);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // btnLaw
            // 
            btnLaw.BackColor = SystemColors.ActiveCaption;
            btnLaw.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLaw.Location = new Point(304, 14);
            btnLaw.Name = "btnLaw";
            btnLaw.Size = new Size(83, 66);
            btnLaw.TabIndex = 6;
            btnLaw.Text = "Cấp Quyền";
            btnLaw.UseVisualStyleBackColor = false;
            btnLaw.Click += btnLaw_Click;
            // 
            // cbLaw
            // 
            cbLaw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLaw.FormattingEnabled = true;
            cbLaw.Location = new Point(43, 41);
            cbLaw.Name = "cbLaw";
            cbLaw.Size = new Size(221, 29);
            cbLaw.TabIndex = 5;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnDelete);
            groupBox5.Controls.Add(btnUpdate);
            groupBox5.Controls.Add(btnAdd);
            groupBox5.Dock = DockStyle.Left;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(249, 100);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(168, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 66);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(86, 14);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 66);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Sửa ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(3, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 66);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Controls.Add(groupBox2);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 44);
            panel7.Name = "panel7";
            panel7.Size = new Size(658, 353);
            panel7.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvListUser);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(658, 353);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // gvListUser
            // 
            gvListUser.AllowUserToAddRows = false;
            gvListUser.BackgroundColor = SystemColors.ControlLight;
            gvListUser.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            gvListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvListUser.Dock = DockStyle.Fill;
            gvListUser.Location = new Point(3, 19);
            gvListUser.Name = "gvListUser";
            gvListUser.RowTemplate.Height = 25;
            gvListUser.Size = new Size(652, 331);
            gvListUser.TabIndex = 0;
            gvListUser.CellClick += gvListUser_CellClick;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(658, 44);
            panel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.ImageIndex = 1;
            label2.ImageList = imgTitle;
            label2.Location = new Point(233, 0);
            label2.Name = "label2";
            label2.Size = new Size(280, 41);
            label2.TabIndex = 0;
            label2.Text = "Danh Sách Tài Khoản";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imgTitle
            // 
            imgTitle.ColorDepth = ColorDepth.Depth32Bit;
            imgTitle.ImageStream = (ImageListStreamer)resources.GetObject("imgTitle.ImageStream");
            imgTitle.TransparentColor = Color.Transparent;
            imgTitle.Images.SetKeyName(0, "programmer.png");
            imgTitle.Images.SetKeyName(1, "checklist.png");
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 488);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "User";
            Text = "User";
            Load += User_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvListUser).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private GroupBox groupBox4;
        private Panel panel4;
        private GroupBox groupBox1;
        private Label label3;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Panel panel8;
        private GroupBox groupBox5;
        private Panel panel7;
        private GroupBox groupBox2;
        private Panel panel6;
        private Label label2;
        private Button btnSave;
        private Button btnUpdateEmail;
        private Button btnUpdatePass;
        private TextBox txtType;
        private TextBox txtEmail;
        private TextBox txtPass;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView gvListUser;
        private GroupBox groupBox3;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbLaw;
        private Button btnLaw;
        private ImageList imgTitle;
    }
}