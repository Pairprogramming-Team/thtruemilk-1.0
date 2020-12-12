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

namespace FormMainGUI.Forms
{
    public partial class fProductDetail : MaterialForm
    {
        private List<String> statusList;
        private ProductsDetail productsDetail;
        private Product product;
        private bool isUpdate = false;
        public fProductDetail(List<String> statusList, ProductsDetail productsDetail=null,Product product=null)
        {
            InitializeComponent();
            btnCancle.AutoSize = false;
            btnSave.AutoSize = false;
            btnSave.Size = new System.Drawing.Size(100, 36);
            btnCancle.Size = new System.Drawing.Size(100, 36);
            txtproID.Size = new System.Drawing.Size(205, 28);
            txtProDetailID.Size = new System.Drawing.Size(205,28);
            this.statusList = statusList;
            this.productsDetail = productsDetail;
            this.product = product;
            txtproID.Enabled = false;
            if (productsDetail != null)
            {
                txtproID.Enabled = false;
                ProductEntryDate.Enabled = true;
                btnSave.Text = "UPDATE";
                isUpdate = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = false;
                if (txtProDetailID.Text == "")
                {
                    MessageBox.Show("Invalid Product Detail ID value ");
                    return;
                }
                else if (Convert.ToString(MFG.Value) == "" || MFG.Value >= DateTime.Now)
                {
                    MessageBox.Show("Invalid EXP value");
                    return;
                }
                else if (MFG.Value >= ProductEntryDate.Value)
                {
                    MessageBox.Show("Please check MFG( MFG must be less than ProductEntryDate) !!! ");
                    return;
                }
                else if (EXP.Value < DateTime.Now)
                {
                    MessageBox.Show("Invalid EXP value");
                    return;
                }
                ModelDB.ProductsDetail b = new ModelDB.ProductsDetail(txtProDetailID.Text, Convert.ToString(cmbStatus.SelectedItem), MFG.Value, EXP.Value, ProductEntryDate.Value, txtproID.Text);
                if (isUpdate)
                {
                    isSuccess = ProductsDAO.Instance.updateDetail(b);
                    if (isSuccess)
                    {
                        MessageBox.Show("Update Product Detail Successful!", "");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update Product Detail Fail!", "");
                    }
                }
                else
                {
                    isSuccess = ProductsDAO.Instance.addDetail(b);
                    if (isSuccess)
                    {
                        MessageBox.Show("Add Product Detail Successful!", "");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Add Product Detail Fail!", "");
                    }
                }
            }
            catch (Exception)
            {
                throw;
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

        private void fProductDetail_Load(object sender, EventArgs e)
        {

            cmbStatus.DataSource = statusList;
            if (productsDetail == null)
            { 
                txtproID.Text = product.ProductID;
            }
             else   if (productsDetail != null) {
                txtProDetailID.Text = productsDetail.ProductDetailID;
                cmbStatus.SelectedItem = productsDetail.Status;
                MFG.Value = (DateTime)productsDetail.MFG;
                EXP.Value = (DateTime)productsDetail.EXP;
                ProductEntryDate.Value = (DateTime)productsDetail.ProductEntryDate;
                txtproID.Text = productsDetail.ProductID;
            }
        }
    }
}
