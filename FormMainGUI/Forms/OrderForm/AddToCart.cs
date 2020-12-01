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
        fOrders orders;
        public fAddToCart(fOrders fOrders)
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
            if (fOrders.isUpdate)
            {
                txtIDProduct.Text = orders.dgvCart.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = orders.dgvCart.CurrentRow.Cells[1].Value.ToString(); ;
                numbericQuantity.Value = Convert.ToDecimal(orders.dgvCart.CurrentRow.Cells[2].Value.ToString());
                txtPrice.Text = Convert.ToString(orders.dgvCart.CurrentRow.Cells[3].Value.ToString());
            }
            else
            {
                txtIDProduct.Text = orders.dgvProductInOrder.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = orders.dgvProductInOrder.CurrentRow.Cells[1].Value.ToString(); ;
                txtPrice.Text = Convert.ToString(orders.dgvProductInOrder.CurrentRow.Cells[3].Value.ToString());
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            float totalMoney = 0;
            float price = float.Parse(txtPrice.Text);
            int quantity = Convert.ToInt32(numbericQuantity.Value);
            totalMoney = price * (float)quantity;

            if (fOrders.isUpdate)
            {
                int index = this.orders.dgvCart.CurrentRow.Index;
                this.orders.dgvCart.Rows.RemoveAt(this.orders.dgvCart.SelectedRows[0].Index);
                this.orders.dgvCart.Rows.Insert(index, txtIDProduct.Text, txtNameProduct.Text, numbericQuantity.Value.ToString(), txtPrice.Text, totalMoney);
            }
            else
            {
                this.orders.dgvCart.Rows.Add(txtIDProduct.Text, txtNameProduct.Text, numbericQuantity.Value.ToString(), txtPrice.Text, totalMoney);
            }    
            this.Close();
        }
    }
}
