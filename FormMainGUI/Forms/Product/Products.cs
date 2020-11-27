using System;
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
        Product pro = new Product();
        ProductsDetail proDetail = new ProductsDetail();
        public Products()
        {

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            InitializeComponent();
            btnAdd.Size = new System.Drawing.Size(100, 36);
            btnDelete.Size= new System.Drawing.Size(100, 36);
            btnUpdate.Size= new System.Drawing.Size(100, 36);
            btnDelete.AutoSize = false;
            btnAdd.AutoSize = false;
            btnUpdate.AutoSize = false;
        }

    

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            add add = new add();
            //add.AutoSize = false;
            //add.Size = new System.Drawing.Size(600, 603);
            add.ShowDialog();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            using (var db = DataProvider.Ins.DB)
            {
                var r = db.Products.Where(x => x.ProductID == pro.ProductID).SingleOrDefault();
                var d = db.ProductsDetails.Where(y => y.ProductDetailID == proDetail.ProductDetailID).SingleOrDefault();
                db.Products.Remove(r);
                db.ProductsDetails.Remove(d);
                db.SaveChanges();
            }
            MessageBox.Show("remove");
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            Update update = new Update(pro,proDetail);

            update.ShowDialog();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            var db = DataProvider.Ins.DB;
            var result = from c in db.Products
                         join d in db.ProductsDetails
                         on c.ProductID equals d.ProductID
                         where c.ProductID == d.ProductID
                         select new
                         {
                             ID = c.ProductID,
                             Name = c.Name,
                             Quantity = c.Quantity,
                             Price = c.Price,
                             ProductDetailID = d.ProductDetailID,
                             Status = d.Status,
                             MFG = d.MFG,
                             EXP = d.EXP,
                             ProductEntryDate = d.ProductEntryDate
                         };
            dgvProduct.DataSource = result.ToList();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvProduct.Rows[e.RowIndex];
                pro.ProductID = dgvRow.Cells[0].Value.ToString();
                pro.Name = dgvRow.Cells[1].Value.ToString();
                pro.Quantity = Convert.ToInt32(dgvRow.Cells[2].Value.ToString());
                pro.Price = Convert.ToInt32(dgvRow.Cells[3].Value.ToString());
                proDetail.ProductDetailID = dgvRow.Cells[4].Value.ToString();
                proDetail.Status = dgvRow.Cells[5].Value.ToString();
                proDetail.MFG = Convert.ToDateTime(dgvRow.Cells[6].Value.ToString());
                proDetail.EXP = Convert.ToDateTime(dgvRow.Cells[7].Value.ToString());
                proDetail.ProductEntryDate = Convert.ToDateTime(dgvRow.Cells[8].Value.ToString());
                proDetail.ProductID= dgvRow.Cells[0].Value.ToString();
            }            
        }
    }
}
