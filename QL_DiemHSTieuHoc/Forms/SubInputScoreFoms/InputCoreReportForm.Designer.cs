namespace QL_DiemHSTieuHoc.Forms.SubInputScoreFoms
{
    partial class InputCoreReportForm
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
            lblClass = new Label();
            label1 = new Label();
            lblNamSudent = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            groupBox8 = new GroupBox();
            groupBox12 = new GroupBox();
            rdbUnite3 = new RadioButton();
            rdbUnite2 = new RadioButton();
            rdbUnite1 = new RadioButton();
            label10 = new Label();
            groupBox9 = new GroupBox();
            rdbHonest3 = new RadioButton();
            rdbHonest2 = new RadioButton();
            rdbHonest1 = new RadioButton();
            label7 = new Label();
            groupBox10 = new GroupBox();
            rdbReponsibilty3 = new RadioButton();
            rdbReponsibilty2 = new RadioButton();
            rdbReponsibilty1 = new RadioButton();
            label8 = new Label();
            groupBox11 = new GroupBox();
            rdbHardWork3 = new RadioButton();
            rdbHardWork2 = new RadioButton();
            rdbHardWork1 = new RadioButton();
            label9 = new Label();
            groupBox5 = new GroupBox();
            groupBox7 = new GroupBox();
            rdbSelfStudy3 = new RadioButton();
            rdbSelfStudy2 = new RadioButton();
            rdbSelfStudy1 = new RadioButton();
            label6 = new Label();
            groupBox6 = new GroupBox();
            rdbContact3 = new RadioButton();
            rdbContact2 = new RadioButton();
            rdbContact1 = new RadioButton();
            label5 = new Label();
            groupBox4 = new GroupBox();
            rdbSelfManager3 = new RadioButton();
            rdbSelfManager2 = new RadioButton();
            rdbSelfManager1 = new RadioButton();
            label4 = new Label();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            gvScoreImported = new DataGridView();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            btnDeleteResult = new Button();
            btnImport = new Button();
            label3 = new Label();
            cbScore = new ComboBox();
            label2 = new Label();
            txtScore = new TextBox();
            panel3 = new Panel();
            gvSuject = new DataGridView();
            btnExit = new Button();
            groupBox3 = new GroupBox();
            txtComment = new TextBox();
            label11 = new Label();
            btnSave = new Button();
            lblSemester = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvScoreImported).BeginInit();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvSuject).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(lblSemester);
            panel1.Controls.Add(lblClass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblNamSudent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 63);
            panel1.TabIndex = 0;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblClass.ForeColor = SystemColors.ButtonHighlight;
            lblClass.Location = new Point(608, 37);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(61, 23);
            lblClass.TabIndex = 0;
            lblClass.Text = "Lớp: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập Điểm";
            // 
            // lblNamSudent
            // 
            lblNamSudent.AutoSize = true;
            lblNamSudent.BackColor = SystemColors.Highlight;
            lblNamSudent.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNamSudent.ForeColor = SystemColors.Control;
            lblNamSudent.Location = new Point(77, 37);
            lblNamSudent.Name = "lblNamSudent";
            lblNamSudent.Size = new Size(147, 23);
            lblNamSudent.TabIndex = 0;
            lblNamSudent.Text = "Tên Học Sinh:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 468);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox8);
            panel6.Controls.Add(groupBox5);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(787, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(343, 468);
            panel6.TabIndex = 1;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(groupBox12);
            groupBox8.Controls.Add(groupBox9);
            groupBox8.Controls.Add(groupBox10);
            groupBox8.Controls.Add(groupBox11);
            groupBox8.Dock = DockStyle.Top;
            groupBox8.Location = new Point(0, 199);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(343, 266);
            groupBox8.TabIndex = 6;
            groupBox8.TabStop = false;
            groupBox8.Text = "Phẩm Chất";
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(rdbUnite3);
            groupBox12.Controls.Add(rdbUnite2);
            groupBox12.Controls.Add(rdbUnite1);
            groupBox12.Controls.Add(label10);
            groupBox12.Location = new Point(6, 196);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(325, 59);
            groupBox12.TabIndex = 2;
            groupBox12.TabStop = false;
            // 
            // rdbUnite3
            // 
            rdbUnite3.AutoSize = true;
            rdbUnite3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbUnite3.Location = new Point(267, 22);
            rdbUnite3.Name = "rdbUnite3";
            rdbUnite3.Size = new Size(52, 20);
            rdbUnite3.TabIndex = 2;
            rdbUnite3.TabStop = true;
            rdbUnite3.Text = "CCG";
            rdbUnite3.UseVisualStyleBackColor = true;
            // 
            // rdbUnite2
            // 
            rdbUnite2.AutoSize = true;
            rdbUnite2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbUnite2.Location = new Point(218, 22);
            rdbUnite2.Name = "rdbUnite2";
            rdbUnite2.Size = new Size(48, 20);
            rdbUnite2.TabIndex = 2;
            rdbUnite2.TabStop = true;
            rdbUnite2.Text = "Đạt";
            rdbUnite2.UseVisualStyleBackColor = true;
            // 
            // rdbUnite1
            // 
            rdbUnite1.AutoSize = true;
            rdbUnite1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbUnite1.Location = new Point(170, 22);
            rdbUnite1.Name = "rdbUnite1";
            rdbUnite1.Size = new Size(48, 20);
            rdbUnite1.TabIndex = 2;
            rdbUnite1.TabStop = true;
            rdbUnite1.Text = "Tốt";
            rdbUnite1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(6, 26);
            label10.Name = "label10";
            label10.Size = new Size(158, 16);
            label10.TabIndex = 1;
            label10.Text = "Đoàn Kết Yêu Thương:";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(rdbHonest3);
            groupBox9.Controls.Add(rdbHonest2);
            groupBox9.Controls.Add(rdbHonest1);
            groupBox9.Controls.Add(label7);
            groupBox9.Location = new Point(6, 136);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(325, 59);
            groupBox9.TabIndex = 2;
            groupBox9.TabStop = false;
            // 
            // rdbHonest3
            // 
            rdbHonest3.AutoSize = true;
            rdbHonest3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbHonest3.Location = new Point(267, 22);
            rdbHonest3.Name = "rdbHonest3";
            rdbHonest3.Size = new Size(52, 20);
            rdbHonest3.TabIndex = 2;
            rdbHonest3.TabStop = true;
            rdbHonest3.Text = "CCG";
            rdbHonest3.UseVisualStyleBackColor = true;
            // 
            // rdbHonest2
            // 
            rdbHonest2.AutoSize = true;
            rdbHonest2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbHonest2.Location = new Point(218, 22);
            rdbHonest2.Name = "rdbHonest2";
            rdbHonest2.Size = new Size(48, 20);
            rdbHonest2.TabIndex = 2;
            rdbHonest2.TabStop = true;
            rdbHonest2.Text = "Đạt";
            rdbHonest2.UseVisualStyleBackColor = true;
            // 
            // rdbHonest1
            // 
            rdbHonest1.AutoSize = true;
            rdbHonest1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbHonest1.Location = new Point(170, 22);
            rdbHonest1.Name = "rdbHonest1";
            rdbHonest1.Size = new Size(48, 20);
            rdbHonest1.TabIndex = 2;
            rdbHonest1.TabStop = true;
            rdbHonest1.Text = "Tốt";
            rdbHonest1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 26);
            label7.Name = "label7";
            label7.Size = new Size(144, 16);
            label7.TabIndex = 1;
            label7.Text = "Trung Thực Kỹ Luật:";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(rdbReponsibilty3);
            groupBox10.Controls.Add(rdbReponsibilty2);
            groupBox10.Controls.Add(rdbReponsibilty1);
            groupBox10.Controls.Add(label8);
            groupBox10.Location = new Point(6, 76);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(325, 59);
            groupBox10.TabIndex = 2;
            groupBox10.TabStop = false;
            // 
            // rdbReponsibilty3
            // 
            rdbReponsibilty3.AutoSize = true;
            rdbReponsibilty3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbReponsibilty3.Location = new Point(267, 22);
            rdbReponsibilty3.Name = "rdbReponsibilty3";
            rdbReponsibilty3.Size = new Size(52, 20);
            rdbReponsibilty3.TabIndex = 2;
            rdbReponsibilty3.TabStop = true;
            rdbReponsibilty3.Text = "CCG";
            rdbReponsibilty3.UseVisualStyleBackColor = true;
            // 
            // rdbReponsibilty2
            // 
            rdbReponsibilty2.AutoSize = true;
            rdbReponsibilty2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbReponsibilty2.Location = new Point(218, 22);
            rdbReponsibilty2.Name = "rdbReponsibilty2";
            rdbReponsibilty2.Size = new Size(48, 20);
            rdbReponsibilty2.TabIndex = 2;
            rdbReponsibilty2.TabStop = true;
            rdbReponsibilty2.Text = "Đạt";
            rdbReponsibilty2.UseVisualStyleBackColor = true;
            // 
            // rdbReponsibilty1
            // 
            rdbReponsibilty1.AutoSize = true;
            rdbReponsibilty1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbReponsibilty1.Location = new Point(170, 22);
            rdbReponsibilty1.Name = "rdbReponsibilty1";
            rdbReponsibilty1.Size = new Size(48, 20);
            rdbReponsibilty1.TabIndex = 2;
            rdbReponsibilty1.TabStop = true;
            rdbReponsibilty1.Text = "Tốt";
            rdbReponsibilty1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 26);
            label8.Name = "label8";
            label8.Size = new Size(142, 16);
            label8.TabIndex = 1;
            label8.Text = "Tự Tin Trách Nhiệm:";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(rdbHardWork3);
            groupBox11.Controls.Add(rdbHardWork2);
            groupBox11.Controls.Add(rdbHardWork1);
            groupBox11.Controls.Add(label9);
            groupBox11.Location = new Point(6, 16);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(325, 59);
            groupBox11.TabIndex = 2;
            groupBox11.TabStop = false;
            // 
            // rdbHardWork3
            // 
            rdbHardWork3.AutoSize = true;
            rdbHardWork3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbHardWork3.Location = new Point(267, 22);
            rdbHardWork3.Name = "rdbHardWork3";
            rdbHardWork3.Size = new Size(52, 20);
            rdbHardWork3.TabIndex = 2;
            rdbHardWork3.TabStop = true;
            rdbHardWork3.Text = "CCG";
            rdbHardWork3.UseVisualStyleBackColor = true;
            // 
            // rdbHardWork2
            // 
            rdbHardWork2.AutoSize = true;
            rdbHardWork2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbHardWork2.Location = new Point(218, 22);
            rdbHardWork2.Name = "rdbHardWork2";
            rdbHardWork2.Size = new Size(48, 20);
            rdbHardWork2.TabIndex = 2;
            rdbHardWork2.TabStop = true;
            rdbHardWork2.Text = "Đạt";
            rdbHardWork2.UseVisualStyleBackColor = true;
            // 
            // rdbHardWork1
            // 
            rdbHardWork1.AutoSize = true;
            rdbHardWork1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbHardWork1.Location = new Point(170, 22);
            rdbHardWork1.Name = "rdbHardWork1";
            rdbHardWork1.Size = new Size(48, 20);
            rdbHardWork1.TabIndex = 2;
            rdbHardWork1.TabStop = true;
            rdbHardWork1.Text = "Tốt";
            rdbHardWork1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 24);
            label9.Name = "label9";
            label9.Size = new Size(156, 16);
            label9.TabIndex = 1;
            label9.Text = "Chăm Học Chăm Làm :";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox7);
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Controls.Add(groupBox4);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(343, 199);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Năng Lực ";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(rdbSelfStudy3);
            groupBox7.Controls.Add(rdbSelfStudy2);
            groupBox7.Controls.Add(rdbSelfStudy1);
            groupBox7.Controls.Add(label6);
            groupBox7.Location = new Point(6, 130);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(325, 59);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            // 
            // rdbSelfStudy3
            // 
            rdbSelfStudy3.AutoSize = true;
            rdbSelfStudy3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSelfStudy3.Location = new Point(267, 22);
            rdbSelfStudy3.Name = "rdbSelfStudy3";
            rdbSelfStudy3.Size = new Size(52, 20);
            rdbSelfStudy3.TabIndex = 2;
            rdbSelfStudy3.TabStop = true;
            rdbSelfStudy3.Text = "CCG";
            rdbSelfStudy3.UseVisualStyleBackColor = true;
            // 
            // rdbSelfStudy2
            // 
            rdbSelfStudy2.AutoSize = true;
            rdbSelfStudy2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSelfStudy2.Location = new Point(218, 22);
            rdbSelfStudy2.Name = "rdbSelfStudy2";
            rdbSelfStudy2.Size = new Size(48, 20);
            rdbSelfStudy2.TabIndex = 2;
            rdbSelfStudy2.TabStop = true;
            rdbSelfStudy2.Text = "Đạt";
            rdbSelfStudy2.UseVisualStyleBackColor = true;
            // 
            // rdbSelfStudy1
            // 
            rdbSelfStudy1.AutoSize = true;
            rdbSelfStudy1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSelfStudy1.Location = new Point(170, 22);
            rdbSelfStudy1.Name = "rdbSelfStudy1";
            rdbSelfStudy1.Size = new Size(48, 20);
            rdbSelfStudy1.TabIndex = 2;
            rdbSelfStudy1.TabStop = true;
            rdbSelfStudy1.Text = "Tốt";
            rdbSelfStudy1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(137, 16);
            label6.TabIndex = 1;
            label6.Text = "Tự Học GQ Vấn Đề:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rdbContact3);
            groupBox6.Controls.Add(rdbContact2);
            groupBox6.Controls.Add(rdbContact1);
            groupBox6.Controls.Add(label5);
            groupBox6.Location = new Point(6, 72);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(325, 59);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            // 
            // rdbContact3
            // 
            rdbContact3.AutoSize = true;
            rdbContact3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbContact3.Location = new Point(267, 22);
            rdbContact3.Name = "rdbContact3";
            rdbContact3.Size = new Size(52, 20);
            rdbContact3.TabIndex = 2;
            rdbContact3.TabStop = true;
            rdbContact3.Text = "CCG";
            rdbContact3.UseVisualStyleBackColor = true;
            // 
            // rdbContact2
            // 
            rdbContact2.AutoSize = true;
            rdbContact2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbContact2.Location = new Point(218, 22);
            rdbContact2.Name = "rdbContact2";
            rdbContact2.Size = new Size(48, 20);
            rdbContact2.TabIndex = 2;
            rdbContact2.TabStop = true;
            rdbContact2.Text = "Đạt";
            rdbContact2.UseVisualStyleBackColor = true;
            // 
            // rdbContact1
            // 
            rdbContact1.AutoSize = true;
            rdbContact1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbContact1.Location = new Point(170, 22);
            rdbContact1.Name = "rdbContact1";
            rdbContact1.Size = new Size(48, 20);
            rdbContact1.TabIndex = 2;
            rdbContact1.TabStop = true;
            rdbContact1.Text = "Tốt";
            rdbContact1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(68, 16);
            label5.TabIndex = 1;
            label5.Text = "Hợp Tác:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rdbSelfManager3);
            groupBox4.Controls.Add(rdbSelfManager2);
            groupBox4.Controls.Add(rdbSelfManager1);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(6, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(325, 59);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // rdbSelfManager3
            // 
            rdbSelfManager3.AutoSize = true;
            rdbSelfManager3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSelfManager3.Location = new Point(267, 22);
            rdbSelfManager3.Name = "rdbSelfManager3";
            rdbSelfManager3.Size = new Size(52, 20);
            rdbSelfManager3.TabIndex = 2;
            rdbSelfManager3.TabStop = true;
            rdbSelfManager3.Text = "CCG";
            rdbSelfManager3.UseVisualStyleBackColor = true;
            // 
            // rdbSelfManager2
            // 
            rdbSelfManager2.AutoSize = true;
            rdbSelfManager2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSelfManager2.Location = new Point(218, 22);
            rdbSelfManager2.Name = "rdbSelfManager2";
            rdbSelfManager2.Size = new Size(48, 20);
            rdbSelfManager2.TabIndex = 2;
            rdbSelfManager2.TabStop = true;
            rdbSelfManager2.Text = "Đạt";
            rdbSelfManager2.UseVisualStyleBackColor = true;
            // 
            // rdbSelfManager1
            // 
            rdbSelfManager1.AutoSize = true;
            rdbSelfManager1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSelfManager1.Location = new Point(170, 22);
            rdbSelfManager1.Name = "rdbSelfManager1";
            rdbSelfManager1.Size = new Size(48, 20);
            rdbSelfManager1.TabIndex = 2;
            rdbSelfManager1.TabStop = true;
            rdbSelfManager1.Text = "Tốt";
            rdbSelfManager1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 24);
            label4.Name = "label4";
            label4.Size = new Size(151, 16);
            label4.TabIndex = 1;
            label4.Text = "Tự Phục Vụ, Tự Quản";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 468);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Điểm";
            // 
            // panel5
            // 
            panel5.Controls.Add(gvScoreImported);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(426, 19);
            panel5.Name = "panel5";
            panel5.Size = new Size(357, 446);
            panel5.TabIndex = 5;
            // 
            // gvScoreImported
            // 
            gvScoreImported.AllowUserToAddRows = false;
            gvScoreImported.BackgroundColor = SystemColors.Info;
            gvScoreImported.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvScoreImported.Dock = DockStyle.Fill;
            gvScoreImported.Location = new Point(0, 0);
            gvScoreImported.Name = "gvScoreImported";
            gvScoreImported.RowTemplate.Height = 25;
            gvScoreImported.Size = new Size(357, 446);
            gvScoreImported.TabIndex = 1;
            gvScoreImported.CellClick += gvScoreImported_CellClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(193, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 446);
            panel4.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDeleteResult);
            groupBox2.Controls.Add(btnImport);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cbScore);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtScore);
            groupBox2.Location = new Point(6, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(218, 331);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập điểm";
            // 
            // btnDeleteResult
            // 
            btnDeleteResult.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteResult.Location = new Point(33, 256);
            btnDeleteResult.Name = "btnDeleteResult";
            btnDeleteResult.Size = new Size(155, 42);
            btnDeleteResult.TabIndex = 3;
            btnDeleteResult.Text = "Xóa Đánh Giá";
            btnDeleteResult.UseVisualStyleBackColor = true;
            btnDeleteResult.Click += btnDeleteResult_Click;
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImport.Location = new Point(33, 187);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(155, 42);
            btnImport.TabIndex = 3;
            btnImport.Text = "Nhập";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 98);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Điểm:";
            // 
            // cbScore
            // 
            cbScore.DropDownStyle = ComboBoxStyle.DropDownList;
            cbScore.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbScore.FormattingEnabled = true;
            cbScore.Items.AddRange(new object[] { "HTT", "HT", "CHT" });
            cbScore.Location = new Point(33, 56);
            cbScore.Name = "cbScore";
            cbScore.Size = new Size(155, 26);
            cbScore.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 17);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 4;
            label2.Text = "Đánh Giá:";
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtScore.Location = new Point(33, 138);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(155, 27);
            txtScore.TabIndex = 2;
            txtScore.KeyPress += txtScore_KeyPress;
            // 
            // panel3
            // 
            panel3.Controls.Add(gvSuject);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(3, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 446);
            panel3.TabIndex = 0;
            // 
            // gvSuject
            // 
            gvSuject.AllowUserToAddRows = false;
            gvSuject.BackgroundColor = SystemColors.Info;
            gvSuject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSuject.Dock = DockStyle.Fill;
            gvSuject.Location = new Point(0, 0);
            gvSuject.Name = "gvSuject";
            gvSuject.RowTemplate.Height = 25;
            gvSuject.Size = new Size(190, 446);
            gvSuject.TabIndex = 0;
            gvSuject.CellClick += gvSuject_CellClick;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(680, 611);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(277, 41);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtComment);
            groupBox3.Controls.Add(label11);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(0, 531);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(657, 136);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComment.Location = new Point(18, 43);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(617, 70);
            txtComment.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(20, 20);
            label11.Name = "label11";
            label11.Size = new Size(84, 18);
            label11.TabIndex = 0;
            label11.Text = "Nhận Xét";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(680, 558);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(277, 41);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSemester.ForeColor = SystemColors.ButtonHighlight;
            lblSemester.Location = new Point(799, 37);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(86, 23);
            lblSemester.TabIndex = 0;
            lblSemester.Text = "Học Kỳ:";
            // 
            // InputCoreReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 667);
            Controls.Add(groupBox3);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "InputCoreReportForm";
            Text = "`";
            Load += InputCoreReportForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvScoreImported).EndInit();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvSuject).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblClass;
        private Label lblNamSudent;
        private Panel panel2;
        private GroupBox groupBox1;
        private Button btnExit;
        private Panel panel5;
        private DataGridView gvScoreImported;
        private Panel panel4;
        private TextBox txtScore;
        private ComboBox cbScore;
        private Button btnImport;
        private Panel panel3;
        private DataGridView gvSuject;
        private Label label1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnDeleteResult;
        private Panel panel6;
        private GroupBox groupBox8;
        private GroupBox groupBox12;
        private RadioButton rdbUnite3;
        private RadioButton rdbUnite2;
        private RadioButton rdbUnite1;
        private Label label10;
        private GroupBox groupBox9;
        private RadioButton rdbHonest3;
        private RadioButton rdbHonest2;
        private RadioButton rdbHonest1;
        private Label label7;
        private GroupBox groupBox10;
        private RadioButton rdbReponsibilty3;
        private RadioButton rdbReponsibilty2;
        private RadioButton rdbReponsibilty1;
        private Label label8;
        private GroupBox groupBox11;
        private RadioButton rdbHardWork3;
        private RadioButton rdbHardWork2;
        private RadioButton rdbHardWork1;
        private Label label9;
        private GroupBox groupBox5;
        private GroupBox groupBox7;
        private RadioButton rdbSelfStudy3;
        private RadioButton rdbSelfStudy2;
        private RadioButton rdbSelfStudy1;
        private Label label6;
        private GroupBox groupBox6;
        private RadioButton rdbContact3;
        private RadioButton rdbContact2;
        private RadioButton rdbContact1;
        private Label label5;
        private GroupBox groupBox4;
        private RadioButton rdbSelfManager3;
        private RadioButton rdbSelfManager2;
        private RadioButton rdbSelfManager1;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txtComment;
        private Label label11;
        private Button btnSave;
        private Label lblSemester;
    }
}