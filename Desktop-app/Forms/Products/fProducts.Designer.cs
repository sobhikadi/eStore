namespace Desktop_app.Forms
{
    partial class fProducts
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
            this.subCategory = new System.Windows.Forms.ColumnHeader();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnOpenEditProduct = new System.Windows.Forms.Button();
            this.btnSpecifications = new System.Windows.Forms.Button();
            this.btnProductDescription = new System.Windows.Forms.Button();
            this.btnProductReviews = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnComboProducts = new System.Windows.Forms.Button();
            this.gboxSearchProduct.SuspendLayout();
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
            this.lblSepcs.Location = new System.Drawing.Point(914, 110);
            this.lblSepcs.Name = "lblSepcs";
            this.lblSepcs.Size = new System.Drawing.Size(178, 23);
            this.lblSepcs.TabIndex = 4;
            this.lblSepcs.Text = "Product Specifications";
            // 
            // lboxProductSpecs
            // 
            this.lboxProductSpecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxProductSpecs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxProductSpecs.FormattingEnabled = true;
            this.lboxProductSpecs.ItemHeight = 23;
            this.lboxProductSpecs.Location = new System.Drawing.Point(914, 139);
            this.lboxProductSpecs.Name = "lboxProductSpecs";
            this.lboxProductSpecs.Size = new System.Drawing.Size(312, 740);
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
            this.listViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.Quantity,
            this.Category,
            this.subCategory,
            this.Price});
            this.listViewProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.Location = new System.Drawing.Point(5, 137);
            this.listViewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(902, 742);
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewProducts_ItemSelectionChanged);
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // subCategory
            // 
            this.subCategory.Text = "Sub Category";
            this.subCategory.Width = 150;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(5, 886);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(160, 42);
            this.btnAddProduct.TabIndex = 34;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnOpenEditProduct
            // 
            this.btnOpenEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnOpenEditProduct.FlatAppearance.BorderSize = 0;
            this.btnOpenEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenEditProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnOpenEditProduct.Location = new System.Drawing.Point(171, 886);
            this.btnOpenEditProduct.Name = "btnOpenEditProduct";
            this.btnOpenEditProduct.Size = new System.Drawing.Size(160, 42);
            this.btnOpenEditProduct.TabIndex = 36;
            this.btnOpenEditProduct.Text = "Edit Product";
            this.btnOpenEditProduct.UseVisualStyleBackColor = false;
            // 
            // btnSpecifications
            // 
            this.btnSpecifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpecifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnSpecifications.FlatAppearance.BorderSize = 0;
            this.btnSpecifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecifications.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSpecifications.ForeColor = System.Drawing.Color.White;
            this.btnSpecifications.Location = new System.Drawing.Point(337, 886);
            this.btnSpecifications.Name = "btnSpecifications";
            this.btnSpecifications.Size = new System.Drawing.Size(160, 42);
            this.btnSpecifications.TabIndex = 38;
            this.btnSpecifications.Text = "Specifications";
            this.btnSpecifications.UseVisualStyleBackColor = false;
            // 
            // btnProductDescription
            // 
            this.btnProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProductDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnProductDescription.FlatAppearance.BorderSize = 0;
            this.btnProductDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductDescription.ForeColor = System.Drawing.Color.White;
            this.btnProductDescription.Location = new System.Drawing.Point(503, 886);
            this.btnProductDescription.Name = "btnProductDescription";
            this.btnProductDescription.Size = new System.Drawing.Size(160, 42);
            this.btnProductDescription.TabIndex = 39;
            this.btnProductDescription.Text = "Description";
            this.btnProductDescription.UseVisualStyleBackColor = false;
            // 
            // btnProductReviews
            // 
            this.btnProductReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProductReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnProductReviews.FlatAppearance.BorderSize = 0;
            this.btnProductReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductReviews.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductReviews.ForeColor = System.Drawing.Color.White;
            this.btnProductReviews.Location = new System.Drawing.Point(669, 886);
            this.btnProductReviews.Name = "btnProductReviews";
            this.btnProductReviews.Size = new System.Drawing.Size(160, 42);
            this.btnProductReviews.TabIndex = 40;
            this.btnProductReviews.Text = "Reviews";
            this.btnProductReviews.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(1031, 886);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(195, 42);
            this.btnDeleteProduct.TabIndex = 41;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // btnComboProducts
            // 
            this.btnComboProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnComboProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnComboProducts.FlatAppearance.BorderSize = 0;
            this.btnComboProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComboProducts.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComboProducts.ForeColor = System.Drawing.Color.White;
            this.btnComboProducts.Location = new System.Drawing.Point(835, 886);
            this.btnComboProducts.Name = "btnComboProducts";
            this.btnComboProducts.Size = new System.Drawing.Size(160, 42);
            this.btnComboProducts.TabIndex = 42;
            this.btnComboProducts.Text = "Combo Products";
            this.btnComboProducts.UseVisualStyleBackColor = false;
            this.btnComboProducts.Click += new System.EventHandler(this.btnComboProducts_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 935);
            this.Controls.Add(this.btnComboProducts);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnProductReviews);
            this.Controls.Add(this.btnProductDescription);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnSpecifications);
            this.Controls.Add(this.btnOpenEditProduct);
            this.Controls.Add(this.lboxProductSpecs);
            this.Controls.Add(this.lblSepcs);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.gboxSearchProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Products";
            this.gboxSearchProduct.ResumeLayout(false);
            this.gboxSearchProduct.PerformLayout();
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
        private Button btnOpenEditProduct;
        private Button btnSpecifications;
        private Button btnProductDescription;
        private Button btnProductReviews;
        private Button btnDeleteProduct;
        private ColumnHeader subCategory;
        private Button btnComboProducts;
    }
}