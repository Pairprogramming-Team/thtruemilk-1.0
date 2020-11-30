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
using FormMainGUI.Utils;
using MaterialSkin.Controls;
using FormMainGUI.ModelDB;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            try
            {
                employee.EmployeeID = txbId.Text;
                employee.Name = txbName.Text;
                employee.Phone = txbPhone.Text;
                employee.Sex = Convert.ToBoolean(cbmSex.SelectedIndex);
                employee.YearOfBirth = Convert.ToInt32(txbBirth.Text);
                employee.Address = txbAddress.Text;
                using (var db = DataProvider.Ins.DB)
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                }
                MessageBox.Show("Add successfully");
            }
            catch
            {
                if (txbId.Text == "")
                {
                    MessageBox.Show("Invalid ID");
                    return;
                }
                 else if (txbName.Text == "")
                {
                    MessageBox.Show("Invalid Name");
                    return;
                }
                else if (txbPhone.Text == "")
                {
                    MessageBox.Show("Invalid Phone");
                    return;
                }
                else if (txbBirth.Text == "" )
                {
                    MessageBox.Show("Invalid Year Of Birth");
                    return;
                }
                DialogResult = DialogResult.Cancel;

            }

        }
    }
}
