using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormMainGUI.Utils;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FormMainGUI.Forms.EmployeeForm
{
    public partial class updateEmployee : MaterialForm
    {
        public updateEmployee()
        {
            InitializeComponent();
        }

        private void updateEmployee_Load(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = DataProvider.Ins.DB)
            {
                var emp = db.Employees.Where(x => x.EmployeeID == txbId.Text).SingleOrDefault();
                emp.Name = txbName.Text;
                emp.Phone = txbPhone.Text;
                emp.Sex = Convert.ToBoolean(cbmSex.SelectedIndex);
                emp.YearOfBirth = Convert.ToInt32(txbBirth.Text);
                emp.Address = txbAddress.Text;

                db.SaveChanges();
            }
            DialogResult = DialogResult.Cancel;
        }
    }
}
