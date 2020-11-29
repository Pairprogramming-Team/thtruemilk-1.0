using FormMainGUI.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormMainGUI.Forms.AccountForm
{
    public partial class Account : Form
    {
        private fAddAccount addAccountForm;
        private List<String> roleList;
        private List<String> employeeList;
        private AccountInfo accountInfor;
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

            accountInfor = new AccountInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addAccountForm = new fAddAccount(employeeList, roleList);
            addAccountForm.Text = "ADD ACCOUNT";
            addAccountForm.ShowDialog();
            dgvAccount.DataSource = AccountDAO.Instance.loadListAccount();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            addAccountForm = new fAddAccount(employeeList, roleList, accountInfor);
            addAccountForm.Text = "UPDATE ACCOUNT";
            addAccountForm.ShowDialog();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            employeeList = AccountDAO.Instance.getEmployeeList();
            roleList = AccountDAO.Instance.getRoleList();
            dgvAccount.DataSource = AccountDAO.Instance.loadListAccount();
            Console.WriteLine("form account loading...");
        }

        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAccount.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAccount.Rows[selectedrowindex];
                accountInfor.DisplayName = selectedRow.Cells["displayname"].Value.ToString();
                accountInfor.Username = selectedRow.Cells["Username"].Value.ToString();
                accountInfor.Password = selectedRow.Cells["Password"].Value.ToString();
                accountInfor.Role = selectedRow.Cells["Role"].Value.ToString();
                accountInfor.EmployeeId = selectedRow.Cells["EmployeeId"].Value.ToString();
            }
        }
    }
}
