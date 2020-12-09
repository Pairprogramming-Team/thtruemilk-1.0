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
    public partial class formReportEmployee : Form
    {
        public formReportEmployee()
        {
            InitializeComponent();
        }

        private void formReportEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport.Employees' table. You can move, or remove it, as needed.
            this.EmployeesTableAdapter.Fill(this.DataSetReport.Employees);

            this.reportViewer1.RefreshReport();
        }
    }
}
