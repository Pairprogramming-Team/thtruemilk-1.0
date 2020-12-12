
namespace FormMainGUI.Forms
{
    partial class fProductDetail
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
            this.txtProDetailID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ID = new System.Windows.Forms.Label();
            this.ProductEntryDate = new System.Windows.Forms.DateTimePicker();
            this.EXP = new System.Windows.Forms.DateTimePicker();
            this.MFG = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProDetailID
            // 
            this.txtProDetailID.Depth = 0;
            this.txtProDetailID.Hint = "";
            this.txtProDetailID.Location = new System.Drawing.Point(265, 94);
            this.txtProDetailID.MaxLength = 32767;
            this.txtProDetailID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProDetailID.Name = "txtProDetailID";
            this.txtProDetailID.PasswordChar = '\0';
            this.txtProDetailID.SelectedText = "";
            this.txtProDetailID.SelectionLength = 0;
            this.txtProDetailID.SelectionStart = 0;
            this.txtProDetailID.Size = new System.Drawing.Size(276, 28);
            this.txtProDetailID.TabIndex = 106;
            this.txtProDetailID.TabStop = false;
            this.txtProDetailID.UseSystemPasswordChar = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID.Location = new System.Drawing.Point(33, 98);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(144, 24);
            this.ID.TabIndex = 115;
            this.ID.Text = "Product Detail ID :";
            // 
            // ProductEntryDate
            // 
            this.ProductEntryDate.CustomFormat = "yyyy/MM/dd";
            this.ProductEntryDate.Enabled = false;
            this.ProductEntryDate.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.ProductEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ProductEntryDate.Location = new System.Drawing.Point(265, 381);
            this.ProductEntryDate.Name = "ProductEntryDate";
            this.ProductEntryDate.Size = new System.Drawing.Size(275, 30);
            this.ProductEntryDate.TabIndex = 114;
            // 
            // EXP
            // 
            this.EXP.CustomFormat = "yyyy/MM/dd";
            this.EXP.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.EXP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EXP.Location = new System.Drawing.Point(264, 303);
            this.EXP.Name = "EXP";
            this.EXP.Size = new System.Drawing.Size(275, 30);
            this.EXP.TabIndex = 109;
            // 
            // MFG
            // 
            this.MFG.CustomFormat = "yyyy/MM/dd";
            this.MFG.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.MFG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MFG.Location = new System.Drawing.Point(265, 236);
            this.MFG.Name = "MFG";
            this.MFG.Size = new System.Drawing.Size(275, 30);
            this.MFG.TabIndex = 108;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(264, 161);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(274, 32);
            this.cmbStatus.TabIndex = 107;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(34, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 24);
            this.label9.TabIndex = 113;
            this.label9.Text = "Product Entry Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(32, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 112;
            this.label5.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(34, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 111;
            this.label4.Text = "MFG :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(32, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 110;
            this.label3.Text = "EXP :";
            // 
            // txtproID
            // 
            this.txtproID.Depth = 0;
            this.txtproID.Enabled = false;
            this.txtproID.Hint = "";
            this.txtproID.Location = new System.Drawing.Point(265, 453);
            this.txtproID.MaxLength = 32767;
            this.txtproID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtproID.Name = "txtproID";
            this.txtproID.PasswordChar = '\0';
            this.txtproID.SelectedText = "";
            this.txtproID.SelectionLength = 0;
            this.txtproID.SelectionStart = 0;
            this.txtproID.Size = new System.Drawing.Size(276, 28);
            this.txtproID.TabIndex = 116;
            this.txtproID.TabStop = false;
            this.txtproID.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(33, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 117;
            this.label1.Text = "Product ID :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 67);
            this.panel1.TabIndex = 118;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(137, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 67);
            this.panel2.TabIndex = 88;
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
            // fProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtproID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProDetailID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ProductEntryDate);
            this.Controls.Add(this.EXP);
            this.Controls.Add(this.MFG);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "fProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Detail";
            this.Load += new System.EventHandler(this.fProductDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtProDetailID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.DateTimePicker ProductEntryDate;
        private System.Windows.Forms.DateTimePicker EXP;
        private System.Windows.Forms.DateTimePicker MFG;
        protected System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtproID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancle;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
    }
}