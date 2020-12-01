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
                //var a = DateTime.Parse(Convert.ToString(item.DateOfOrder));
                series.Points.AddXY(item.Key, item.Select(i => i.TotalMoney).Sum());
            }
            series.ChartType = SeriesChartType.Column;
            series.Label = "#PERCENT{P0}";
            series.Font = new Font("Arial", 8.0f, FontStyle.Bold);
            series.Palette = ChartColorPalette.Light;
            series.Name = "Total Money";
            Title title = new Title("Total Money in Year");
            title.Font = new Font("Matura MT Script Capitals", 14f, FontStyle.Bold);
            chartTotal.Titles.Add(title);

            //series["PieLabelStyle"] = "Outside";
            chartTotal.Dock = DockStyle.Fill;
            chartTotal.Series.Add(series);
            panelOrder.Controls.Add(chartTotal);
        }
    }
}
