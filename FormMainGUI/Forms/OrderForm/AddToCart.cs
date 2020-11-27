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
        Product pro = new Product();
        public fAddToCart(Product product)
        {
            InitializeComponent();
            this.pro = product;
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
            txtIDProduct.Text = pro.ProductID;
            txtNameProduct.Text = pro.Name;
            txtPrice.Text = Convert.ToString(pro.Price);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }
    }
}
