//using QL_DiemHSTieuHoc.Forms;
using BusinessLogicLayer;
using QL_DiemHSTieuHoc.Forms;
using QL_DiemHSTieuHoc.Forms.SubFroms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiemHSTieuHoc
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private string currentUser = null;
        public Main(string currentUser)
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.currentUser = currentUser;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Student(currentUser), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new User(currentUser), sender);

        }

        private void btnClasss_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BlockAndClass(currentUser), sender);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher(currentUser), sender);
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FamilyForm(currentUser), sender);
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InputScore(currentUser), sender);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            DatabaseBLL dbll = new DatabaseBLL();
            FolderBrowserDialog saoluu = new FolderBrowserDialog();
            saoluu.Description = "Chọn thư mực lưu trự";
            if (saoluu.ShowDialog() == DialogResult.OK)
            {
                string DuongDan = saoluu.SelectedPath;
                string mess = dbll.Backup(DuongDan);
                if (mess == "success")
                {
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + DuongDan);
                }
                else
                {
                    MessageBox.Show("Thao tác không thành công: " + mess);
                }
            }
        }

        private void btnRetore_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoi = new OpenFileDialog();
            DatabaseBLL dbll = new DatabaseBLL();
            phuchoi.Filter = "*.bak|*.bak";
            phuchoi.Title = "Chọn tập tin phục hồi(.bak)";
            if (phuchoi.ShowDialog() == DialogResult.OK && phuchoi.CheckFileExists == true)
            {
                string DuongDan = phuchoi.FileName;
                string mess = dbll.Retore(DuongDan);
                if (mess == "success")
                {
                    MessageBox.Show("Thành Công");
                }
                else
                {
                    MessageBox.Show("Thất Bại: " + mess);
                }
            }
        }
        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "DA.chm");
        }
    }
}
