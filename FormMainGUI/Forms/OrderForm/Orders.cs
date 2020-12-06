using FormMainGUI.DAO;
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

namespace FormMainGUI.Forms.OrderForm
{
    public partial class fOrders : MaterialForm
    {
        public fOrders()
        {
            InitializeComponent();

            btnDelete.AutoSize = false;
            btnAdd.AutoSize = false;
            btnUpdate.AutoSize = false;

            btnDelete.Size = new System.Drawing.Size(100, 36);
            btnAdd.Size = new System.Drawing.Size(100, 36);
            btnUpdate.Size = new System.Drawing.Size(100, 36);

        }

        private void fOrders_Load(object sender, EventArgs e)
        {
            dgvOrdersList.DataSource = OrderDAO.Instance.getListOrder();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fOrdersDetail fOrdersDetail = new fOrdersDetail();
            fOrdersDetail.ShowDialog();
        }
    }
}
