namespace QL_DiemHSTieuHoc.Forms.SubTeacherForms
{
    partial class TeacherTakeSubject
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
            panel2 = new Panel();
            panel3 = new Panel();
            gvSubjectAccess = new DataGridView();
            panel5 = new Panel();
            btnRemove = new Button();
            btnAdd = new Button();
            panel4 = new Panel();
            gvSubject = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvSubjectAccess).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvSubject).BeginInit();
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
            panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Highlight;
            lblTitle.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(41, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(305, 35);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Phân Công Môn Cho";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 315);
            panel2.TabIndex = 3;
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
            panel4.Controls.Add(gvSubject);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(362, 315);
            panel4.TabIndex = 0;
            // 
            // gvSubject
            // 
            gvSubject.BackgroundColor = SystemColors.GradientInactiveCaption;
            gvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSubject.Dock = DockStyle.Fill;
            gvSubject.Location = new Point(0, 0);
            gvSubject.Name = "gvSubject";
            gvSubject.RowTemplate.Height = 25;
            gvSubject.Size = new Size(362, 315);
            gvSubject.TabIndex = 0;
            // 
            // TeacherTakeSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 379);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TeacherTakeSubject";
            Text = "TeacherTakeSubject";
            Load += TeacherTakeSubject_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvSubjectAccess).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private Panel panel3;
        private DataGridView gvSubjectAccess;
        private Panel panel5;
        private Button btnRemove;
        private Button btnAdd;
        private Panel panel4;
        private DataGridView gvSubject;
    }
}