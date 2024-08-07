﻿namespace QL_DiemHSTieuHoc.Forms
{
    partial class Student
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
            panel6 = new Panel();
            groupBox3 = new GroupBox();
            cbSex = new ComboBox();
            dateBirth = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtAdress = new TextBox();
            txtSdt = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            cbClass = new ComboBox();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel8 = new Panel();
            panel7 = new Panel();
            groupBox5 = new GroupBox();
            btnAdd = new Button();
            btnAbout = new Button();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            gvParent = new DataGridView();
            panel2 = new Panel();
            panel9 = new Panel();
            groupBox4 = new GroupBox();
            gvStudent = new DataGridView();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            groupBox5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvParent).BeginInit();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvStudent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 515);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 94);
            panel5.Name = "panel5";
            panel5.Size = new Size(307, 394);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox3);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(295, 394);
            panel6.TabIndex = 2;
            // 
            // groupBox3
            // 
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
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cbClass);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(295, 394);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin học sinh";
            // 
            // cbSex
            // 
            cbSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbSex.Location = new Point(22, 362);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(257, 29);
            cbSex.TabIndex = 27;
            // 
            // dateBirth
            // 
            dateBirth.CustomFormat = "yyyy-MM-dd";
            dateBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateBirth.Format = DateTimePickerFormat.Custom;
            dateBirth.Location = new Point(22, 298);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(257, 29);
            dateBirth.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 334);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 20;
            label6.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 271);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 21;
            label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 208);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 22;
            label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 145);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 23;
            label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 24;
            label2.Text = "Họ và Tên:";
            // 
            // txtAdress
            // 
            txtAdress.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdress.Location = new Point(22, 229);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(262, 27);
            txtAdress.TabIndex = 16;
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdt.Location = new Point(22, 171);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(262, 27);
            txtSdt.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(22, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 27);
            txtName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 25;
            label1.Text = "Lớp:";
            // 
            // cbClass
            // 
            cbClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(22, 43);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(262, 29);
            cbClass.TabIndex = 19;
            cbClass.SelectedIndexChanged += cbClass_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 94);
            panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.Location = new Point(208, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 32);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(20, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 27);
            txtSearch.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel7);
            panel8.Controls.Add(panel4);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(307, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(265, 515);
            panel8.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(groupBox5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 323);
            panel7.Name = "panel7";
            panel7.Size = new Size(265, 189);
            panel7.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnAdd);
            groupBox5.Controls.Add(btnAbout);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(265, 189);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức Năng";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(23, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(222, 52);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm Học Sinh Vào Lớp";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.Location = new Point(23, 124);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(218, 38);
            btnAbout.TabIndex = 0;
            btnAbout.Text = "Chi Tiết";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(265, 323);
            panel4.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvParent);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 323);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Phụ Huynh";
            // 
            // gvParent
            // 
            gvParent.AllowUserToAddRows = false;
            gvParent.BackgroundColor = Color.LavenderBlush;
            gvParent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvParent.Dock = DockStyle.Fill;
            gvParent.Location = new Point(3, 19);
            gvParent.Name = "gvParent";
            gvParent.RowTemplate.Height = 25;
            gvParent.Size = new Size(259, 301);
            gvParent.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel9);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(572, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 515);
            panel2.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Controls.Add(groupBox4);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(476, 515);
            panel9.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(gvStudent);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(476, 515);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin học sinh:";
            // 
            // gvStudent
            // 
            gvStudent.AllowUserToAddRows = false;
            gvStudent.BackgroundColor = Color.LavenderBlush;
            gvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvStudent.Dock = DockStyle.Fill;
            gvStudent.Location = new Point(3, 19);
            gvStudent.Name = "gvStudent";
            gvStudent.RowTemplate.Height = 25;
            gvStudent.Size = new Size(470, 493);
            gvStudent.TabIndex = 1;
            gvStudent.CellClick += gvStudent_CellClick;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 515);
            Controls.Add(panel2);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvParent).EndInit();
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel3;
        private GroupBox groupBox1;
        private Panel panel6;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox txtAdress;
        private TextBox txtSdt;
        private TextBox txtName;
        private Label label1;
        private ComboBox cbClass;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel8;
        private Panel panel7;
        private Panel panel4;
        private Panel panel2;
        private GroupBox groupBox2;
        private Button button2;
        private Button btnAdd;
        private Button btnAbout;
        private Panel panel9;
        private DataGridView dataGridView1;
        private ComboBox cbSex;
        private DateTimePicker dateBirth;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private DataGridView gvStudent;
        private DataGridView gvParent;
    }
}