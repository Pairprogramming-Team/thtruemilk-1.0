namespace FormMainGUI.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartOrder = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.labelEmployee = new MaterialSkin.Controls.MaterialLabel();
            this.imageEmployee = new System.Windows.Forms.PictureBox();
            this.panelTotalMoney = new System.Windows.Forms.Panel();
            this.labelTotalMoney = new MaterialSkin.Controls.MaterialLabel();
            this.imageTotalMoney = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMilk = new System.Windows.Forms.Panel();
            this.labelMilk = new MaterialSkin.Controls.MaterialLabel();
            this.imageMilk = new System.Windows.Forms.PictureBox();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.lbMilk = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageEmployee)).BeginInit();
            this.panelTotalMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageTotalMoney)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelMilk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageMilk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel.Controls.Add(this.panelChart);
            this.panel.Controls.Add(this.panel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1022, 535);
            this.panel.TabIndex = 0;
            // 
            // panelChart
            // 
            this.panelChart.AutoScroll = true;
            this.panelChart.Controls.Add(this.chart1);
            this.panelChart.Controls.Add(this.chartOrder);
            this.panelChart.Controls.Add(this.chartProduct);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(0, 126);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1022, 409);
            this.panelChart.TabIndex = 1;
            // 
            // chartOrder
            // 
            chartArea2.Name = "ChartArea1";
            this.chartOrder.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartOrder.Legends.Add(legend2);
            this.chartOrder.Location = new System.Drawing.Point(509, 6);
            this.chartOrder.Name = "chartOrder";
            this.chartOrder.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "TotalMoney";
            this.chartOrder.Series.Add(series2);
            this.chartOrder.Size = new System.Drawing.Size(489, 500);
            this.chartOrder.TabIndex = 3;
            this.chartOrder.Text = "chart2";
            title2.Name = "TotalMoney";
            title2.Text = "Total Money";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartOrder.Titles.Add(title2);
            // 
            // chartProduct
            // 
            chartArea3.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartProduct.Legends.Add(legend3);
            this.chartProduct.Location = new System.Drawing.Point(12, 6);
            this.chartProduct.Name = "chartProduct";
            this.chartProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Employee";
            series3.YValuesPerPoint = 2;
            this.chartProduct.Series.Add(series3);
            this.chartProduct.Size = new System.Drawing.Size(489, 500);
            this.chartProduct.TabIndex = 1;
            this.chartProduct.Text = "chart Salary";
            title3.Name = "Product";
            title3.Text = "Products";
            title3.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartProduct.Titles.Add(title3);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panelEmployee);
            this.panel1.Controls.Add(this.panelTotalMoney);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 126);
            this.panel1.TabIndex = 0;
            // 
            // panelEmployee
            // 
            this.panelEmployee.AutoSize = true;
            this.panelEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.panelEmployee.Controls.Add(this.lbEmployee);
            this.panelEmployee.Controls.Add(this.labelEmployee);
            this.panelEmployee.Controls.Add(this.imageEmployee);
            this.panelEmployee.Location = new System.Drawing.Point(354, 0);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(310, 132);
            this.panelEmployee.TabIndex = 2;
            // 
            // labelEmployee
            // 
            this.labelEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmployee.Depth = 0;
            this.labelEmployee.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmployee.Location = new System.Drawing.Point(141, 57);
            this.labelEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(147, 47);
            this.labelEmployee.TabIndex = 4;
            // 
            // imageEmployee
            // 
            this.imageEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageEmployee.Image = global::FormMainGUI.Properties.Resources.employee;
            this.imageEmployee.Location = new System.Drawing.Point(0, 0);
            this.imageEmployee.Name = "imageEmployee";
            this.imageEmployee.Size = new System.Drawing.Size(126, 132);
            this.imageEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageEmployee.TabIndex = 1;
            this.imageEmployee.TabStop = false;
            // 
            // panelTotalMoney
            // 
            this.panelTotalMoney.BackColor = System.Drawing.SystemColors.Control;
            this.panelTotalMoney.Controls.Add(this.lbTotalMoney);
            this.panelTotalMoney.Controls.Add(this.labelTotalMoney);
            this.panelTotalMoney.Controls.Add(this.imageTotalMoney);
            this.panelTotalMoney.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTotalMoney.Location = new System.Drawing.Point(0, 0);
            this.panelTotalMoney.Name = "panelTotalMoney";
            this.panelTotalMoney.Size = new System.Drawing.Size(310, 126);
            this.panelTotalMoney.TabIndex = 1;
            // 
            // labelTotalMoney
            // 
            this.labelTotalMoney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotalMoney.Depth = 0;
            this.labelTotalMoney.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTotalMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTotalMoney.Location = new System.Drawing.Point(142, 57);
            this.labelTotalMoney.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTotalMoney.Name = "labelTotalMoney";
            this.labelTotalMoney.Size = new System.Drawing.Size(147, 47);
            this.labelTotalMoney.TabIndex = 5;
            // 
            // imageTotalMoney
            // 
            this.imageTotalMoney.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageTotalMoney.Image = global::FormMainGUI.Properties.Resources.money_1;
            this.imageTotalMoney.Location = new System.Drawing.Point(0, 0);
            this.imageTotalMoney.Name = "imageTotalMoney";
            this.imageTotalMoney.Size = new System.Drawing.Size(126, 126);
            this.imageTotalMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageTotalMoney.TabIndex = 1;
            this.imageTotalMoney.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.AutoScroll = true;
            this.panelTop.Controls.Add(this.panelMilk);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTop.Location = new System.Drawing.Point(712, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(310, 126);
            this.panelTop.TabIndex = 0;
            // 
            // panelMilk
            // 
            this.panelMilk.BackColor = System.Drawing.SystemColors.Control;
            this.panelMilk.Controls.Add(this.lbMilk);
            this.panelMilk.Controls.Add(this.labelMilk);
            this.panelMilk.Controls.Add(this.imageMilk);
            this.panelMilk.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMilk.Location = new System.Drawing.Point(0, 0);
            this.panelMilk.Name = "panelMilk";
            this.panelMilk.Size = new System.Drawing.Size(310, 126);
            this.panelMilk.TabIndex = 1;
            // 
            // labelMilk
            // 
            this.labelMilk.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMilk.Depth = 0;
            this.labelMilk.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelMilk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMilk.Location = new System.Drawing.Point(139, 57);
            this.labelMilk.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMilk.Name = "labelMilk";
            this.labelMilk.Size = new System.Drawing.Size(147, 47);
            this.labelMilk.TabIndex = 3;
            // 
            // imageMilk
            // 
            this.imageMilk.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageMilk.Image = global::FormMainGUI.Properties.Resources.milk_box_1;
            this.imageMilk.Location = new System.Drawing.Point(0, 0);
            this.imageMilk.Name = "imageMilk";
            this.imageMilk.Size = new System.Drawing.Size(124, 126);
            this.imageMilk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageMilk.TabIndex = 0;
            this.imageMilk.TabStop = false;
            // 
            // lbEmployee
            // 
            this.lbEmployee.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.Location = new System.Drawing.Point(146, 11);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(141, 34);
            this.lbEmployee.TabIndex = 5;
            this.lbEmployee.Text = "Employee";
            this.lbEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMilk
            // 
            this.lbMilk.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMilk.Location = new System.Drawing.Point(145, 11);
            this.lbMilk.Name = "lbMilk";
            this.lbMilk.Size = new System.Drawing.Size(141, 34);
            this.lbMilk.TabIndex = 6;
            this.lbMilk.Text = "Product";
            this.lbMilk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.Location = new System.Drawing.Point(148, 11);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(141, 34);
            this.lbTotalMoney.TabIndex = 6;
            this.lbTotalMoney.Text = "TotalMoney";
            this.lbTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(298, 524);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Employee";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(489, 500);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart Salary";
            title1.Name = "Employee";
            title1.Text = "Employee";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart1.Titles.Add(title1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 535);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageEmployee)).EndInit();
            this.panelTotalMoney.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageTotalMoney)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelMilk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageMilk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Panel panelTotalMoney;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMilk;
        private System.Windows.Forms.PictureBox imageMilk;
        private System.Windows.Forms.PictureBox imageEmployee;
        private System.Windows.Forms.PictureBox imageTotalMoney;
        private MaterialSkin.Controls.MaterialLabel labelMilk;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrder;
        private MaterialSkin.Controls.MaterialLabel labelEmployee;
        private MaterialSkin.Controls.MaterialLabel labelTotalMoney;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label lbMilk;
    }
}