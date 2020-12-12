
namespace FormMainGUI.Forms.OrderForm
{
    partial class ListOrderDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrderDetailList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.numbericQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrderDetailList);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(4, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(913, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order detail";
            // 
            // dgvOrderDetailList
            // 
            this.dgvOrderDetailList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetailList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOrderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetailList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOrderDetailList.Location = new System.Drawing.Point(4, 27);
            this.dgvOrderDetailList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderDetailList.MultiSelect = false;
            this.dgvOrderDetailList.Name = "dgvOrderDetailList";
            this.dgvOrderDetailList.ReadOnly = true;
            this.dgvOrderDetailList.RowHeadersWidth = 51;
            this.dgvOrderDetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailList.Size = new System.Drawing.Size(905, 336);
            this.dgvOrderDetailList.TabIndex = 0;
            this.dgvOrderDetailList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetailList_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.numbericQuantity);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(4, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(913, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(782, 14);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(87, 36);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numbericQuantity
            // 
            this.numbericQuantity.Location = new System.Drawing.Point(92, 59);
            this.numbericQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numbericQuantity.Name = "numbericQuantity";
            this.numbericQuantity.Size = new System.Drawing.Size(145, 30);
            this.numbericQuantity.TabIndex = 0;
            this.numbericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTotal
            // 
            this.txtTotal.Depth = 0;
            this.txtTotal.Enabled = false;
            this.txtTotal.Hint = "";
            this.txtTotal.Location = new System.Drawing.Point(565, 59);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.Size = new System.Drawing.Size(145, 28);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TabStop = false;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Depth = 0;
            this.txtPrice.Enabled = false;
            this.txtPrice.Hint = "";
            this.txtPrice.Location = new System.Drawing.Point(314, 59);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(170, 28);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TabStop = false;
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Enabled = false;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(320, 25);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(272, 28);
            this.txtName.TabIndex = 8;
            this.txtName.TabStop = false;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Enabled = false;
            this.txtID.Hint = "";
            this.txtID.Location = new System.Drawing.Point(92, 25);
            this.txtID.MaxLength = 32767;
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(145, 28);
            this.txtID.TabIndex = 7;
            this.txtID.TabStop = false;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // ListOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListOrderDetail";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Detail List";
            this.Load += new System.EventHandler(this.ListOrderDetail_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrderDetailList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numbericQuantity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
    }
}