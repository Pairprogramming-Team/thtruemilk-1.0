using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FormMainGUI.ModelDB;
using FormMainGUI.Utils;
using FormMainGUI.DAO;
using System.Collections.Generic;

namespace FormMainGUI.Forms.EmployeeForm
{
    public partial class Employees : Form
    {
        Employee emp = new Employee();
        public Employees()
        {
            InitializeComponent();
            btnAdd.AutoSize = false;
            btnDelete.AutoSize = false;
            btnUpdate.AutoSize = false;

            btnDelete.Size = new System.Drawing.Size(100, 36);
            btnUpdate.Size = new System.Drawing.Size(100, 36);
            btnAdd.Size = new System.Drawing.Size(100, 36);

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = EmployeeDAO.Instance.loadListEmployee();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEmployee add = new addEmployee();
            add.Text = "Add Employee";
            add.ShowDialog();
            dgvEmployee.DataSource = EmployeeDAO.Instance.loadListEmployee();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            addEmployee add = new addEmployee(emp);
            add.Text = "Update Employee";
            add.ShowDialog();
            dgvEmployee.DataSource = EmployeeDAO.Instance.loadListEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure remove employee ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ModelDB.Employee employee = new ModelDB.Employee(emp.EmployeeID, emp.Name, emp.Phone, Convert.ToBoolean(emp.Sex), Convert.ToInt32(emp.YearOfBirth), emp.Address);
                bool isRemoved = EmployeeDAO.Instance.removeEmployee(emp.EmployeeID);
                if (isRemoved == true)
                {
                    MessageBox.Show("Remove successful employee !", "");
                    dgvEmployee.DataSource = EmployeeDAO.Instance.loadListEmployee();
                }
                else
                {
                    MessageBox.Show("Can not remove employee !", "");
                }
            }
        }

        private void dgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvEmployee.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvEmployee.Rows[selectedrowindex];

                emp.EmployeeID = selectedRow.Cells[0].Value.ToString();
                emp.Name = selectedRow.Cells[1].Value.ToString();
                emp.Phone = selectedRow.Cells[2].Value.ToString();
                emp.Sex = Convert.ToBoolean(selectedRow.Cells[3].Value.ToString());
                emp.YearOfBirth = Convert.ToInt32(selectedRow.Cells[4].Value.ToString());
                emp.Address = selectedRow.Cells[5].Value.ToString();
            }
        }
    }
}
