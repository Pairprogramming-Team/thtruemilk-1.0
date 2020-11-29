using FormMainGUI.DAO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormMainGUI.Forms.AccountForm
{
    public partial class fAddAccount : MaterialForm
    {
        private List<String> roleList;
        private List<String> employeeList;
        private AccountInfo accountInfo;
        private bool isUpdate = false;


        public fAddAccount(List<String> employeeList, List<String> roleList, AccountInfo accountInfo = null)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            btnCancel.AutoSize = false;
            btnAdd.AutoSize = false;

            btnCancel.Size = new System.Drawing.Size(100, 36);
            btnAdd.Size = new System.Drawing.Size(100, 36);

            this.accountInfo = accountInfo;
            this.employeeList = employeeList;
            this.roleList = roleList;

            if (accountInfo != null)
            {
                btnAdd.Text = "UPDATE";
                isUpdate = true;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cbxRole.SelectedItem.ToString();
            string empid = AccountDAO.Instance.getEmployeeIdByName(cbxDisplayName.SelectedItem.ToString());
            ModelDB.Account account = new ModelDB.Account(username, password, role, empid);

            if (isUpdate)
            {
                isSuccess = AccountDAO.Instance.updateAccount(account);
                if (isSuccess)
                {
                    MessageBox.Show("Update Account Successful!", "");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Account Fail!", "");
                }
            }
            else
            {
                isSuccess = AccountDAO.Instance.addAccount(account);
                if (isSuccess)
                {
                    MessageBox.Show("Add Account Successful!", "");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add Account Fail!", "");
                }
            }


        }

        private void fAddAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }

        int findIndexByName(string name, int option) // option = 0 => name | 1=> role
        {
            if (option == 0)
            {
                for (int i = 0; i < employeeList.Count; i++)
                {
                    if (String.Compare(employeeList[i], name) == 0)
                    {
                        return i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < roleList.Count; i++)
                {
                    if (String.Compare(roleList[i], name) == 0)
                    {
                        return i;
                    }
                }
            }

            return 0;
        }

        private void fAddAccount_Load(object sender, EventArgs e)
        {
            cbxDisplayName.DataSource = employeeList;
            cbxRole.DataSource = roleList;

            if (accountInfo != null)
            {
                txtUsername.Text = accountInfo.Username;
                txtPassword.Text = accountInfo.Password;
                cbxDisplayName.SelectedIndex = findIndexByName(accountInfo.DisplayName, 0);
                cbxRole.SelectedIndex = findIndexByName(accountInfo.Role, 1);

                cbxDisplayName.Enabled = false;
                txtUsername.Enabled = false;
            }
        }
    }
}
