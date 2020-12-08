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
    public partial class fOrdersDetail : MaterialForm
    {
        public static bool isUpdate = true;
        public fOrdersDetail()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            btnDone.AutoSize = false;
            btnUpdate.AutoSize = false;
            btnDelete.AutoSize = false;
            btnAddToCart.AutoSize = false;

            btnDone.Size = new System.Drawing.Size(100, 36);
            btnUpdate.Size = new System.Drawing.Size(100, 36);
            btnDelete.Size = new System.Drawing.Size(100, 36);
            btnAddToCart.Size = new System.Drawing.Size(150, 36);

            btnDone.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            dgvCart.AllowUserToAddRows = false;
        }

        private void fOrders_Load(object sender, EventArgs e)
        {
            dgvProductInOrder.DataSource = OrderDAO.Instance.getListProduct();
            dgvProductInOrder.Columns[4].Visible = false;
            dgvProductInOrder.Columns[5].Visible = false;
            this.Dock = DockStyle.Fill;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            if (dgvProductInOrder.SelectedRows.Count == 1)
            {
                if (!dgvProductInOrder.CurrentRow.Cells[2].Value.Equals(0))
                {
                    fAddToCart fAddToCart = new fAddToCart(this);
                    fAddToCart.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sorry, This product is out of stock!!!", "Notification");
                }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 0)
            {
                for (int i = 0; i < dgvProductInOrder.Rows.Count; i++)
                {
                    if (dgvCart.CurrentRow.Cells["colID"].Value.ToString().Contains(dgvProductInOrder.Rows[i].Cells[0].Value.ToString()))
                    {
                        dgvProductInOrder.Rows[i].Cells[2].Value = Convert.ToInt32(dgvProductInOrder.Rows[i].Cells[2].Value)
                                                                 + Convert.ToInt32(dgvCart.CurrentRow.Cells[2].Value);
                    }
                }

                foreach (DataGridViewRow item in this.dgvCart.SelectedRows)
                {
                    dgvCart.Rows.RemoveAt(item.Index);
                }
            }
            else
            {

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

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCart.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDone.Enabled = true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }
    }
}
