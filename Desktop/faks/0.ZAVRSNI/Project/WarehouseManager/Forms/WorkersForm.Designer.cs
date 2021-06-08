namespace WarehouseManager.Forms
{
    partial class WorkersForm
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
            this.btnAddWorker_tab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlWorkers = new System.Windows.Forms.TabControl();
            this.tabPageAddWorker = new System.Windows.Forms.TabPage();
            this.dtp_addWorker = new System.Windows.Forms.DateTimePicker();
            this.btn_addWorkere_complete = new System.Windows.Forms.Button();
            this.cmb_addWorker_warehouse = new System.Windows.Forms.ComboBox();
            this.cmb_addWorker_position = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_addWorker_city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox_addWorker_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_addWorker_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_addWorker_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_addWorker_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEditWorker = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlWorkers.SuspendLayout();
            this.tabPageAddWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditWorker);
            this.panel1.Controls.Add(this.btnAddWorker_tab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 841);
            this.panel1.TabIndex = 0;
            // 
            // btnAddWorker_tab
            // 
            this.btnAddWorker_tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddWorker_tab.Location = new System.Drawing.Point(0, 0);
            this.btnAddWorker_tab.Name = "btnAddWorker_tab";
            this.btnAddWorker_tab.Size = new System.Drawing.Size(157, 50);
            this.btnAddWorker_tab.TabIndex = 2;
            this.btnAddWorker_tab.Text = "Add worker";
            this.btnAddWorker_tab.UseVisualStyleBackColor = true;
            this.btnAddWorker_tab.Click += new System.EventHandler(this.btnAddWorker_tab_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControlWorkers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(157, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1673, 841);
            this.panel2.TabIndex = 1;
            // 
            // tabControlWorkers
            // 
            this.tabControlWorkers.Controls.Add(this.tabPageAddWorker);
            this.tabControlWorkers.Controls.Add(this.tabPage2);
            this.tabControlWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWorkers.Location = new System.Drawing.Point(0, 0);
            this.tabControlWorkers.Name = "tabControlWorkers";
            this.tabControlWorkers.SelectedIndex = 0;
            this.tabControlWorkers.Size = new System.Drawing.Size(1673, 841);
            this.tabControlWorkers.TabIndex = 0;
            // 
            // tabPageAddWorker
            // 
            this.tabPageAddWorker.Controls.Add(this.btnSearch);
            this.tabPageAddWorker.Controls.Add(this.dtp_addWorker);
            this.tabPageAddWorker.Controls.Add(this.btn_addWorkere_complete);
            this.tabPageAddWorker.Controls.Add(this.cmb_addWorker_warehouse);
            this.tabPageAddWorker.Controls.Add(this.cmb_addWorker_position);
            this.tabPageAddWorker.Controls.Add(this.label5);
            this.tabPageAddWorker.Controls.Add(this.label6);
            this.tabPageAddWorker.Controls.Add(this.tbox_addWorker_city);
            this.tabPageAddWorker.Controls.Add(this.label7);
            this.tabPageAddWorker.Controls.Add(this.label8);
            this.tabPageAddWorker.Controls.Add(this.tbox_addWorker_username);
            this.tabPageAddWorker.Controls.Add(this.label4);
            this.tabPageAddWorker.Controls.Add(this.tbox_addWorker_surname);
            this.tabPageAddWorker.Controls.Add(this.label3);
            this.tabPageAddWorker.Controls.Add(this.tbox_addWorker_name);
            this.tabPageAddWorker.Controls.Add(this.label2);
            this.tabPageAddWorker.Controls.Add(this.tbox_addWorker_id);
            this.tabPageAddWorker.Controls.Add(this.label1);
            this.tabPageAddWorker.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddWorker.Name = "tabPageAddWorker";
            this.tabPageAddWorker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddWorker.Size = new System.Drawing.Size(1665, 812);
            this.tabPageAddWorker.TabIndex = 0;
            this.tabPageAddWorker.Text = "Add worker";
            this.tabPageAddWorker.UseVisualStyleBackColor = true;
            // 
            // dtp_addWorker
            // 
            this.dtp_addWorker.Location = new System.Drawing.Point(117, 141);
            this.dtp_addWorker.Name = "dtp_addWorker";
            this.dtp_addWorker.Size = new System.Drawing.Size(330, 22);
            this.dtp_addWorker.TabIndex = 34;
            // 
            // btn_addWorkere_complete
            // 
            this.btn_addWorkere_complete.Location = new System.Drawing.Point(376, 280);
            this.btn_addWorkere_complete.Name = "btn_addWorkere_complete";
            this.btn_addWorkere_complete.Size = new System.Drawing.Size(100, 50);
            this.btn_addWorkere_complete.TabIndex = 33;
            this.btn_addWorkere_complete.Text = "Complete";
            this.btn_addWorkere_complete.UseVisualStyleBackColor = true;
            this.btn_addWorkere_complete.Click += new System.EventHandler(this.btn_addWorkere_complete_Click);
            // 
            // cmb_addWorker_warehouse
            // 
            this.cmb_addWorker_warehouse.FormattingEnabled = true;
            this.cmb_addWorker_warehouse.Location = new System.Drawing.Point(117, 226);
            this.cmb_addWorker_warehouse.Name = "cmb_addWorker_warehouse";
            this.cmb_addWorker_warehouse.Size = new System.Drawing.Size(334, 24);
            this.cmb_addWorker_warehouse.TabIndex = 32;
            // 
            // cmb_addWorker_position
            // 
            this.cmb_addWorker_position.FormattingEnabled = true;
            this.cmb_addWorker_position.Location = new System.Drawing.Point(117, 196);
            this.cmb_addWorker_position.Name = "cmb_addWorker_position";
            this.cmb_addWorker_position.Size = new System.Drawing.Size(334, 24);
            this.cmb_addWorker_position.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Warehouse:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Position:";
            // 
            // tbox_addWorker_city
            // 
            this.tbox_addWorker_city.Location = new System.Drawing.Point(117, 168);
            this.tbox_addWorker_city.Name = "tbox_addWorker_city";
            this.tbox_addWorker_city.Size = new System.Drawing.Size(334, 22);
            this.tbox_addWorker_city.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "City: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Date of birth:";
            // 
            // tbox_addWorker_username
            // 
            this.tbox_addWorker_username.Location = new System.Drawing.Point(117, 113);
            this.tbox_addWorker_username.Name = "tbox_addWorker_username";
            this.tbox_addWorker_username.Size = new System.Drawing.Size(334, 22);
            this.tbox_addWorker_username.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Username:";
            // 
            // tbox_addWorker_surname
            // 
            this.tbox_addWorker_surname.Location = new System.Drawing.Point(117, 85);
            this.tbox_addWorker_surname.Name = "tbox_addWorker_surname";
            this.tbox_addWorker_surname.Size = new System.Drawing.Size(334, 22);
            this.tbox_addWorker_surname.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Surname: ";
            // 
            // tbox_addWorker_name
            // 
            this.tbox_addWorker_name.Location = new System.Drawing.Point(117, 57);
            this.tbox_addWorker_name.Name = "tbox_addWorker_name";
            this.tbox_addWorker_name.Size = new System.Drawing.Size(334, 22);
            this.tbox_addWorker_name.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            // 
            // tbox_addWorker_id
            // 
            this.tbox_addWorker_id.Enabled = false;
            this.tbox_addWorker_id.Location = new System.Drawing.Point(117, 29);
            this.tbox_addWorker_id.Name = "tbox_addWorker_id";
            this.tbox_addWorker_id.Size = new System.Drawing.Size(108, 22);
            this.tbox_addWorker_id.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1665, 812);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditWorker
            // 
            this.btnEditWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditWorker.Location = new System.Drawing.Point(0, 50);
            this.btnEditWorker.Name = "btnEditWorker";
            this.btnEditWorker.Size = new System.Drawing.Size(157, 50);
            this.btnEditWorker.TabIndex = 3;
            this.btnEditWorker.Text = "Edit Worker";
            this.btnEditWorker.UseVisualStyleBackColor = true;
            this.btnEditWorker.Click += new System.EventHandler(this.btnEditWorker_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(27, 280);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 50);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 841);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WorkersForm";
            this.Text = "WorkersForm";
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControlWorkers.ResumeLayout(false);
            this.tabPageAddWorker.ResumeLayout(false);
            this.tabPageAddWorker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddWorker_tab;
        private System.Windows.Forms.TabControl tabControlWorkers;
        private System.Windows.Forms.TabPage tabPageAddWorker;
        private System.Windows.Forms.ComboBox cmb_addWorker_warehouse;
        private System.Windows.Forms.ComboBox cmb_addWorker_position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_addWorker_city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbox_addWorker_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_addWorker_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_addWorker_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_addWorker_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_addWorkere_complete;
        private System.Windows.Forms.DateTimePicker dtp_addWorker;
        private System.Windows.Forms.Button btnEditWorker;
        private System.Windows.Forms.Button btnSearch;
    }
}