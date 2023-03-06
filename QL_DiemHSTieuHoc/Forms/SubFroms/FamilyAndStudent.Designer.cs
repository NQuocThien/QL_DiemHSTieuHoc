namespace QL_DiemHSTieuHoc.Forms.SubFroms
{
    partial class FamilyAndStudent
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
            lblTitle = new Label();
            panel6 = new Panel();
            groupBox1 = new GroupBox();
            btnFind = new Button();
            txtName = new TextBox();
            cbClass = new ComboBox();
            rdbName = new RadioButton();
            rdbClass = new RadioButton();
            panel2 = new Panel();
            panel3 = new Panel();
            gvSubjectAccess = new DataGridView();
            panel5 = new Panel();
            btnRemove = new Button();
            btnAdd = new Button();
            panel4 = new Panel();
            gvStudent = new DataGridView();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvSubjectAccess).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvStudent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 57);
            panel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Highlight;
            lblTitle.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(41, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(337, 35);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Thông Tin Người Thân";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.GradientActiveCaption;
            panel6.Controls.Add(groupBox1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 57);
            panel6.Name = "panel6";
            panel6.Size = new Size(800, 115);
            panel6.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFind);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(cbClass);
            groupBox1.Controls.Add(rdbName);
            groupBox1.Controls.Add(rdbClass);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFind.Location = new Point(368, 28);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 58);
            btnFind.TabIndex = 3;
            btnFind.Text = "Lọc";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(140, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 27);
            txtName.TabIndex = 2;
            // 
            // cbClass
            // 
            cbClass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(140, 26);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(194, 26);
            cbClass.TabIndex = 1;
            cbClass.SelectedIndexChanged += cbClass_SelectedIndexChanged;
            // 
            // rdbName
            // 
            rdbName.AutoSize = true;
            rdbName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbName.Location = new Point(17, 64);
            rdbName.Name = "rdbName";
            rdbName.Size = new Size(102, 22);
            rdbName.TabIndex = 0;
            rdbName.Text = "Theo Tên";
            rdbName.UseVisualStyleBackColor = true;
            rdbName.CheckedChanged += rdbName_CheckedChanged;
            // 
            // rdbClass
            // 
            rdbClass.AutoSize = true;
            rdbClass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbClass.Location = new Point(17, 27);
            rdbClass.Name = "rdbClass";
            rdbClass.Size = new Size(101, 22);
            rdbClass.TabIndex = 0;
            rdbClass.Text = "Theo Lớp";
            rdbClass.UseVisualStyleBackColor = true;
            rdbClass.CheckedChanged += rdbClass_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 315);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(gvSubjectAccess);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(433, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 315);
            panel3.TabIndex = 1;
            // 
            // gvSubjectAccess
            // 
            gvSubjectAccess.AllowUserToAddRows = false;
            gvSubjectAccess.BackgroundColor = SystemColors.GradientInactiveCaption;
            gvSubjectAccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSubjectAccess.Dock = DockStyle.Fill;
            gvSubjectAccess.Location = new Point(0, 0);
            gvSubjectAccess.Name = "gvSubjectAccess";
            gvSubjectAccess.RowTemplate.Height = 25;
            gvSubjectAccess.Size = new Size(360, 315);
            gvSubjectAccess.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRemove);
            panel5.Controls.Add(btnAdd);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(362, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(71, 315);
            panel5.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.ButtonShadow;
            btnRemove.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Location = new Point(0, 165);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(71, 65);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "<<";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonShadow;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(0, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(71, 65);
            btnAdd.TabIndex = 0;
            btnAdd.Text = ">>";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(gvStudent);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(362, 315);
            panel4.TabIndex = 0;
            // 
            // gvStudent
            // 
            gvStudent.AllowUserToAddRows = false;
            gvStudent.BackgroundColor = SystemColors.GradientInactiveCaption;
            gvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvStudent.Dock = DockStyle.Fill;
            gvStudent.Location = new Point(0, 0);
            gvStudent.Name = "gvStudent";
            gvStudent.RowTemplate.Height = 25;
            gvStudent.Size = new Size(362, 315);
            gvStudent.TabIndex = 0;
            gvStudent.CellClick += gvStudent_CellClick;
            // 
            // FamilyAndStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "FamilyAndStudent";
            Text = "FamilyAndStudent";
            Load += FamilyAndStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvSubjectAccess).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel6;
        private GroupBox groupBox1;
        private Button btnFind;
        private TextBox txtName;
        private ComboBox cbClass;
        private RadioButton rdbName;
        private RadioButton rdbClass;
        private Panel panel2;
        private Panel panel3;
        private DataGridView gvSubjectAccess;
        private Panel panel5;
        private Button btnRemove;
        private Button btnAdd;
        private Panel panel4;
        private DataGridView gvStudent;
    }
}