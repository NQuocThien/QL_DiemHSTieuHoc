namespace QL_DiemHSTieuHoc
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelMenu = new Panel();
            btnUser = new Button();
            iconButon = new ImageList(components);
            btnFamily = new Button();
            btnClasss = new Button();
            btnSubject = new Button();
            btnStatistic = new Button();
            btnScore = new Button();
            btnTeacher = new Button();
            btnStudent = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnUser);
            panelMenu.Controls.Add(btnFamily);
            panelMenu.Controls.Add(btnClasss);
            panelMenu.Controls.Add(btnSubject);
            panelMenu.Controls.Add(btnStatistic);
            panelMenu.Controls.Add(btnScore);
            panelMenu.Controls.Add(btnTeacher);
            panelMenu.Controls.Add(btnStudent);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 581);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUser.ForeColor = SystemColors.Control;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.ImageIndex = 1;
            btnUser.ImageList = iconButon;
            btnUser.Location = new Point(0, 397);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(5, 0, 0, 0);
            btnUser.Size = new Size(220, 49);
            btnUser.TabIndex = 7;
            btnUser.Text = "Tài Khoản";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // iconButon
            // 
            iconButon.ColorDepth = ColorDepth.Depth32Bit;
            iconButon.ImageStream = (ImageListStreamer)resources.GetObject("iconButon.ImageStream");
            iconButon.TransparentColor = Color.Transparent;
            iconButon.Images.SetKeyName(0, "close.png");
            iconButon.Images.SetKeyName(1, "admin-with-cogwheels.png");
            iconButon.Images.SetKeyName(2, "analytics.png");
            iconButon.Images.SetKeyName(3, "enter.png");
            iconButon.Images.SetKeyName(4, "family.png");
            iconButon.Images.SetKeyName(5, "student.png");
            iconButon.Images.SetKeyName(6, "teacher.png");
            iconButon.Images.SetKeyName(7, "user.png");
            iconButon.Images.SetKeyName(8, "book.png");
            iconButon.Images.SetKeyName(9, "class.png");
            // 
            // btnFamily
            // 
            btnFamily.Dock = DockStyle.Top;
            btnFamily.FlatAppearance.BorderSize = 0;
            btnFamily.FlatStyle = FlatStyle.Flat;
            btnFamily.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFamily.ForeColor = SystemColors.Control;
            btnFamily.ImageAlign = ContentAlignment.MiddleLeft;
            btnFamily.ImageIndex = 4;
            btnFamily.ImageList = iconButon;
            btnFamily.Location = new Point(0, 348);
            btnFamily.Name = "btnFamily";
            btnFamily.Padding = new Padding(5, 0, 0, 0);
            btnFamily.Size = new Size(220, 49);
            btnFamily.TabIndex = 6;
            btnFamily.Text = "Người Nhà";
            btnFamily.UseVisualStyleBackColor = true;
            btnFamily.Click += btnFamily_Click;
            // 
            // btnClasss
            // 
            btnClasss.Dock = DockStyle.Top;
            btnClasss.FlatAppearance.BorderSize = 0;
            btnClasss.FlatStyle = FlatStyle.Flat;
            btnClasss.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClasss.ForeColor = SystemColors.Control;
            btnClasss.ImageAlign = ContentAlignment.MiddleLeft;
            btnClasss.ImageIndex = 9;
            btnClasss.ImageList = iconButon;
            btnClasss.Location = new Point(0, 299);
            btnClasss.Name = "btnClasss";
            btnClasss.Padding = new Padding(5, 0, 0, 0);
            btnClasss.Size = new Size(220, 49);
            btnClasss.TabIndex = 5;
            btnClasss.Text = "Lớp Học";
            btnClasss.UseVisualStyleBackColor = true;
            btnClasss.Click += btnClasss_Click;
            // 
            // btnSubject
            // 
            btnSubject.Dock = DockStyle.Top;
            btnSubject.FlatAppearance.BorderSize = 0;
            btnSubject.FlatStyle = FlatStyle.Flat;
            btnSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubject.ForeColor = SystemColors.Control;
            btnSubject.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubject.ImageKey = "book.png";
            btnSubject.ImageList = iconButon;
            btnSubject.Location = new Point(0, 250);
            btnSubject.Name = "btnSubject";
            btnSubject.Padding = new Padding(5, 0, 0, 0);
            btnSubject.Size = new Size(220, 49);
            btnSubject.TabIndex = 4;
            btnSubject.Text = "Môn Học";
            btnSubject.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            btnStatistic.Dock = DockStyle.Top;
            btnStatistic.FlatAppearance.BorderSize = 0;
            btnStatistic.FlatStyle = FlatStyle.Flat;
            btnStatistic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStatistic.ForeColor = SystemColors.Control;
            btnStatistic.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistic.ImageIndex = 2;
            btnStatistic.ImageList = iconButon;
            btnStatistic.Location = new Point(0, 201);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Padding = new Padding(5, 0, 0, 0);
            btnStatistic.Size = new Size(220, 49);
            btnStatistic.TabIndex = 3;
            btnStatistic.Text = "Thống Kê";
            btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnScore
            // 
            btnScore.Dock = DockStyle.Top;
            btnScore.FlatAppearance.BorderSize = 0;
            btnScore.FlatStyle = FlatStyle.Flat;
            btnScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnScore.ForeColor = SystemColors.Control;
            btnScore.ImageAlign = ContentAlignment.MiddleLeft;
            btnScore.ImageIndex = 3;
            btnScore.ImageList = iconButon;
            btnScore.Location = new Point(0, 152);
            btnScore.Name = "btnScore";
            btnScore.Padding = new Padding(5, 0, 0, 0);
            btnScore.Size = new Size(220, 49);
            btnScore.TabIndex = 2;
            btnScore.Text = "Nhập Điểm";
            btnScore.UseVisualStyleBackColor = true;
            // 
            // btnTeacher
            // 
            btnTeacher.Dock = DockStyle.Top;
            btnTeacher.FlatAppearance.BorderSize = 0;
            btnTeacher.FlatStyle = FlatStyle.Flat;
            btnTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTeacher.ForeColor = SystemColors.Control;
            btnTeacher.ImageAlign = ContentAlignment.MiddleLeft;
            btnTeacher.ImageIndex = 6;
            btnTeacher.ImageList = iconButon;
            btnTeacher.Location = new Point(0, 103);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Padding = new Padding(5, 0, 0, 0);
            btnTeacher.Size = new Size(220, 49);
            btnTeacher.TabIndex = 1;
            btnTeacher.Text = "Giáo Viên";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnStudent
            // 
            btnStudent.Dock = DockStyle.Top;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStudent.ForeColor = SystemColors.Control;
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.ImageKey = "student.png";
            btnStudent.ImageList = iconButon;
            btnStudent.Location = new Point(0, 54);
            btnStudent.Name = "btnStudent";
            btnStudent.Padding = new Padding(5, 0, 0, 0);
            btnStudent.Size = new Size(220, 49);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Học Sinh";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 54);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 40);
            label1.TabIndex = 0;
            label1.Text = "Primary Shool";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1065, 54);
            panelTitleBar.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.ImageAlign = ContentAlignment.MiddleRight;
            btnCloseChildForm.ImageIndex = 0;
            btnCloseChildForm.ImageList = iconButon;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Margin = new Padding(0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(42, 54);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(422, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(87, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Home";
            lblTitle.Click += label1_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(220, 54);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1065, 527);
            panelDesktopPane.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 581);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnFamily;
        private Button btnClasss;
        private Button btnSubject;
        private Button btnStatistic;
        private Button btnScore;
        private Button btnTeacher;
        private Button btnStudent;
        private ImageList iconButon;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private Label label1;
        private Button btnUser;
    }
}