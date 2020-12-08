using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormMainGUI.DAO;
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
            /*bool isSuccess = false;

            string employeeId = txbId.Text;
            string name = txbName.Text;
            string phone = txbPhone.Text;
            bool sex;
            if (cbmSex.SelectedIndex == 1)
            {
                sex = true;
            }
            else
            {
                sex = false;
            }
            int birth = Convert.ToInt32(txbBirth.Text);
            string address = txbAddress.Text;
            ModelDB.Employee employee = new ModelDB.Employee(employeeId, name, phone, sex, birth, address);

            isSuccess = EmployeeDAO.Instance.updateEmployee(employee);
            if (isSuccess)
            {
                MessageBox.Show("Update Employee Successful!", "");
                this.Close();
            }
            else
            {
                MessageBox.Show("Update Employee Fail!", "");
            }*/
        }
    }
}
