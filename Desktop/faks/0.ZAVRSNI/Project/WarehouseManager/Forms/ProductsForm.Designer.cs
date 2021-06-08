namespace WarehouseManager.Forms
{
    partial class ProductsForm
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnReturnToSupplier = new System.Windows.Forms.Button();
            this.btnWriteOff = new System.Windows.Forms.Button();
            this.btnIntermediate = new System.Windows.Forms.Button();
            this.btnReceiving = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tabPageDocuments = new System.Windows.Forms.TabPage();
            this.btn_document_complete = new System.Windows.Forms.Button();
            this.panelReceiving = new System.Windows.Forms.Panel();
            this.dgv_receiving = new System.Windows.Forms.DataGridView();
            this.tBox_Receiving_Price = new System.Windows.Forms.TextBox();
            this.lblReceivingPrice = new System.Windows.Forms.Label();
            this.tBox_Receiving_Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_Receiving_PName = new System.Windows.Forms.TextBox();
            this.lblReceivingProductName = new System.Windows.Forms.Label();
            this.btnReceivingSearch = new System.Windows.Forms.Button();
            this.tbox_document_amount = new System.Windows.Forms.TextBox();
            this.lblReceivingID = new System.Windows.Forms.Label();
            this.cmb_document_option2 = new System.Windows.Forms.ComboBox();
            this.cmb_document_option1 = new System.Windows.Forms.ComboBox();
            this.lbl_document_option2 = new System.Windows.Forms.Label();
            this.lbl_document_option1 = new System.Windows.Forms.Label();
            this.lblReceivingRemark = new System.Windows.Forms.Label();
            this.lblDocumentDate = new System.Windows.Forms.Label();
            this.rtb_document_remark = new System.Windows.Forms.RichTextBox();
            this.tbox_document_name = new System.Windows.Forms.TextBox();
            this.dtp_document_date = new System.Windows.Forms.DateTimePicker();
            this.lblDocumentName = new System.Windows.Forms.Label();
            this.AddProductTab = new System.Windows.Forms.TabPage();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.btnSaveProducts = new System.Windows.Forms.Button();
            this.lblAddBarcode = new System.Windows.Forms.Label();
            this.tBoxBarcode = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tBoxAddSizeZ = new System.Windows.Forms.TextBox();
            this.tBoxAddSizeY = new System.Windows.Forms.TextBox();
            this.tBoxAddSizeX = new System.Windows.Forms.TextBox();
            this.tBoxAmount = new System.Windows.Forms.TextBox();
            this.tBoxWeight = new System.Windows.Forms.TextBox();
            this.tBoxSellPrice = new System.Windows.Forms.TextBox();
            this.tBoxPurchasePrice = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxAddID = new System.Windows.Forms.TextBox();
            this.checkBoxShipmentEmpty = new System.Windows.Forms.CheckBox();
            this.dtpDateOfShipment = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfShipment = new System.Windows.Forms.Label();
            this.btnAddProductTab = new System.Windows.Forms.Button();
            this.dtpDateOfArival = new System.Windows.Forms.DateTimePicker();
            this.lblz = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDateOfArival = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblPP = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tabControlProducts = new System.Windows.Forms.TabControl();
            this.panelButtons.SuspendLayout();
            this.tabPageDocuments.SuspendLayout();
            this.panelReceiving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receiving)).BeginInit();
            this.AddProductTab.SuspendLayout();
            this.tabControlProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnEditProduct);
            this.panelButtons.Controls.Add(this.btnReturnToSupplier);
            this.panelButtons.Controls.Add(this.btnWriteOff);
            this.panelButtons.Controls.Add(this.btnIntermediate);
            this.panelButtons.Controls.Add(this.btnReceiving);
            this.panelButtons.Controls.Add(this.btnAddProduct);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(157, 663);
            this.panelButtons.TabIndex = 0;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(3, 59);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(150, 50);
            this.btnEditProduct.TabIndex = 6;
            this.btnEditProduct.Text = "Edit products";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnReturnToSupplier
            // 
            this.btnReturnToSupplier.Location = new System.Drawing.Point(3, 283);
            this.btnReturnToSupplier.Name = "btnReturnToSupplier";
            this.btnReturnToSupplier.Size = new System.Drawing.Size(150, 50);
            this.btnReturnToSupplier.TabIndex = 4;
            this.btnReturnToSupplier.Text = "Return to supplier";
            this.btnReturnToSupplier.UseVisualStyleBackColor = true;
            this.btnReturnToSupplier.Click += new System.EventHandler(this.btnReturnToSupplier_Click);
            // 
            // btnWriteOff
            // 
            this.btnWriteOff.Location = new System.Drawing.Point(3, 227);
            this.btnWriteOff.Name = "btnWriteOff";
            this.btnWriteOff.Size = new System.Drawing.Size(150, 50);
            this.btnWriteOff.TabIndex = 3;
            this.btnWriteOff.Text = "Write-off";
            this.btnWriteOff.UseVisualStyleBackColor = true;
            this.btnWriteOff.Click += new System.EventHandler(this.btnWriteOff_Click);
            // 
            // btnIntermediate
            // 
            this.btnIntermediate.Location = new System.Drawing.Point(4, 171);
            this.btnIntermediate.Name = "btnIntermediate";
            this.btnIntermediate.Size = new System.Drawing.Size(150, 50);
            this.btnIntermediate.TabIndex = 2;
            this.btnIntermediate.Text = "Intermediate warehouse";
            this.btnIntermediate.UseVisualStyleBackColor = true;
            this.btnIntermediate.Click += new System.EventHandler(this.btnIntermediate_Click);
            // 
            // btnReceiving
            // 
            this.btnReceiving.Location = new System.Drawing.Point(3, 115);
            this.btnReceiving.Name = "btnReceiving";
            this.btnReceiving.Size = new System.Drawing.Size(150, 50);
            this.btnReceiving.TabIndex = 1;
            this.btnReceiving.Text = "Receiving";
            this.btnReceiving.UseVisualStyleBackColor = true;
            this.btnReceiving.Click += new System.EventHandler(this.btnReceiving_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 50);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tabPageDocuments
            // 
            this.tabPageDocuments.Controls.Add(this.btn_document_complete);
            this.tabPageDocuments.Controls.Add(this.panelReceiving);
            this.tabPageDocuments.Controls.Add(this.cmb_document_option2);
            this.tabPageDocuments.Controls.Add(this.cmb_document_option1);
            this.tabPageDocuments.Controls.Add(this.lbl_document_option2);
            this.tabPageDocuments.Controls.Add(this.lbl_document_option1);
            this.tabPageDocuments.Controls.Add(this.lblReceivingRemark);
            this.tabPageDocuments.Controls.Add(this.lblDocumentDate);
            this.tabPageDocuments.Controls.Add(this.rtb_document_remark);
            this.tabPageDocuments.Controls.Add(this.tbox_document_name);
            this.tabPageDocuments.Controls.Add(this.dtp_document_date);
            this.tabPageDocuments.Controls.Add(this.lblDocumentName);
            this.tabPageDocuments.Location = new System.Drawing.Point(4, 25);
            this.tabPageDocuments.Name = "tabPageDocuments";
            this.tabPageDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocuments.Size = new System.Drawing.Size(1295, 634);
            this.tabPageDocuments.TabIndex = 1;
            this.tabPageDocuments.Text = "Documents";
            this.tabPageDocuments.UseVisualStyleBackColor = true;
            // 
            // btn_document_complete
            // 
            this.btn_document_complete.Location = new System.Drawing.Point(1160, 172);
            this.btn_document_complete.Name = "btn_document_complete";
            this.btn_document_complete.Size = new System.Drawing.Size(100, 50);
            this.btn_document_complete.TabIndex = 12;
            this.btn_document_complete.Text = "Complete";
            this.btn_document_complete.UseVisualStyleBackColor = true;
            this.btn_document_complete.Click += new System.EventHandler(this.btnCompleteDocument_Click);
            // 
            // panelReceiving
            // 
            this.panelReceiving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReceiving.Controls.Add(this.dgv_receiving);
            this.panelReceiving.Controls.Add(this.tBox_Receiving_Price);
            this.panelReceiving.Controls.Add(this.lblReceivingPrice);
            this.panelReceiving.Controls.Add(this.tBox_Receiving_Amount);
            this.panelReceiving.Controls.Add(this.label2);
            this.panelReceiving.Controls.Add(this.tBox_Receiving_PName);
            this.panelReceiving.Controls.Add(this.lblReceivingProductName);
            this.panelReceiving.Controls.Add(this.btnReceivingSearch);
            this.panelReceiving.Controls.Add(this.tbox_document_amount);
            this.panelReceiving.Controls.Add(this.lblReceivingID);
            this.panelReceiving.Location = new System.Drawing.Point(21, 247);
            this.panelReceiving.Name = "panelReceiving";
            this.panelReceiving.Size = new System.Drawing.Size(1248, 379);
            this.panelReceiving.TabIndex = 11;
            // 
            // dgv_receiving
            // 
            this.dgv_receiving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_receiving.Location = new System.Drawing.Point(6, 66);
            this.dgv_receiving.Name = "dgv_receiving";
            this.dgv_receiving.RowHeadersWidth = 51;
            this.dgv_receiving.RowTemplate.Height = 24;
            this.dgv_receiving.Size = new System.Drawing.Size(1232, 308);
            this.dgv_receiving.TabIndex = 9;
            this.dgv_receiving.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_receiving_CellMouseClick);
            // 
            // tBox_Receiving_Price
            // 
            this.tBox_Receiving_Price.Enabled = false;
            this.tBox_Receiving_Price.Location = new System.Drawing.Point(537, 24);
            this.tBox_Receiving_Price.Name = "tBox_Receiving_Price";
            this.tBox_Receiving_Price.Size = new System.Drawing.Size(100, 22);
            this.tBox_Receiving_Price.TabIndex = 8;
            // 
            // lblReceivingPrice
            // 
            this.lblReceivingPrice.AutoSize = true;
            this.lblReceivingPrice.Location = new System.Drawing.Point(534, 3);
            this.lblReceivingPrice.Name = "lblReceivingPrice";
            this.lblReceivingPrice.Size = new System.Drawing.Size(40, 17);
            this.lblReceivingPrice.TabIndex = 7;
            this.lblReceivingPrice.Text = "Price";
            // 
            // tBox_Receiving_Amount
            // 
            this.tBox_Receiving_Amount.Enabled = false;
            this.tBox_Receiving_Amount.Location = new System.Drawing.Point(357, 25);
            this.tBox_Receiving_Amount.Name = "tBox_Receiving_Amount";
            this.tBox_Receiving_Amount.Size = new System.Drawing.Size(129, 22);
            this.tBox_Receiving_Amount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount avalible";
            // 
            // tBox_Receiving_PName
            // 
            this.tBox_Receiving_PName.Enabled = false;
            this.tBox_Receiving_PName.Location = new System.Drawing.Point(104, 25);
            this.tBox_Receiving_PName.Name = "tBox_Receiving_PName";
            this.tBox_Receiving_PName.Size = new System.Drawing.Size(218, 22);
            this.tBox_Receiving_PName.TabIndex = 4;
            // 
            // lblReceivingProductName
            // 
            this.lblReceivingProductName.AutoSize = true;
            this.lblReceivingProductName.Location = new System.Drawing.Point(101, 4);
            this.lblReceivingProductName.Name = "lblReceivingProductName";
            this.lblReceivingProductName.Size = new System.Drawing.Size(98, 17);
            this.lblReceivingProductName.TabIndex = 3;
            this.lblReceivingProductName.Text = "Product Name";
            // 
            // btnReceivingSearch
            // 
            this.btnReceivingSearch.Location = new System.Drawing.Point(6, 24);
            this.btnReceivingSearch.Name = "btnReceivingSearch";
            this.btnReceivingSearch.Size = new System.Drawing.Size(73, 23);
            this.btnReceivingSearch.TabIndex = 2;
            this.btnReceivingSearch.Text = "Search";
            this.btnReceivingSearch.UseVisualStyleBackColor = true;
            this.btnReceivingSearch.Click += new System.EventHandler(this.btnDocumentProductSearch_Click);
            // 
            // tbox_document_amount
            // 
            this.tbox_document_amount.Location = new System.Drawing.Point(673, 25);
            this.tbox_document_amount.Name = "tbox_document_amount";
            this.tbox_document_amount.Size = new System.Drawing.Size(154, 22);
            this.tbox_document_amount.TabIndex = 1;
            // 
            // lblReceivingID
            // 
            this.lblReceivingID.AutoSize = true;
            this.lblReceivingID.Location = new System.Drawing.Point(670, 4);
            this.lblReceivingID.Name = "lblReceivingID";
            this.lblReceivingID.Size = new System.Drawing.Size(56, 17);
            this.lblReceivingID.TabIndex = 0;
            this.lblReceivingID.Text = "Amount";
            // 
            // cmb_document_option2
            // 
            this.cmb_document_option2.FormattingEnabled = true;
            this.cmb_document_option2.Location = new System.Drawing.Point(653, 79);
            this.cmb_document_option2.Name = "cmb_document_option2";
            this.cmb_document_option2.Size = new System.Drawing.Size(582, 24);
            this.cmb_document_option2.TabIndex = 10;
            // 
            // cmb_document_option1
            // 
            this.cmb_document_option1.FormattingEnabled = true;
            this.cmb_document_option1.Location = new System.Drawing.Point(653, 34);
            this.cmb_document_option1.Name = "cmb_document_option1";
            this.cmb_document_option1.Size = new System.Drawing.Size(582, 24);
            this.cmb_document_option1.TabIndex = 9;
            // 
            // lbl_document_option2
            // 
            this.lbl_document_option2.AutoSize = true;
            this.lbl_document_option2.Location = new System.Drawing.Point(486, 82);
            this.lbl_document_option2.Name = "lbl_document_option2";
            this.lbl_document_option2.Size = new System.Drawing.Size(95, 17);
            this.lbl_document_option2.TabIndex = 8;
            this.lbl_document_option2.Text = "Transporeter:";
            // 
            // lbl_document_option1
            // 
            this.lbl_document_option1.AutoSize = true;
            this.lbl_document_option1.Location = new System.Drawing.Point(486, 37);
            this.lbl_document_option1.Name = "lbl_document_option1";
            this.lbl_document_option1.Size = new System.Drawing.Size(64, 17);
            this.lbl_document_option1.TabIndex = 7;
            this.lbl_document_option1.Text = "Supplier:";
            // 
            // lblReceivingRemark
            // 
            this.lblReceivingRemark.AutoSize = true;
            this.lblReceivingRemark.Location = new System.Drawing.Point(54, 146);
            this.lblReceivingRemark.Name = "lblReceivingRemark";
            this.lblReceivingRemark.Size = new System.Drawing.Size(61, 17);
            this.lblReceivingRemark.TabIndex = 6;
            this.lblReceivingRemark.Text = "Remark:";
            // 
            // lblDocumentDate
            // 
            this.lblDocumentDate.AutoSize = true;
            this.lblDocumentDate.Location = new System.Drawing.Point(18, 84);
            this.lblDocumentDate.Name = "lblDocumentDate";
            this.lblDocumentDate.Size = new System.Drawing.Size(108, 17);
            this.lblDocumentDate.TabIndex = 5;
            this.lblDocumentDate.Text = "Document date:";
            // 
            // rtb_document_remark
            // 
            this.rtb_document_remark.Location = new System.Drawing.Point(160, 130);
            this.rtb_document_remark.Name = "rtb_document_remark";
            this.rtb_document_remark.Size = new System.Drawing.Size(690, 82);
            this.rtb_document_remark.TabIndex = 4;
            this.rtb_document_remark.Text = "";
            // 
            // tbox_document_name
            // 
            this.tbox_document_name.Location = new System.Drawing.Point(160, 34);
            this.tbox_document_name.Name = "tbox_document_name";
            this.tbox_document_name.Size = new System.Drawing.Size(200, 22);
            this.tbox_document_name.TabIndex = 0;
            // 
            // dtp_document_date
            // 
            this.dtp_document_date.Location = new System.Drawing.Point(160, 79);
            this.dtp_document_date.Name = "dtp_document_date";
            this.dtp_document_date.Size = new System.Drawing.Size(200, 22);
            this.dtp_document_date.TabIndex = 2;
            // 
            // lblDocumentName
            // 
            this.lblDocumentName.AutoSize = true;
            this.lblDocumentName.Location = new System.Drawing.Point(18, 34);
            this.lblDocumentName.Name = "lblDocumentName";
            this.lblDocumentName.Size = new System.Drawing.Size(123, 17);
            this.lblDocumentName.TabIndex = 1;
            this.lblDocumentName.Text = "Doucument name:";
            // 
            // AddProductTab
            // 
            this.AddProductTab.Controls.Add(this.lblWeightUnit);
            this.AddProductTab.Controls.Add(this.btnClearForm);
            this.AddProductTab.Controls.Add(this.btnSearchProducts);
            this.AddProductTab.Controls.Add(this.btnSaveProducts);
            this.AddProductTab.Controls.Add(this.lblAddBarcode);
            this.AddProductTab.Controls.Add(this.tBoxBarcode);
            this.AddProductTab.Controls.Add(this.rtbDescription);
            this.AddProductTab.Controls.Add(this.tBoxAddSizeZ);
            this.AddProductTab.Controls.Add(this.tBoxAddSizeY);
            this.AddProductTab.Controls.Add(this.tBoxAddSizeX);
            this.AddProductTab.Controls.Add(this.tBoxAmount);
            this.AddProductTab.Controls.Add(this.tBoxWeight);
            this.AddProductTab.Controls.Add(this.tBoxSellPrice);
            this.AddProductTab.Controls.Add(this.tBoxPurchasePrice);
            this.AddProductTab.Controls.Add(this.tBoxName);
            this.AddProductTab.Controls.Add(this.tBoxAddID);
            this.AddProductTab.Controls.Add(this.checkBoxShipmentEmpty);
            this.AddProductTab.Controls.Add(this.dtpDateOfShipment);
            this.AddProductTab.Controls.Add(this.lblDateOfShipment);
            this.AddProductTab.Controls.Add(this.btnAddProductTab);
            this.AddProductTab.Controls.Add(this.dtpDateOfArival);
            this.AddProductTab.Controls.Add(this.lblz);
            this.AddProductTab.Controls.Add(this.lbly);
            this.AddProductTab.Controls.Add(this.lblx);
            this.AddProductTab.Controls.Add(this.lblAmount);
            this.AddProductTab.Controls.Add(this.lblDateOfArival);
            this.AddProductTab.Controls.Add(this.lblWeight);
            this.AddProductTab.Controls.Add(this.lblSize);
            this.AddProductTab.Controls.Add(this.lblSP);
            this.AddProductTab.Controls.Add(this.lblPP);
            this.AddProductTab.Controls.Add(this.lblDescription);
            this.AddProductTab.Controls.Add(this.lblName);
            this.AddProductTab.Controls.Add(this.lblID);
            this.AddProductTab.Location = new System.Drawing.Point(4, 25);
            this.AddProductTab.Name = "AddProductTab";
            this.AddProductTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddProductTab.Size = new System.Drawing.Size(1295, 634);
            this.AddProductTab.TabIndex = 0;
            this.AddProductTab.Text = "AddProduct";
            this.AddProductTab.UseVisualStyleBackColor = true;
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Location = new System.Drawing.Point(747, 191);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(0, 17);
            this.lblWeightUnit.TabIndex = 64;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(173, 524);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(100, 50);
            this.btnClearForm.TabIndex = 63;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnProductClearForm_Click);
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Location = new System.Drawing.Point(21, 524);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(100, 50);
            this.btnSearchProducts.TabIndex = 62;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            this.btnSearchProducts.Click += new System.EventHandler(this.btnEditSearch_Click);
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.Location = new System.Drawing.Point(965, 524);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Size = new System.Drawing.Size(100, 50);
            this.btnSaveProducts.TabIndex = 61;
            this.btnSaveProducts.Text = "Save";
            this.btnSaveProducts.UseVisualStyleBackColor = true;
            this.btnSaveProducts.Click += new System.EventHandler(this.btnSaveProducts_Click);
            // 
            // lblAddBarcode
            // 
            this.lblAddBarcode.AutoSize = true;
            this.lblAddBarcode.Location = new System.Drawing.Point(156, 28);
            this.lblAddBarcode.Name = "lblAddBarcode";
            this.lblAddBarcode.Size = new System.Drawing.Size(65, 17);
            this.lblAddBarcode.TabIndex = 31;
            this.lblAddBarcode.Text = "Barcode:";
            // 
            // tBoxBarcode
            // 
            this.tBoxBarcode.Location = new System.Drawing.Point(227, 25);
            this.tBoxBarcode.MaxLength = 12;
            this.tBoxBarcode.Name = "tBoxBarcode";
            this.tBoxBarcode.Size = new System.Drawing.Size(149, 22);
            this.tBoxBarcode.TabIndex = 30;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(20, 278);
            this.rtbDescription.MaxLength = 255;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(912, 225);
            this.rtbDescription.TabIndex = 25;
            this.rtbDescription.Text = "";
            // 
            // tBoxAddSizeZ
            // 
            this.tBoxAddSizeZ.Location = new System.Drawing.Point(799, 233);
            this.tBoxAddSizeZ.Name = "tBoxAddSizeZ";
            this.tBoxAddSizeZ.Size = new System.Drawing.Size(64, 22);
            this.tBoxAddSizeZ.TabIndex = 22;
            // 
            // tBoxAddSizeY
            // 
            this.tBoxAddSizeY.Location = new System.Drawing.Point(696, 234);
            this.tBoxAddSizeY.Name = "tBoxAddSizeY";
            this.tBoxAddSizeY.Size = new System.Drawing.Size(64, 22);
            this.tBoxAddSizeY.TabIndex = 20;
            // 
            // tBoxAddSizeX
            // 
            this.tBoxAddSizeX.Location = new System.Drawing.Point(595, 233);
            this.tBoxAddSizeX.Name = "tBoxAddSizeX";
            this.tBoxAddSizeX.Size = new System.Drawing.Size(65, 22);
            this.tBoxAddSizeX.TabIndex = 18;
            this.tBoxAddSizeX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxNumberOnly);
            // 
            // tBoxAmount
            // 
            this.tBoxAmount.Location = new System.Drawing.Point(574, 143);
            this.tBoxAmount.Name = "tBoxAmount";
            this.tBoxAmount.Size = new System.Drawing.Size(166, 22);
            this.tBoxAmount.TabIndex = 17;
            this.tBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxNumberOnly);
            // 
            // tBoxWeight
            // 
            this.tBoxWeight.Location = new System.Drawing.Point(574, 188);
            this.tBoxWeight.Name = "tBoxWeight";
            this.tBoxWeight.Size = new System.Drawing.Size(166, 22);
            this.tBoxWeight.TabIndex = 13;
            this.tBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxNumberOnly);
            // 
            // tBoxSellPrice
            // 
            this.tBoxSellPrice.Location = new System.Drawing.Point(574, 89);
            this.tBoxSellPrice.Name = "tBoxSellPrice";
            this.tBoxSellPrice.Size = new System.Drawing.Size(166, 22);
            this.tBoxSellPrice.TabIndex = 9;
            this.tBoxSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxNumberOnly);
            // 
            // tBoxPurchasePrice
            // 
            this.tBoxPurchasePrice.Location = new System.Drawing.Point(574, 44);
            this.tBoxPurchasePrice.Name = "tBoxPurchasePrice";
            this.tBoxPurchasePrice.Size = new System.Drawing.Size(166, 22);
            this.tBoxPurchasePrice.TabIndex = 7;
            this.tBoxPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxNumberOnly);
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(20, 87);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(522, 22);
            this.tBoxName.TabIndex = 3;
            // 
            // tBoxAddID
            // 
            this.tBoxAddID.Enabled = false;
            this.tBoxAddID.Location = new System.Drawing.Point(49, 24);
            this.tBoxAddID.Name = "tBoxAddID";
            this.tBoxAddID.Size = new System.Drawing.Size(100, 22);
            this.tBoxAddID.TabIndex = 1;
            // 
            // checkBoxShipmentEmpty
            // 
            this.checkBoxShipmentEmpty.AutoSize = true;
            this.checkBoxShipmentEmpty.Location = new System.Drawing.Point(265, 202);
            this.checkBoxShipmentEmpty.Name = "checkBoxShipmentEmpty";
            this.checkBoxShipmentEmpty.Size = new System.Drawing.Size(111, 21);
            this.checkBoxShipmentEmpty.TabIndex = 29;
            this.checkBoxShipmentEmpty.Text = "Leave empty";
            this.checkBoxShipmentEmpty.UseVisualStyleBackColor = true;
            this.checkBoxShipmentEmpty.CheckedChanged += new System.EventHandler(this.checkBoxShipmentEmpty_CheckedChanged);
            // 
            // dtpDateOfShipment
            // 
            this.dtpDateOfShipment.Location = new System.Drawing.Point(20, 199);
            this.dtpDateOfShipment.Name = "dtpDateOfShipment";
            this.dtpDateOfShipment.Size = new System.Drawing.Size(239, 22);
            this.dtpDateOfShipment.TabIndex = 28;
            // 
            // lblDateOfShipment
            // 
            this.lblDateOfShipment.AutoSize = true;
            this.lblDateOfShipment.Location = new System.Drawing.Point(18, 179);
            this.lblDateOfShipment.Name = "lblDateOfShipment";
            this.lblDateOfShipment.Size = new System.Drawing.Size(115, 17);
            this.lblDateOfShipment.TabIndex = 27;
            this.lblDateOfShipment.Text = "Date of shipment";
            // 
            // btnAddProductTab
            // 
            this.btnAddProductTab.Location = new System.Drawing.Point(965, 468);
            this.btnAddProductTab.Name = "btnAddProductTab";
            this.btnAddProductTab.Size = new System.Drawing.Size(100, 50);
            this.btnAddProductTab.TabIndex = 26;
            this.btnAddProductTab.Text = "Add";
            this.btnAddProductTab.UseVisualStyleBackColor = true;
            this.btnAddProductTab.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDateOfArival
            // 
            this.dtpDateOfArival.Location = new System.Drawing.Point(20, 143);
            this.dtpDateOfArival.Name = "dtpDateOfArival";
            this.dtpDateOfArival.Size = new System.Drawing.Size(239, 22);
            this.dtpDateOfArival.TabIndex = 24;
            // 
            // lblz
            // 
            this.lblz.AutoSize = true;
            this.lblz.Location = new System.Drawing.Point(766, 236);
            this.lblz.Name = "lblz";
            this.lblz.Size = new System.Drawing.Size(27, 17);
            this.lblz.TabIndex = 23;
            this.lblz.Text = ", z:";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(666, 236);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(27, 17);
            this.lbly.TabIndex = 21;
            this.lbly.Text = ", y:";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(571, 236);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(18, 17);
            this.lblx.TabIndex = 19;
            this.lblx.Text = "x:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(571, 123);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Amount";
            // 
            // lblDateOfArival
            // 
            this.lblDateOfArival.AutoSize = true;
            this.lblDateOfArival.Location = new System.Drawing.Point(18, 123);
            this.lblDateOfArival.Name = "lblDateOfArival";
            this.lblDateOfArival.Size = new System.Drawing.Size(92, 17);
            this.lblDateOfArival.TabIndex = 14;
            this.lblDateOfArival.Text = "Date of arival";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(571, 168);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(56, 17);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "Weight:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(571, 213);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 17);
            this.lblSize.TabIndex = 10;
            this.lblSize.Text = "Size:";
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(571, 69);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(89, 17);
            this.lblSP.TabIndex = 8;
            this.lblSP.Text = "Selling price:";
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.Location = new System.Drawing.Point(571, 24);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(107, 17);
            this.lblPP.TabIndex = 6;
            this.lblPP.Text = "Purchase price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 258);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(18, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // tabControlProducts
            // 
            this.tabControlProducts.Controls.Add(this.AddProductTab);
            this.tabControlProducts.Controls.Add(this.tabPageDocuments);
            this.tabControlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProducts.Location = new System.Drawing.Point(157, 0);
            this.tabControlProducts.Name = "tabControlProducts";
            this.tabControlProducts.SelectedIndex = 0;
            this.tabControlProducts.Size = new System.Drawing.Size(1303, 663);
            this.tabControlProducts.TabIndex = 1;
            this.tabControlProducts.TabStop = false;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 663);
            this.Controls.Add(this.tabControlProducts);
            this.Controls.Add(this.panelButtons);
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.panelButtons.ResumeLayout(false);
            this.tabPageDocuments.ResumeLayout(false);
            this.tabPageDocuments.PerformLayout();
            this.panelReceiving.ResumeLayout(false);
            this.panelReceiving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receiving)).EndInit();
            this.AddProductTab.ResumeLayout(false);
            this.AddProductTab.PerformLayout();
            this.tabControlProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnIntermediate;
        private System.Windows.Forms.Button btnReceiving;
        private System.Windows.Forms.Button btnReturnToSupplier;
        private System.Windows.Forms.Button btnWriteOff;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.TabPage tabPageDocuments;
        private System.Windows.Forms.Button btn_document_complete;
        private System.Windows.Forms.Panel panelReceiving;
        private System.Windows.Forms.DataGridView dgv_receiving;
        private System.Windows.Forms.TextBox tBox_Receiving_Price;
        private System.Windows.Forms.Label lblReceivingPrice;
        private System.Windows.Forms.TextBox tBox_Receiving_Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_Receiving_PName;
        private System.Windows.Forms.Label lblReceivingProductName;
        private System.Windows.Forms.Button btnReceivingSearch;
        private System.Windows.Forms.TextBox tbox_document_amount;
        private System.Windows.Forms.Label lblReceivingID;
        private System.Windows.Forms.ComboBox cmb_document_option2;
        private System.Windows.Forms.ComboBox cmb_document_option1;
        private System.Windows.Forms.Label lbl_document_option2;
        private System.Windows.Forms.Label lbl_document_option1;
        private System.Windows.Forms.Label lblReceivingRemark;
        private System.Windows.Forms.Label lblDocumentDate;
        private System.Windows.Forms.RichTextBox rtb_document_remark;
        private System.Windows.Forms.TextBox tbox_document_name;
        private System.Windows.Forms.DateTimePicker dtp_document_date;
        private System.Windows.Forms.Label lblDocumentName;
        private System.Windows.Forms.TabPage AddProductTab;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnSearchProducts;
        private System.Windows.Forms.Button btnSaveProducts;
        private System.Windows.Forms.Label lblAddBarcode;
        private System.Windows.Forms.TextBox tBoxBarcode;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tBoxAddSizeZ;
        private System.Windows.Forms.TextBox tBoxAddSizeY;
        private System.Windows.Forms.TextBox tBoxAddSizeX;
        private System.Windows.Forms.TextBox tBoxAmount;
        private System.Windows.Forms.TextBox tBoxWeight;
        private System.Windows.Forms.TextBox tBoxSellPrice;
        private System.Windows.Forms.TextBox tBoxPurchasePrice;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxAddID;
        private System.Windows.Forms.CheckBox checkBoxShipmentEmpty;
        private System.Windows.Forms.DateTimePicker dtpDateOfShipment;
        private System.Windows.Forms.Label lblDateOfShipment;
        private System.Windows.Forms.Button btnAddProductTab;
        private System.Windows.Forms.DateTimePicker dtpDateOfArival;
        private System.Windows.Forms.Label lblz;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDateOfArival;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblPP;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TabControl tabControlProducts;
        private System.Windows.Forms.Label lblWeightUnit;
    }
}