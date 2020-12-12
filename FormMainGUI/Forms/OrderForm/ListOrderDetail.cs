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
    public partial class ListOrderDetail : MaterialForm
    {
        public ListOrderDetail()
        {
            InitializeComponent();
            btnUpdate.AutoSize = false;
            btnUpdate.Size = new System.Drawing.Size(100, 66);
            btnUpdate.Enabled = false;
        }

        private void ListOrderDetail_Load(object sender, EventArgs e)
        {
            dgvOrderDetailList.DataSource = OrderDAO.Instance.getListOrderDetail();
            dgvOrderDetailList.Columns[1].Width = 300;
        }

        private void dgvOrderDetailList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            txtID.Text = dgvOrderDetailList.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvOrderDetailList.CurrentRow.Cells[1].Value.ToString();
            numbericQuantity.Value = Convert.ToInt32(dgvOrderDetailList.CurrentRow.Cells[2].Value.ToString());
            txtPrice.Text = dgvOrderDetailList.CurrentRow.Cells[3].Value.ToString();
            txtTotal.Text = dgvOrderDetailList.CurrentRow.Cells[4].Value.ToString();
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

                    if (MessageBox.Show("Are you sure update this Order detail?", "Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool isRemoved = OrderDAO.Instance.updateOrderDetail(ordersDetail);
                        if (isRemoved == true)
                        {
                            MessageBox.Show("Update Product successfully!", "Notification");
                            dgvOrderDetailList.DataSource = OrderDAO.Instance.getListOrderDetail();
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
    }
}
