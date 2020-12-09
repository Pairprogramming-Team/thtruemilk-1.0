using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainGUI.Forms.DashboardForm
{
    public partial class formReportProduct : Form
    {
        public formReportProduct()
        {
            InitializeComponent();
        }

        private void formReportProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport.OrdersDetail' table. You can move, or remove it, as needed.
            this.OrdersDetailTableAdapter.Fill(this.DataSetReport.OrdersDetail);

            this.reportViewer1.RefreshReport();
        }
    }
}
