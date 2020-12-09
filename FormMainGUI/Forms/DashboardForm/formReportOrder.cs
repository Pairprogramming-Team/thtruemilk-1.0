using FormMainGUI.Utils;
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
    public partial class formReportOrder : Form
    {
        public formReportOrder()
        {
            InitializeComponent();
        }

        private void formReportOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport.Orders' table. You can move, or remove it, as needed.
            //this.OrdersTableAdapter.Fill(this.DataSetReport.Orders);

            var db = DataProvider.Ins.DB;
            var data = db.Orders.ToList();

            this.OrdersBindingSource.DataSource = data;

            this.reportViewer1.RefreshReport();
        }
    }
}
