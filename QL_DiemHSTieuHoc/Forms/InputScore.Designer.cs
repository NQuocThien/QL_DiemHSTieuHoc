namespace QL_DiemHSTieuHoc.Forms
{
    partial class InputScore
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
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            cbClass = new ComboBox();
            btnSearch = new Button();
            rdbClass = new RadioButton();
            rdbName = new RadioButton();
            txtName = new TextBox();
            panel5 = new Panel();
            groupBox4 = new GroupBox();
            groupBox6 = new GroupBox();
            gvReport = new DataGridView();
            groupBox5 = new GroupBox();
            cbSemester = new ComboBox();
            btnDelete = new Button();
            btnCreateReport = new Button();
            groupBox3 = new GroupBox();
            gvStudent = new DataGridView();
            btnImportReportSubject = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvReport).BeginInit();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvStudent).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1051, 102);
            panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1051, 102);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbClass);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(rdbClass);
            groupBox2.Controls.Add(rdbName);
            groupBox2.Controls.Add(txtName);
            groupBox2.Location = new Point(20, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(700, 82);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // cbClass
            // 
            cbClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(296, 44);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(240, 29);
            cbClass.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.Location = new Point(590, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 52);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // rdbClass
            // 
            rdbClass.AutoSize = true;
            rdbClass.Location = new Point(296, 20);
            rdbClass.Name = "rdbClass";
            rdbClass.Size = new Size(92, 19);
            rdbClass.TabIndex = 6;
            rdbClass.TabStop = true;
            rdbClass.Text = "Tìm theo lớp";
            rdbClass.UseVisualStyleBackColor = true;
            rdbClass.CheckedChanged += rdbClass_CheckedChanged;
            // 
            // rdbName
            // 
            rdbName.AutoSize = true;
            rdbName.Location = new Point(17, 21);
            rdbName.Name = "rdbName";
            rdbName.Size = new Size(93, 19);
            rdbName.TabIndex = 6;
            rdbName.TabStop = true;
            rdbName.Text = "Tìm theo Ten";
            rdbName.UseVisualStyleBackColor = true;
            rdbName.CheckedChanged += rdbName_CheckedChanged;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(17, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 27);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtSearch_TextChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 102);
            panel5.Name = "panel5";
            panel5.Size = new Size(1051, 332);
            panel5.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1051, 332);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin học sinh";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(gvReport);
            groupBox6.Dock = DockStyle.Left;
            groupBox6.Location = new Point(581, 19);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(464, 310);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh Sách Phiếu Đánh Giá Của HS:";
            // 
            // gvReport
            // 
            gvReport.AllowUserToAddRows = false;
            gvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvReport.Dock = DockStyle.Left;
            gvReport.Location = new Point(3, 19);
            gvReport.Name = "gvReport";
            gvReport.RowTemplate.Height = 25;
            gvReport.Size = new Size(456, 288);
            gvReport.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbSemester);
            groupBox5.Controls.Add(btnDelete);
            groupBox5.Controls.Add(btnCreateReport);
            groupBox5.Dock = DockStyle.Left;
            groupBox5.Location = new Point(496, 19);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(85, 310);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            // 
            // cbSemester
            // 
            cbSemester.FormattingEnabled = true;
            cbSemester.Items.AddRange(new object[] { "HK I", "HK II", "HK III" });
            cbSemester.Location = new Point(5, 22);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(77, 23);
            cbSemester.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(6, 217);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 68);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreateReport
            // 
            btnCreateReport.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateReport.Location = new Point(6, 61);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(75, 127);
            btnCreateReport.TabIndex = 0;
            btnCreateReport.Text = "Tạo Thêm Phiếu Đánh Giá";
            btnCreateReport.UseVisualStyleBackColor = true;
            btnCreateReport.Click += btnCreateReport_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(gvStudent);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(3, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(493, 310);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Học Sinh";
            // 
            // gvStudent
            // 
            gvStudent.AllowUserToAddRows = false;
            gvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvStudent.Dock = DockStyle.Left;
            gvStudent.Location = new Point(3, 19);
            gvStudent.Name = "gvStudent";
            gvStudent.RowTemplate.Height = 25;
            gvStudent.Size = new Size(490, 288);
            gvStudent.TabIndex = 2;
            gvStudent.CellClick += gvStudent_CellClick;
            gvStudent.CellContentClick += gvStudent_CellContentClick;
            // 
            // btnImportReportSubject
            // 
            btnImportReportSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImportReportSubject.Location = new Point(361, 26);
            btnImportReportSubject.Name = "btnImportReportSubject";
            btnImportReportSubject.Size = new Size(391, 43);
            btnImportReportSubject.TabIndex = 0;
            btnImportReportSubject.Text = "Đánh Giá Môn Học";
            btnImportReportSubject.UseVisualStyleBackColor = true;
            btnImportReportSubject.Click += btnImportReportSubject_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 515);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnImportReportSubject);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(1051, 89);
            panel2.TabIndex = 1;
            // 
            // InputScore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 515);
            Controls.Add(panel1);
            Name = "InputScore";
            Text = "Nhập Điểm";
            Load += InputScore_Load;
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvReport).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvStudent).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private GroupBox groupBox1;
        private RadioButton rdbClass;
        private GroupBox groupBox2;
        private RadioButton rdbName;
        private TextBox txtName;
        private Button btnSearch;
        private Panel panel5;
        private Button btnImportReportSubject;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox4;
        private ComboBox cbClass;
        private GroupBox groupBox5;
        private GroupBox groupBox3;
        private DataGridView gvStudent;
        private GroupBox groupBox6;
        private DataGridView gvReport;
        private Button btnCreateReport;
        private ComboBox cbSemester;
        private Button btnDelete;
    }
}