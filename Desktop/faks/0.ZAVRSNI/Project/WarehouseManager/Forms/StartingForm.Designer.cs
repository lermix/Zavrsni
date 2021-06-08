namespace WarehouseManager
{
    partial class StartingForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenGui = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.cmb_start_selectWarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnOpenGui);
            this.flowLayoutPanel1.Controls.Add(this.btnWorkers);
            this.flowLayoutPanel1.Controls.Add(this.btnDelivery);
            this.flowLayoutPanel1.Controls.Add(this.btnTable);
            this.flowLayoutPanel1.Controls.Add(this.btnProperties);
            this.flowLayoutPanel1.Controls.Add(this.btnProducts);
            this.flowLayoutPanel1.Controls.Add(this.btnReports);
            this.flowLayoutPanel1.Controls.Add(this.btnWarehouse);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(156, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnOpenGui
            // 
            this.btnOpenGui.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOpenGui.Location = new System.Drawing.Point(3, 3);
            this.btnOpenGui.Name = "btnOpenGui";
            this.btnOpenGui.Size = new System.Drawing.Size(150, 50);
            this.btnOpenGui.TabIndex = 0;
            this.btnOpenGui.Text = "Graphical Interface";
            this.btnOpenGui.UseVisualStyleBackColor = true;
            this.btnOpenGui.Click += new System.EventHandler(this.btnOpenGui_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Location = new System.Drawing.Point(3, 59);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(150, 50);
            this.btnWorkers.TabIndex = 3;
            this.btnWorkers.Text = "Workers";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(3, 115);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(150, 50);
            this.btnDelivery.TabIndex = 2;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(3, 171);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(150, 50);
            this.btnTable.TabIndex = 4;
            this.btnTable.Text = "Table";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.Location = new System.Drawing.Point(3, 227);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(150, 50);
            this.btnProperties.TabIndex = 1;
            this.btnProperties.Text = "Properties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(3, 283);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(150, 50);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(3, 339);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 50);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Location = new System.Drawing.Point(3, 395);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(150, 50);
            this.btnWarehouse.TabIndex = 7;
            this.btnWarehouse.Text = "Warehouse";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // cmb_start_selectWarehouse
            // 
            this.cmb_start_selectWarehouse.FormattingEnabled = true;
            this.cmb_start_selectWarehouse.Location = new System.Drawing.Point(352, 9);
            this.cmb_start_selectWarehouse.Name = "cmb_start_selectWarehouse";
            this.cmb_start_selectWarehouse.Size = new System.Drawing.Size(239, 24);
            this.cmb_start_selectWarehouse.TabIndex = 1;
            this.cmb_start_selectWarehouse.SelectedValueChanged += new System.EventHandler(this.cmb_start_selectWarehouse_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECT WAREHOUSE:";
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_start_selectWarehouse);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StartingForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StartingForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOpenGui;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.ComboBox cmb_start_selectWarehouse;
        private System.Windows.Forms.Label label1;
    }
}

