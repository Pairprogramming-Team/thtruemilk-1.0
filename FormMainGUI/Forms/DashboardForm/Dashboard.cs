﻿using FormMainGUI.Forms.DashboardForm;
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
            var db = DataProvider.Ins.DB;

                var total = (from ta in db.Orders
                             group ta by ta.TotalMoney).Select(a => a.Key).Sum();

                labelInputOrder.Text = total.ToString();

                var em = DataProvider.Ins.DB.Employees.Count();
                labelInputEmployee.Text = em.ToString();

                var p = db.Products.Count();
                labelInputProduct.Text = p.ToString();

            chartTotal_Click();
        }

        public void chartTotal_Click()
        {
            var db = DataProvider.Ins.DB;
            var data = (db.Orders.GroupBy(d => d.DateOfOrder.Value.Month)).ToList();
            var area = new ChartArea();
            var chartTotal = new Chart();
            chartTotal.ChartAreas.Add(area);
            var series = new Series();
            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Select(i => i.TotalMoney).Sum());
            }
            area.AxisX.Title = "Biểu đồ thể hiện tổng tiền trong năm theo từng tháng";
            area.AxisX.TitleFont = new Font("Arial", 12.0f, FontStyle.Regular);
            area.AxisY.LabelStyle.Format = "{#,##} VND";
            
            series.IsValueShownAsLabel = true;
            series.XValueType = ChartValueType.Int32;
            series.ChartType = SeriesChartType.Column;
            series.IsXValueIndexed = true;
            
            series.Font = new Font("Arial", 8.0f, FontStyle.Bold);
            series.Palette = ChartColorPalette.Light;
            series.Name = "Total Money";
            var name = series.Name;
            Title title = new Title("Total Money by Month");
            title.Font = new Font("Matura MT Script Capitals", 14f, FontStyle.Bold);
            chartTotal.Titles.Add(title);
            chartTotal.BackColor = Color.Azure;

            series["PieLabelStyle"] = "Outside";
            chartTotal.Dock = DockStyle.Fill;
            chartTotal.Series.Add(series);
            panelChart.Controls.Add(chartTotal);
        }
         
        private void btnTotal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new chartOrder());
            btnReportEmployee.Visible = false;
            btnReportOrder.Visible = true;
            btnReportProduct.Visible = false;
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

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new chartEmployee());
            btnReportEmployee.Visible = true;
            btnReportOrder.Visible = false;
            btnReportProduct.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new chartProduct());
            btnReportEmployee.Visible = false;
            btnReportOrder.Visible = false;
            btnReportProduct.Visible = true;
        }

        private void btnReportOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formReportOrder());
        }

        private void btnReportProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formReportProduct());
        }

        private void btnReportEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formReportEmployee());
        }
    }
}
