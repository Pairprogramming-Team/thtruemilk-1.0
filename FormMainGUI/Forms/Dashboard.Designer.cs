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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pictureDashboard = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.labelText1 = new System.Windows.Forms.Label();
            this.labelInputEmployee = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.labelInputProduct = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.labelSold = new System.Windows.Forms.Label();
            this.labelInputOrder = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.pictureBoxOrder = new System.Windows.Forms.PictureBox();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chartTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeft.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDashboard)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.panel9.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.panel8.SuspendLayout();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrder)).BeginInit();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLeft.Controls.Add(this.panelMenu);
            this.panelLeft.Controls.Add(this.lblMenu);
            this.panelLeft.Controls.Add(this.pictureDashboard);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(315, 797);
            this.panelLeft.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMenu.Controls.Add(this.btnEmployee);
            this.panelMenu.Controls.Add(this.btnProduct);
            this.panelMenu.Controls.Add(this.btnTotal);
            this.panelMenu.Location = new System.Drawing.Point(19, 261);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(273, 488);
            this.panelMenu.TabIndex = 3;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(30, 297);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(216, 87);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(30, 162);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(216, 86);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Image = ((System.Drawing.Image)(resources.GetObject("btnTotal.Image")));
            this.btnTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotal.Location = new System.Drawing.Point(30, 29);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(216, 88);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "Total Money";
            this.btnTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(19, 173);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(273, 65);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Dashboard";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureDashboard
            // 
            this.pictureDashboard.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureDashboard.ErrorImage")));
            this.pictureDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pictureDashboard.Image")));
            this.pictureDashboard.Location = new System.Drawing.Point(82, 28);
            this.pictureDashboard.Name = "pictureDashboard";
            this.pictureDashboard.Size = new System.Drawing.Size(148, 108);
            this.pictureDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDashboard.TabIndex = 2;
            this.pictureDashboard.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(315, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1164, 28);
            this.panelTop.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(315, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 196);
            this.panel2.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel10.Controls.Add(this.panelEmployee);
            this.panel10.Location = new System.Drawing.Point(434, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(320, 196);
            this.panel10.TabIndex = 8;
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelEmployee.Controls.Add(this.labelText1);
            this.panelEmployee.Controls.Add(this.labelInputEmployee);
            this.panelEmployee.Controls.Add(this.labelEmployee);
            this.panelEmployee.Controls.Add(this.pictureBoxEmployee);
            this.panelEmployee.Location = new System.Drawing.Point(3, 6);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(305, 158);
            this.panelEmployee.TabIndex = 5;
            // 
            // labelText1
            // 
            this.labelText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText1.Location = new System.Drawing.Point(130, 109);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(152, 30);
            this.labelText1.TabIndex = 4;
            this.labelText1.Text = "In the store";
            // 
            // labelInputEmployee
            // 
            this.labelInputEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.labelInputEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputEmployee.Location = new System.Drawing.Point(135, 68);
            this.labelInputEmployee.Name = "labelInputEmployee";
            this.labelInputEmployee.Size = new System.Drawing.Size(132, 34);
            this.labelInputEmployee.TabIndex = 4;
            this.labelInputEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee
            // 
            this.labelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.Location = new System.Drawing.Point(130, 12);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(172, 41);
            this.labelEmployee.TabIndex = 2;
            this.labelEmployee.Text = "Employee";
            this.labelEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.Image = global::FormMainGUI.Properties.Resources.employee;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmployee.TabIndex = 1;
            this.pictureBoxEmployee.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panelProduct);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(814, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(350, 196);
            this.panel9.TabIndex = 7;
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelProduct.Controls.Add(this.labelText);
            this.panelProduct.Controls.Add(this.labelInputProduct);
            this.panelProduct.Controls.Add(this.labelProduct);
            this.panelProduct.Controls.Add(this.pictureBoxProduct);
            this.panelProduct.Location = new System.Drawing.Point(17, 6);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(305, 158);
            this.panelProduct.TabIndex = 4;
            // 
            // labelText
            // 
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(141, 109);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(142, 30);
            this.labelText.TabIndex = 3;
            this.labelText.Text = "In the store";
            // 
            // labelInputProduct
            // 
            this.labelInputProduct.BackColor = System.Drawing.SystemColors.Control;
            this.labelInputProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputProduct.Location = new System.Drawing.Point(151, 68);
            this.labelInputProduct.Name = "labelInputProduct";
            this.labelInputProduct.Size = new System.Drawing.Size(122, 34);
            this.labelInputProduct.TabIndex = 2;
            this.labelInputProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProduct
            // 
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(146, 16);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(137, 37);
            this.labelProduct.TabIndex = 1;
            this.labelProduct.Text = "Product";
            this.labelProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Image = global::FormMainGUI.Properties.Resources.milk_box_1;
            this.pictureBoxProduct.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(93, 90);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 0;
            this.pictureBoxProduct.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panelOrder);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(372, 196);
            this.panel8.TabIndex = 6;
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelOrder.Controls.Add(this.labelSold);
            this.panelOrder.Controls.Add(this.labelInputOrder);
            this.panelOrder.Controls.Add(this.labelOrder);
            this.panelOrder.Controls.Add(this.pictureBoxOrder);
            this.panelOrder.Location = new System.Drawing.Point(30, 6);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(307, 158);
            this.panelOrder.TabIndex = 4;
            // 
            // labelSold
            // 
            this.labelSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSold.Location = new System.Drawing.Point(147, 109);
            this.labelSold.Name = "labelSold";
            this.labelSold.Size = new System.Drawing.Size(112, 30);
            this.labelSold.TabIndex = 4;
            this.labelSold.Text = "Sold";
            this.labelSold.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInputOrder
            // 
            this.labelInputOrder.BackColor = System.Drawing.SystemColors.Control;
            this.labelInputOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputOrder.Location = new System.Drawing.Point(139, 68);
            this.labelInputOrder.Name = "labelInputOrder";
            this.labelInputOrder.Size = new System.Drawing.Size(133, 34);
            this.labelInputOrder.TabIndex = 3;
            this.labelInputOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrder
            // 
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(134, 16);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(151, 37);
            this.labelOrder.TabIndex = 3;
            this.labelOrder.Text = "Order";
            this.labelOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxOrder
            // 
            this.pictureBoxOrder.Image = global::FormMainGUI.Properties.Resources.money_1;
            this.pictureBoxOrder.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxOrder.Name = "pictureBoxOrder";
            this.pictureBoxOrder.Size = new System.Drawing.Size(88, 90);
            this.pictureBoxOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrder.TabIndex = 2;
            this.pictureBoxOrder.TabStop = false;
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelChart.Controls.Add(this.panel7);
            this.panelChart.Controls.Add(this.chartTotal);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(315, 224);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1164, 573);
            this.panelChart.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1164, 14);
            this.panel7.TabIndex = 1;
            // 
            // chartTotal
            // 
            this.chartTotal.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chartTotal.ChartAreas.Add(chartArea2);
            this.chartTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartTotal.Legends.Add(legend2);
            this.chartTotal.Location = new System.Drawing.Point(0, 0);
            this.chartTotal.Name = "chartTotal";
            this.chartTotal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "TotalMoney";
            this.chartTotal.Series.Add(series2);
            this.chartTotal.Size = new System.Drawing.Size(1164, 573);
            this.chartTotal.TabIndex = 0;
            this.chartTotal.Text = "TotalMoney";
            title2.Name = "TotalMoney";
            title2.Text = "Total Money";
            this.chartTotal.Titles.Add(title2);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1479, 797);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDashboard)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panelEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrder)).EndInit();
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pictureDashboard;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotal;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Label labelInputEmployee;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelInputProduct;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label labelSold;
        private System.Windows.Forms.Label labelInputOrder;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.PictureBox pictureBoxOrder;
    }
}