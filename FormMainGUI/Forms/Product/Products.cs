using FormMainGUI.DAO;
using FormMainGUI.ModelDB;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            btnAddDetail.Size = new System.Drawing.Size(100, 36);
            btnDeleteDetail.Size = new System.Drawing.Size(100, 36);
            btnUpdateDetail.Size = new System.Drawing.Size(100, 36);
            btnDelete.AutoSize = false;
            btnAdd.AutoSize = false;
            btnUpdate.AutoSize = false;
            btnDeleteDetail.AutoSize = false;
            btnAddDetail.AutoSize = false;
            btnUpdateDetail.AutoSize = false;
            txtSearch.Size = new System.Drawing.Size(381, 28);
        }
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.Text = "ADD PRODUCT";
            add.ShowDialog();
            dgvProduct.DataSource = ProductsDAO.Instance.loadListProducts();
        }
        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure remove this Product?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ModelDB.Product b = new ModelDB.Product(pro.ProductID, pro.Name, Convert.ToInt32(pro.Quantity), Convert.ToInt32(pro.Price));
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

            add add = new add(pro);
            add.Text = "UPDATE PRODUCT";
            add.ShowDialog(); dgvProduct.DataSource = ProductsDAO.Instance.loadListProducts();

        }
        private void Products_Load(object sender, EventArgs e)
        {
            statusList = ProductsDAO.Instance.getStatusList();
            dgvProduct.DataSource = ProductsDAO.Instance.loadListProducts();
            dgvDetail.DataSource = ProductsDAO.Instance.loadListDetail(pro.ProductID);
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
                dgvDetail.DataSource = ProductsDAO.Instance.loadListDetail(pro.ProductID);
            }
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            dgvProduct.DataSource = ProductsDAO.Instance.Search(id);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetail.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvDetail.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvDetail.Rows[selectedrowindex];
                proDetail.ProductDetailID = selectedRow.Cells[0].Value.ToString();
                proDetail.Status = selectedRow.Cells[1].Value.ToString();
                proDetail.MFG = Convert.ToDateTime(selectedRow.Cells[2].Value.ToString());
                proDetail.EXP = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
                proDetail.ProductEntryDate = Convert.ToDateTime(selectedRow.Cells[4].Value.ToString());
                proDetail.ProductID = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            fProductDetail add = new fProductDetail(statusList, null, pro);
            add.ShowDialog();
            dgvDetail.DataSource = ProductsDAO.Instance.loadListDetail(pro.ProductID);
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            fProductDetail update = new fProductDetail(statusList, proDetail);
            update.Text = "UPDATE PRODUCT DETAIL";
            update.ShowDialog();
            dgvDetail.DataSource = ProductsDAO.Instance.loadListDetail(pro.ProductID);
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure remove this Product Detail?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ModelDB.ProductsDetail b = new ModelDB.ProductsDetail(proDetail.ProductDetailID, proDetail.Status, (DateTime)proDetail.MFG, (DateTime)proDetail.EXP, (DateTime)proDetail.ProductEntryDate, proDetail.ProductID);
                bool isRemoved = ProductsDAO.Instance.removeDetail(proDetail.ProductDetailID);
                if (isRemoved == true)
                {
                    MessageBox.Show("Remove successful Product Detail!", "");
                    dgvProduct.DataSource = ProductsDAO.Instance.loadListProducts();
                }
                else
                {
                    MessageBox.Show("Can not remove Product Detail!", "");
                }
            }
        }
    }

}
