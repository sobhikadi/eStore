namespace Desktop_app.Forms.Products
{
    partial class ComboProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboProduct));
            this.listViewComboProducts = new System.Windows.Forms.ListView();
            this.listViewProductsInCombo = new System.Windows.Forms.ListView();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.btnFrom = new System.Windows.Forms.Button();
            this.btnTo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listViewComboProducts
            // 
            this.listViewComboProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewComboProducts.GridLines = true;
            this.listViewComboProducts.Location = new System.Drawing.Point(12, 37);
            this.listViewComboProducts.Name = "listViewComboProducts";
            this.listViewComboProducts.Size = new System.Drawing.Size(392, 467);
            this.listViewComboProducts.TabIndex = 0;
            this.listViewComboProducts.UseCompatibleStateImageBehavior = false;
            this.listViewComboProducts.View = System.Windows.Forms.View.Details;
            // 
            // listViewProductsInCombo
            // 
            this.listViewProductsInCombo.GridLines = true;
            this.listViewProductsInCombo.Location = new System.Drawing.Point(424, 37);
            this.listViewProductsInCombo.Name = "listViewProductsInCombo";
            this.listViewProductsInCombo.Size = new System.Drawing.Size(367, 467);
            this.listViewProductsInCombo.TabIndex = 1;
            this.listViewProductsInCombo.UseCompatibleStateImageBehavior = false;
            this.listViewProductsInCombo.View = System.Windows.Forms.View.Details;
            // 
            // listViewProducts
            // 
            this.listViewProducts.GridLines = true;
            this.listViewProducts.Location = new System.Drawing.Point(879, 37);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(367, 467);
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // btnFrom
            // 
            this.btnFrom.Location = new System.Drawing.Point(797, 197);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(76, 29);
            this.btnFrom.TabIndex = 3;
            this.btnFrom.Text = "From";
            this.btnFrom.UseVisualStyleBackColor = true;
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(797, 298);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(76, 29);
            this.btnTo.TabIndex = 4;
            this.btnTo.Text = "To";
            this.btnTo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 531);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 30);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(424, 534);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 30);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "quantity";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(719, 534);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 30);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "discount";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1134, 629);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            // 
            // ComboProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 714);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.btnFrom);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.listViewProductsInCombo);
            this.Controls.Add(this.listViewComboProducts);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComboProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewComboProducts;
        private ListView listViewProductsInCombo;
        private ListView listViewProducts;
        private Button btnFrom;
        private Button btnTo;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button btnAdd;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}