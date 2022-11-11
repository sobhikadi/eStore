namespace Desktop_app.Forms
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cboxRoles = new System.Windows.Forms.ComboBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalcode = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordConfirmation = new System.Windows.Forms.Label();
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
            this.btnAddEmployee.Location = new System.Drawing.Point(597, 347);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(194, 34);
            this.btnAddEmployee.TabIndex = 54;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cboxRoles
            // 
            this.cboxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRoles.FormattingEnabled = true;
            this.cboxRoles.ItemHeight = 23;
            this.cboxRoles.Location = new System.Drawing.Point(175, 305);
            this.cboxRoles.MaximumSize = new System.Drawing.Size(731, 0);
            this.cboxRoles.Name = "cboxRoles";
            this.cboxRoles.Size = new System.Drawing.Size(616, 31);
            this.cboxRoles.TabIndex = 9;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(175, 233);
            this.tbAddress.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PlaceholderText = "Amsterdam street 100(L)";
            this.tbAddress.Size = new System.Drawing.Size(616, 30);
            this.tbAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddress.Location = new System.Drawing.Point(22, 237);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 23);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhoneNumber.Location = new System.Drawing.Point(22, 200);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(124, 23);
            this.lblPhoneNumber.TabIndex = 42;
            this.lblPhoneNumber.Text = "Phone number";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(175, 89);
            this.tbEmail.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "Jhon.doe@email.com";
            this.tbEmail.Size = new System.Drawing.Size(616, 30);
            this.tbEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(22, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(175, 53);
            this.tbLastName.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PlaceholderText = "Doe";
            this.tbLastName.Size = new System.Drawing.Size(616, 30);
            this.tbLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastName.Location = new System.Drawing.Point(22, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 23);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Last name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(175, 17);
            this.tbFirstName.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderText = "Jhon";
            this.tbFirstName.Size = new System.Drawing.Size(616, 30);
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
            this.tbPhoneNumber.Location = new System.Drawing.Point(175, 197);
            this.tbPhoneNumber.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.PlaceholderText = "(+31)123456789 / 0123456789";
            this.tbPhoneNumber.Size = new System.Drawing.Size(616, 30);
            this.tbPhoneNumber.TabIndex = 5;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(175, 269);
            this.tbPostalCode.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.PlaceholderText = "4444 KK";
            this.tbPostalCode.Size = new System.Drawing.Size(616, 30);
            this.tbPostalCode.TabIndex = 8;
            // 
            // lblPostalcode
            // 
            this.lblPostalcode.AutoSize = true;
            this.lblPostalcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPostalcode.Location = new System.Drawing.Point(22, 272);
            this.lblPostalcode.Name = "lblPostalcode";
            this.lblPostalcode.Size = new System.Drawing.Size(100, 23);
            this.lblPostalcode.TabIndex = 57;
            this.lblPostalcode.Text = "Postal Code";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRole.Location = new System.Drawing.Point(23, 311);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 23);
            this.lblRole.TabIndex = 59;
            this.lblRole.Text = "Role";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(175, 125);
            this.tbPassword.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(616, 30);
            this.tbPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(22, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 61;
            this.lblPassword.Text = "Password";
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Location = new System.Drawing.Point(175, 161);
            this.tbRepeatPassword.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.Size = new System.Drawing.Size(616, 30);
            this.tbRepeatPassword.TabIndex = 4;
            // 
            // tbPasswordConfirmation
            // 
            this.tbPasswordConfirmation.AutoSize = true;
            this.tbPasswordConfirmation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPasswordConfirmation.Location = new System.Drawing.Point(22, 164);
            this.tbPasswordConfirmation.Name = "tbPasswordConfirmation";
            this.tbPasswordConfirmation.Size = new System.Drawing.Size(147, 23);
            this.tbPasswordConfirmation.TabIndex = 63;
            this.tbPasswordConfirmation.Text = "Confirm password";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 393);
            this.Controls.Add(this.tbRepeatPassword);
            this.Controls.Add(this.tbPasswordConfirmation);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.tbPostalCode);
            this.Controls.Add(this.lblPostalcode);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.cboxRoles);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAddEmployee_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddEmployee;
        private ComboBox cboxRoles;
        private TextBox tbAddress;
        private Label lblAddress;
        private Label lblPhoneNumber;
        private TextBox tbEmail;
        private Label lblEmail;
        private TextBox tbLastName;
        private Label lblLastName;
        private TextBox tbFirstName;
        private Label lblFirstName;
        private TextBox tbPhoneNumber;
        private TextBox tbPostalCode;
        private Label lblPostalcode;
        private Label lblRole;
        private TextBox tbPassword;
        private Label lblPassword;
        private TextBox textBox1;
        private Label tbPasswordConfirmation;
        private TextBox tbRepeatPassword;
    }
}