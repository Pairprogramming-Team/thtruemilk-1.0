namespace FormMainGUI.Forms.EmployeeForm
{
    public partial class addEmployee
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
            this.lbId = new MaterialSkin.Controls.MaterialLabel();
            this.lbAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lbBirth = new MaterialSkin.Controls.MaterialLabel();
            this.lbPhone = new MaterialSkin.Controls.MaterialLabel();
            this.lbSex = new MaterialSkin.Controls.MaterialLabel();
            this.lbName = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbmSex = new System.Windows.Forms.ComboBox();
            this.txbId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbBirth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.White;
            this.lbId.Depth = 0;
            this.lbId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbId.Location = new System.Drawing.Point(21, 102);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(93, 19);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Employee ID";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.White;
            this.lbAddress.Depth = 0;
            this.lbAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAddress.Location = new System.Drawing.Point(22, 448);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(64, 19);
            this.lbAddress.TabIndex = 2;
            this.lbAddress.Text = "Address";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.BackColor = System.Drawing.Color.White;
            this.lbBirth.Depth = 0;
            this.lbBirth.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbBirth.Location = new System.Drawing.Point(21, 381);
            this.lbBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(93, 19);
            this.lbBirth.TabIndex = 3;
            this.lbBirth.Text = "Year Of Birth";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.White;
            this.lbPhone.Depth = 0;
            this.lbPhone.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPhone.Location = new System.Drawing.Point(21, 243);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(51, 19);
            this.lbPhone.TabIndex = 4;
            this.lbPhone.Text = "Phone";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.BackColor = System.Drawing.Color.White;
            this.lbSex.Depth = 0;
            this.lbSex.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSex.Location = new System.Drawing.Point(22, 313);
            this.lbSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(33, 19);
            this.lbSex.TabIndex = 5;
            this.lbSex.Text = "Sex";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Depth = 0;
            this.lbName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(21, 168);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 19);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(326, 505);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(211, 505);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(48, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbmSex
            // 
            this.cbmSex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbmSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmSex.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmSex.FormatString = "d";
            this.cbmSex.FormattingEnabled = true;
            this.cbmSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbmSex.Location = new System.Drawing.Point(167, 313);
            this.cbmSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbmSex.Name = "cbmSex";
            this.cbmSex.Size = new System.Drawing.Size(86, 24);
            this.cbmSex.TabIndex = 3;
            // 
            // txbId
            // 
            this.txbId.Depth = 0;
            this.txbId.Hint = "";
            this.txbId.Location = new System.Drawing.Point(166, 101);
            this.txbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbId.MaxLength = 32767;
            this.txbId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbId.Name = "txbId";
            this.txbId.PasswordChar = '\0';
            this.txbId.SelectedText = "";
            this.txbId.SelectionLength = 0;
            this.txbId.SelectionStart = 0;
            this.txbId.Size = new System.Drawing.Size(225, 23);
            this.txbId.TabIndex = 0;
            this.txbId.TabStop = false;
            this.txbId.UseSystemPasswordChar = false;
            // 
            // txbName
            // 
            this.txbName.Depth = 0;
            this.txbName.Hint = "";
            this.txbName.Location = new System.Drawing.Point(166, 167);
            this.txbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbName.MaxLength = 32767;
            this.txbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbName.Name = "txbName";
            this.txbName.PasswordChar = '\0';
            this.txbName.SelectedText = "";
            this.txbName.SelectionLength = 0;
            this.txbName.SelectionStart = 0;
            this.txbName.Size = new System.Drawing.Size(225, 23);
            this.txbName.TabIndex = 1;
            this.txbName.TabStop = false;
            this.txbName.UseSystemPasswordChar = false;
            // 
            // txbPhone
            // 
            this.txbPhone.Depth = 0;
            this.txbPhone.Hint = "";
            this.txbPhone.Location = new System.Drawing.Point(166, 242);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPhone.MaxLength = 32767;
            this.txbPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.PasswordChar = '\0';
            this.txbPhone.SelectedText = "";
            this.txbPhone.SelectionLength = 0;
            this.txbPhone.SelectionStart = 0;
            this.txbPhone.Size = new System.Drawing.Size(225, 23);
            this.txbPhone.TabIndex = 2;
            this.txbPhone.TabStop = false;
            this.txbPhone.UseSystemPasswordChar = false;
            // 
            // txbAddress
            // 
            this.txbAddress.Depth = 0;
            this.txbAddress.Hint = "";
            this.txbAddress.Location = new System.Drawing.Point(166, 444);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbAddress.MaxLength = 32767;
            this.txbAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.PasswordChar = '\0';
            this.txbAddress.SelectedText = "";
            this.txbAddress.SelectionLength = 0;
            this.txbAddress.SelectionStart = 0;
            this.txbAddress.Size = new System.Drawing.Size(225, 23);
            this.txbAddress.TabIndex = 5;
            this.txbAddress.TabStop = false;
            this.txbAddress.UseSystemPasswordChar = false;
            // 
            // txbBirth
            // 
            this.txbBirth.Depth = 0;
            this.txbBirth.Hint = "";
            this.txbBirth.Location = new System.Drawing.Point(166, 378);
            this.txbBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbBirth.MaxLength = 32767;
            this.txbBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbBirth.Name = "txbBirth";
            this.txbBirth.PasswordChar = '\0';
            this.txbBirth.SelectedText = "";
            this.txbBirth.SelectionLength = 0;
            this.txbBirth.SelectionStart = 0;
            this.txbBirth.Size = new System.Drawing.Size(225, 23);
            this.txbBirth.TabIndex = 4;
            this.txbBirth.TabStop = false;
            this.txbBirth.UseSystemPasswordChar = false;
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 575);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbBirth);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.cbmSex);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbBirth);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbId);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.addEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbId;
        private MaterialSkin.Controls.MaterialLabel lbAddress;
        private MaterialSkin.Controls.MaterialLabel lbBirth;
        private MaterialSkin.Controls.MaterialLabel lbPhone;
        private MaterialSkin.Controls.MaterialLabel lbSex;
        private MaterialSkin.Controls.MaterialLabel lbName;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbId;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbAddress;
        protected System.Windows.Forms.ComboBox cbmSex;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbBirth;
    }
}