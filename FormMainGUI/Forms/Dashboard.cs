using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainGUI.Forms
{
    public partial class Dashboard : Form
    {
        private Form currentChildForm;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            double i = 99999999999, j = 9999, z = 99;
            labelInputEmployee.Text = z.ToString();
            labelInputOrder.Text = i.ToString();
            labelInputProduct.Text = j.ToString();
            chartTotal_Click();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChart.Controls.Add(childForm);
            panelChart.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitileChildForm.Text = childForm.Text;
        }

        private void chartTotal_Click()
        {
            chartTotal.Series["TotalMoney"].Points.AddXY("ThienHi", "100000");
            chartTotal.Series["TotalMoney"].Points.AddXY("Thien", "90000");
            chartTotal.Series["TotalMoney"].Points.AddXY("Tai9", "10000");
            chartTotal.Series["TotalMoney"].Points.AddXY("TrungMi", "20000");
            chartTotal.Series["TotalMoney"].Points.AddXY("TaiChip", "50000");
            chartTotal.Series["TotalMoney"].Points.AddXY("KhaiMe", "70000");
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Chart_Employee());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Chart_Product());
        }
    }
}
