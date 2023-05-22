namespace QL_DiemHSTieuHoc.Forms.SubFroms
{
    partial class FamilyForm
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
            panel4 = new Panel();
            gvParent = new DataGridView();
            groupBox3 = new GroupBox();
            dateBirth = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtRelationShip = new TextBox();
            txtSdt = new TextBox();
            txtName = new TextBox();
            panel3 = new Panel();
            btnStudent = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvParent).BeginInit();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1049, 420);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(gvParent);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(286, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(778, 420);
            panel4.TabIndex = 16;
            // 
            // gvParent
            // 
            gvParent.AllowUserToAddRows = false;
            gvParent.BackgroundColor = Color.Snow;
            gvParent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvParent.Dock = DockStyle.Fill;
            gvParent.Location = new Point(0, 0);
            gvParent.Name = "gvParent";
            gvParent.RowTemplate.Height = 25;
            gvParent.Size = new Size(778, 420);
            gvParent.TabIndex = 0;
            gvParent.CellClick += gvParent_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateBirth);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtRelationShip);
            groupBox3.Controls.Add(txtSdt);
            groupBox3.Controls.Add(txtName);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(286, 420);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin phụ huynh";
            groupBox3.UseCompatibleTextRendering = true;
            // 
            // dateBirth
            // 
            dateBirth.CustomFormat = "yyyy-MM-dd";
            dateBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateBirth.Format = DateTimePickerFormat.Custom;
            dateBirth.Location = new Point(12, 168);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(257, 29);
            dateBirth.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 131);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 32;
            label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 293);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 33;
            label4.Text = "Mối Quan Hệ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 213);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 34;
            label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 35;
            label2.Text = "Họ và Tên:";
            // 
            // txtRelationShip
            // 
            txtRelationShip.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRelationShip.Location = new Point(12, 330);
            txtRelationShip.Name = "txtRelationShip";
            txtRelationShip.Size = new Size(262, 27);
            txtRelationShip.TabIndex = 28;
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdt.Location = new Point(12, 250);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(262, 27);
            txtSdt.TabIndex = 29;
            // 
            // txtName
            // 
            txtName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(12, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 27);
            txtName.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnStudent);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnUpdate);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 420);
            panel3.Name = "panel3";
            panel3.Size = new Size(1049, 71);
            panel3.TabIndex = 9;
            // 
            // btnStudent
            // 
            btnStudent.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStudent.Location = new Point(798, 17);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(251, 42);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Thông Tin HS";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(541, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(251, 42);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Xóa Thông Tin";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(12, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(251, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm thông tin";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(274, 17);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(251, 42);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Sửa thông tin";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // FamilyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 488);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FamilyForm";
            Text = "Family";
            Load += FamilyForm_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvParent).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private DataGridView gvParent;
        private GroupBox groupBox3;
        private ComboBox cbSex;
        private DateTimePicker dateBirth;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtRelationShip;
        private TextBox txtSdt;
        private TextBox txtName;
        private Panel panel3;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnStudent;
    }
}