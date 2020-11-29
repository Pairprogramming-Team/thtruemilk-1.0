using FormMainGUI.Forms.OrderForm;
using FormMainGUI.ModelDB;
using FormMainGUI.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FormMainGUI.Forms
{
    public partial class fOrders : MaterialForm
    {
        //Product product = new Product();
        public fOrders()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            btnDelete.AutoSize = false;
            btnUpdate.AutoSize = false;
            btnDone.AutoSize = false;
            btnAddToCart.AutoSize = false;

            btnDelete.Size = new System.Drawing.Size(100, 36);
            btnUpdate.Size = new System.Drawing.Size(100, 36);
            btnDone.Size = new System.Drawing.Size(100, 36);
            btnAddToCart.Size = new System.Drawing.Size(150, 36);

            btnDelete.Enabled = false;
            btnDone.Enabled = false;
            btnUpdate.Enabled = false;

            dgvCart.AllowUserToAddRows = false;
        }

        private void fOrders_Load(object sender, EventArgs e)
        {
            var db = DataProvider.Ins.DB;
            var listProducts = from p in db.Products
                               select p;
            dgvProductInOrder.DataSource = listProducts.ToList();
            dgvProductInOrder.Columns[4].Visible = false;
            dgvProductInOrder.Columns[5].Visible = false;
        }
        
        private void dgvProductInOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvProductInOrder.Rows[index].Selected = true;

            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dgvProductInOrder.Rows[e.RowIndex];
            //    product.ProductID = row.Cells[0].Value.ToString();
            //    product.Name = row.Cells[1].Value.ToString();
            //    product.Price = Convert.ToInt32(row.Cells[3].Value.ToString());
            //}
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProductInOrder.SelectedRows.Count == 1)
            {
                fAddToCart fAddToCart = new fAddToCart(this);
                fAddToCart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a product!!!", "Notification");
            }
            

                //DataGridViewRow a = (DataGridViewRow)dgvCart.Rows[0].Clone();
                //a.Cells[0].Value = row.Cells[0].Value.ToString();
                //a.Cells[1].Value = "cac";
                //dgvCart.Rows.Add(a);
                ////dgvCart.Rows.Add(row.Cells[1].Value.ToString());
        }

        private void dgvCartInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //float TotalAmount;
            //for (int i = 0; i < dgvCartInfo.Rows.Count - 1; i++)
            //{
            //    TotalAmount += float.Parse(dgvCartInfo.Rows[i].Cells["Price"].Value.ToString());
            //}
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var listProductSearch = from l in DataProvider.Ins.DB.Products
                                    where l.Name.Trim().Contains(txtSearch.Text)
                                    select l;
            dgvProductInOrder.DataSource = listProductSearch.ToList();
        }

        private void dgvCart_RowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnDone.Enabled = true;

            float totalAmount = 0;
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {
                totalAmount += float.Parse(dgvCart.Rows[i].Cells[4].Value.ToString());
            }
            txtTotalAmount.Text = totalAmount.ToString();
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvCart.Rows[index].Selected = true;

            if (dgvCart.SelectedRows.Count > 0)
            {
                btnDelete.Enabled = true;
            }

            if (dgvCart.SelectedRows.Count == 1)
            {
                btnUpdate.Enabled = true;
            }             
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            foreach (DataGridViewRow item in this.dgvCart.SelectedRows)
            {
                dgvCart.Rows.RemoveAt(item.Index);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }
    }
}
