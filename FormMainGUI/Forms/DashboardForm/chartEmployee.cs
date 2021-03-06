﻿using FormMainGUI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormMainGUI.Forms.DashboardForm
{
    public partial class chartEmployee : Form
    {
        public chartEmployee()
        {
            InitializeComponent();
            ChartEmpolyee();
        }

        private void ChartEmpolyee()
        {
            var db = DataProvider.Ins.DB;
            var data = db.Employees.ToList();
            var area = new ChartArea();
            var chartEmp = new Chart();
            chartEmp.ChartAreas.Add(area);
            var series = new Series();
            foreach(var i in data)
            {
                series.Points.AddXY(i.Name,i.Orders.Count());
            }

            area.AxisY.Title = "Biểu đồ thể hiện số hóa đơn mà nhân viên đã bán";
            area.AxisY.TitleFont = new Font("Arial", 12.0f, FontStyle.Regular);
            area.AxisY.LabelStyle.Format = "{#,##} Hóa Đơn";

            chartEmp.BackColor = Color.Azure;
            series.IsValueShownAsLabel = true;
            series.IsXValueIndexed = true;
            series.YValueType = ChartValueType.Int32;
            
            series.ChartType = SeriesChartType.RangeBar;
            series.Font = new Font("Arial", 8.0f, FontStyle.Bold);
            series.Palette = ChartColorPalette.Light;
            Title title = new Title("Employee sales invoice");
            title.Font = new Font("Matura MT Script Capitals", 14f, FontStyle.Bold);
            chartEmp.Titles.Add(title);
            chartEmp.Series.Add(series);
            chartEmp.Dock = DockStyle.Fill;
            panel1.Controls.Add(chartEmp);
        }
    }
}
