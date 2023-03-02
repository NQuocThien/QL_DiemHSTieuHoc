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
            groupBox5 = new GroupBox();
            btnProvideLaw = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel7 = new Panel();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            gvListUser = new DataGridView();
            panel6 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            groupBox4.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
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
            panel5.Location = new Point(0, 387);
            panel5.Name = "panel5";
            panel5.Size = new Size(379, 100);
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
            groupBox4.Size = new Size(379, 100);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "control";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(118, 59);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdateEmail
            // 
            btnUpdateEmail.Anchor = AnchorStyles.None;
            btnUpdateEmail.BackColor = SystemColors.ActiveBorder;
            btnUpdateEmail.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateEmail.Location = new Point(210, 19);
            btnUpdateEmail.Name = "btnUpdateEmail";
            btnUpdateEmail.Size = new Size(104, 36);
            btnUpdateEmail.TabIndex = 0;
            btnUpdateEmail.Text = "Đổi Email";
            btnUpdateEmail.UseVisualStyleBackColor = false;
            btnUpdateEmail.Click += btnUpdateEmail_Click;
            // 
            // btnUpdatePass
            // 
            btnUpdatePass.Anchor = AnchorStyles.None;
            btnUpdatePass.BackColor = SystemColors.ActiveBorder;
            btnUpdatePass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdatePass.Location = new Point(27, 19);
            btnUpdatePass.Name = "btnUpdatePass";
            btnUpdatePass.Size = new Size(148, 36);
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
            panel4.Location = new Point(0, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(379, 319);
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
            groupBox1.Size = new Size(379, 319);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "infor";
            // 
            // txtType
            // 
            txtType.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtType.Location = new Point(52, 261);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(275, 27);
            txtType.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(52, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(52, 131);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(275, 27);
            txtPass.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(52, 66);
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
            label6.Location = new Point(12, 240);
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
            label5.Location = new Point(12, 175);
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
            label4.Location = new Point(12, 110);
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
            label3.Location = new Point(12, 45);
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
            panel3.Size = new Size(379, 68);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(58, 19);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Tài Khoản";
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
            panel8.Controls.Add(groupBox5);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 387);
            panel8.Name = "panel8";
            panel8.Size = new Size(658, 100);
            panel8.TabIndex = 3;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnProvideLaw);
            groupBox5.Controls.Add(btnDelete);
            groupBox5.Controls.Add(btnUpdate);
            groupBox5.Controls.Add(btnAdd);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(658, 100);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "control";
            // 
            // btnProvideLaw
            // 
            btnProvideLaw.Anchor = AnchorStyles.None;
            btnProvideLaw.BackColor = SystemColors.ActiveBorder;
            btnProvideLaw.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProvideLaw.Location = new Point(462, 24);
            btnProvideLaw.Name = "btnProvideLaw";
            btnProvideLaw.Size = new Size(156, 65);
            btnProvideLaw.TabIndex = 0;
            btnProvideLaw.Text = "Cấp Quyền";
            btnProvideLaw.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = SystemColors.ActiveBorder;
            btnDelete.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(305, 24);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 65);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = SystemColors.ActiveBorder;
            btnUpdate.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(166, 24);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 67);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Sửa ";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = SystemColors.ActiveBorder;
            btnAdd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(34, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 69);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Controls.Add(groupBox3);
            panel7.Controls.Add(groupBox2);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 68);
            panel7.Name = "panel7";
            panel7.Size = new Size(658, 319);
            panel7.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(82, 316);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvListUser);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(658, 319);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "list";
            // 
            // gvListUser
            // 
            gvListUser.Anchor = AnchorStyles.None;
            gvListUser.BackgroundColor = SystemColors.ControlLight;
            gvListUser.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            gvListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvListUser.Location = new Point(3, 19);
            gvListUser.Name = "gvListUser";
            gvListUser.RowTemplate.Height = 25;
            gvListUser.Size = new Size(652, 297);
            gvListUser.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(658, 68);
            panel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(235, 19);
            label2.Name = "label2";
            label2.Size = new Size(238, 25);
            label2.TabIndex = 0;
            label2.Text = "Danh Sách Tài Khoản";
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
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvListUser).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private GroupBox groupBox3;
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
        private Button btnProvideLaw;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView gvListUser;
    }
}