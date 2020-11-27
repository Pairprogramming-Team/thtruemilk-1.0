using FormMainGUI.DAO;
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
using FormMainGUI.ModelDB;

namespace FormMainGUI.Forms.AccountForm
{
    public partial class fAddAccount : MaterialForm
    {
        private List<String> roleList;
        private List<String> employeeList;
        public fAddAccount(List<String> employeeList, List<String> roleList)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            btnCancel.AutoSize = false;
            btnAdd.AutoSize = false;

            btnCancel.Size = new System.Drawing.Size(100, 36);
            btnAdd.Size = new System.Drawing.Size(100, 36);
            this.employeeList = employeeList;
            this.roleList = roleList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isAdd = AccountDAO.Instance.addAccount(new ModelDB.Account("user3","user3","admin","NV05"));
            if (isAdd)
            {
                MessageBox.Show("Add Account Successful!", "");
            }
            else{
                MessageBox.Show("Add Account Fail!", "");
            }
        }

        private void fAddAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fAddAccount_Load(object sender, EventArgs e)
        {
            cbxDisplayName.DataSource = employeeList;
            cbxRole.DataSource = roleList;
        }
    }
}
