using System;
using FormMainGUI.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MaterialSkin;
using FormMainGUI.Utils;
using MaterialSkin.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormMainGUI.ModelDB;

namespace FormMainGUI.Forms
{
    public partial class Products : Form

    {
        private List<String> statusList;
        Product pro = new Product();
        ProductsDetail proDetail = new ProductsDetail();
        public Products()
        {

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            InitializeComponent();
            btnAdd.Size = new System.Drawing.Size(100, 36);
            btnDelete.Size = new System.Drawing.Size(100, 36);
            btnUpdate.Size = new System.Drawing.Size(100, 36);
            btnDelete.AutoSize = false;
            btnAdd.AutoSize = false;
            btnUpdate.AutoSize = false;
            txtSearch.Size = new System.Drawing.Size(381, 28);
        }
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            add add = new add(statusList);
            add.Text = "ADD PRODUCT";
            add.ShowDialog();
            dgvProduct.DataSource = ProductsDAO.Instance.loadListProducts();
        }
        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure remove this Product?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ModelDB.Product b = new ModelDB.Product(pro.ProductID,pro.Name,Convert.ToInt32(pro.Quantity),Convert.ToInt32(pro.Price));
                bool isRemoved = ProductsDAO.Instance.removeProduct(pro.ProductID);
                if (isRemoved == true)
                {
                    MessageBox.Show("Remove successful Product!", "");
                    dgvProduct.DataSource = ProductsDAO.Instance.loadListProducts();
                }
                else
                {
                    MessageBox.Show("Can not remove Product!", "");
                }
            }
        }
       
       
     
        private void btnUpdate1_Click(object sender, EventArgs e)
        {
        
                add add = new add(statusList,pro, proDetail);
                add.Text= "UPDATE PRODUCT";
                add.ShowDialog();
                dgvProduct.DataSource = ProductsDAO.Instance.loadListProducts();
        }
        private void Products_Load(object sender, EventArgs e)
        {
            statusList = ProductsDAO.Instance.getStatusList();
            dgvProduct.DataSource = ProductsDAO.Instance.loadListProducts();
            
        }

        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvProduct.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvProduct.Rows[selectedrowindex];
                pro.ProductID = selectedRow.Cells[0].Value.ToString();
                pro.Name = selectedRow.Cells[1].Value.ToString();
                pro.Quantity = Convert.ToInt32(selectedRow.Cells[2].Value.ToString());
                pro.Price = Convert.ToInt32(selectedRow.Cells[3].Value.ToString());
                proDetail.ProductDetailID = selectedRow.Cells[4].Value.ToString();
                proDetail.Status = selectedRow.Cells[5].Value.ToString();
                proDetail.MFG = Convert.ToDateTime(selectedRow.Cells[6].Value.ToString());
                proDetail.EXP = Convert.ToDateTime(selectedRow.Cells[7].Value.ToString());
                proDetail.ProductEntryDate = Convert.ToDateTime(selectedRow.Cells[8].Value.ToString());
                proDetail.ProductID = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            var db = DataProvider.Ins.DB;
            var result = (from c in db.Products
                          join d in db.ProductsDetails
                          on c.ProductID equals d.ProductID
                          where  c.Name.Contains(txtSearch.Text)
                          select new
                          {
                              ID = c.ProductID,
                              Name = c.Name,
                              Quantity = c.Quantity,
                              Price = c.Price,
                              ProductDetailID = d.ProductDetailID,
                              Status = (d.Status),
                              MFG = d.MFG,
                              EXP = d.EXP,
                              ProductEntryDate = d.ProductEntryDate
                          }
                    ).ToList();
            dgvProduct.DataSource = result;
        }
    }
    
}
