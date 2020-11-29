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
using System.Windows.Forms;
using FormMainGUI.ModelDB;
using FormMainGUI.Utils;

namespace FormMainGUI.Forms.EmployeeForm
{
    public partial class Employees : Form
    {
        Product pro = new Product();
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
            var db = DataProvider.Ins.DB;
            var result = from c in db.Employees
                         select new
                         {
                             EmployeeID = c.EmployeeID,
                             Name = c.Name,
                             Phone = c.Phone,
                             Sex = c.Sex,
                             YearOfBirth = c.YearOfBirth,
                             Address = c.Address,
                         };
            dataGridView1.DataSource = result.ToList();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = DataProvider.Ins.DB)
            {
                var em = db.Employees.Where(x => x.EmployeeID == emp.EmployeeID).SingleOrDefault();
                db.Employees.Remove(em);
                db.SaveChanges();
            }
            MessageBox.Show("Remove");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
            }
        }
    }
}
