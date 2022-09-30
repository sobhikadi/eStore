namespace Desktop_app.Forms
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.flpanelContainerSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.brnCustomers = new System.Windows.Forms.Button();
            this.flpanelContainerSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpanelContainerSidebar
            // 
            this.flpanelContainerSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.flpanelContainerSidebar.Controls.Add(this.panelLogo);
            this.flpanelContainerSidebar.Controls.Add(this.btnProducts);
            this.flpanelContainerSidebar.Controls.Add(this.btnEmployees);
            this.flpanelContainerSidebar.Controls.Add(this.brnCustomers);
            this.flpanelContainerSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpanelContainerSidebar.ForeColor = System.Drawing.Color.White;
            this.flpanelContainerSidebar.Location = new System.Drawing.Point(0, 0);
            this.flpanelContainerSidebar.Name = "flpanelContainerSidebar";
            this.flpanelContainerSidebar.Size = new System.Drawing.Size(274, 935);
            this.flpanelContainerSidebar.TabIndex = 7;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.panelLogo.Controls.Add(this.picboxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 3);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(274, 157);
            this.panelLogo.TabIndex = 6;
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.Location = new System.Drawing.Point(67, 9);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(141, 134);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLogo.TabIndex = 0;
            this.picboxLogo.TabStop = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(3, 178);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(268, 65);
            this.btnProducts.TabIndex = 7;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Location = new System.Drawing.Point(3, 261);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(268, 65);
            this.btnEmployees.TabIndex = 8;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelSidebar.Controls.Add(this.flpanelContainerSidebar);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.ForeColor = System.Drawing.Color.White;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(274, 935);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(274, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1238, 935);
            this.panelContainer.TabIndex = 8;
            // 
            // brnCustomers
            // 
            this.brnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.brnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnCustomers.FlatAppearance.BorderSize = 0;
            this.brnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brnCustomers.ForeColor = System.Drawing.Color.White;
            this.brnCustomers.Location = new System.Drawing.Point(3, 344);
            this.brnCustomers.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.brnCustomers.Name = "brnCustomers";
            this.brnCustomers.Size = new System.Drawing.Size(268, 65);
            this.brnCustomers.TabIndex = 9;
            this.brnCustomers.Text = "Customers";
            this.brnCustomers.UseVisualStyleBackColor = false;
            this.brnCustomers.Click += new System.EventHandler(this.brnCustomers_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 935);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSidebar);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.flpanelContainerSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel flpanelContainerSidebar;
        private Panel panelLogo;
        private PictureBox picboxLogo;
        private Button btnProducts;
        private Button btnEmployees;
        private Panel panelSidebar;
        private Panel panelContainer;
        private Button brnCustomers;
    }
}