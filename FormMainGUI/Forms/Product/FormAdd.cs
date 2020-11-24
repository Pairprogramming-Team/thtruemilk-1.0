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

namespace FormMainGUI.Forms
{
    public partial class add : MaterialForm
    {
        public add()
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
            txtID.Size= new System.Drawing.Size(205, 28);
            txtName.Size = new System.Drawing.Size(205, 28);
            txtPrice.Size = new System.Drawing.Size(205, 28);
            txtProDetailID.Size = new System.Drawing.Size(205, 28);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

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

        private void btnSave1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            ProductsDetail pDetail = new ProductsDetail();
           
            try
            {
                p.ProductID = txtID.Text;
                p.Name = txtName.Text;
                p.Quantity = Convert.ToInt32(Quantity.Value);
                p.Price = Convert.ToInt32(txtPrice.Text);
                pDetail.ProductDetailID = txtProDetailID.Text;
                pDetail.Status = Convert.ToString(cmbStatus.SelectedIndex);
                pDetail.MFG = MFG.Value;
                pDetail.EXP = EXP.Value;
                pDetail.ProductEntryDate = ProductEntryDate.Value;
                Console.WriteLine(p.Name, p.ProductID);
                using (var db = DataProvider.Ins.DB)
                {
                    db.Products.Add(p);
                    db.ProductsDetails.Add(pDetail);
                    db.SaveChanges();
                   
                }
                MessageBox.Show("add successfully");
           
            }
            catch (Exception)
            {
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
                else if (txtProDetailID.Text == "")
                {
                    MessageBox.Show("Invalid Product Detail ID value ");
                    return;
                }
                else if (EXP.Value < DateTime.Now)
                {
                    MessageBox.Show("Invalid EXP value");
                    return;
                }
                DialogResult = DialogResult.Cancel;

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

        }


    }
}
