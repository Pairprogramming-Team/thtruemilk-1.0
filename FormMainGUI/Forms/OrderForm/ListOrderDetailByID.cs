using FormMainGUI.DAO;
using FormMainGUI.ModelDB;
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

namespace FormMainGUI.Forms.OrderForm
{
    public partial class ListOrderDetailByID : MaterialForm
    {
        fOrders order;
        public ListOrderDetailByID(fOrders order)
        {
            InitializeComponent();
            this.order = order;
            txtNameEmployee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            btnUpdate.AutoSize = false;
            btnUpdate.Size = new System.Drawing.Size(100, 66);
            btnUpdate.Enabled = false;
        }

        private void ListOrderDetail_Load(object sender, EventArgs e)
        {
            txtNameEmployee.Text = this.order.dgvOrdersList.CurrentRow.Cells[3].Value.ToString();
            string OrderID = this.order.dgvOrdersList.CurrentRow.Cells[0].Value.ToString();
            dgvOrderDetailList.DataSource = OrderDAO.Instance.getListOrderDetailByOrderID(OrderID);            
            dgvOrderDetailList.Columns[1].Width = 300;
            dgvOrderDetailList.Columns[0].Width = 120;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetailList.SelectedRows.Count != 0)
            {
                if (numbericQuantity.Value > 0)
                {
                    OrdersDetail ordersDetail = new OrdersDetail();
                    ordersDetail.OrderDetailID = txtID.Text;
                    ordersDetail.Quantity = Convert.ToInt32(numbericQuantity.Value.ToString());
                    ordersDetail.TotalAmount = Convert.ToDecimal(txtPrice.Text) * Convert.ToInt32(numbericQuantity.Value.ToString());

                    

                    string OrderID = this.order.dgvOrdersList.CurrentRow.Cells[0].Value.ToString();
                    if (MessageBox.Show("Are you sure update this Order detail?", "Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool isUpdated = OrderDAO.Instance.updateOrderDetail(ordersDetail);
                        
                        if (isUpdated == true)
                        {
                            MessageBox.Show("Update Product successfully!", "Notification");
                            dgvOrderDetailList.DataSource = OrderDAO.Instance.getListOrderDetailByOrderID(OrderID);

                            Order order = new Order();
                            decimal sum = 0;
                            order.OrderID = this.order.dgvOrdersList.CurrentRow.Cells[0].Value.ToString();
                            order.DateOfOrder = Convert.ToDateTime(this.order.dgvOrdersList.CurrentRow.Cells[1].Value.ToString());
                            order.EmployeeID = this.order.dgvOrdersList.CurrentRow.Cells[2].Value.ToString();
                            for (int i = 0; i < dgvOrderDetailList.Rows.Count; i++)
                            {
                                order.TotalMoney = sum + Convert.ToDecimal(dgvOrderDetailList.Rows[i].Cells[4].Value);
                            }
                            OrderDAO.Instance.updateOrderByTotalMoney(order);

                            this.order.dgvOrdersList.DataSource = OrderDAO.Instance.getListOrder();
                        }
                        else
                        {
                            MessageBox.Show("Can not update this Order detail!", "Notification");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, the quantity you enter is incorrect!!!", "Notification");
                    numbericQuantity.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Please choose an order detail to update!!!", "Notification");
            }
            
        }

        private void dgvOrderDetailList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrderDetailList.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvOrderDetailList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvOrderDetailList.Rows[selectedrowindex];
                btnUpdate.Enabled = true;
                txtID.Text = dgvOrderDetailList.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvOrderDetailList.CurrentRow.Cells[1].Value.ToString();
                numbericQuantity.Value = Convert.ToInt32(dgvOrderDetailList.CurrentRow.Cells[2].Value.ToString());
                txtPrice.Text = dgvOrderDetailList.CurrentRow.Cells[3].Value.ToString();
                txtTotal.Text = dgvOrderDetailList.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
