using FormMainGUI.ModelDB;
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

namespace FormMainGUI.Forms.OrderForm
{
    public partial class fAddToCart : MaterialForm
    {
        fOrdersDetail orders;
        public fAddToCart(fOrdersDetail fOrders)
        {
            InitializeComponent();
            this.orders = fOrders;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            btnCancel.AutoSize = false;
            btnDone.AutoSize = false;
            btnCancel.Size = new System.Drawing.Size(100, 36);
            btnDone.Size = new System.Drawing.Size(100, 36);

            txtIDProduct.Size = new System.Drawing.Size(300, 36);
            txtNameProduct.Size = new System.Drawing.Size(300, 36);
            txtPrice.Size = new System.Drawing.Size(300, 36);
        }

        private void fAddToCart_Load(object sender, EventArgs e)
        {
            if (fOrdersDetail.isUpdate)
            {
                txtIDProduct.Text = orders.dgvCart.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = orders.dgvCart.CurrentRow.Cells[1].Value.ToString(); ;
                numbericQuantity.Value = Convert.ToDecimal(orders.dgvCart.CurrentRow.Cells[2].Value.ToString());
                txtPrice.Text = Convert.ToString(orders.dgvCart.CurrentRow.Cells[3].Value.ToString());
            }
            else
            {
                txtIDProduct.Text = orders.dgvProductInOrder.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = orders.dgvProductInOrder.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = Convert.ToString(orders.dgvProductInOrder.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //caculate total money when add/update a product into the table
            float totalMoney;
            float price = float.Parse(txtPrice.Text);
            int quantity = Convert.ToInt32(numbericQuantity.Value);
            totalMoney = price * (float)quantity;

            // quantity remaining product in the warehouse
            int quantityRemaining = Convert.ToInt32(this.orders.dgvProductInOrder.CurrentRow.Cells[2].Value);

            if (fOrdersDetail.isUpdate)
            {
                for (int i = 0; i < this.orders.dgvProductInOrder.Rows.Count; i++)
                {
                    if (this.orders.dgvCart.CurrentRow.Cells["colID"].Value.ToString().Contains(this.orders.dgvProductInOrder.Rows[i].Cells[0].Value.ToString()))
                    {
                        int quantityUpdate = Convert.ToInt32(this.orders.dgvProductInOrder.Rows[i].Cells[2].Value) + Convert.ToInt32(this.orders.dgvCart.CurrentRow.Cells[2].Value);
                        if (numbericQuantity.Value > 0 && numbericQuantity.Value <= quantityUpdate)
                        {
                            this.orders.dgvProductInOrder.Rows[i].Cells[2].Value = Convert.ToInt32(this.orders.dgvProductInOrder.Rows[i].Cells[2].Value)
                                                                                 - quantity + Convert.ToInt32(this.orders.dgvCart.CurrentRow.Cells[2].Value);

                            this.orders.dgvCart.CurrentRow.Cells["colQuantity"].Value = numbericQuantity.Value;
                            this.orders.dgvCart.CurrentRow.Cells["colTotalMoney"].Value = totalMoney;

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sorry, the quantity you enter is incorrect!!!", "Notification");
                        }
                    }
                }
            }
            else
            {
                if (numbericQuantity.Value > 0 && numbericQuantity.Value <= Convert.ToInt32(this.orders.dgvProductInOrder.CurrentRow.Cells[2].Value))
                {
                    if (this.orders.dgvCart.Rows.Count == 0)
                    {
                        this.orders.dgvCart.Rows.Add(txtIDProduct.Text, txtNameProduct.Text, numbericQuantity.Value.ToString(), txtPrice.Text, totalMoney);
                        this.orders.dgvProductInOrder.CurrentRow.Cells[2].Value = quantityRemaining - quantity;
                    }
                    else
                    {
                        int sum;
                        int count = 0;
                        for (int i = 0; i < this.orders.dgvCart.Rows.Count; i++)
                        {
                            //caculate quantity and total money when add new products with the same ID product.
                            if (txtIDProduct.Text.Contains(this.orders.dgvCart.Rows[i].Cells["colID"].Value.ToString()))
                            {
                                //caculate quantity remaining in the warehouse
                                this.orders.dgvProductInOrder.CurrentRow.Cells[2].Value = quantityRemaining - quantity;

                                //caculate quantity
                                sum = Convert.ToInt32(this.orders.dgvCart.Rows[i].Cells[2].Value);
                                sum += Convert.ToInt32(numbericQuantity.Value.ToString());
                                this.orders.dgvCart.Rows[i].Cells["colQuantity"].Value = sum;
                                count++;

                                //caculate total money.
                                price = float.Parse(txtPrice.Text);
                                quantity = sum;
                                this.orders.dgvCart.Rows[i].Cells["colTotalMoney"].Value = price * (float)quantity;
                            }
                        }
                        if (count != 1)
                        {
                            this.orders.dgvCart.Rows.Add(txtIDProduct.Text, txtNameProduct.Text, numbericQuantity.Value.ToString(), txtPrice.Text, totalMoney);
                            this.orders.dgvProductInOrder.CurrentRow.Cells[2].Value = quantityRemaining - quantity;
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sorry, the quantity you enter is incorrect!!!", "Notification");
                }
            }

            //caculate total amount in orders
            float totalAmount = 0;
            for (int i = 0; i < this.orders.dgvCart.Rows.Count; i++)
            {
                totalAmount += float.Parse(this.orders.dgvCart.Rows[i].Cells[4].Value.ToString());
            }
            this.orders.txtTotalAmount.Text = totalAmount.ToString();
        }
    }
}
