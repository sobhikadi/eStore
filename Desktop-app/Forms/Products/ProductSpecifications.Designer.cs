namespace Desktop_app.Forms.Products
{
    partial class ProductSpecifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSpecifications));
            this.dataGridViewSpecifications = new System.Windows.Forms.DataGridView();
            this.SpecificationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecificationValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxAddSpecs = new System.Windows.Forms.GroupBox();
            this.btnAddSpec = new System.Windows.Forms.Button();
            this.tbSpecsValue = new System.Windows.Forms.TextBox();
            this.lblSpecsValue = new System.Windows.Forms.Label();
            this.tbSpecsName = new System.Windows.Forms.TextBox();
            this.lblSpecsName = new System.Windows.Forms.Label();
            this.btnDeleteSpec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecifications)).BeginInit();
            this.gboxAddSpecs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSpecifications
            // 
            this.dataGridViewSpecifications.AllowUserToAddRows = false;
            this.dataGridViewSpecifications.AllowUserToDeleteRows = false;
            this.dataGridViewSpecifications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewSpecifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSpecifications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSpecifications.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSpecifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpecificationName,
            this.SpecificationValue});
            this.dataGridViewSpecifications.Location = new System.Drawing.Point(14, 14);
            this.dataGridViewSpecifications.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSpecifications.Name = "dataGridViewSpecifications";
            this.dataGridViewSpecifications.ReadOnly = true;
            this.dataGridViewSpecifications.RowHeadersWidth = 51;
            this.dataGridViewSpecifications.RowTemplate.Height = 29;
            this.dataGridViewSpecifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSpecifications.Size = new System.Drawing.Size(466, 486);
            this.dataGridViewSpecifications.TabIndex = 0;
            // 
            // SpecificationName
            // 
            this.SpecificationName.HeaderText = "Specification Name";
            this.SpecificationName.MinimumWidth = 6;
            this.SpecificationName.Name = "SpecificationName";
            this.SpecificationName.ReadOnly = true;
            // 
            // SpecificationValue
            // 
            this.SpecificationValue.HeaderText = "SpecificationValue";
            this.SpecificationValue.MinimumWidth = 6;
            this.SpecificationValue.Name = "SpecificationValue";
            this.SpecificationValue.ReadOnly = true;
            // 
            // gboxAddSpecs
            // 
            this.gboxAddSpecs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxAddSpecs.Controls.Add(this.btnAddSpec);
            this.gboxAddSpecs.Controls.Add(this.tbSpecsValue);
            this.gboxAddSpecs.Controls.Add(this.lblSpecsValue);
            this.gboxAddSpecs.Controls.Add(this.tbSpecsName);
            this.gboxAddSpecs.Controls.Add(this.lblSpecsName);
            this.gboxAddSpecs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.gboxAddSpecs.Location = new System.Drawing.Point(487, 14);
            this.gboxAddSpecs.Margin = new System.Windows.Forms.Padding(4);
            this.gboxAddSpecs.Name = "gboxAddSpecs";
            this.gboxAddSpecs.Padding = new System.Windows.Forms.Padding(4);
            this.gboxAddSpecs.Size = new System.Drawing.Size(414, 184);
            this.gboxAddSpecs.TabIndex = 1;
            this.gboxAddSpecs.TabStop = false;
            this.gboxAddSpecs.Text = "Add Specification";
            // 
            // btnAddSpec
            // 
            this.btnAddSpec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddSpec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnAddSpec.FlatAppearance.BorderSize = 0;
            this.btnAddSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpec.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSpec.ForeColor = System.Drawing.Color.White;
            this.btnAddSpec.Location = new System.Drawing.Point(213, 131);
            this.btnAddSpec.Name = "btnAddSpec";
            this.btnAddSpec.Size = new System.Drawing.Size(194, 34);
            this.btnAddSpec.TabIndex = 47;
            this.btnAddSpec.Text = "Add";
            this.btnAddSpec.UseVisualStyleBackColor = false;
            this.btnAddSpec.Click += new System.EventHandler(this.btnAddSpec_Click);
            // 
            // tbSpecsValue
            // 
            this.tbSpecsValue.Location = new System.Drawing.Point(87, 79);
            this.tbSpecsValue.MaximumSize = new System.Drawing.Size(658, 32);
            this.tbSpecsValue.Name = "tbSpecsValue";
            this.tbSpecsValue.Size = new System.Drawing.Size(321, 30);
            this.tbSpecsValue.TabIndex = 19;
            // 
            // lblSpecsValue
            // 
            this.lblSpecsValue.AutoSize = true;
            this.lblSpecsValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSpecsValue.Location = new System.Drawing.Point(22, 82);
            this.lblSpecsValue.Name = "lblSpecsValue";
            this.lblSpecsValue.Size = new System.Drawing.Size(52, 23);
            this.lblSpecsValue.TabIndex = 21;
            this.lblSpecsValue.Text = "Value";
            // 
            // tbSpecsName
            // 
            this.tbSpecsName.Location = new System.Drawing.Point(87, 39);
            this.tbSpecsName.MaximumSize = new System.Drawing.Size(658, 32);
            this.tbSpecsName.Name = "tbSpecsName";
            this.tbSpecsName.Size = new System.Drawing.Size(321, 30);
            this.tbSpecsName.TabIndex = 18;
            // 
            // lblSpecsName
            // 
            this.lblSpecsName.AutoSize = true;
            this.lblSpecsName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSpecsName.Location = new System.Drawing.Point(22, 40);
            this.lblSpecsName.Name = "lblSpecsName";
            this.lblSpecsName.Size = new System.Drawing.Size(56, 23);
            this.lblSpecsName.TabIndex = 20;
            this.lblSpecsName.Text = "Name";
            // 
            // btnDeleteSpec
            // 
            this.btnDeleteSpec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteSpec.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSpec.FlatAppearance.BorderSize = 0;
            this.btnDeleteSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSpec.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSpec.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSpec.Location = new System.Drawing.Point(700, 466);
            this.btnDeleteSpec.Name = "btnDeleteSpec";
            this.btnDeleteSpec.Size = new System.Drawing.Size(194, 34);
            this.btnDeleteSpec.TabIndex = 48;
            this.btnDeleteSpec.Text = "Delete";
            this.btnDeleteSpec.UseVisualStyleBackColor = false;
            this.btnDeleteSpec.Click += new System.EventHandler(this.btnDeleteSpec_Click);
            // 
            // ProductSpecifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 513);
            this.Controls.Add(this.btnDeleteSpec);
            this.Controls.Add(this.gboxAddSpecs);
            this.Controls.Add(this.dataGridViewSpecifications);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductSpecifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Specifications";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductSpecifications_FormClosing);
            this.Load += new System.EventHandler(this.ProductSpecifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecifications)).EndInit();
            this.gboxAddSpecs.ResumeLayout(false);
            this.gboxAddSpecs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewSpecifications;
        private DataGridViewTextBoxColumn SpecificationName;
        private DataGridViewTextBoxColumn SpecificationValue;
        private GroupBox gboxAddSpecs;
        private TextBox tbSpecsValue;
        private Label lblSpecsValue;
        private TextBox tbSpecsName;
        private Label lblSpecsName;
        private Button btnAddSpec;
        private Button btnDeleteSpec;
    }
}