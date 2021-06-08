namespace WarehouseManager.Forms
{
    partial class PropertiesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDistanceUnit = new System.Windows.Forms.ComboBox();
            this.cmbWeightUnit = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight unit:";
            // 
            // cmbDistanceUnit
            // 
            this.cmbDistanceUnit.FormattingEnabled = true;
            this.cmbDistanceUnit.Location = new System.Drawing.Point(112, 9);
            this.cmbDistanceUnit.Name = "cmbDistanceUnit";
            this.cmbDistanceUnit.Size = new System.Drawing.Size(149, 24);
            this.cmbDistanceUnit.TabIndex = 2;
            this.cmbDistanceUnit.TextChanged += new System.EventHandler(this.cmbDistanceUnit_TextChanged);
            // 
            // cmbWeightUnit
            // 
            this.cmbWeightUnit.FormattingEnabled = true;
            this.cmbWeightUnit.Location = new System.Drawing.Point(112, 49);
            this.cmbWeightUnit.Name = "cmbWeightUnit";
            this.cmbWeightUnit.Size = new System.Drawing.Size(149, 24);
            this.cmbWeightUnit.TabIndex = 3;
            this.cmbWeightUnit.TextChanged += new System.EventHandler(this.cmbWeightUnit_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(678, 400);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbWeightUnit);
            this.Controls.Add(this.cmbDistanceUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PropertiesForm";
            this.Text = "PropertiesForm";
            this.Load += new System.EventHandler(this.PropertiesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDistanceUnit;
        private System.Windows.Forms.ComboBox cmbWeightUnit;
        private System.Windows.Forms.Button btnOk;
    }
}