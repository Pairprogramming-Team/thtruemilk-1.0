using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FormMainGUI.Forms.LoginForm
{
    public partial class Login : MaterialForm
    {
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
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.ShowDialog();
        }
    }
}
