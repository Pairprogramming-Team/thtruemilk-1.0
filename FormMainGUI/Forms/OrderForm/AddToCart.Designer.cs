namespace FormMainGUI.Forms.OrderForm
{
    partial class fAddToCart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDone = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.numbericQuantity = new System.Windows.Forms.NumericUpDown();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNameProduct = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIDProduct = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtOrderDetalID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 87);
            this.panel1.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.AutoSize = true;
            this.btnDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.Depth = 0;
            this.btnDone.Icon = null;
            this.btnDone.Location = new System.Drawing.Point(182, 16);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDone.Name = "btnDone";
            this.btnDone.Primary = true;
            this.btnDone.Size = new System.Drawing.Size(57, 36);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(328, 16);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numbericQuantity
            // 
            this.numbericQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numbericQuantity.Location = new System.Drawing.Point(182, 236);
            this.numbericQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.numbericQuantity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numbericQuantity.Name = "numbericQuantity";
            this.numbericQuantity.Size = new System.Drawing.Size(90, 20);
            this.numbericQuantity.TabIndex = 1;
            this.numbericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(60, 300);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(43, 19);
            this.materialLabel4.TabIndex = 56;
            this.materialLabel4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Depth = 0;
            this.txtPrice.Enabled = false;
            this.txtPrice.Hint = "";
            this.txtPrice.Location = new System.Drawing.Point(180, 297);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(221, 23);
            this.txtPrice.TabIndex = 55;
            this.txtPrice.TabStop = false;
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(56, 239);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(64, 19);
            this.materialLabel3.TabIndex = 54;
            this.materialLabel3.Text = "Quantity";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameProduct.Depth = 0;
            this.txtNameProduct.Enabled = false;
            this.txtNameProduct.Hint = "";
            this.txtNameProduct.Location = new System.Drawing.Point(180, 179);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameProduct.MaxLength = 32767;
            this.txtNameProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.PasswordChar = '\0';
            this.txtNameProduct.SelectedText = "";
            this.txtNameProduct.SelectionLength = 0;
            this.txtNameProduct.SelectionStart = 0;
            this.txtNameProduct.Size = new System.Drawing.Size(221, 23);
            this.txtNameProduct.TabIndex = 53;
            this.txtNameProduct.TabStop = false;
            this.txtNameProduct.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(56, 182);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(104, 19);
            this.materialLabel2.TabIndex = 52;
            this.materialLabel2.Text = "Name product";
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDProduct.Depth = 0;
            this.txtIDProduct.Enabled = false;
            this.txtIDProduct.Hint = "";
            this.txtIDProduct.Location = new System.Drawing.Point(180, 127);
            this.txtIDProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDProduct.MaxLength = 32767;
            this.txtIDProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.PasswordChar = '\0';
            this.txtIDProduct.SelectedText = "";
            this.txtIDProduct.SelectionLength = 0;
            this.txtIDProduct.SelectionStart = 0;
            this.txtIDProduct.Size = new System.Drawing.Size(221, 23);
            this.txtIDProduct.TabIndex = 51;
            this.txtIDProduct.TabStop = false;
            this.txtIDProduct.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(56, 130);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 50;
            this.materialLabel1.Text = "ID product";
            // 
            // txtOrderDetalID
            // 
            this.txtOrderDetalID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderDetalID.Depth = 0;
            this.txtOrderDetalID.Hint = "";
            this.txtOrderDetalID.Location = new System.Drawing.Point(180, 77);
            this.txtOrderDetalID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderDetalID.MaxLength = 32767;
            this.txtOrderDetalID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOrderDetalID.Name = "txtOrderDetalID";
            this.txtOrderDetalID.PasswordChar = '\0';
            this.txtOrderDetalID.SelectedText = "";
            this.txtOrderDetalID.SelectionLength = 0;
            this.txtOrderDetalID.SelectionStart = 0;
            this.txtOrderDetalID.Size = new System.Drawing.Size(221, 23);
            this.txtOrderDetalID.TabIndex = 0;
            this.txtOrderDetalID.TabStop = false;
            this.txtOrderDetalID.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(56, 80);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(103, 19);
            this.materialLabel5.TabIndex = 57;
            this.materialLabel5.Text = "ID order detail";
            // 
            // fAddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(557, 421);
            this.Controls.Add(this.txtOrderDetalID);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.numbericQuantity);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtIDProduct);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAddToCart";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD TO CART";
            this.Load += new System.EventHandler(this.fAddToCart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnDone;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private System.Windows.Forms.NumericUpDown numbericQuantity;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNameProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIDProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOrderDetalID;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}