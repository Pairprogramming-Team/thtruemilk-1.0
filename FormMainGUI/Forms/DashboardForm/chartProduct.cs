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
    public partial class chartProduct : Form
    {
        public chartProduct()
        {
            InitializeComponent();
            ChartProduct();
        }

        private void ChartProduct()
        {
            var db = DataProvider.Ins.DB;
            var data = db.Products.ToList();
            var d = (db.OrdersDetails.GroupBy(x => x.ProductID).ToList());
            var area = new ChartArea();
            var chartProduct = new Chart();
            chartProduct.ChartAreas.Add(area);
            var series = new Series();
            foreach (var i in d)
            {
                series.Points.AddXY(i.Key, i.Select(a => a.Quantity).Sum());
            }

            area.AxisY.Title = "Biểu đồ thể hiện số lượng sản phẩm đã bán được";
            area.AxisY.TitleFont = new Font("Arial", 12.0f, FontStyle.Regular);
            area.AxisY.LabelStyle.Format = "{#,##} Sản Phẩm";

            chartProduct.BackColor = Color.Azure;
            series.IsValueShownAsLabel = true;
            series.IsXValueIndexed = true;
            series.YValueType = ChartValueType.Int32;

            series.ChartType = SeriesChartType.RangeBar;
            series.Font = new Font("Arial", 8.0f, FontStyle.Bold);
            series.Palette = ChartColorPalette.Light;
            Title title = new Title("Product selling");
            title.Font = new Font("Matura MT Script Capitals", 14f, FontStyle.Bold);
            chartProduct.Titles.Add(title);
            chartProduct.Series.Add(series);
            chartProduct.Dock = DockStyle.Fill;
            panelProduct.Controls.Add(chartProduct);
        }
    }
}
