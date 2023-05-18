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
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            gvScoreImported = new DataGridView();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            txtScore = new TextBox();
            cbScore = new ComboBox();
            btnImport = new Button();
            panel3 = new Panel();
            gvSuject = new DataGridView();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvScoreImported).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvSuject).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(lblClass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblNamSudent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 63);
            panel1.TabIndex = 0;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblClass.ForeColor = SystemColors.ButtonHighlight;
            lblClass.Location = new Point(679, 17);
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
            label1.Location = new Point(31, 17);
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
            lblNamSudent.Location = new Point(211, 17);
            lblNamSudent.Name = "lblNamSudent";
            lblNamSudent.Size = new Size(147, 23);
            lblNamSudent.TabIndex = 0;
            lblNamSudent.Text = "Tên Học Sinh:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 468);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1048, 468);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Điểm";
            // 
            // panel5
            // 
            panel5.Controls.Add(gvScoreImported);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(562, 19);
            panel5.Name = "panel5";
            panel5.Size = new Size(474, 446);
            panel5.TabIndex = 5;
            // 
            // gvScoreImported
            // 
            gvScoreImported.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvScoreImported.Dock = DockStyle.Fill;
            gvScoreImported.Location = new Point(0, 0);
            gvScoreImported.Name = "gvScoreImported";
            gvScoreImported.RowTemplate.Height = 25;
            gvScoreImported.Size = new Size(474, 446);
            gvScoreImported.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtScore);
            panel4.Controls.Add(cbScore);
            panel4.Controls.Add(btnImport);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(368, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 446);
            panel4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 108);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Điểm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 4;
            label2.Text = "Đánh Giá:";
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtScore.Location = new Point(11, 148);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(155, 27);
            txtScore.TabIndex = 2;
            // 
            // cbScore
            // 
            cbScore.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbScore.FormattingEnabled = true;
            cbScore.Location = new Point(11, 66);
            cbScore.Name = "cbScore";
            cbScore.Size = new Size(155, 26);
            cbScore.TabIndex = 1;
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImport.Location = new Point(45, 213);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(89, 42);
            btnImport.TabIndex = 3;
            btnImport.Text = "Nhập";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(gvSuject);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(3, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(365, 446);
            panel3.TabIndex = 0;
            // 
            // gvSuject
            // 
            gvSuject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSuject.Dock = DockStyle.Fill;
            gvSuject.Location = new Point(0, 0);
            gvSuject.Name = "gvSuject";
            gvSuject.RowTemplate.Height = 25;
            gvSuject.Size = new Size(365, 446);
            gvSuject.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(199, 537);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(517, 41);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // InputCoreReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 590);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "InputCoreReportForm";
            Text = "`";
            Load += InputCoreReportForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvScoreImported).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvSuject).EndInit();
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
    }
}