using FormMainGUI.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainGUI.Forms.AccountForm
{
    public partial class Account : Form
    {
        private fAddAccount addAccountForm;
        private List<String> roleList;
        private List<String> employeeList;
        public Account()
        {
            InitializeComponent();

            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //// Configure color schema
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue400, Primary.Blue500,
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE
            //);

            btnDelete.AutoSize = false;
            btnUpdate.AutoSize = false;
            btnAdd.AutoSize = false;

            btnDelete.Size = new System.Drawing.Size(100, 36);
            btnUpdate.Size = new System.Drawing.Size(100, 36);
            btnAdd.Size = new System.Drawing.Size(100, 36);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addAccountForm = new fAddAccount(employeeList, roleList);
            addAccountForm.Text = "ADD ACCOUNT";
            addAccountForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            addAccountForm = new fAddAccount(employeeList, roleList);
            addAccountForm.Text = "UPDATE ACCOUNT";
            addAccountForm.ShowDialog();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            using(var db = DataProvider.Ins.DB)
            {
                roleList = db.Accounts.GroupBy(a => a.Role).Select(x => x.Key).ToList();
                employeeList = db.Employees.GroupBy(em => em.Name).Select(x => x.Key).ToList();
                var data = db.Accounts.Join(
                    db.Employees,
                    account => account.EmployeeID,
                    employee => employee.EmployeeID,
                    (account, employee) => new
                    {
                        EmployeeId = employee.EmployeeID,
                        DisplayName = employee.Name,
                        Username = account.UserName,
                        Password = account.PassWord,
                        Role = account.Role,
                    }).ToList();
                dgvAccount.DataSource = data;

            }
        }
    }
}
