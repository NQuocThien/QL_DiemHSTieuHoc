namespace QL_DiemHSTieuHoc
{
    partial class Form1
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
            pnTop = new Panel();
            label2 = new Label();
            pnBody = new Panel();
            pnRight = new Panel();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUserName = new TextBox();
            label3 = new Label();
            Icon = new ImageList(components);
            label1 = new Label();
            body_left = new Panel();
            pictureBox1 = new PictureBox();
            pnFoodter = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pnTop.SuspendLayout();
            pnBody.SuspendLayout();
            pnRight.SuspendLayout();
            body_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnFoodter.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.Controls.Add(label2);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(664, 72);
            pnTop.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(258, 60);
            label2.TabIndex = 1;
            label2.Text = "Đăng Nhập ";
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
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(24, 233);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(232, 38);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(24, 171);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(266, 33);
            txtPass.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(24, 83);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(266, 33);
            txtUserName.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageList = Icon;
            label3.Location = new Point(24, 41);
            label3.Name = "label3";
            label3.Size = new Size(160, 28);
            label3.TabIndex = 1;
            label3.Text = "Tên Tài Khoản:";
            // 
            // Icon
            // 
            Icon.ColorDepth = ColorDepth.Depth8Bit;
            Icon.ImageSize = new Size(16, 16);
            Icon.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageList = Icon;
            label1.Location = new Point(24, 132);
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
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 321);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnFoodter
            // 
            pnFoodter.Controls.Add(label6);
            pnFoodter.Controls.Add(label5);
            pnFoodter.Controls.Add(label4);
            pnFoodter.Dock = DockStyle.Top;
            pnFoodter.Location = new Point(0, 393);
            pnFoodter.Name = "pnFoodter";
            pnFoodter.Size = new Size(664, 50);
            pnFoodter.TabIndex = 0;
            // 
            // label6
            // 
            label6.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(76, 14);
            label6.Name = "label6";
            label6.Size = new Size(185, 23);
            label6.TabIndex = 0;
            label6.Text = "Quên mật khẩu";
            // 
            // label5
            // 
            label5.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.ImageList = Icon;
            label5.Location = new Point(430, 14);
            label5.Name = "label5";
            label5.Size = new Size(172, 23);
            label5.TabIndex = 0;
            label5.Text = "Tạo tài khoản";
            // 
            // label4
            // 
            label4.ImageList = Icon;
            label4.Location = new Point(109, 14);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 445);
            Controls.Add(pnFoodter);
            Controls.Add(pnBody);
            Controls.Add(pnTop);
            Name = "Form1";
            Text = "Login";
            pnTop.ResumeLayout(false);
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
        private Label label2;
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
        private Label label5;
        private Label label4;
        private Label label6;
    }
}