namespace Desktop_app.Forms
{
    partial class fEmployee
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
            this.gboxSearchUsers = new System.Windows.Forms.GroupBox();
            this.cboxSearchCriteria = new System.Windows.Forms.ComboBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.tbSearchTerm = new System.Windows.Forms.TextBox();
            this.lblSearchTerm = new System.Windows.Forms.Label();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.gboxSearchUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSearchUsers
            // 
            this.gboxSearchUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxSearchUsers.Controls.Add(this.cboxSearchCriteria);
            this.gboxSearchUsers.Controls.Add(this.btnSearchUser);
            this.gboxSearchUsers.Controls.Add(this.lblSearchCriteria);
            this.gboxSearchUsers.Controls.Add(this.btnShowAllUsers);
            this.gboxSearchUsers.Controls.Add(this.tbSearchTerm);
            this.gboxSearchUsers.Controls.Add(this.lblSearchTerm);
            this.gboxSearchUsers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxSearchUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.gboxSearchUsers.Location = new System.Drawing.Point(4, 4);
            this.gboxSearchUsers.Margin = new System.Windows.Forms.Padding(4);
            this.gboxSearchUsers.Name = "gboxSearchUsers";
            this.gboxSearchUsers.Padding = new System.Windows.Forms.Padding(4);
            this.gboxSearchUsers.Size = new System.Drawing.Size(1230, 105);
            this.gboxSearchUsers.TabIndex = 1;
            this.gboxSearchUsers.TabStop = false;
            this.gboxSearchUsers.Text = "Search Employee Or Show All Employees";
            // 
            // cboxSearchCriteria
            // 
            this.cboxSearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSearchCriteria.FormattingEnabled = true;
            this.cboxSearchCriteria.Items.AddRange(new object[] {
            "Id",
            "FirstName",
            "LastName",
            "Role",
            "Email"});
            this.cboxSearchCriteria.Location = new System.Drawing.Point(151, 63);
            this.cboxSearchCriteria.Name = "cboxSearchCriteria";
            this.cboxSearchCriteria.Size = new System.Drawing.Size(795, 31);
            this.cboxSearchCriteria.TabIndex = 13;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnSearchUser.FlatAppearance.BorderSize = 0;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Location = new System.Drawing.Point(967, 27);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(256, 30);
            this.btnSearchUser.TabIndex = 7;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            // 
            // lblSearchCriteria
            // 
            this.lblSearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchCriteria.AutoSize = true;
            this.lblSearchCriteria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearchCriteria.Location = new System.Drawing.Point(14, 66);
            this.lblSearchCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchCriteria.Name = "lblSearchCriteria";
            this.lblSearchCriteria.Size = new System.Drawing.Size(130, 23);
            this.lblSearchCriteria.TabIndex = 9;
            this.lblSearchCriteria.Text = "Search Criteria: ";
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowAllUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnShowAllUsers.FlatAppearance.BorderSize = 0;
            this.btnShowAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllUsers.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllUsers.ForeColor = System.Drawing.Color.White;
            this.btnShowAllUsers.Location = new System.Drawing.Point(967, 64);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Size = new System.Drawing.Size(256, 30);
            this.btnShowAllUsers.TabIndex = 8;
            this.btnShowAllUsers.Text = "Show All Users";
            this.btnShowAllUsers.UseVisualStyleBackColor = false;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // tbSearchTerm
            // 
            this.tbSearchTerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchTerm.Location = new System.Drawing.Point(151, 27);
            this.tbSearchTerm.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchTerm.Name = "tbSearchTerm";
            this.tbSearchTerm.Size = new System.Drawing.Size(795, 30);
            this.tbSearchTerm.TabIndex = 1;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearchTerm.Location = new System.Drawing.Point(14, 28);
            this.lblSearchTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(111, 23);
            this.lblSearchTerm.TabIndex = 0;
            this.lblSearchTerm.Text = "Search term: ";
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.AllowColumnReorder = true;
            this.listViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewEmployees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewEmployees.FullRowSelect = true;
            this.listViewEmployees.GridLines = true;
            this.listViewEmployees.Location = new System.Drawing.Point(4, 140);
            this.listViewEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(1230, 612);
            this.listViewEmployees.TabIndex = 3;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            this.listViewEmployees.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewUsers_ItemSelectionChanged);
            this.listViewEmployees.SelectedIndexChanged += new System.EventHandler(this.listViewUsers_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Role";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 400;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.lblEmployees.Location = new System.Drawing.Point(4, 113);
            this.lblEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(91, 23);
            this.lblEmployees.TabIndex = 4;
            this.lblEmployees.Text = "Employees";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 871);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(246, 52);
            this.btnAddEmployee.TabIndex = 35;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 935);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.listViewEmployees);
            this.Controls.Add(this.gboxSearchUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fEmployee";
            this.Text = "TestForm2";
            this.gboxSearchUsers.ResumeLayout(false);
            this.gboxSearchUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gboxSearchUsers;
        private ComboBox cboxSearchCriteria;
        private Label lblSearchCriteria;
        private Button btnShowAllUsers;
        private Button btnSearchUser;
        private TextBox tbSearchTerm;
        private Label lblSearchTerm;
        private ListView listViewEmployees;
        private ColumnHeader ID;
        private Label lblEmployees;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnAddEmployee;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}