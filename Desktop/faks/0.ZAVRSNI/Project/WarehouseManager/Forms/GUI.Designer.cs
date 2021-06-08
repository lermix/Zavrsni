namespace WarehouseManager.Forms
{
    partial class GUI
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
            this.panelGUI = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFoundProducts = new System.Windows.Forms.ComboBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.tBoxSearchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchProperty = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panelDragControl = new System.Windows.Forms.Panel();
            this.checkBoxDragEnabled = new System.Windows.Forms.CheckBox();
            this.btnAllowDrag = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tBoxAddName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbAddType = new System.Windows.Forms.ComboBox();
            this.lblAddUnit = new System.Windows.Forms.Label();
            this.btnBackFromChild = new System.Windows.Forms.Button();
            this.lblCurrentButtonID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxDeleteEnabled = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelSearch.SuspendLayout();
            this.panelDragControl.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGUI
            // 
            this.panelGUI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelGUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGUI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGUI.Location = new System.Drawing.Point(0, 0);
            this.panelGUI.Name = "panelGUI";
            this.panelGUI.Size = new System.Drawing.Size(1343, 632);
            this.panelGUI.TabIndex = 0;
            this.panelGUI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseClicked);
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.cmbFoundProducts);
            this.panelSearch.Controls.Add(this.btnClearSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.lblValue);
            this.panelSearch.Controls.Add(this.tBoxSearchValue);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.cmbSearchProperty);
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(1343, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(393, 214);
            this.panelSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Found products";
            // 
            // cmbFoundProducts
            // 
            this.cmbFoundProducts.FormattingEnabled = true;
            this.cmbFoundProducts.Location = new System.Drawing.Point(118, 180);
            this.cmbFoundProducts.Name = "cmbFoundProducts";
            this.cmbFoundProducts.Size = new System.Drawing.Size(253, 24);
            this.cmbFoundProducts.TabIndex = 7;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(104, 148);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(145, 23);
            this.btnClearSearch.TabIndex = 6;
            this.btnClearSearch.Text = "Clear search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(9, 148);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(6, 84);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(44, 17);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value";
            // 
            // tBoxSearchValue
            // 
            this.tBoxSearchValue.Location = new System.Drawing.Point(9, 104);
            this.tBoxSearchValue.Name = "tBoxSearchValue";
            this.tBoxSearchValue.Size = new System.Drawing.Size(362, 22);
            this.tBoxSearchValue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Property";
            // 
            // cmbSearchProperty
            // 
            this.cmbSearchProperty.FormattingEnabled = true;
            this.cmbSearchProperty.Items.AddRange(new object[] {
            "name",
            "description",
            "barcode"});
            this.cmbSearchProperty.Location = new System.Drawing.Point(9, 57);
            this.cmbSearchProperty.Name = "cmbSearchProperty";
            this.cmbSearchProperty.Size = new System.Drawing.Size(362, 24);
            this.cmbSearchProperty.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "SEARCH";
            // 
            // panelDragControl
            // 
            this.panelDragControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDragControl.Controls.Add(this.checkBoxDragEnabled);
            this.panelDragControl.Controls.Add(this.btnAllowDrag);
            this.panelDragControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDragControl.Location = new System.Drawing.Point(1343, 214);
            this.panelDragControl.Name = "panelDragControl";
            this.panelDragControl.Size = new System.Drawing.Size(393, 48);
            this.panelDragControl.TabIndex = 2;
            // 
            // checkBoxDragEnabled
            // 
            this.checkBoxDragEnabled.AutoSize = true;
            this.checkBoxDragEnabled.Enabled = false;
            this.checkBoxDragEnabled.Location = new System.Drawing.Point(146, 13);
            this.checkBoxDragEnabled.Name = "checkBoxDragEnabled";
            this.checkBoxDragEnabled.Size = new System.Drawing.Size(116, 21);
            this.checkBoxDragEnabled.TabIndex = 3;
            this.checkBoxDragEnabled.Text = "Drag enabled";
            this.checkBoxDragEnabled.UseVisualStyleBackColor = true;
            // 
            // btnAllowDrag
            // 
            this.btnAllowDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAllowDrag.Location = new System.Drawing.Point(9, 6);
            this.btnAllowDrag.Name = "btnAllowDrag";
            this.btnAllowDrag.Size = new System.Drawing.Size(130, 32);
            this.btnAllowDrag.TabIndex = 1;
            this.btnAllowDrag.Text = "Allow Drag";
            this.btnAllowDrag.UseVisualStyleBackColor = false;
            this.btnAllowDrag.Click += new System.EventHandler(this.btnAllowDrag_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdd.Controls.Add(this.btnAdd);
            this.panelAdd.Controls.Add(this.tBoxAddName);
            this.panelAdd.Controls.Add(this.lblName);
            this.panelAdd.Controls.Add(this.lblType);
            this.panelAdd.Controls.Add(this.cmbAddType);
            this.panelAdd.Controls.Add(this.lblAddUnit);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdd.Location = new System.Drawing.Point(1343, 262);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(393, 152);
            this.panelAdd.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.Location = new System.Drawing.Point(14, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tBoxAddName
            // 
            this.tBoxAddName.Location = new System.Drawing.Point(90, 66);
            this.tBoxAddName.Name = "tBoxAddName";
            this.tBoxAddName.Size = new System.Drawing.Size(281, 22);
            this.tBoxAddName.TabIndex = 4;
            this.tBoxAddName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limitTo255Chars);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Unit name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(11, 26);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(68, 17);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Unit type:";
            // 
            // cmbAddType
            // 
            this.cmbAddType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddType.FormattingEnabled = true;
            this.cmbAddType.Items.AddRange(new object[] {
            "Storage collection",
            "Storage unit"});
            this.cmbAddType.Location = new System.Drawing.Point(90, 23);
            this.cmbAddType.Name = "cmbAddType";
            this.cmbAddType.Size = new System.Drawing.Size(281, 24);
            this.cmbAddType.TabIndex = 1;
            // 
            // lblAddUnit
            // 
            this.lblAddUnit.AutoSize = true;
            this.lblAddUnit.Location = new System.Drawing.Point(6, 3);
            this.lblAddUnit.Name = "lblAddUnit";
            this.lblAddUnit.Size = new System.Drawing.Size(73, 17);
            this.lblAddUnit.TabIndex = 0;
            this.lblAddUnit.Text = "ADD UNIT";
            // 
            // btnBackFromChild
            // 
            this.btnBackFromChild.Location = new System.Drawing.Point(1349, 501);
            this.btnBackFromChild.Name = "btnBackFromChild";
            this.btnBackFromChild.Size = new System.Drawing.Size(75, 23);
            this.btnBackFromChild.TabIndex = 4;
            this.btnBackFromChild.Text = "Back";
            this.btnBackFromChild.UseVisualStyleBackColor = true;
            this.btnBackFromChild.Click += new System.EventHandler(this.btnBackFromChild_Click);
            // 
            // lblCurrentButtonID
            // 
            this.lblCurrentButtonID.AutoSize = true;
            this.lblCurrentButtonID.Location = new System.Drawing.Point(1350, 462);
            this.lblCurrentButtonID.Name = "lblCurrentButtonID";
            this.lblCurrentButtonID.Size = new System.Drawing.Size(96, 17);
            this.lblCurrentButtonID.TabIndex = 5;
            this.lblCurrentButtonID.Text = "CurrentButton";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxDeleteEnabled);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1343, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 45);
            this.panel1.TabIndex = 6;
            // 
            // checkBoxDeleteEnabled
            // 
            this.checkBoxDeleteEnabled.AutoSize = true;
            this.checkBoxDeleteEnabled.Enabled = false;
            this.checkBoxDeleteEnabled.Location = new System.Drawing.Point(147, 13);
            this.checkBoxDeleteEnabled.Name = "checkBoxDeleteEnabled";
            this.checkBoxDeleteEnabled.Size = new System.Drawing.Size(126, 21);
            this.checkBoxDeleteEnabled.TabIndex = 1;
            this.checkBoxDeleteEnabled.Text = "Delete enabled";
            this.checkBoxDeleteEnabled.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 32);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1736, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCurrentButtonID);
            this.Controls.Add(this.btnBackFromChild);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelDragControl);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelGUI);
            this.Name = "GUI";
            this.Text = "GUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelDragControl.ResumeLayout(false);
            this.panelDragControl.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGUI;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox tBoxSearchValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchProperty;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panelDragControl;
        private System.Windows.Forms.CheckBox checkBoxDragEnabled;
        private System.Windows.Forms.Button btnAllowDrag;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.TextBox tBoxAddName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbAddType;
        private System.Windows.Forms.Button btnBackFromChild;
        private System.Windows.Forms.Label lblCurrentButtonID;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFoundProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxDeleteEnabled;
        private System.Windows.Forms.Button btnDelete;
    }
}