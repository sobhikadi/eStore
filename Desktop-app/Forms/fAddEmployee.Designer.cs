namespace Desktop_app.Forms
{
    partial class fAddEmployee
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cboxRoles = new System.Windows.Forms.ComboBox();
            this.tbStreetName = new System.Windows.Forms.TextBox();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbHouseNumber = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalcode = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(598, 363);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(194, 34);
            this.btnAddEmployee.TabIndex = 54;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cboxRoles
            // 
            this.cboxRoles.FormattingEnabled = true;
            this.cboxRoles.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cboxRoles.Location = new System.Drawing.Point(176, 311);
            this.cboxRoles.MaximumSize = new System.Drawing.Size(731, 0);
            this.cboxRoles.Name = "cboxRoles";
            this.cboxRoles.Size = new System.Drawing.Size(615, 31);
            this.cboxRoles.TabIndex = 7;
            // 
            // tbStreetName
            // 
            this.tbStreetName.Location = new System.Drawing.Point(176, 191);
            this.tbStreetName.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbStreetName.Name = "tbStreetName";
            this.tbStreetName.Size = new System.Drawing.Size(615, 30);
            this.tbStreetName.TabIndex = 4;
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStreetName.Location = new System.Drawing.Point(22, 195);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(102, 23);
            this.lblStreetName.TabIndex = 43;
            this.lblStreetName.Text = "Street name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhoneNumber.Location = new System.Drawing.Point(22, 150);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(124, 23);
            this.lblPhoneNumber.TabIndex = 42;
            this.lblPhoneNumber.Text = "Phone number";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(176, 104);
            this.tbEmail.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(615, 30);
            this.tbEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(22, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(176, 61);
            this.tbLastName.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(615, 30);
            this.tbLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastName.Location = new System.Drawing.Point(22, 65);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 23);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Last name";
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHouseNumber.Location = new System.Drawing.Point(22, 234);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(123, 23);
            this.lblHouseNumber.TabIndex = 36;
            this.lblHouseNumber.Text = "House number";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(176, 17);
            this.tbFirstName.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(615, 30);
            this.tbFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFirstName.Location = new System.Drawing.Point(22, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 23);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "First name";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(176, 147);
            this.tbPhoneNumber.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(615, 30);
            this.tbPhoneNumber.TabIndex = 3;
            // 
            // tbHouseNumber
            // 
            this.tbHouseNumber.Location = new System.Drawing.Point(176, 231);
            this.tbHouseNumber.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbHouseNumber.Name = "tbHouseNumber";
            this.tbHouseNumber.Size = new System.Drawing.Size(615, 30);
            this.tbHouseNumber.TabIndex = 5;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(176, 272);
            this.tbPostalCode.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(615, 30);
            this.tbPostalCode.TabIndex = 6;
            // 
            // lblPostalcode
            // 
            this.lblPostalcode.AutoSize = true;
            this.lblPostalcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPostalcode.Location = new System.Drawing.Point(22, 275);
            this.lblPostalcode.Name = "lblPostalcode";
            this.lblPostalcode.Size = new System.Drawing.Size(100, 23);
            this.lblPostalcode.TabIndex = 57;
            this.lblPostalcode.Text = "Postal Code";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRole.Location = new System.Drawing.Point(22, 314);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 23);
            this.lblRole.TabIndex = 59;
            this.lblRole.Text = "Role";
            // 
            // fAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 414);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.tbPostalCode);
            this.Controls.Add(this.lblPostalcode);
            this.Controls.Add(this.tbHouseNumber);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.cboxRoles);
            this.Controls.Add(this.tbStreetName);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblHouseNumber);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "fAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAddEmployee_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddEmployee;
        private ComboBox cboxRoles;
        private TextBox tbStreetName;
        private Label lblStreetName;
        private Label lblPhoneNumber;
        private TextBox tbEmail;
        private Label lblEmail;
        private TextBox tbLastName;
        private Label lblLastName;
        private Label lblHouseNumber;
        private TextBox tbFirstName;
        private Label lblFirstName;
        private TextBox tbPhoneNumber;
        private TextBox tbHouseNumber;
        private TextBox tbPostalCode;
        private Label lblPostalcode;
        private Label lblRole;
    }
}