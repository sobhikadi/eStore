namespace Desktop_app.Forms
{
    partial class Products
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
            this.gboxSearchProduct = new System.Windows.Forms.GroupBox();
            this.cboxSearchCriteria = new System.Windows.Forms.ComboBox();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.btnShowAllProducts = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.tbSearchTerm = new System.Windows.Forms.TextBox();
            this.lblSearchTerm = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblSepcs = new System.Windows.Forms.Label();
            this.lboxProductSpecs = new System.Windows.Forms.ListBox();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Product = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Category = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gboxProductDescription = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.gboxEditProduct = new System.Windows.Forms.GroupBox();
            this.lblOpenEditProduct = new System.Windows.Forms.Label();
            this.btnOpenEditProduct = new System.Windows.Forms.Button();
            this.gboxAddSpecifications = new System.Windows.Forms.GroupBox();
            this.lblOpenAddSpecs = new System.Windows.Forms.Label();
            this.btnAddSpecifications = new System.Windows.Forms.Button();
            this.gboxSearchProduct.SuspendLayout();
            this.gboxProductDescription.SuspendLayout();
            this.gboxEditProduct.SuspendLayout();
            this.gboxAddSpecifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSearchProduct
            // 
            this.gboxSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxSearchProduct.Controls.Add(this.cboxSearchCriteria);
            this.gboxSearchProduct.Controls.Add(this.lblSearchCriteria);
            this.gboxSearchProduct.Controls.Add(this.btnShowAllProducts);
            this.gboxSearchProduct.Controls.Add(this.btnSearchProduct);
            this.gboxSearchProduct.Controls.Add(this.tbSearchTerm);
            this.gboxSearchProduct.Controls.Add(this.lblSearchTerm);
            this.gboxSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.gboxSearchProduct.Location = new System.Drawing.Point(0, 1);
            this.gboxSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.gboxSearchProduct.Name = "gboxSearchProduct";
            this.gboxSearchProduct.Padding = new System.Windows.Forms.Padding(4);
            this.gboxSearchProduct.Size = new System.Drawing.Size(1238, 105);
            this.gboxSearchProduct.TabIndex = 0;
            this.gboxSearchProduct.TabStop = false;
            this.gboxSearchProduct.Text = "Search Product Or Show All Products";
            // 
            // cboxSearchCriteria
            // 
            this.cboxSearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSearchCriteria.FormattingEnabled = true;
            this.cboxSearchCriteria.Items.AddRange(new object[] {
            "Name",
            "Category",
            "Subcategory"});
            this.cboxSearchCriteria.Location = new System.Drawing.Point(153, 62);
            this.cboxSearchCriteria.Name = "cboxSearchCriteria";
            this.cboxSearchCriteria.Size = new System.Drawing.Size(754, 31);
            this.cboxSearchCriteria.TabIndex = 13;
            // 
            // lblSearchCriteria
            // 
            this.lblSearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchCriteria.AutoSize = true;
            this.lblSearchCriteria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearchCriteria.Location = new System.Drawing.Point(13, 62);
            this.lblSearchCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchCriteria.Name = "lblSearchCriteria";
            this.lblSearchCriteria.Size = new System.Drawing.Size(130, 23);
            this.lblSearchCriteria.TabIndex = 9;
            this.lblSearchCriteria.Text = "Search Criteria: ";
            // 
            // btnShowAllProducts
            // 
            this.btnShowAllProducts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowAllProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnShowAllProducts.FlatAppearance.BorderSize = 0;
            this.btnShowAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllProducts.ForeColor = System.Drawing.Color.White;
            this.btnShowAllProducts.Location = new System.Drawing.Point(925, 62);
            this.btnShowAllProducts.Name = "btnShowAllProducts";
            this.btnShowAllProducts.Size = new System.Drawing.Size(301, 30);
            this.btnShowAllProducts.TabIndex = 8;
            this.btnShowAllProducts.Text = "Show All Products";
            this.btnShowAllProducts.UseVisualStyleBackColor = false;
            this.btnShowAllProducts.Click += new System.EventHandler(this.btnShowAllProducts_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(925, 24);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(301, 30);
            this.btnSearchProduct.TabIndex = 7;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            // 
            // tbSearchTerm
            // 
            this.tbSearchTerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchTerm.Location = new System.Drawing.Point(153, 24);
            this.tbSearchTerm.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchTerm.Name = "tbSearchTerm";
            this.tbSearchTerm.Size = new System.Drawing.Size(754, 30);
            this.tbSearchTerm.TabIndex = 1;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearchTerm.Location = new System.Drawing.Point(13, 27);
            this.lblSearchTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(111, 23);
            this.lblSearchTerm.TabIndex = 0;
            this.lblSearchTerm.Text = "Search term: ";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.lblProducts.Location = new System.Drawing.Point(5, 107);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(77, 23);
            this.lblProducts.TabIndex = 3;
            this.lblProducts.Text = "Products";
            // 
            // lblSepcs
            // 
            this.lblSepcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSepcs.AutoSize = true;
            this.lblSepcs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSepcs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.lblSepcs.Location = new System.Drawing.Point(987, 111);
            this.lblSepcs.Name = "lblSepcs";
            this.lblSepcs.Size = new System.Drawing.Size(178, 23);
            this.lblSepcs.TabIndex = 4;
            this.lblSepcs.Text = "Product Specifications";
            // 
            // lboxProductSpecs
            // 
            this.lboxProductSpecs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxProductSpecs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxProductSpecs.FormattingEnabled = true;
            this.lboxProductSpecs.ItemHeight = 23;
            this.lboxProductSpecs.Location = new System.Drawing.Point(987, 139);
            this.lboxProductSpecs.Name = "lboxProductSpecs";
            this.lboxProductSpecs.Size = new System.Drawing.Size(239, 533);
            this.lboxProductSpecs.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Product
            // 
            this.Product.Text = "Name";
            this.Product.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 80;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 320;
            // 
            // listViewProducts
            // 
            this.listViewProducts.AllowColumnReorder = true;
            this.listViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.Quantity,
            this.Category,
            this.Price});
            this.listViewProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.Location = new System.Drawing.Point(5, 139);
            this.listViewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(975, 533);
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewProducts_ItemSelectionChanged);
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(5, 861);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(246, 52);
            this.btnAddProduct.TabIndex = 34;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gboxProductDescription
            // 
            this.gboxProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxProductDescription.Controls.Add(this.tbDescription);
            this.gboxProductDescription.Controls.Add(this.lblProductDescription);
            this.gboxProductDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.gboxProductDescription.Location = new System.Drawing.Point(5, 676);
            this.gboxProductDescription.Name = "gboxProductDescription";
            this.gboxProductDescription.Size = new System.Drawing.Size(1221, 148);
            this.gboxProductDescription.TabIndex = 7;
            this.gboxProductDescription.TabStop = false;
            this.gboxProductDescription.Text = "Product Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(191, 26);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(1023, 107);
            this.tbDescription.TabIndex = 36;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductDescription.Location = new System.Drawing.Point(8, 26);
            this.lblProductDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(162, 46);
            this.lblProductDescription.TabIndex = 35;
            this.lblProductDescription.Text = "Select Product to \r\nview the description";
            // 
            // gboxEditProduct
            // 
            this.gboxEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxEditProduct.Controls.Add(this.lblOpenEditProduct);
            this.gboxEditProduct.Controls.Add(this.btnOpenEditProduct);
            this.gboxEditProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxEditProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.gboxEditProduct.Location = new System.Drawing.Point(268, 844);
            this.gboxEditProduct.Name = "gboxEditProduct";
            this.gboxEditProduct.Size = new System.Drawing.Size(358, 79);
            this.gboxEditProduct.TabIndex = 36;
            this.gboxEditProduct.TabStop = false;
            this.gboxEditProduct.Text = "Edit Product";
            // 
            // lblOpenEditProduct
            // 
            this.lblOpenEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpenEditProduct.AutoSize = true;
            this.lblOpenEditProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOpenEditProduct.Location = new System.Drawing.Point(3, 35);
            this.lblOpenEditProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpenEditProduct.Name = "lblOpenEditProduct";
            this.lblOpenEditProduct.Size = new System.Drawing.Size(189, 23);
            this.lblOpenEditProduct.TabIndex = 37;
            this.lblOpenEditProduct.Text = "Select a product to edit";
            // 
            // btnOpenEditProduct
            // 
            this.btnOpenEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnOpenEditProduct.FlatAppearance.BorderSize = 0;
            this.btnOpenEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenEditProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnOpenEditProduct.Location = new System.Drawing.Point(197, 31);
            this.btnOpenEditProduct.Name = "btnOpenEditProduct";
            this.btnOpenEditProduct.Size = new System.Drawing.Size(155, 30);
            this.btnOpenEditProduct.TabIndex = 36;
            this.btnOpenEditProduct.Text = "Edit Product";
            this.btnOpenEditProduct.UseVisualStyleBackColor = false;
            // 
            // gboxAddSpecifications
            // 
            this.gboxAddSpecifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxAddSpecifications.Controls.Add(this.lblOpenAddSpecs);
            this.gboxAddSpecifications.Controls.Add(this.btnAddSpecifications);
            this.gboxAddSpecifications.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxAddSpecifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.gboxAddSpecifications.Location = new System.Drawing.Point(642, 844);
            this.gboxAddSpecifications.Name = "gboxAddSpecifications";
            this.gboxAddSpecifications.Size = new System.Drawing.Size(584, 79);
            this.gboxAddSpecifications.TabIndex = 38;
            this.gboxAddSpecifications.TabStop = false;
            this.gboxAddSpecifications.Text = "Add Product";
            // 
            // lblOpenAddSpecs
            // 
            this.lblOpenAddSpecs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpenAddSpecs.AutoSize = true;
            this.lblOpenAddSpecs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOpenAddSpecs.Location = new System.Drawing.Point(7, 34);
            this.lblOpenAddSpecs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpenAddSpecs.Name = "lblOpenAddSpecs";
            this.lblOpenAddSpecs.Size = new System.Drawing.Size(285, 23);
            this.lblOpenAddSpecs.TabIndex = 39;
            this.lblOpenAddSpecs.Text = "Select Product to Add Specifications";
            // 
            // btnAddSpecifications
            // 
            this.btnAddSpecifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSpecifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnAddSpecifications.FlatAppearance.BorderSize = 0;
            this.btnAddSpecifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpecifications.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSpecifications.ForeColor = System.Drawing.Color.White;
            this.btnAddSpecifications.Location = new System.Drawing.Point(310, 31);
            this.btnAddSpecifications.Name = "btnAddSpecifications";
            this.btnAddSpecifications.Size = new System.Drawing.Size(268, 30);
            this.btnAddSpecifications.TabIndex = 38;
            this.btnAddSpecifications.Text = "Add Specifications";
            this.btnAddSpecifications.UseVisualStyleBackColor = false;
            // 
            // fProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 935);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.gboxAddSpecifications);
            this.Controls.Add(this.gboxEditProduct);
            this.Controls.Add(this.gboxProductDescription);
            this.Controls.Add(this.lboxProductSpecs);
            this.Controls.Add(this.lblSepcs);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.gboxSearchProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fProducts";
            this.gboxSearchProduct.ResumeLayout(false);
            this.gboxSearchProduct.PerformLayout();
            this.gboxProductDescription.ResumeLayout(false);
            this.gboxProductDescription.PerformLayout();
            this.gboxEditProduct.ResumeLayout(false);
            this.gboxEditProduct.PerformLayout();
            this.gboxAddSpecifications.ResumeLayout(false);
            this.gboxAddSpecifications.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gboxSearchProduct;
        private TextBox tbSearchTerm;
        private Label lblSearchTerm;
        private Label lblProducts;
        private Label lblSepcs;
        private ListBox lboxProductSpecs;
        private Button btnSearchProduct;
        private Button btnShowAllProducts;
        private ComboBox cboxSearchCriteria;
        private Label lblSearchCriteria;
        private ColumnHeader ID;
        private ColumnHeader Product;
        private ColumnHeader Quantity;
        private ColumnHeader Category;
        private ColumnHeader Price;
        private ListView listViewProducts;
        private Button btnAddProduct;
        private GroupBox gboxProductDescription;
        private Label lblProductDescription;
        private TextBox tbDescription;
        private GroupBox gboxEditProduct;
        private Label lblOpenEditProduct;
        private Button btnOpenEditProduct;
        private GroupBox gboxAddSpecifications;
        private Label lblOpenAddSpecs;
        private Button btnAddSpecifications;
    }
}