﻿namespace FormMainGUI.Forms.OrderForm
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNameProduct = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIDProduct = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 166);
            this.panel1.TabIndex = 1;
            // 
            // btnDone
            // 
            this.btnDone.AutoSize = true;
            this.btnDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.Depth = 0;
            this.btnDone.Icon = null;
            this.btnDone.Location = new System.Drawing.Point(389, 20);
            this.btnDone.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDone.Name = "btnDone";
            this.btnDone.Primary = true;
            this.btnDone.Size = new System.Drawing.Size(57, 36);
            this.btnDone.TabIndex = 1;
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
            this.btnCancel.Location = new System.Drawing.Point(240, 20);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Location = new System.Drawing.Point(242, 219);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
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
            this.materialLabel4.Location = new System.Drawing.Point(80, 298);
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
            this.txtPrice.Location = new System.Drawing.Point(240, 294);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(295, 23);
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
            this.materialLabel3.Location = new System.Drawing.Point(75, 223);
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
            this.txtNameProduct.Location = new System.Drawing.Point(240, 149);
            this.txtNameProduct.MaxLength = 32767;
            this.txtNameProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.PasswordChar = '\0';
            this.txtNameProduct.SelectedText = "";
            this.txtNameProduct.SelectionLength = 0;
            this.txtNameProduct.SelectionStart = 0;
            this.txtNameProduct.Size = new System.Drawing.Size(295, 23);
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
            this.materialLabel2.Location = new System.Drawing.Point(75, 153);
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
            this.txtIDProduct.Location = new System.Drawing.Point(242, 85);
            this.txtIDProduct.MaxLength = 32767;
            this.txtIDProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.PasswordChar = '\0';
            this.txtIDProduct.SelectedText = "";
            this.txtIDProduct.SelectionLength = 0;
            this.txtIDProduct.SelectionStart = 0;
            this.txtIDProduct.Size = new System.Drawing.Size(295, 23);
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
            this.materialLabel1.Location = new System.Drawing.Point(77, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 50;
            this.materialLabel1.Text = "ID product";
            // 
            // fAddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(743, 518);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtIDProduct);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fAddToCart";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add to cart";
            this.Load += new System.EventHandler(this.fAddToCart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnDone;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNameProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIDProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}