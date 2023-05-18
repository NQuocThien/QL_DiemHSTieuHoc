namespace QL_DiemHSTieuHoc.Forms.SubTeacherForms
{
    partial class TeacherAboutForm
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
            btnUpdate = new Button();
            panel3 = new Panel();
            btnDelete = new Button();
            cbSex = new ComboBox();
            dateBirth = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            label2 = new Label();
            txtAdress = new TextBox();
            txtSdt = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            cbTeacherBoss = new ComboBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(97, 18);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(251, 42);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Sửa thông tin";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 330);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 71);
            panel3.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(425, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(251, 42);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Xóa giáo viên";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbSex
            // 
            cbSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbSex.Location = new Point(81, 117);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(257, 29);
            cbSex.TabIndex = 27;
            // 
            // dateBirth
            // 
            dateBirth.CustomFormat = "yyyy-MM-dd";
            dateBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateBirth.Format = DateTimePickerFormat.Custom;
            dateBirth.Location = new Point(81, 181);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(257, 29);
            dateBirth.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(81, 89);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 20;
            label6.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(81, 153);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 21;
            label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(425, 97);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 22;
            label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(425, 34);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 23;
            label3.Text = "Số Điện Thoại";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 261);
            panel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbTeacherBoss);
            groupBox3.Controls.Add(cbSex);
            groupBox3.Controls.Add(dateBirth);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtAdress);
            groupBox3.Controls.Add(txtSdt);
            groupBox3.Controls.Add(txtName);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(800, 261);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin giáo viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(81, 27);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 24;
            label2.Text = "Họ và Tên:";
            // 
            // txtAdress
            // 
            txtAdress.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdress.Location = new Point(425, 118);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(262, 27);
            txtAdress.TabIndex = 16;
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdt.Location = new Point(425, 60);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(262, 27);
            txtSdt.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(81, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 27);
            txtName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 35);
            label1.TabIndex = 0;
            label1.Text = "Thông tin giáo viên";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 69);
            panel1.TabIndex = 3;
            // 
            // cbTeacherBoss
            // 
            cbTeacherBoss.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTeacherBoss.FormattingEnabled = true;
            cbTeacherBoss.Location = new Point(425, 181);
            cbTeacherBoss.Name = "cbTeacherBoss";
            cbTeacherBoss.Size = new Size(262, 26);
            cbTeacherBoss.TabIndex = 28;
            // 
            // TeacherAboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 404);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TeacherAboutForm";
            Text = "TeacherAboutForm";
            Load += TeacherAboutForm_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdate;
        private Panel panel3;
        private Button btnDelete;
        private ComboBox cbSex;
        private DateTimePicker dateBirth;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox txtAdress;
        private TextBox txtSdt;
        private TextBox txtName;
        private Label label1;
        private Panel panel1;
        private ComboBox cbTeacherBoss;
    }
}