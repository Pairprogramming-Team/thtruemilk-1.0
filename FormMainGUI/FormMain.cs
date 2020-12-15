using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using FormMainGUI.Forms;
using FormMainGUI.Forms.AccountForm;
using FormMainGUI.Forms.EmployeeForm;
using FormMainGUI.Forms.OrderForm;
using FormMainGUI.ModelDB;
using FormMainGUI.Utils;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FormMainGUI
{
    public partial class FormMain : MaterialForm
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private ModelDB.Account account;

        //Constructor
        public FormMain(ModelDB.Account account)
        {           
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            this.account = account;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Size = new Size(1300, 800);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            displayName.Text = account.UserName;

            if (!account.Role.Equals("admin"))
            {
                btnAccount.Visible = false;
            }
            OpenChildForm(new Dashboard());
            ActiveButton(btnDashboard, Color.White);
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(47, 133, 243);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // icon child form
                lblTitileChildForm.Text = currentBtn.Text;
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(33, 150, 243);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitileChildForm.Text = childForm.Text;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.White);
            OpenChildForm(new Dashboard());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.White);
            OpenChildForm(new Products());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.White);
            OpenChildForm(new fOrders(account));

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.White);
            OpenChildForm(new Employees());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.White);
            OpenChildForm(new Forms.AccountForm.Account());
        }

        private void Reset(object sender)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            ActiveButton(btnDashboard, Color.White);
            OpenChildForm(new Dashboard());
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset(sender);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
    }
}
