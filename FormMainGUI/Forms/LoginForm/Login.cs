﻿using FormMainGUI.DAO;
using FormMainGUI.ModelDB;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FormMainGUI.Forms.LoginForm
{
    public partial class fLogin : MaterialForm
    {
        private FormMain formMain;
        public fLogin()
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

            if (username == "")
            {
                MessageBox.Show("Please input username!", "Login failed");
                txtUsername.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Please input password!", "Login failed");
                txtPassword.Focus();
                return;
            }

            Account account = isLogin(username, password);

            if (account != null)
            {
                formMain = new FormMain(account);
                this.Hide();
                formMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login failed");
                txtUsername.Focus();
            }

        }

        Account isLogin(string username, string password)
        {
            return AccountDAO.Instance.isLogin(username, password);
        }

    }
}
