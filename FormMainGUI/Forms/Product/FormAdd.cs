using FormMainGUI.DAO;
using FormMainGUI.ModelDB;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FormMainGUI.Forms
{
    public partial class add : MaterialForm
    {
        private Product product;
        private bool isUpdate = false;

        public add(Product product = null)
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
                txtID.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            try
            {
                string id = txtID.Text;
                string name = txtName.Text;
                int quantity = 0;
                int price = 0;

                if (id == "")
                {
                    MessageBox.Show("Invalid ID value");
                    txtID.Focus();
                    return;
                }

                if (name == "")
                {
                    MessageBox.Show("Invalid name value ");
                    txtName.Focus();
                    return;
                }

                try
                {
                    quantity = Convert.ToInt32(Quantity.Value);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid quantity value");
                    Quantity.Focus();
                    return;
                }

                try
                {
                    price = Convert.ToInt32(txtPrice.Text);
                    if (price < 0)
                    {
                        MessageBox.Show("Invalid Price value");
                        txtPrice.Focus();
                        return;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Price value");
                    txtPrice.Focus();
                    return;
                }


                ModelDB.Product a = new ModelDB.Product(id, name, quantity, price);

                if (isUpdate)
                {
                    try
                    {
                        isSuccess = ProductsDAO.Instance.updateProduct(a);
                        MessageBox.Show("Update Product Successful!", "");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Update Product Fail!", "");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        isSuccess = ProductsDAO.Instance.productAdd(a);
                        MessageBox.Show("Add Product Successful!", "");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Add Product Fail!", "");
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong!!");
                return;
            }
        }
    }
}
