using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainGUI.Forms
{
    public partial class formCancel : Form
    {
        public formCancel()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            formCancel formCancel = new formCancel();
            this.Hide();
            formAdd formAdd = new formAdd();
            this.Hide();
           FormUpdate formUpdate = new FormUpdate();
            this.Hide();
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}
