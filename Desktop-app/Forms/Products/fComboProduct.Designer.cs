namespace Desktop_app.Forms.Products
{
    partial class fComboProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fComboProduct));
            this.btnFrom = new System.Windows.Forms.Button();
            this.btnTo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewSingleProducts = new System.Windows.Forms.DataGridView();
            this.SingleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinglePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingleQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSingleProducts = new System.Windows.Forms.Label();
            this.lblComboProducts = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewSingleInCombo = new System.Windows.Forms.DataGridView();
            this.SinCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinCPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinCQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboNrProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboProducts = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingleProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingleInCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComboProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrom
            // 
            this.btnFrom.Location = new System.Drawing.Point(921, 213);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(87, 29);
            this.btnFrom.TabIndex = 2;
            this.btnFrom.Text = "<<";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(921, 314);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(87, 29);
            this.btnTo.TabIndex = 3;
            this.btnTo.Text = ">>";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
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
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(101, 531);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(440, 30);
            this.tbName.TabIndex = 6;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(101, 567);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(440, 30);
            this.tbDiscount.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "discount";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(1233, 604);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 44);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewSingleProducts
            // 
            this.dataGridViewSingleProducts.AllowUserToAddRows = false;
            this.dataGridViewSingleProducts.AllowUserToDeleteRows = false;
            this.dataGridViewSingleProducts.AllowUserToOrderColumns = true;
            this.dataGridViewSingleProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSingleProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSingleProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSingleProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingleName,
            this.SinglePrice,
            this.SingleQuantity});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSingleProducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSingleProducts.Location = new System.Drawing.Point(1014, 35);
            this.dataGridViewSingleProducts.MultiSelect = false;
            this.dataGridViewSingleProducts.Name = "dataGridViewSingleProducts";
            this.dataGridViewSingleProducts.ReadOnly = true;
            this.dataGridViewSingleProducts.RowHeadersWidth = 30;
            this.dataGridViewSingleProducts.RowTemplate.Height = 29;
            this.dataGridViewSingleProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSingleProducts.Size = new System.Drawing.Size(375, 467);
            this.dataGridViewSingleProducts.TabIndex = 4;
            this.dataGridViewSingleProducts.SelectionChanged += new System.EventHandler(this.dataGridViewSingleProducts_SelectionChanged);
            // 
            // SingleName
            // 
            this.SingleName.HeaderText = "Name";
            this.SingleName.MinimumWidth = 6;
            this.SingleName.Name = "SingleName";
            this.SingleName.ReadOnly = true;
            this.SingleName.Width = 180;
            // 
            // SinglePrice
            // 
            this.SinglePrice.HeaderText = "Price";
            this.SinglePrice.MinimumWidth = 6;
            this.SinglePrice.Name = "SinglePrice";
            this.SinglePrice.ReadOnly = true;
            this.SinglePrice.Width = 80;
            // 
            // SingleQuantity
            // 
            this.SingleQuantity.HeaderText = "Quantity";
            this.SingleQuantity.MinimumWidth = 6;
            this.SingleQuantity.Name = "SingleQuantity";
            this.SingleQuantity.ReadOnly = true;
            this.SingleQuantity.Width = 80;
            // 
            // lblSingleProducts
            // 
            this.lblSingleProducts.AutoSize = true;
            this.lblSingleProducts.Location = new System.Drawing.Point(1014, 7);
            this.lblSingleProducts.Name = "lblSingleProducts";
            this.lblSingleProducts.Size = new System.Drawing.Size(123, 23);
            this.lblSingleProducts.TabIndex = 15;
            this.lblSingleProducts.Text = "SingleProducts";
            // 
            // lblComboProducts
            // 
            this.lblComboProducts.AutoSize = true;
            this.lblComboProducts.Location = new System.Drawing.Point(10, 7);
            this.lblComboProducts.Name = "lblComboProducts";
            this.lblComboProducts.Size = new System.Drawing.Size(133, 23);
            this.lblComboProducts.TabIndex = 16;
            this.lblComboProducts.Text = "ComboProducts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Single In Combo products";
            // 
            // dataGridViewSingleInCombo
            // 
            this.dataGridViewSingleInCombo.AllowUserToAddRows = false;
            this.dataGridViewSingleInCombo.AllowUserToDeleteRows = false;
            this.dataGridViewSingleInCombo.AllowUserToOrderColumns = true;
            this.dataGridViewSingleInCombo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSingleInCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSingleInCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SinCName,
            this.SinCPrice,
            this.SinCQuantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSingleInCombo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSingleInCombo.Location = new System.Drawing.Point(547, 35);
            this.dataGridViewSingleInCombo.MultiSelect = false;
            this.dataGridViewSingleInCombo.Name = "dataGridViewSingleInCombo";
            this.dataGridViewSingleInCombo.ReadOnly = true;
            this.dataGridViewSingleInCombo.RowHeadersWidth = 30;
            this.dataGridViewSingleInCombo.RowTemplate.Height = 29;
            this.dataGridViewSingleInCombo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSingleInCombo.Size = new System.Drawing.Size(368, 467);
            this.dataGridViewSingleInCombo.TabIndex = 1;
            this.dataGridViewSingleInCombo.SelectionChanged += new System.EventHandler(this.dataGridViewSingleInCombo_SelectionChanged);
            // 
            // SinCName
            // 
            this.SinCName.FillWeight = 280.7487F;
            this.SinCName.HeaderText = "Name";
            this.SinCName.MinimumWidth = 6;
            this.SinCName.Name = "SinCName";
            this.SinCName.ReadOnly = true;
            this.SinCName.Width = 175;
            // 
            // SinCPrice
            // 
            this.SinCPrice.FillWeight = 10.6863F;
            this.SinCPrice.HeaderText = "Price";
            this.SinCPrice.MinimumWidth = 6;
            this.SinCPrice.Name = "SinCPrice";
            this.SinCPrice.ReadOnly = true;
            this.SinCPrice.Width = 80;
            // 
            // SinCQuantity
            // 
            this.SinCQuantity.FillWeight = 8.565047F;
            this.SinCQuantity.HeaderText = "Quantity";
            this.SinCQuantity.MinimumWidth = 6;
            this.SinCQuantity.Name = "SinCQuantity";
            this.SinCQuantity.ReadOnly = true;
            this.SinCQuantity.Width = 80;
            // 
            // ComboNrProducts
            // 
            this.ComboNrProducts.HeaderText = "Nr.Products";
            this.ComboNrProducts.MinimumWidth = 6;
            this.ComboNrProducts.Name = "ComboNrProducts";
            this.ComboNrProducts.ReadOnly = true;
            // 
            // ComboDiscount
            // 
            this.ComboDiscount.HeaderText = "Discount";
            this.ComboDiscount.MinimumWidth = 6;
            this.ComboDiscount.Name = "ComboDiscount";
            this.ComboDiscount.ReadOnly = true;
            // 
            // ComboQuantity
            // 
            this.ComboQuantity.HeaderText = "Quantity";
            this.ComboQuantity.MinimumWidth = 6;
            this.ComboQuantity.Name = "ComboQuantity";
            this.ComboQuantity.ReadOnly = true;
            // 
            // ComboPrice
            // 
            this.ComboPrice.HeaderText = "Price";
            this.ComboPrice.MinimumWidth = 6;
            this.ComboPrice.Name = "ComboPrice";
            this.ComboPrice.ReadOnly = true;
            // 
            // ComboName
            // 
            this.ComboName.HeaderText = "Name";
            this.ComboName.MinimumWidth = 6;
            this.ComboName.Name = "ComboName";
            this.ComboName.ReadOnly = true;
            // 
            // dataGridViewComboProducts
            // 
            this.dataGridViewComboProducts.AllowUserToAddRows = false;
            this.dataGridViewComboProducts.AllowUserToDeleteRows = false;
            this.dataGridViewComboProducts.AllowUserToOrderColumns = true;
            this.dataGridViewComboProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComboProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewComboProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComboProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComboName,
            this.ComboPrice,
            this.ComboQuantity,
            this.ComboDiscount,
            this.ComboNrProducts});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewComboProducts.Location = new System.Drawing.Point(10, 35);
            this.dataGridViewComboProducts.Name = "dataGridViewComboProducts";
            this.dataGridViewComboProducts.ReadOnly = true;
            this.dataGridViewComboProducts.RowHeadersWidth = 20;
            this.dataGridViewComboProducts.RowTemplate.Height = 29;
            this.dataGridViewComboProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComboProducts.Size = new System.Drawing.Size(531, 467);
            this.dataGridViewComboProducts.TabIndex = 0;
            this.dataGridViewComboProducts.SelectionChanged += new System.EventHandler(this.dataGridViewComboProducts_SelectionChanged);
            this.dataGridViewComboProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewComboProducts_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(898, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 69);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select a combo product to add and remove products to/from,\r\n or deselect the comb" +
    "o product and enter new information to\r\n create new combo product and add/remove" +
    " products to from.";
            // 
            // fComboProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 660);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSingleInCombo);
            this.Controls.Add(this.dataGridViewComboProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblComboProducts);
            this.Controls.Add(this.lblSingleProducts);
            this.Controls.Add(this.dataGridViewSingleProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.btnFrom);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fComboProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComboProduct_FormClosing);
            this.Load += new System.EventHandler(this.ComboProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingleProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingleInCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComboProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnFrom;
        private Button btnTo;
        private Label label1;
        private TextBox tbName;
        private TextBox tbDiscount;
        private Label label3;
        private Button btnAdd;
        private DataGridView dataGridViewSingleProducts;
        private Label lblSingleProducts;
        private Label lblComboProducts;
        private Label label5;
        private DataGridView dataGridViewComboProducts;
        private DataGridView dataGridViewSingleInCombo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn SingleName;
        private DataGridViewTextBoxColumn ComboName;
        private DataGridViewTextBoxColumn SinglePrice;
        private DataGridViewTextBoxColumn SingleQuantity;
        private DataGridViewTextBoxColumn ComboPrice;
        private DataGridViewTextBoxColumn ComboQuantity;
        private DataGridViewTextBoxColumn ComboDiscount;
        private DataGridViewTextBoxColumn ComboNrProducts;
        private DataGridViewTextBoxColumn SinCName;
        private DataGridViewTextBoxColumn SinCPrice;
        private DataGridViewTextBoxColumn SinCQuantity;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
    }
}