using FormMainGUI.DAO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FormMainGUI.ModelDB;



namespace FormMainGUI.Forms.EmployeeForm
{
    public partial class addEmployee : MaterialForm
    {
        private Employee employee;
        private bool isUpdate = false;
        public addEmployee(Employee employee = null)
        {
            InitializeComponent();
            btnAdd.AutoSize = false;
            btnCancel.AutoSize = false;

            btnCancel.Size = new System.Drawing.Size(87, 36);
            btnAdd.Size = new System.Drawing.Size(87, 36);

            txbId.Size = new System.Drawing.Size(250, 40);
            txbName.Size = new System.Drawing.Size(250, 40);
            txbBirth.Size = new System.Drawing.Size(250, 40);
            txbAddress.Size = new System.Drawing.Size(250, 40);
            txbPhone.Size = new System.Drawing.Size(250, 40);

            this.employee = employee;
            if (employee != null)
            {
                btnAdd.Text = "Update";
                isUpdate = true;
            }
        }

        private void addEmployee_Load(object sender, EventArgs e)
        {
            if (employee != null)
            {
                txbId.Text = employee.EmployeeID;
                txbName.Text = employee.Name;
                txbPhone.Text = employee.Phone;
                txbAddress.Text = employee.Address;
                txbBirth.Text = Convert.ToString(employee.YearOfBirth);
                txbId.Enabled = false;
            }
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
            bool isSuccess = false;

            string employeeId= txbId.Text;
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
            string address= txbAddress.Text;

            if (txbId.Text == "")
            {
                MessageBox.Show("Please Input ID");
                return;
            }

            if (txbName.Text == "" )
            {
                MessageBox.Show("Please Input Name");
                return;
            }
            if (txbPhone.Text == "")
            {
                MessageBox.Show("Please Input Phone");
                return;
            }

            if (txbBirth.Text == "")
            {
                MessageBox.Show("Please Input Year of Birth");
                return;
            }

            if (Convert.ToInt32(txbBirth.Text) <= 1990 || Convert.ToInt32(txbBirth.Text) >= 2003)
            {
                MessageBox.Show("Invalid Year of Birth");
                return;
            }

            if (txbAddress.Text == "")
            {
                MessageBox.Show("Please Input Address");
                return;
            }
            int birth = Convert.ToInt32(txbBirth.Text);

            ModelDB.Employee employee = new ModelDB.Employee(employeeId, name, phone, sex, birth, address);

            if (isUpdate)
            {
                isSuccess = EmployeeDAO.Instance.updateEmployee(employee);
                if (isSuccess)
                {
                    MessageBox.Show("Update Employee Successful!", "");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Employee Fail!", "");
                }
            }

            else
            {
                isSuccess = EmployeeDAO.Instance.addEmployee(employee);

                if (isSuccess)
                {
                    MessageBox.Show("Add Employee Successful ", "");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add Employee Fail ", "");
                }
            }
        }
    }
}
