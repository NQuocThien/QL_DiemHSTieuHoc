namespace QL_DiemHSTieuHoc.Forms
{
    partial class Teacher
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
            gvClassAccess = new GroupBox();
            gvTeacher = new DataGridView();
            groupBox5 = new GroupBox();
            btnAbout = new Button();
            btnTakeSubject = new Button();
            bttnTakeClass = new Button();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            gvSubject = new DataGridView();
            panel7 = new Panel();
            panel2 = new Panel();
            panel10 = new Panel();
            groupBox4 = new GroupBox();
            gvClass = new DataGridView();
            panel9 = new Panel();
            panel8 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            groupBox8 = new GroupBox();
            btnAddSubject = new Button();
            btnUpdate = new Button();
            btnDeleteSubject = new Button();
            label1 = new Label();
            txtSubjectName = new TextBox();
            groupBox7 = new GroupBox();
            gv_ListSubject = new DataGridView();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            gvClassAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvTeacher).BeginInit();
            groupBox5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvSubject).BeginInit();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvClass).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gv_ListSubject).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gvClassAccess
            // 
            gvClassAccess.Controls.Add(gvTeacher);
            gvClassAccess.Dock = DockStyle.Fill;
            gvClassAccess.Location = new Point(0, 0);
            gvClassAccess.Name = "gvClassAccess";
            gvClassAccess.Size = new Size(476, 301);
            gvClassAccess.TabIndex = 0;
            gvClassAccess.TabStop = false;
            gvClassAccess.Text = "Danh Sách Giáo Viên";
            // 
            // gvTeacher
            // 
            gvTeacher.AllowUserToAddRows = false;
            gvTeacher.BackgroundColor = Color.LavenderBlush;
            gvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTeacher.Dock = DockStyle.Fill;
            gvTeacher.Location = new Point(3, 19);
            gvTeacher.Name = "gvTeacher";
            gvTeacher.RowTemplate.Height = 25;
            gvTeacher.Size = new Size(470, 279);
            gvTeacher.TabIndex = 1;
            gvTeacher.CellClick += gvTeacher_CellClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnAbout);
            groupBox5.Controls.Add(btnTakeSubject);
            groupBox5.Controls.Add(bttnTakeClass);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(302, 193);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức Năng";
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.Location = new Point(36, 147);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(222, 43);
            btnAbout.TabIndex = 0;
            btnAbout.Text = "Chi Tiết";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnTakeSubject
            // 
            btnTakeSubject.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTakeSubject.Location = new Point(36, 85);
            btnTakeSubject.Name = "btnTakeSubject";
            btnTakeSubject.Size = new Size(222, 43);
            btnTakeSubject.TabIndex = 0;
            btnTakeSubject.Text = "Phân công môn";
            btnTakeSubject.UseVisualStyleBackColor = true;
            btnTakeSubject.Click += btnTakeSubject_Click;
            // 
            // bttnTakeClass
            // 
            bttnTakeClass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bttnTakeClass.Location = new Point(36, 22);
            bttnTakeClass.Name = "bttnTakeClass";
            bttnTakeClass.Size = new Size(222, 43);
            bttnTakeClass.TabIndex = 0;
            bttnTakeClass.Text = "Phân công lớp";
            bttnTakeClass.UseVisualStyleBackColor = true;
            bttnTakeClass.Click += bttnTakeSubject_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 301);
            panel4.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvSubject);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 301);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhiệm vụ";
            // 
            // gvSubject
            // 
            gvSubject.AllowUserToAddRows = false;
            gvSubject.BackgroundColor = Color.LavenderBlush;
            gvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSubject.Dock = DockStyle.Fill;
            gvSubject.Location = new Point(3, 19);
            gvSubject.Name = "gvSubject";
            gvSubject.RowTemplate.Height = 25;
            gvSubject.Size = new Size(296, 279);
            gvSubject.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(groupBox5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 301);
            panel7.Name = "panel7";
            panel7.Size = new Size(302, 193);
            panel7.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(573, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 504);
            panel2.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.Controls.Add(groupBox4);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 301);
            panel10.Name = "panel10";
            panel10.Size = new Size(476, 180);
            panel10.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(gvClass);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(476, 180);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh Sách Lớp Dạy";
            // 
            // gvClass
            // 
            gvClass.AllowUserToAddRows = false;
            gvClass.BackgroundColor = Color.LavenderBlush;
            gvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvClass.Dock = DockStyle.Fill;
            gvClass.Location = new Point(3, 19);
            gvClass.Name = "gvClass";
            gvClass.RowTemplate.Height = 25;
            gvClass.Size = new Size(470, 158);
            gvClass.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(gvClassAccess);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(476, 301);
            panel9.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel7);
            panel8.Controls.Add(panel4);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(271, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(302, 504);
            panel8.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 504);
            panel1.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(groupBox8);
            panel5.Controls.Add(groupBox7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 73);
            panel5.Name = "panel5";
            panel5.Size = new Size(271, 421);
            panel5.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btnAddSubject);
            groupBox8.Controls.Add(btnUpdate);
            groupBox8.Controls.Add(btnDeleteSubject);
            groupBox8.Controls.Add(label1);
            groupBox8.Controls.Add(txtSubjectName);
            groupBox8.Dock = DockStyle.Fill;
            groupBox8.Location = new Point(0, 254);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(271, 167);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            groupBox8.Text = "Control";
            // 
            // btnAddSubject
            // 
            btnAddSubject.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSubject.Location = new Point(12, 97);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(100, 39);
            btnAddSubject.TabIndex = 2;
            btnAddSubject.Text = "Thêm Môn";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(119, 97);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(70, 39);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sủa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteSubject.Location = new Point(195, 97);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Size = new Size(70, 39);
            btnDeleteSubject.TabIndex = 2;
            btnDeleteSubject.Text = "Xóa ";
            btnDeleteSubject.UseVisualStyleBackColor = true;
            btnDeleteSubject.Click += btnDeleteSubject_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(120, 18);
            label1.TabIndex = 1;
            label1.Text = "Tên môn học:";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubjectName.Location = new Point(12, 59);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(231, 27);
            txtSubjectName.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(gv_ListSubject);
            groupBox7.Dock = DockStyle.Top;
            groupBox7.Location = new Point(0, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(271, 254);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Danh Sách Môn Học";
            // 
            // gv_ListSubject
            // 
            gv_ListSubject.AllowUserToAddRows = false;
            gv_ListSubject.BackgroundColor = SystemColors.ButtonFace;
            gv_ListSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_ListSubject.Dock = DockStyle.Fill;
            gv_ListSubject.Location = new Point(3, 19);
            gv_ListSubject.Name = "gv_ListSubject";
            gv_ListSubject.RowTemplate.Height = 25;
            gv_ListSubject.Size = new Size(265, 232);
            gv_ListSubject.TabIndex = 0;
            gv_ListSubject.CellClick += gv_ListSubject_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 73);
            panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 73);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.Location = new Point(181, 24);
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
            txtSearch.Location = new Point(10, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 27);
            txtSearch.TabIndex = 4;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 504);
            Controls.Add(panel2);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "Teacher";
            Text = "Teacher";
            Load += Teacher_Load;
            gvClassAccess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvTeacher).EndInit();
            groupBox5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvSubject).EndInit();
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvClass).EndInit();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gv_ListSubject).EndInit();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gvClassAccess;
        private DataGridView gvTeacher;
        private GroupBox groupBox5;
        private Button btnAdd;
        private Panel panel4;
        private Panel panel7;
        private Panel panel2;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel1;
        private Panel panel5;
        private Panel panel3;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnAbout;
        private Button btnTakeSubject;
        private Button bttnTakeClass;
        private GroupBox groupBox2;
        private DataGridView gvSubject;
        private GroupBox groupBox4;
        private DataGridView gvClass;
        private GroupBox groupBox3;
        private GroupBox groupBox6;
        private ComboBox cbSex;
        private DateTimePicker dateBirth;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtAdress;
        private TextBox txtSdt;
        private TextBox txtName;
        private GroupBox groupBox8;
        private Button btnAddSubject;
        private Button btnDeleteSubject;
        private Label label1;
        private TextBox txtSubjectName;
        private GroupBox groupBox7;
        private DataGridView gv_ListSubject;
        private Button btnUpdate;
    }
}