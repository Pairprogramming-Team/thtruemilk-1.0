using FormMainGUI.Utils;
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
using System.Windows.Forms.DataVisualization.Charting;

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
            using (var db = DataProvider.Ins.DB)
            {

                var data = db.Orders.ToList();
                //var total = from to in db.Orders
                //            group to by DateTime.Parse(Convert.ToString(to.DateOfOrder));
                            

                var area = new ChartArea();
                //var chart = new Chart();
                chartTotal.ChartAreas.Add(area);
                var series = new Series();
                foreach (var item in data)
                {
                    var a = DateTime.Parse(Convert.ToString(item.DateOfOrder));
                    var b = new DateTime(a.Month);
                    
                    series.Points.AddXY((a.Month), item.TotalMoney);
                    //series.XValueMember = "item.DateOfOrder";
                    //series.YValueMembers = "item.TotalMoney";
                    //chartTotal.Series["TotalMoney"].XValueMember = "item.DateOfOrder";
                    //chartTotal.Series["TotalMoney"].YValueMembers = "item.TotalMoney";
                }
                series.ChartType = SeriesChartType.Column;
                series.Label = "#PERCENT{P0}";
                series.Font = new Font("Arial", 8.0f, FontStyle.Bold);
                series["PieLabelStyle"] = "Outside";
                chartTotal.Series.Add(series);
            }
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
