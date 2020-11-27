using FormMainGUI.DAO;
using FormMainGUI.ModelDB;
using FormMainGUI.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FormMainGUI.Forms.LoginForm
{
    public partial class Login : MaterialForm
    {
        private FormMain formMain;
        public Login()
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

            btnLogin.AutoSize = false;
            btnCancel.AutoSize = false;

            txtUsername.Size = new System.Drawing.Size(210, 40);
            txtPassword.Size = new System.Drawing.Size(210, 40);

            btnLogin.Size = new System.Drawing.Size(100, 36);
            btnCancel.Size = new System.Drawing.Size(100, 36);
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Account account = isLogin(username, password);

            if (account != null)
            {
                formMain = new FormMain(account);
                this.Hide();
                formMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login failed");
            }

        }

        Account isLogin(string username, string password)
        {
            return AccountDAO.Instance.isLogin(username, password);
        }

    }
}
