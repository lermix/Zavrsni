namespace WarehouseManager.Forms
{
    partial class WarehouseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditWarehoseTab = new System.Windows.Forms.Button();
            this.btnAddWarehouse_tab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.warehouseTab = new System.Windows.Forms.TabControl();
            this.tabPageAddWarehaouse = new System.Windows.Forms.TabPage();
            this.btn_editWarehosue_search = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_addWarehouse_add = new System.Windows.Forms.Button();
            this.tbox_addWarehouse_capacity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_addWarehouse_adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_addWarahouse_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_addWarehouse_id = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.warehouseTab.SuspendLayout();
            this.tabPageAddWarehaouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditWarehoseTab);
            this.panel1.Controls.Add(this.btnAddWarehouse_tab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 663);
            this.panel1.TabIndex = 0;
            // 
            // btnEditWarehoseTab
            // 
            this.btnEditWarehoseTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditWarehoseTab.Location = new System.Drawing.Point(0, 50);
            this.btnEditWarehoseTab.Name = "btnEditWarehoseTab";
            this.btnEditWarehoseTab.Size = new System.Drawing.Size(157, 50);
            this.btnEditWarehoseTab.TabIndex = 2;
            this.btnEditWarehoseTab.Text = "Edit warehouse";
            this.btnEditWarehoseTab.UseVisualStyleBackColor = true;
            this.btnEditWarehoseTab.Click += new System.EventHandler(this.btnEditWarehoseTab_Click);
            // 
            // btnAddWarehouse_tab
            // 
            this.btnAddWarehouse_tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddWarehouse_tab.Location = new System.Drawing.Point(0, 0);
            this.btnAddWarehouse_tab.Name = "btnAddWarehouse_tab";
            this.btnAddWarehouse_tab.Size = new System.Drawing.Size(157, 50);
            this.btnAddWarehouse_tab.TabIndex = 1;
            this.btnAddWarehouse_tab.Text = "Add Warehouse";
            this.btnAddWarehouse_tab.UseVisualStyleBackColor = true;
            this.btnAddWarehouse_tab.Click += new System.EventHandler(this.btnAddWarehouse_tab_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.warehouseTab);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(157, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 663);
            this.panel2.TabIndex = 1;
            // 
            // warehouseTab
            // 
            this.warehouseTab.Controls.Add(this.tabPageAddWarehaouse);
            this.warehouseTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warehouseTab.Location = new System.Drawing.Point(0, 0);
            this.warehouseTab.Name = "warehouseTab";
            this.warehouseTab.SelectedIndex = 0;
            this.warehouseTab.Size = new System.Drawing.Size(1303, 663);
            this.warehouseTab.TabIndex = 0;
            // 
            // tabPageAddWarehaouse
            // 
            this.tabPageAddWarehaouse.Controls.Add(this.btn_editWarehosue_search);
            this.tabPageAddWarehaouse.Controls.Add(this.btnSave);
            this.tabPageAddWarehaouse.Controls.Add(this.btn_addWarehouse_add);
            this.tabPageAddWarehaouse.Controls.Add(this.tbox_addWarehouse_capacity);
            this.tabPageAddWarehaouse.Controls.Add(this.label3);
            this.tabPageAddWarehaouse.Controls.Add(this.tbox_addWarehouse_adress);
            this.tabPageAddWarehaouse.Controls.Add(this.label2);
            this.tabPageAddWarehaouse.Controls.Add(this.tbox_addWarahouse_name);
            this.tabPageAddWarehaouse.Controls.Add(this.label1);
            this.tabPageAddWarehaouse.Controls.Add(this.tbox_addWarehouse_id);
            this.tabPageAddWarehaouse.Controls.Add(this.lblName);
            this.tabPageAddWarehaouse.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddWarehaouse.Name = "tabPageAddWarehaouse";
            this.tabPageAddWarehaouse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddWarehaouse.Size = new System.Drawing.Size(1295, 634);
            this.tabPageAddWarehaouse.TabIndex = 0;
            this.tabPageAddWarehaouse.Text = "add warehouse";
            this.tabPageAddWarehaouse.UseVisualStyleBackColor = true;
            // 
            // btn_editWarehosue_search
            // 
            this.btn_editWarehosue_search.Location = new System.Drawing.Point(13, 200);
            this.btn_editWarehosue_search.Name = "btn_editWarehosue_search";
            this.btn_editWarehosue_search.Size = new System.Drawing.Size(75, 23);
            this.btn_editWarehosue_search.TabIndex = 19;
            this.btn_editWarehosue_search.Text = "Search";
            this.btn_editWarehosue_search.UseVisualStyleBackColor = true;
            this.btn_editWarehosue_search.Click += new System.EventHandler(this.btn_editWarehosue_search_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btn_addWarehouse_add_Click);
            // 
            // btn_addWarehouse_add
            // 
            this.btn_addWarehouse_add.Location = new System.Drawing.Point(314, 200);
            this.btn_addWarehouse_add.Name = "btn_addWarehouse_add";
            this.btn_addWarehouse_add.Size = new System.Drawing.Size(75, 23);
            this.btn_addWarehouse_add.TabIndex = 17;
            this.btn_addWarehouse_add.Text = "Add";
            this.btn_addWarehouse_add.UseVisualStyleBackColor = true;
            this.btn_addWarehouse_add.Click += new System.EventHandler(this.btn_addWarehouse_add_Click);
            // 
            // tbox_addWarehouse_capacity
            // 
            this.tbox_addWarehouse_capacity.Location = new System.Drawing.Point(13, 158);
            this.tbox_addWarehouse_capacity.Name = "tbox_addWarehouse_capacity";
            this.tbox_addWarehouse_capacity.Size = new System.Drawing.Size(376, 22);
            this.tbox_addWarehouse_capacity.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Capacity:";
            // 
            // tbox_addWarehouse_adress
            // 
            this.tbox_addWarehouse_adress.Location = new System.Drawing.Point(13, 113);
            this.tbox_addWarehouse_adress.Name = "tbox_addWarehouse_adress";
            this.tbox_addWarehouse_adress.Size = new System.Drawing.Size(376, 22);
            this.tbox_addWarehouse_adress.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adress:";
            // 
            // tbox_addWarahouse_name
            // 
            this.tbox_addWarahouse_name.Location = new System.Drawing.Point(13, 68);
            this.tbox_addWarahouse_name.Name = "tbox_addWarahouse_name";
            this.tbox_addWarahouse_name.Size = new System.Drawing.Size(376, 22);
            this.tbox_addWarahouse_name.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // tbox_addWarehouse_id
            // 
            this.tbox_addWarehouse_id.Enabled = false;
            this.tbox_addWarehouse_id.Location = new System.Drawing.Point(41, 6);
            this.tbox_addWarehouse_id.Name = "tbox_addWarehouse_id";
            this.tbox_addWarehouse_id.Size = new System.Drawing.Size(92, 22);
            this.tbox_addWarehouse_id.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "ID:";
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WarehouseForm";
            this.Text = "WarehouseForm";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.warehouseTab.ResumeLayout(false);
            this.tabPageAddWarehaouse.ResumeLayout(false);
            this.tabPageAddWarehaouse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddWarehouse_tab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl warehouseTab;
        private System.Windows.Forms.TabPage tabPageAddWarehaouse;
        private System.Windows.Forms.Button btn_addWarehouse_add;
        private System.Windows.Forms.TextBox tbox_addWarehouse_capacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_addWarehouse_adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_addWarahouse_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_addWarehouse_id;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEditWarehoseTab;
        private System.Windows.Forms.Button btn_editWarehosue_search;
        private System.Windows.Forms.Button btnSave;
    }
}