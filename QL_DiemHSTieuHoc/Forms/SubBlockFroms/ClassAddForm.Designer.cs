﻿namespace QL_DiemHSTieuHoc.Forms.SubBlockFroms
{
    partial class ClassAddForm
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
            panel2 = new Panel();
            cbBlockName = new ComboBox();
            txtSchoolYear = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            btnAdd = new Button();
            btnCancel = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(cbBlockName);
            panel2.Controls.Add(txtSchoolYear);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 216);
            panel2.TabIndex = 1;
            // 
            // cbBlockName
            // 
            cbBlockName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbBlockName.FormattingEnabled = true;
            cbBlockName.Location = new Point(154, 149);
            cbBlockName.Name = "cbBlockName";
            cbBlockName.Size = new Size(209, 29);
            cbBlockName.TabIndex = 2;
            cbBlockName.SelectedIndexChanged += cbBlockName_SelectedIndexChanged;
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSchoolYear.Location = new Point(154, 93);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.Size = new Size(209, 29);
            txtSchoolYear.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(154, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 29);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 149);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 0;
            label3.Text = "Khối:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 92);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 0;
            label2.Text = "Niên Khóa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 40);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên Lớp:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 56);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(127, 9);
            label5.Name = "label5";
            label5.Size = new Size(185, 29);
            label5.TabIndex = 0;
            label5.Text = "Thêm Lớp Học";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnCancel);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 272);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 75);
            panel3.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(247, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(157, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(59, 19);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 42);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ClassAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 346);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ClassAddForm";
            Text = "ClassAddForm";
            Load += ClassAddForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtSchoolYear;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Button btnAdd;
        private Button btnCancel;
        private ComboBox cbBlockName;
        private Label label5;
    }
}