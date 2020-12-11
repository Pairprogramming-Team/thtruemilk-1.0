namespace FormMainGUI.Forms
{
    partial class add
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
            this.btnCancle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ProductEntryDate = new System.Windows.Forms.DateTimePicker();
            this.EXP = new System.Windows.Forms.DateTimePicker();
            this.MFG = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProDetailID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ID = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.AutoSize = true;
            this.btnCancle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancle.Depth = 0;
            this.btnCancle.Icon = null;
            this.btnCancle.Location = new System.Drawing.Point(278, 19);
            this.btnCancle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Primary = true;
            this.btnCancle.Size = new System.Drawing.Size(87, 36);
            this.btnCancle.TabIndex = 87;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(72, 19);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(65, 36);
            this.btnSave.TabIndex = 86;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProductEntryDate
            // 
            this.ProductEntryDate.CustomFormat = "yyyy/MM/dd";
            this.ProductEntryDate.Enabled = false;
            this.ProductEntryDate.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.ProductEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ProductEntryDate.Location = new System.Drawing.Point(283, 541);
            this.ProductEntryDate.Name = "ProductEntryDate";
            this.ProductEntryDate.Size = new System.Drawing.Size(275, 30);
            this.ProductEntryDate.TabIndex = 100;
            // 
            // EXP
            // 
            this.EXP.CustomFormat = "yyyy/MM/dd";
            this.EXP.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.EXP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EXP.Location = new System.Drawing.Point(284, 481);
            this.EXP.Name = "EXP";
            this.EXP.Size = new System.Drawing.Size(275, 30);
            this.EXP.TabIndex = 8;
            // 
            // MFG
            // 
            this.MFG.CustomFormat = "yyyy/MM/dd";
            this.MFG.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.MFG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MFG.Location = new System.Drawing.Point(283, 420);
            this.MFG.Name = "MFG";
            this.MFG.Size = new System.Drawing.Size(275, 30);
            this.MFG.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(284, 360);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(274, 32);
            this.cmbStatus.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(52, 547);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 24);
            this.label9.TabIndex = 95;
            this.label9.Text = "Product Entry Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(53, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 94;
            this.label8.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(53, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 93;
            this.label7.Text = "Quantity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(53, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 92;
            this.label6.Text = "Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(52, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 91;
            this.label5.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(52, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 90;
            this.label4.Text = "MFG :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(52, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 89;
            this.label3.Text = "EXP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(53, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 88;
            this.label2.Text = "Product ID :";
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Hint = "";
            this.txtID.Location = new System.Drawing.Point(284, 100);
            this.txtID.MaxLength = 32767;
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(276, 28);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(284, 147);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(275, 28);
            this.txtName.TabIndex = 2;
            this.txtName.TabStop = false;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Depth = 0;
            this.txtPrice.Hint = "";
            this.txtPrice.Location = new System.Drawing.Point(285, 256);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(276, 28);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TabStop = false;
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 582);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 67);
            this.panel1.TabIndex = 104;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 67);
            this.panel2.TabIndex = 88;
            // 
            // txtProDetailID
            // 
            this.txtProDetailID.Depth = 0;
            this.txtProDetailID.Hint = "";
            this.txtProDetailID.Location = new System.Drawing.Point(283, 309);
            this.txtProDetailID.MaxLength = 32767;
            this.txtProDetailID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProDetailID.Name = "txtProDetailID";
            this.txtProDetailID.PasswordChar = '\0';
            this.txtProDetailID.SelectedText = "";
            this.txtProDetailID.SelectionLength = 0;
            this.txtProDetailID.SelectionStart = 0;
            this.txtProDetailID.Size = new System.Drawing.Size(276, 28);
            this.txtProDetailID.TabIndex = 5;
            this.txtProDetailID.TabStop = false;
            this.txtProDetailID.UseSystemPasswordChar = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID.Location = new System.Drawing.Point(51, 313);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(144, 24);
            this.ID.TabIndex = 105;
            this.ID.Text = "Product Detail ID :";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Quantity.Location = new System.Drawing.Point(285, 198);
            this.Quantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(275, 30);
            this.Quantity.TabIndex = 3;
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 649);
            this.Controls.Add(this.txtProDetailID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ProductEntryDate);
            this.Controls.Add(this.EXP);
            this.Controls.Add(this.MFG);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.add_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnCancle;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private System.Windows.Forms.DateTimePicker ProductEntryDate;
        private System.Windows.Forms.DateTimePicker EXP;
        private System.Windows.Forms.DateTimePicker MFG;
        protected System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProDetailID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.NumericUpDown Quantity;
    }
}