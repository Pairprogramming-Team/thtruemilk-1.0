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
using System.Windows.Forms.DataVisualization.Charting;

namespace FormMainGUI.Forms.DashboardForm
{
    public partial class chartOrder : Form
    {
        public chartOrder()
        {
            InitializeComponent();
            ChartOrder();
        }

        public void ChartOrder()
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
            panelOrder.Controls.Add(chartTotal);
        }
    }
}
