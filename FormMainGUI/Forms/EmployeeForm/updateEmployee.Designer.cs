namespace FormMainGUI.Forms.EmployeeForm
{
    partial class updateEmployee
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
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txbAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbName = new MaterialSkin.Controls.MaterialLabel();
            this.lbSex = new MaterialSkin.Controls.MaterialLabel();
            this.lbPhone = new MaterialSkin.Controls.MaterialLabel();
            this.lbBirth = new MaterialSkin.Controls.MaterialLabel();
            this.lbAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lbId = new MaterialSkin.Controls.MaterialLabel();
            this.txbId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbBirth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbmSex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(423, 611);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(87, 36);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(238, 611);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(87, 36);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbAddress
            // 
            this.txbAddress.BackColor = System.Drawing.Color.White;
            this.txbAddress.Depth = 0;
            this.txbAddress.Hint = "";
            this.txbAddress.Location = new System.Drawing.Point(238, 539);
            this.txbAddress.MaxLength = 32767;
            this.txbAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.PasswordChar = '\0';
            this.txbAddress.SelectedText = "";
            this.txbAddress.SelectionLength = 0;
            this.txbAddress.SelectionStart = 0;
            this.txbAddress.Size = new System.Drawing.Size(282, 28);
            this.txbAddress.TabIndex = 24;
            this.txbAddress.TabStop = false;
            this.txbAddress.UseSystemPasswordChar = false;
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.Color.White;
            this.txbPhone.Depth = 0;
            this.txbPhone.Hint = "";
            this.txbPhone.Location = new System.Drawing.Point(238, 288);
            this.txbPhone.MaxLength = 32767;
            this.txbPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.PasswordChar = '\0';
            this.txbPhone.SelectedText = "";
            this.txbPhone.SelectionLength = 0;
            this.txbPhone.SelectionStart = 0;
            this.txbPhone.Size = new System.Drawing.Size(282, 28);
            this.txbPhone.TabIndex = 23;
            this.txbPhone.TabStop = false;
            this.txbPhone.UseSystemPasswordChar = false;
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.White;
            this.txbName.Depth = 0;
            this.txbName.Hint = "";
            this.txbName.Location = new System.Drawing.Point(238, 196);
            this.txbName.MaxLength = 32767;
            this.txbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbName.Name = "txbName";
            this.txbName.PasswordChar = '\0';
            this.txbName.SelectedText = "";
            this.txbName.SelectionLength = 0;
            this.txbName.SelectionStart = 0;
            this.txbName.Size = new System.Drawing.Size(282, 28);
            this.txbName.TabIndex = 22;
            this.txbName.TabStop = false;
            this.txbName.UseSystemPasswordChar = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Depth = 0;
            this.lbName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(46, 200);
            this.lbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(61, 24);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Name";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.BackColor = System.Drawing.Color.White;
            this.lbSex.Depth = 0;
            this.lbSex.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSex.Location = new System.Drawing.Point(46, 375);
            this.lbSex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(40, 24);
            this.lbSex.TabIndex = 20;
            this.lbSex.Text = "Sex";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.White;
            this.lbPhone.Depth = 0;
            this.lbPhone.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPhone.Location = new System.Drawing.Point(44, 292);
            this.lbPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(63, 24);
            this.lbPhone.TabIndex = 19;
            this.lbPhone.Text = "Phone";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.BackColor = System.Drawing.Color.White;
            this.lbBirth.Depth = 0;
            this.lbBirth.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbBirth.Location = new System.Drawing.Point(45, 459);
            this.lbBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(116, 24);
            this.lbBirth.TabIndex = 18;
            this.lbBirth.Text = "Year Of Birth";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.White;
            this.lbAddress.Depth = 0;
            this.lbAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAddress.Location = new System.Drawing.Point(46, 541);
            this.lbAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(80, 24);
            this.lbAddress.TabIndex = 17;
            this.lbAddress.Text = "Address";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.White;
            this.lbId.Depth = 0;
            this.lbId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbId.Location = new System.Drawing.Point(45, 118);
            this.lbId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(116, 24);
            this.lbId.TabIndex = 16;
            this.lbId.Text = "Employee ID";
            // 
            // txbId
            // 
            this.txbId.BackColor = System.Drawing.Color.White;
            this.txbId.Depth = 0;
            this.txbId.Hint = "";
            this.txbId.Location = new System.Drawing.Point(238, 116);
            this.txbId.MaxLength = 32767;
            this.txbId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbId.Name = "txbId";
            this.txbId.PasswordChar = '\0';
            this.txbId.SelectedText = "";
            this.txbId.SelectionLength = 0;
            this.txbId.SelectionStart = 0;
            this.txbId.Size = new System.Drawing.Size(282, 28);
            this.txbId.TabIndex = 15;
            this.txbId.TabStop = false;
            this.txbId.UseSystemPasswordChar = false;
            // 
            // txbBirth
            // 
            this.txbBirth.Depth = 0;
            this.txbBirth.Hint = "";
            this.txbBirth.Location = new System.Drawing.Point(238, 455);
            this.txbBirth.MaxLength = 32767;
            this.txbBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbBirth.Name = "txbBirth";
            this.txbBirth.PasswordChar = '\0';
            this.txbBirth.SelectedText = "";
            this.txbBirth.SelectionLength = 0;
            this.txbBirth.SelectionStart = 0;
            this.txbBirth.Size = new System.Drawing.Size(282, 28);
            this.txbBirth.TabIndex = 31;
            this.txbBirth.TabStop = false;
            this.txbBirth.UseSystemPasswordChar = false;
            // 
            // cbmSex
            // 
            this.cbmSex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbmSex.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmSex.FormattingEnabled = true;
            this.cbmSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbmSex.Location = new System.Drawing.Point(238, 375);
            this.cbmSex.Name = "cbmSex";
            this.cbmSex.Size = new System.Drawing.Size(114, 27);
            this.cbmSex.TabIndex = 30;
            this.cbmSex.Text = "Male";
            // 
            // updateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 708);
            this.Controls.Add(this.txbBirth);
            this.Controls.Add(this.cbmSex);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbBirth);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txbId);
            this.Name = "updateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Employee";
            this.Load += new System.EventHandler(this.updateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbName;
        private MaterialSkin.Controls.MaterialLabel lbName;
        private MaterialSkin.Controls.MaterialLabel lbSex;
        private MaterialSkin.Controls.MaterialLabel lbPhone;
        private MaterialSkin.Controls.MaterialLabel lbBirth;
        private MaterialSkin.Controls.MaterialLabel lbAddress;
        private MaterialSkin.Controls.MaterialLabel lbId;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbId;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbBirth;
        private System.Windows.Forms.ComboBox cbmSex;
    }
}