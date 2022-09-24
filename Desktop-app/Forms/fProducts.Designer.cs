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
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.tbSearchId = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Product = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblSepcs = new System.Windows.Forms.Label();
            this.lboxProductSpecs = new System.Windows.Forms.ListBox();
            this.gboxAddProduct = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbGamePlatform = new System.Windows.Forms.TextBox();
            this.lblGamePlatform = new System.Windows.Forms.Label();
            this.tbBookIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbProductDescription = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbProductColor = new System.Windows.Forms.TextBox();
            this.lblProductColor = new System.Windows.Forms.Label();
            this.tbSeriaNumber = new System.Windows.Forms.TextBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.gboxSearchProduct.SuspendLayout();
            this.gboxAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSearchProduct
            // 
            this.gboxSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxSearchProduct.Controls.Add(this.btnSearchProduct);
            this.gboxSearchProduct.Controls.Add(this.tbSearchId);
            this.gboxSearchProduct.Controls.Add(this.lblSearch);
            this.gboxSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.gboxSearchProduct.Location = new System.Drawing.Point(0, 13);
            this.gboxSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.gboxSearchProduct.Name = "gboxSearchProduct";
            this.gboxSearchProduct.Padding = new System.Windows.Forms.Padding(4);
            this.gboxSearchProduct.Size = new System.Drawing.Size(1238, 78);
            this.gboxSearchProduct.TabIndex = 0;
            this.gboxSearchProduct.TabStop = false;
            this.gboxSearchProduct.Text = "Search Product";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(1054, 27);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(172, 39);
            this.btnSearchProduct.TabIndex = 7;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            // 
            // tbSearchId
            // 
            this.tbSearchId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchId.Location = new System.Drawing.Point(484, 32);
            this.tbSearchId.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchId.Name = "tbSearchId";
            this.tbSearchId.Size = new System.Drawing.Size(554, 31);
            this.tbSearchId.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearch.Location = new System.Drawing.Point(13, 35);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(463, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Enter name, category or subcategory to search a product";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.Quantity,
            this.Description});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(5, 132);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(975, 229);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 300;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.lblProducts.Location = new System.Drawing.Point(5, 100);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(82, 25);
            this.lblProducts.TabIndex = 3;
            this.lblProducts.Text = "Products";
            // 
            // lblSepcs
            // 
            this.lblSepcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSepcs.AutoSize = true;
            this.lblSepcs.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSepcs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.lblSepcs.Location = new System.Drawing.Point(987, 104);
            this.lblSepcs.Name = "lblSepcs";
            this.lblSepcs.Size = new System.Drawing.Size(187, 25);
            this.lblSepcs.TabIndex = 4;
            this.lblSepcs.Text = "Product Specifications";
            // 
            // lboxProductSpecs
            // 
            this.lboxProductSpecs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxProductSpecs.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxProductSpecs.FormattingEnabled = true;
            this.lboxProductSpecs.ItemHeight = 25;
            this.lboxProductSpecs.Location = new System.Drawing.Point(987, 132);
            this.lboxProductSpecs.Name = "lboxProductSpecs";
            this.lboxProductSpecs.Size = new System.Drawing.Size(239, 229);
            this.lboxProductSpecs.TabIndex = 5;
            // 
            // gboxAddProduct
            // 
            this.gboxAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxAddProduct.Controls.Add(this.tbSeriaNumber);
            this.gboxAddProduct.Controls.Add(this.lblSerialNumber);
            this.gboxAddProduct.Controls.Add(this.tbProductColor);
            this.gboxAddProduct.Controls.Add(this.lblProductColor);
            this.gboxAddProduct.Controls.Add(this.btnAddProduct);
            this.gboxAddProduct.Controls.Add(this.tbGamePlatform);
            this.gboxAddProduct.Controls.Add(this.lblGamePlatform);
            this.gboxAddProduct.Controls.Add(this.tbBookIsbn);
            this.gboxAddProduct.Controls.Add(this.lblIsbn);
            this.gboxAddProduct.Controls.Add(this.comboBox1);
            this.gboxAddProduct.Controls.Add(this.textBox4);
            this.gboxAddProduct.Controls.Add(this.label4);
            this.gboxAddProduct.Controls.Add(this.lblProductCategory);
            this.gboxAddProduct.Controls.Add(this.tbProductPrice);
            this.gboxAddProduct.Controls.Add(this.lblProductPrice);
            this.gboxAddProduct.Controls.Add(this.tbProductQuantity);
            this.gboxAddProduct.Controls.Add(this.lblQuantity);
            this.gboxAddProduct.Controls.Add(this.tbProductDescription);
            this.gboxAddProduct.Controls.Add(this.lblProductDescription);
            this.gboxAddProduct.Controls.Add(this.tbProductName);
            this.gboxAddProduct.Controls.Add(this.lblProductName);
            this.gboxAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.gboxAddProduct.Location = new System.Drawing.Point(5, 380);
            this.gboxAddProduct.Name = "gboxAddProduct";
            this.gboxAddProduct.Size = new System.Drawing.Size(670, 543);
            this.gboxAddProduct.TabIndex = 6;
            this.gboxAddProduct.TabStop = false;
            this.gboxAddProduct.Text = "Add Product";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(492, 498);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(172, 39);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // tbGamePlatform
            // 
            this.tbGamePlatform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGamePlatform.Location = new System.Drawing.Point(153, 363);
            this.tbGamePlatform.Name = "tbGamePlatform";
            this.tbGamePlatform.Size = new System.Drawing.Size(511, 31);
            this.tbGamePlatform.TabIndex = 16;
            // 
            // lblGamePlatform
            // 
            this.lblGamePlatform.AutoSize = true;
            this.lblGamePlatform.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGamePlatform.Location = new System.Drawing.Point(16, 366);
            this.lblGamePlatform.Name = "lblGamePlatform";
            this.lblGamePlatform.Size = new System.Drawing.Size(131, 25);
            this.lblGamePlatform.TabIndex = 15;
            this.lblGamePlatform.Text = "Game Platform";
            // 
            // tbBookIsbn
            // 
            this.tbBookIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBookIsbn.Location = new System.Drawing.Point(153, 316);
            this.tbBookIsbn.Name = "tbBookIsbn";
            this.tbBookIsbn.Size = new System.Drawing.Size(511, 31);
            this.tbBookIsbn.TabIndex = 14;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIsbn.Location = new System.Drawing.Point(16, 319);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(96, 25);
            this.lblIsbn.TabIndex = 13;
            this.lblIsbn.Text = "Book ISBN";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Books",
            "Electronics",
            "VedioGames",
            "Households"});
            this.comboBox1.Location = new System.Drawing.Point(153, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(511, 33);
            this.comboBox1.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(153, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(511, 31);
            this.textBox4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(16, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sub category";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductCategory.Location = new System.Drawing.Point(16, 141);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(84, 25);
            this.lblProductCategory.TabIndex = 8;
            this.lblProductCategory.Text = "Category";
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductPrice.Location = new System.Drawing.Point(153, 101);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(511, 31);
            this.tbProductPrice.TabIndex = 7;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductPrice.Location = new System.Drawing.Point(16, 104);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(49, 25);
            this.lblProductPrice.TabIndex = 6;
            this.lblProductPrice.Text = "Price";
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductQuantity.Location = new System.Drawing.Point(153, 64);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(511, 31);
            this.tbProductQuantity.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuantity.Location = new System.Drawing.Point(16, 67);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 25);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // tbProductDescription
            // 
            this.tbProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductDescription.Location = new System.Drawing.Point(153, 214);
            this.tbProductDescription.Multiline = true;
            this.tbProductDescription.Name = "tbProductDescription";
            this.tbProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProductDescription.Size = new System.Drawing.Size(511, 96);
            this.tbProductDescription.TabIndex = 3;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductDescription.Location = new System.Drawing.Point(16, 214);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(102, 25);
            this.lblProductDescription.TabIndex = 2;
            this.lblProductDescription.Text = "Description";
            // 
            // tbProductName
            // 
            this.tbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductName.Location = new System.Drawing.Point(153, 25);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(511, 31);
            this.tbProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductName.Location = new System.Drawing.Point(16, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(59, 25);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name";
            // 
            // tbProductColor
            // 
            this.tbProductColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductColor.Location = new System.Drawing.Point(153, 400);
            this.tbProductColor.Name = "tbProductColor";
            this.tbProductColor.Size = new System.Drawing.Size(511, 31);
            this.tbProductColor.TabIndex = 18;
            // 
            // lblProductColor
            // 
            this.lblProductColor.AutoSize = true;
            this.lblProductColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductColor.Location = new System.Drawing.Point(16, 403);
            this.lblProductColor.Name = "lblProductColor";
            this.lblProductColor.Size = new System.Drawing.Size(55, 25);
            this.lblProductColor.TabIndex = 17;
            this.lblProductColor.Text = "Color";
            // 
            // tbSeriaNumber
            // 
            this.tbSeriaNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSeriaNumber.Location = new System.Drawing.Point(153, 437);
            this.tbSeriaNumber.Name = "tbSeriaNumber";
            this.tbSeriaNumber.Size = new System.Drawing.Size(511, 31);
            this.tbSeriaNumber.TabIndex = 20;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSerialNumber.Location = new System.Drawing.Point(16, 440);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(124, 25);
            this.lblSerialNumber.TabIndex = 19;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // fProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 935);
            this.Controls.Add(this.gboxAddProduct);
            this.Controls.Add(this.lboxProductSpecs);
            this.Controls.Add(this.lblSepcs);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gboxSearchProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fProducts";
            this.gboxSearchProduct.ResumeLayout(false);
            this.gboxSearchProduct.PerformLayout();
            this.gboxAddProduct.ResumeLayout(false);
            this.gboxAddProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gboxSearchProduct;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Product;
        private TextBox tbSearchId;
        private Label lblSearch;
        private Label lblProducts;
        private Label lblSepcs;
        private ListBox lboxProductSpecs;
        private ColumnHeader Quantity;
        private ColumnHeader Description;
        private GroupBox gboxAddProduct;
        private TextBox textBox4;
        private Label label4;
        private Label lblProductCategory;
        private TextBox tbProductPrice;
        private Label lblProductPrice;
        private TextBox tbProductQuantity;
        private Label lblQuantity;
        private TextBox tbProductDescription;
        private Label lblProductDescription;
        private TextBox tbProductName;
        private Label lblProductName;
        private ComboBox comboBox1;
        private TextBox tbGamePlatform;
        private Label lblGamePlatform;
        private TextBox tbBookIsbn;
        private Label lblIsbn;
        private Button btnSearchProduct;
        private Button btnAddProduct;
        private TextBox tbProductColor;
        private Label lblProductColor;
        private TextBox tbSeriaNumber;
        private Label lblSerialNumber;
    }
}