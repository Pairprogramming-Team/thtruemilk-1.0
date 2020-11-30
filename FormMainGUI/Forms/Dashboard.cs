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
            //labelInputEmployee_Click();
            //labelInputOrder_Click();
            //labelInputProduct_Click();
            //using(var db = DataProvider.Ins.DB)
            //{
                var db = DataProvider.Ins.DB;

                var total = (from ta in db.Orders
                             group ta by ta.TotalMoney).Select(a => a.Key).Sum();

                labelInputOrder.Text = total.ToString();

                var em = DataProvider.Ins.DB.Employees.Count();
                labelInputEmployee.Text = em.ToString();

                var p = db.Products.Count();
                labelInputProduct.Text = p.ToString();

                chartTotal_Click();
            //}
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
            //using (var db = DataProvider.Ins.DB)
            //{
                var db = DataProvider.Ins.DB;
                var data = (db.Orders.GroupBy(d => d.DateOfOrder.Value.Month)).ToList();
                //var total = (from to in db.Orders
                //             group to by to.DateOfOrder.Value.Month).Select(i => i.Key).Sum();

                //var emmm = data[0].Select(i => i.TotalMoney).Sum();

                //var acccc = db.Orders.GroupBy(o => o.DateOfOrder.Value.Month).Select(x => x.Key).ToList();

                var area = new ChartArea();
                chartTotal.ChartAreas.Add(area);
                var series = new Series();
                foreach (var item in data)
                {
                    //var a = DateTime.Parse(Convert.ToString(item.DateOfOrder));
                    series.Points.AddXY(item.Key, item.Select(i => i.TotalMoney).Sum());
                }
                series.ChartType = SeriesChartType.Column;
                series.Label = "#PERCENT{P0}";
                series.Font = new Font("Arial", 8.0f, FontStyle.Bold);
                //series["PieLabelStyle"] = "Outside";
                chartTotal.Series.Add(series);
            //}
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Chart_Employee());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Chart_Product());
        }

        private void labelInputOrder_Click()
        {
            using (var db = DataProvider.Ins.DB)
            {
                //var DB = db.Orders;
                var to = db.Orders.Select(i => i.TotalMoney).Sum();
                var total = (from ta in db.Orders
                             group ta by ta.TotalMoney).Select(a => a.Key).Sum();

                labelInputOrder.Text = to.ToString();
            }
        }

        private void labelInputEmployee_Click()
        {
            using (var db = DataProvider.Ins.DB)
            {
                var em = DataProvider.Ins.DB.Employees.Count();
                labelInputEmployee.Text = em.ToString();
            }
        }

        private void labelInputProduct_Click()
        {
            using (var A = DataProvider.Ins.DB)
            {
                var p = A.Products.Count();
                labelProduct.Text = p.ToString();
            }
        }
    }
}
