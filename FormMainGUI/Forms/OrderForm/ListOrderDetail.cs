using FormMainGUI.DAO;
using FormMainGUI.Utils;
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
    public partial class fListOrderDetail : MaterialForm
    {
        public fListOrderDetail()
        {
            InitializeComponent();            
        }

        private void fListOrderDetail_Load(object sender, EventArgs e)
        {
            dgvListOrderDetail.DataSource = OrderDAO.Instance.getListOrderDetail();
            dgvListOrderDetail.Columns[0].Width = 100;
            dgvListOrderDetail.Columns[1].Width = 300;
        }
    }
}
