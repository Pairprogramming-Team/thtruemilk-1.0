using FormMainGUI.DAO;
using FormMainGUI.Forms.OrderForm;
using FormMainGUI.ModelDB;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
namespace FormMainGUI.Forms
{
    public partial class fOrdersDetail : MaterialForm
    {
        public static bool isUpdate = true;
        fOrders fOrders;
        private ModelDB.Account account1;
        public fOrdersDetail(fOrders fOrders, Account account)
        {
            InitializeComponent();
            this.fOrders = fOrders;
            this.account1 = account;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            btnDone.AutoSize = false;
            btnUpdate.AutoSize = false;
            btnDelete.AutoSize = false;
            btnAddToCart.AutoSize = false;

            btnDone.Size = new System.Drawing.Size(100, 36);
            btnUpdate.Size = new System.Drawing.Size(100, 36);
            btnDelete.Size = new System.Drawing.Size(100, 36);
            btnAddToCart.Size = new System.Drawing.Size(150, 36);

            btnDone.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            dgvCart.AllowUserToAddRows = false;
        }

        private void fOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHTrueMilkDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.tHTrueMilkDataSet1.Products);

            dgvProductInOrder.DataSource = ProductsDAO.Instance.loadListProducts();
            this.Dock = DockStyle.Fill;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            if (!dgvProductInOrder.CurrentRow.Cells[2].Value.Equals(0))
            {
                fAddToCart fAddToCart = new fAddToCart(this);
                fAddToCart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry, This product is out of stock!!!", "Notification");
            }
        }

        private void dgvCart_RowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnDone.Enabled = true;
        }

        private void dgvCart_RowRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            float totalAmount = 0;
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {
                totalAmount += float.Parse(dgvCart.Rows[i].Cells["colTotalMoney"].Value.ToString());
            }
            txtTotalAmount.Text = totalAmount.ToString();

            if (dgvCart.Rows.Count == 0)
            {
                btnDone.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProductInOrder.DataSource = ProductsDAO.Instance.Search(txtSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 0)
            {
                for (int i = 0; i < dgvProductInOrder.Rows.Count; i++)
                {
                    if (dgvCart.CurrentRow.Cells["colID"].Value.ToString().Contains(dgvProductInOrder.Rows[i].Cells[0].Value.ToString()))
                    {
                        dgvProductInOrder.Rows[i].Cells[2].Value = Convert.ToInt32(dgvProductInOrder.Rows[i].Cells[2].Value)
                                                                 + Convert.ToInt32(dgvCart.CurrentRow.Cells["colQuantity"].Value);
                    }
                }

                foreach (DataGridViewRow item in this.dgvCart.SelectedRows)
                {
                    dgvCart.Rows.RemoveAt(item.Index);
                }
            }
            else
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            if (dgvCart.SelectedRows.Count == 1)
            {
                fAddToCart fAddToCart = new fAddToCart(this);
                fAddToCart.Text = "UPDATE CART";
                fAddToCart.ShowDialog();
            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCart.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "")
            {
                MessageBox.Show("Please enter OrderID!!!. This cell can not be empty!!!");
                txtOrderID.Focus();
            }
            else
            {
                //Add order to DB
                Order order = new Order();
                order.OrderID = txtOrderID.Text;
                order.DateOfOrder = DateTime.Today;
                order.TotalMoney = Convert.ToDecimal(txtTotalAmount.Text);
                order.EmployeeID = account1.EmployeeID;
                bool isCreateOrder = OrderDAO.Instance.addOrder(order);

                //Add order detail to DB                
                bool isCreateOrderDetail = false;
                for (int i = 0; i < dgvCart.Rows.Count; i++)
                {
                    OrdersDetail ordersDetail = new OrdersDetail();
                    ordersDetail.OrderDetailID = dgvCart.Rows[i].Cells["colIDDetail"].Value.ToString();
                    ordersDetail.Quantity = Convert.ToInt32(dgvCart.Rows[i].Cells["colQuantity"].Value.ToString());
                    ordersDetail.TotalAmount = Convert.ToDecimal(dgvCart.Rows[i].Cells["colTotalMoney"].Value.ToString());
                    ordersDetail.OrderID = txtOrderID.Text;
                    ordersDetail.ProductID = dgvCart.Rows[i].Cells["colID"].Value.ToString();
                    isCreateOrderDetail = OrderDAO.Instance.addOrderDetail(ordersDetail);
                }

                //update product to DB
                bool isUpdateProduct = false;
                for (int i = 0; i < dgvCart.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvProductInOrder.Rows.Count; j++)
                    {
                        if (dgvCart.Rows[i].Cells["colID"].Value.Equals(dgvProductInOrder.Rows[j].Cells[0].Value))
                        {
                            Product product = new Product();
                            product.ProductID = dgvProductInOrder.Rows[j].Cells[0].Value.ToString();
                            product.Name = dgvProductInOrder.Rows[j].Cells[1].Value.ToString();
                            product.Quantity = Convert.ToInt32(dgvProductInOrder.Rows[j].Cells[2].Value.ToString());
                            product.Price = Convert.ToDecimal(dgvProductInOrder.Rows[j].Cells[3].Value.ToString());
                            isUpdateProduct = OrderDAO.Instance.updateProduct(product);
                        }
                    }
                }

                if (isCreateOrder == true && isCreateOrderDetail == true && isUpdateProduct == true)
                {
                    MessageBox.Show("Create order successfully!!!", "Notification");
                    this.fOrders.dgvOrdersList.DataSource = OrderDAO.Instance.getListOrder();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Create order failed!!!");
                }
            }
        }

        private void fOrdersDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {
                for (int j = 0; j < dgvProductInOrder.Rows.Count; j++)
                {
                    if (dgvCart.Rows[i].Cells["colID"].Value.ToString().Contains(dgvProductInOrder.Rows[j].Cells[0].Value.ToString()))
                    {
                        dgvProductInOrder.Rows[j].Cells[2].Value = Convert.ToInt32(dgvProductInOrder.Rows[j].Cells[2].Value)
                                                                + Convert.ToInt32(dgvCart.Rows[i].Cells[3].Value);
                    }
                }
            }
        }
    }
}
