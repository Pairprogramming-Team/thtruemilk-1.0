using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FormMainGUI.Forms.EmployeeForm
{
    public partial class addEmployee : MaterialForm
    {
        public addEmployee()
        {
            InitializeComponent();
            btnAdd.AutoSize = false;
            btnCancel.AutoSize = false;

            btnCancel.Size = new System.Drawing.Size(87, 36);
            btnAdd.Size = new System.Drawing.Size(87, 36);
        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Do you want to cancel?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
        }
    }
}
