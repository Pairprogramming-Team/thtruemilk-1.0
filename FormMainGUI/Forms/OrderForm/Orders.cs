using FormMainGUI.DAO;
using FormMainGUI.ModelDB;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FormMainGUI.Forms.OrderForm
{
    public partial class fOrders : MaterialForm
    {
        private ModelDB.Account account;
        public fOrders(Account account)
        {
            InitializeComponent();

            btnDelete.AutoSize = false;
            btnAdd.AutoSize = false;
            btnOrderDetailList.AutoSize = false;

            btnDelete.Size = new System.Drawing.Size(100, 36);
            btnAdd.Size = new System.Drawing.Size(100, 36);
            btnOrderDetailList.Size = new System.Drawing.Size(210, 36);
            this.account = account;
            setRolePermission(account.Role);
        }

        private void setRolePermission(string role)
        {
            if (role.Equals("manager"))
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void fOrders_Load(object sender, EventArgs e)
        {
            dgvOrdersList.DataSource = OrderDAO.Instance.getListOrder();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fOrdersDetail fOrdersDetail = new fOrdersDetail(this, account);
            fOrdersDetail.ShowDialog();
        }

        private void dgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            ListOrderDetailByID ListOrderDetail = new ListOrderDetailByID(this, account.Role);
            ListOrderDetail.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvOrdersList.DataSource = OrderDAO.Instance.searchOrderByEmployee(txtSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.OrderID = dgvOrdersList.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("Are you sure remove this Order?", "Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool isRemoved = OrderDAO.Instance.deleteOrder(order.OrderID);
                if (isRemoved == true)
                {
                    MessageBox.Show("Remove Product successfully!", "Notification");
                    dgvOrdersList.DataSource = OrderDAO.Instance.getListOrder();
                }
                else
                {
                    MessageBox.Show("Can not remove this Order!", "Notification");
                }
            }
        }

        private void btnOrderDetailList_Click(object sender, EventArgs e)
        {
            fListOrderDetail flistOrderDetail = new fListOrderDetail();
            flistOrderDetail.ShowDialog();
        }
    }
}
