namespace QL_DiemHSTieuHoc
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnTop = new Panel();
            pictureBox2 = new PictureBox();
            pnBody = new Panel();
            pnRight = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            Icon = new ImageList(components);
            txtPass = new TextBox();
            txtUserName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            body_left = new Panel();
            pictureBox1 = new PictureBox();
            pnFoodter = new Panel();
            lblFogotPass = new Label();
            lblCreateUserAccout = new Label();
            label4 = new Label();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnBody.SuspendLayout();
            pnRight.SuspendLayout();
            body_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnFoodter.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.Controls.Add(pictureBox2);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(664, 72);
            pnTop.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.poster;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(664, 72);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pnBody
            // 
            pnBody.Controls.Add(pnRight);
            pnBody.Controls.Add(body_left);
            pnBody.Dock = DockStyle.Top;
            pnBody.Location = new Point(0, 72);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(664, 321);
            pnBody.TabIndex = 0;
            // 
            // pnRight
            // 
            pnRight.BackColor = Color.FromArgb(26, 157, 221);
            pnRight.Controls.Add(btnExit);
            pnRight.Controls.Add(btnLogin);
            pnRight.Controls.Add(txtPass);
            pnRight.Controls.Add(txtUserName);
            pnRight.Controls.Add(label3);
            pnRight.Controls.Add(label1);
            pnRight.Dock = DockStyle.Left;
            pnRight.Location = new Point(276, 0);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(385, 321);
            pnRight.TabIndex = 1;
            pnRight.Paint += pnRight_Paint;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Transparent;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.ImageIndex = 1;
            btnExit.Location = new Point(24, 271);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(266, 47);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Silver;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.ImageIndex = 1;
            btnLogin.ImageList = Icon;
            btnLogin.Location = new Point(24, 214);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(266, 47);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Icon
            // 
            Icon.ColorDepth = ColorDepth.Depth32Bit;
            Icon.ImageStream = (ImageListStreamer)resources.GetObject("Icon.ImageStream");
            Icon.TransparentColor = Color.Transparent;
            Icon.Images.SetKeyName(0, "edit.png");
            Icon.Images.SetKeyName(1, "enter.png");
            Icon.Images.SetKeyName(2, "reset-password.png");
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.ScrollBar;
            txtPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = SystemColors.WindowText;
            txtPass.Location = new Point(24, 158);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(266, 33);
            txtPass.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.ScrollBar;
            txtUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = SystemColors.WindowText;
            txtUserName.Location = new Point(24, 70);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(266, 33);
            txtUserName.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.ImageList = Icon;
            label3.Location = new Point(24, 28);
            label3.Name = "label3";
            label3.Size = new Size(160, 28);
            label3.TabIndex = 1;
            label3.Text = "Tên Tài Khoản:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.ImageList = Icon;
            label1.Location = new Point(24, 119);
            label1.Name = "label1";
            label1.Size = new Size(187, 36);
            label1.TabIndex = 1;
            label1.Text = "Mật Khẩu:";
            // 
            // body_left
            // 
            body_left.Controls.Add(pictureBox1);
            body_left.Dock = DockStyle.Left;
            body_left.Location = new Point(0, 0);
            body_left.Name = "body_left";
            body_left.Size = new Size(276, 321);
            body_left.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 321);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnFoodter
            // 
            pnFoodter.BackColor = SystemColors.GradientActiveCaption;
            pnFoodter.Controls.Add(lblFogotPass);
            pnFoodter.Controls.Add(lblCreateUserAccout);
            pnFoodter.Controls.Add(label4);
            pnFoodter.Dock = DockStyle.Top;
            pnFoodter.Location = new Point(0, 393);
            pnFoodter.Name = "pnFoodter";
            pnFoodter.Size = new Size(664, 50);
            pnFoodter.TabIndex = 0;
            // 
            // lblFogotPass
            // 
            lblFogotPass.Cursor = Cursors.Hand;
            lblFogotPass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFogotPass.ForeColor = SystemColors.HotTrack;
            lblFogotPass.ImageAlign = ContentAlignment.MiddleRight;
            lblFogotPass.ImageIndex = 2;
            lblFogotPass.ImageList = Icon;
            lblFogotPass.Location = new Point(76, 0);
            lblFogotPass.Name = "lblFogotPass";
            lblFogotPass.Size = new Size(143, 50);
            lblFogotPass.TabIndex = 0;
            lblFogotPass.Text = "Quên mật khẩu";
            lblFogotPass.TextAlign = ContentAlignment.MiddleLeft;
            lblFogotPass.Click += lblFogotPass_Click;
            // 
            // lblCreateUserAccout
            // 
            lblCreateUserAccout.Cursor = Cursors.Hand;
            lblCreateUserAccout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreateUserAccout.ForeColor = SystemColors.HotTrack;
            lblCreateUserAccout.ImageAlign = ContentAlignment.MiddleRight;
            lblCreateUserAccout.ImageIndex = 0;
            lblCreateUserAccout.ImageList = Icon;
            lblCreateUserAccout.Location = new Point(432, 0);
            lblCreateUserAccout.Name = "lblCreateUserAccout";
            lblCreateUserAccout.Size = new Size(134, 50);
            lblCreateUserAccout.TabIndex = 0;
            lblCreateUserAccout.Text = "Tạo tài khoản";
            lblCreateUserAccout.TextAlign = ContentAlignment.MiddleLeft;
            lblCreateUserAccout.Click += lblCreateUserAccout_Click;
            // 
            // label4
            // 
            label4.ImageList = Icon;
            label4.Location = new Point(109, 14);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 445);
            Controls.Add(pnFoodter);
            Controls.Add(pnBody);
            Controls.Add(pnTop);
            Name = "Login";
            Text = "Login";
            pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnBody.ResumeLayout(false);
            pnRight.ResumeLayout(false);
            pnRight.PerformLayout();
            body_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnFoodter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private Panel pnBody;
        private Panel pnRight;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUserName;
        private Label label3;
        private ImageList Icon;
        private Label label1;
        private Panel body_left;
        private PictureBox pictureBox1;
        private Panel pnFoodter;
        private Label lblCreateUserAccout;
        private Label label4;
        private Label lblFogotPass;
        private PictureBox pictureBox2;
        private Button btnExit;
    }
}