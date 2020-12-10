using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using FormMainGUI.Utils;
using MaterialSkin.Controls;
using FormMainGUI.ModelDB;
using System.Data.Entity;

namespace FormMainGUI.Forms
{
    public partial class Update : MaterialForm
    {
        private Product product1;
        private ProductsDetail productsDetail1;
        public Update(Product product, ProductsDetail productsDetail)

        {

            this.product1 = product;
            this.productsDetail1 = productsDetail;

            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            btnCancle.AutoSize = false;
            btnSave.AutoSize = false;
            btnSave.Size = new System.Drawing.Size(100, 36);
            btnCancle.Size = new System.Drawing.Size(100, 36);
            txtID.Size = new System.Drawing.Size(205, 28);
            txtName.Size = new System.Drawing.Size(205, 28);
            txtPrice.Size = new System.Drawing.Size(205, 28);
            txtProDetailID.Size = new System.Drawing.Size(205, 28);
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      

        

        private void btnCancle1_Click(object sender, EventArgs e)
        {
            string message = "Do you want to cancel ?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            txtID.Text = product1.ProductID;
            txtName.Text = product1.Name;
            Quantity.Value = Convert.ToInt32(product1.Quantity);
            txtPrice.Text = Convert.ToString(product1.Price);
            txtProDetailID.Text = productsDetail1.ProductDetailID;
            cmbStatus.SelectedItem = productsDetail1.Status;
            MFG.Value = (DateTime)productsDetail1.MFG;
            EXP.Value = (DateTime)productsDetail1.EXP;
            ProEntryDate.Value = (DateTime)productsDetail1.ProductEntryDate;
            Console.WriteLine(productsDetail1.Status);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var db = DataProvider.Ins.DB;
                var r = db.Products.Where(x => x.ProductID == txtID.Text).SingleOrDefault();
                var d = db.ProductsDetails.Where(y => y.ProductID == txtID.Text).SingleOrDefault();

                r.Name = txtName.Text;
                r.Quantity = Convert.ToInt32(Quantity.Value);
                r.Price = Convert.ToInt32(txtPrice.Text);
                d.Status = Convert.ToString(cmbStatus.SelectedItem);
                d.MFG = MFG.Value;
                d.EXP = EXP.Value;
                d.ProductEntryDate = ProEntryDate.Value;

                db.SaveChanges();
            
            Products pro = new Products();
            pro.loadData();
            DialogResult = DialogResult.Cancel;
            //Products products = new Products();
            //products.loadData();

        }
    }
}
