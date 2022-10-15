﻿namespace Desktop_app.Forms
{
    partial class fAddProduct
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
            this.cboxCatgeory = new System.Windows.Forms.ComboBox();
            this.tbsubCaregory = new System.Windows.Forms.TextBox();
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
            this.tbSeriaNumber = new System.Windows.Forms.TextBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.tbProductColor = new System.Windows.Forms.TextBox();
            this.lblProductColor = new System.Windows.Forms.Label();
            this.tbGamePlatform = new System.Windows.Forms.TextBox();
            this.lblGamePlatform = new System.Windows.Forms.Label();
            this.tbBookIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxCatgeory
            // 
            this.cboxCatgeory.FormattingEnabled = true;
            this.cboxCatgeory.Items.AddRange(new object[] {
            "Books",
            "Electronics",
            "VedioGames",
            "Households"});
            this.cboxCatgeory.Location = new System.Drawing.Point(173, 150);
            this.cboxCatgeory.MaximumSize = new System.Drawing.Size(731, 0);
            this.cboxCatgeory.Name = "cboxCatgeory";
            this.cboxCatgeory.Size = new System.Drawing.Size(615, 31);
            this.cboxCatgeory.TabIndex = 24;
            this.cboxCatgeory.SelectedIndexChanged += new System.EventHandler(this.cboxCatgeory_SelectedIndexChanged);
            // 
            // tbsubCaregory
            // 
            this.tbsubCaregory.Location = new System.Drawing.Point(173, 194);
            this.tbsubCaregory.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbsubCaregory.Name = "tbsubCaregory";
            this.tbsubCaregory.Size = new System.Drawing.Size(615, 30);
            this.tbsubCaregory.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(19, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sub category";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductCategory.Location = new System.Drawing.Point(19, 153);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(79, 23);
            this.lblProductCategory.TabIndex = 21;
            this.lblProductCategory.Text = "Category";
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(173, 107);
            this.tbProductPrice.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(615, 30);
            this.tbProductPrice.TabIndex = 20;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductPrice.Location = new System.Drawing.Point(19, 110);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(47, 23);
            this.lblProductPrice.TabIndex = 19;
            this.lblProductPrice.Text = "Price";
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Location = new System.Drawing.Point(173, 64);
            this.tbProductQuantity.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(615, 30);
            this.tbProductQuantity.TabIndex = 18;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuantity.Location = new System.Drawing.Point(19, 68);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 23);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "Quantity";
            // 
            // tbProductDescription
            // 
            this.tbProductDescription.Location = new System.Drawing.Point(173, 237);
            this.tbProductDescription.MaximumSize = new System.Drawing.Size(731, 116);
            this.tbProductDescription.Multiline = true;
            this.tbProductDescription.Name = "tbProductDescription";
            this.tbProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProductDescription.Size = new System.Drawing.Size(615, 114);
            this.tbProductDescription.TabIndex = 16;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductDescription.Location = new System.Drawing.Point(19, 237);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(96, 23);
            this.lblProductDescription.TabIndex = 15;
            this.lblProductDescription.Text = "Description";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(173, 20);
            this.tbProductName.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(615, 30);
            this.tbProductName.TabIndex = 14;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductName.Location = new System.Drawing.Point(19, 23);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(56, 23);
            this.lblProductName.TabIndex = 13;
            this.lblProductName.Text = "Name";
            // 
            // tbSeriaNumber
            // 
            this.tbSeriaNumber.Enabled = false;
            this.tbSeriaNumber.Location = new System.Drawing.Point(173, 497);
            this.tbSeriaNumber.MaximumSize = new System.Drawing.Size(618, 31);
            this.tbSeriaNumber.Name = "tbSeriaNumber";
            this.tbSeriaNumber.Size = new System.Drawing.Size(615, 30);
            this.tbSeriaNumber.TabIndex = 32;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSerialNumber.Location = new System.Drawing.Point(25, 500);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(119, 23);
            this.lblSerialNumber.TabIndex = 31;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // tbProductColor
            // 
            this.tbProductColor.Enabled = false;
            this.tbProductColor.Location = new System.Drawing.Point(173, 454);
            this.tbProductColor.MaximumSize = new System.Drawing.Size(618, 31);
            this.tbProductColor.Name = "tbProductColor";
            this.tbProductColor.Size = new System.Drawing.Size(615, 30);
            this.tbProductColor.TabIndex = 30;
            // 
            // lblProductColor
            // 
            this.lblProductColor.AutoSize = true;
            this.lblProductColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductColor.Location = new System.Drawing.Point(25, 452);
            this.lblProductColor.Name = "lblProductColor";
            this.lblProductColor.Size = new System.Drawing.Size(51, 23);
            this.lblProductColor.TabIndex = 29;
            this.lblProductColor.Text = "Color";
            // 
            // tbGamePlatform
            // 
            this.tbGamePlatform.Enabled = false;
            this.tbGamePlatform.Location = new System.Drawing.Point(173, 412);
            this.tbGamePlatform.MaximumSize = new System.Drawing.Size(618, 31);
            this.tbGamePlatform.Name = "tbGamePlatform";
            this.tbGamePlatform.Size = new System.Drawing.Size(615, 30);
            this.tbGamePlatform.TabIndex = 28;
            // 
            // lblGamePlatform
            // 
            this.lblGamePlatform.AutoSize = true;
            this.lblGamePlatform.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGamePlatform.Location = new System.Drawing.Point(25, 415);
            this.lblGamePlatform.Name = "lblGamePlatform";
            this.lblGamePlatform.Size = new System.Drawing.Size(125, 23);
            this.lblGamePlatform.TabIndex = 27;
            this.lblGamePlatform.Text = "Game Platform";
            // 
            // tbBookIsbn
            // 
            this.tbBookIsbn.Enabled = false;
            this.tbBookIsbn.Location = new System.Drawing.Point(173, 369);
            this.tbBookIsbn.MaximumSize = new System.Drawing.Size(618, 31);
            this.tbBookIsbn.Name = "tbBookIsbn";
            this.tbBookIsbn.Size = new System.Drawing.Size(615, 30);
            this.tbBookIsbn.TabIndex = 26;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIsbn.Location = new System.Drawing.Point(25, 373);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(90, 23);
            this.lblIsbn.TabIndex = 25;
            this.lblIsbn.Text = "Book ISBN";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(595, 551);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(194, 34);
            this.btnAddProduct.TabIndex = 33;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // fAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 599);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.tbSeriaNumber);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.tbProductColor);
            this.Controls.Add(this.lblProductColor);
            this.Controls.Add(this.tbGamePlatform);
            this.Controls.Add(this.lblGamePlatform);
            this.Controls.Add(this.tbBookIsbn);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.cboxCatgeory);
            this.Controls.Add(this.tbsubCaregory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.tbProductQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbProductDescription);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lblProductName);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "fAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAddProduct_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboxCatgeory;
        private TextBox tbsubCaregory;
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
        private TextBox tbSeriaNumber;
        private Label lblSerialNumber;
        private TextBox tbProductColor;
        private Label lblProductColor;
        private TextBox tbGamePlatform;
        private Label lblGamePlatform;
        private TextBox tbBookIsbn;
        private Label lblIsbn;
        private Button btnAddProduct;
    }
}