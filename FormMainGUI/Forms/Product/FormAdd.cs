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
using FormMainGUI.DAO;
using MaterialSkin.Controls;
using FormMainGUI.ModelDB;
using System.Data.SqlClient;
using System.Globalization;

namespace FormMainGUI.Forms
{
    public partial class add : MaterialForm
    {
        private Product product;
        private bool isUpdate = false;

        public add(Product product= null)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //add add = new add();
            //add.Size= new System.Drawing.Size(600,603);
            btnCancle.AutoSize = false;
            btnSave.AutoSize = false;
            btnSave.Size = new System.Drawing.Size(100, 36);
            btnCancle.Size = new System.Drawing.Size(100, 36);
            txtID.Size = new System.Drawing.Size(205, 28);
            txtName.Size = new System.Drawing.Size(205, 28);
            txtPrice.Size = new System.Drawing.Size(205, 28);
            this.product = product;
            if (product != null)
            {
                btnSave.Text = "UPDATE";
                isUpdate = true;
            }
        }
 
        private void btnCancle_Click(object sender, EventArgs e)
        {

            string message = "Do you want to cancel?";
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

        private void add_Load(object sender, EventArgs e)
            
        {
            if (product != null)
            {
                txtID.Text = product.ProductID;
                txtName.Text = product.Name;
                Quantity.Value = Convert.ToInt32(product.Quantity);
                txtPrice.Text = Convert.ToString(product.Price);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string name = txtName.Text;
                int quantity = Convert.ToInt32(Quantity.Value);
                int price = Convert.ToInt32(txtPrice.Text);

                bool isSuccess = false;
                ModelDB.Product a = new ModelDB.Product(id, name, quantity, price);
                if (isUpdate)
                {
                    isSuccess = ProductsDAO.Instance.updateProduct(a);
                    if (isSuccess)
                    {
                        MessageBox.Show("Update Product Successful!", "");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update Product Fail!", "");
                    }
                }
                else
                {
                    isSuccess = ProductsDAO.Instance.productAdd(a);
                    if (isSuccess)
                    {
                        MessageBox.Show("Add Product Successful!", "");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Add Product Fail!", "");
                    }
                }
                if (txtID.Text == "")
                {
                    MessageBox.Show("Invalid ID value");
                    return;
                }
                else if (txtName.Text == "")
                {
                    MessageBox.Show("Invalid name value ");
                    return;
                }

                else if (Quantity.Value == 0)
                {
                    MessageBox.Show("Invalid quantity value");
                    return;
                }
                else if (txtPrice.Text == "" & Convert.ToInt32(txtPrice.Text) <= 0)
                {
                    MessageBox.Show("Invalid Price value");
                    return;
                }
            
            }
            catch (Exception)
            {
                throw;              
            }    
        }
    }
}
