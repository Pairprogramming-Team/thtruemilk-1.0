using FormMainGUI.DAO;
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
        public static bool isUpdate = true;
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
            dgvProductInOrder.DataSource = OrderDAO.Instance.getListProduct();
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
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            if (dgvProductInOrder.SelectedRows.Count == 1)
            {
                fAddToCart fAddToCart = new fAddToCart(this);
                fAddToCart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a product!!!", "Notification");
            }
        }

        private void dgvCart_RowRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            float totalAmount = 0;
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {
                totalAmount += float.Parse(dgvCart.Rows[i].Cells[4].Value.ToString());
            }
            txtTotalAmount.Text = totalAmount.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProductInOrder.DataSource = OrderDAO.Instance.searchProductByName(txtSearch.Text);
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
            isUpdate = true;
            if (dgvCart.SelectedRows.Count == 1)
            {
                fAddToCart fAddToCart = new fAddToCart(this);
                fAddToCart.Text = "UPDATE CART";
                fAddToCart.ShowDialog();
            }            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }
    }
}
