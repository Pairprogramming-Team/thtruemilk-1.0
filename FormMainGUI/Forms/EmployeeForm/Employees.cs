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
    public partial class Employees : Form
    {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEmployee add = new addEmployee();
            add.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEmployee update = new updateEmployee();
            update.ShowDialog();
        }
    }
}
