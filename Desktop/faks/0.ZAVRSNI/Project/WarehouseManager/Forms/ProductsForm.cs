using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WarehouseManager.DataHolders;
using System.Diagnostics;
using DatabaseManagers;
using Models;
using static Models.Enums;

namespace WarehouseManager.Forms
{
    public partial class ProductsForm : Form
    {        
        List<ProductDisplay> documentProducts;
        BindingSource source;
        private DocumentTypes _selectedDocument;
        //On document change
        DocumentTypes selectedDocument
        {
            get { return _selectedDocument; }
            set
            {
                if (value == _selectedDocument) return;
                _selectedDocument = value;
                setupOptions();
            }
        }

        public ProductsForm()
        {
            InitializeComponent();

            
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            //Set tab so tab pages aren't displayed
            tabControlProducts.Appearance = TabAppearance.FlatButtons;
            tabControlProducts.ItemSize = new System.Drawing.Size(0, 1);
            tabControlProducts.SizeMode = TabSizeMode.Fixed;

            //Configure elements for when the form is first time opened
            btnSearchProducts.Visible = false;
            btnSaveProducts.Visible = false;

            lblWeightUnit.Text = PropertiesHolder.weightUnit;

            //Get products from database
            //ProductsHolder.products = ProductManager.GetProducts();

            //set next id [last+1]          
            tBoxAddID.Text = (ProductsHolder.products.Count == 0 ? 0 : (from elem in ProductsHolder.products select elem.id).Max() + 1).ToString();            

            //DataGridViewSetup RECEVING
            documentProducts = new List<ProductDisplay>();
            source = new BindingSource();
            source.DataSource = documentProducts;
            dgv_receiving.DataSource = source;

            _selectedDocument = DocumentTypes.writeOff;

            //Amount document tbox
            tbox_document_amount.Text = "1";
            tbox_document_amount.Enabled = false;
        }


        #region MenuButtons
        private void btnAddProduct_Click(object sender, EventArgs e) 
        {
            tabControlProducts.SelectedTab = tabControlProducts.TabPages[0];
            btnAddProductTab.Visible = true;
            btnSaveProducts.Visible = false;
            btnSearchProducts.Visible = false;
        }
        private void btnEditProduct_Click(object sender, EventArgs e) 
        { 
            tabControlProducts.SelectedTab = tabControlProducts.TabPages[0];
            btnAddProductTab.Visible = false;
            btnSaveProducts.Visible = true;
            btnSearchProducts.Visible = true;

        }
        private void btnReceiving_Click(object sender, EventArgs e) 
        {
            if (WarehouseHolder.selectedWarehouse == null)
            {
                MessageBox.Show("Please select warehouse");
                return;
            }
            selectedDocument = DocumentTypes.receipt;
            tabControlProducts.SelectedTab = tabControlProducts.TabPages[1];
            lbl_document_option1.Text = "Supplier:";
            lbl_document_option2.Text = "Transporter:";
            lbl_document_option1.Visible = true;
            cmb_document_option1.Enabled = true;
            lbl_document_option2.Visible = true;
            cmb_document_option1.Visible = true;
            cmb_document_option2.Visible = true;
        }
        private void btnIntermediate_Click(object sender, EventArgs e)
        {
            if (WarehouseHolder.selectedWarehouse == null)
            {
                MessageBox.Show("Please select warehouse");
                return;
            }
            selectedDocument = DocumentTypes.intermediateWarehouse;
            tabControlProducts.SelectedTab = tabControlProducts.TabPages[1];
            lbl_document_option1.Text = "Origin warehouse:";
            lbl_document_option2.Text = "Destination warehouse:";
            lbl_document_option1.Visible = true;
            lbl_document_option2.Visible = true;
            cmb_document_option1.Visible = true;
            cmb_document_option1.Enabled = false;
            cmb_document_option1.Text = WarehouseHolder.selectedWarehouse.name;
            cmb_document_option2.Visible = true;
        }
        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            if (WarehouseHolder.selectedWarehouse == null)
            {
                MessageBox.Show("Please select warehouse");
                return;
            }
            selectedDocument = DocumentTypes.writeOff;           
            tabControlProducts.SelectedTab = tabControlProducts.TabPages[1];
            lbl_document_option1.Visible = false;
            lbl_document_option2.Visible = false;
            cmb_document_option1.Enabled = true;
            cmb_document_option1.Visible = false;
            cmb_document_option2.Visible = false;
        }
        private void btnReturnToSupplier_Click(object sender, EventArgs e)
        {
            if (WarehouseHolder.selectedWarehouse == null)
            {
                MessageBox.Show("Please select warehouse");
                return;
            }
            selectedDocument = DocumentTypes.returnToSupplier;
            tabControlProducts.SelectedTab = tabControlProducts.TabPages[1];
            lbl_document_option1.Text = "Supplier:";
            lbl_document_option1.Visible = true;
            lbl_document_option2.Visible = false;
            cmb_document_option1.Visible = true;
            cmb_document_option1.Enabled = true;
            cmb_document_option2.Visible = false;
        }

        #endregion     

        /// <summary>
        /// Limit textBox to take only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBoxNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        #region Products
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Check if textboxes are empty
            foreach (var item in AddProductTab.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("All fileds must be filled");
                        return;
                    }
                }

            }

            //Create product object
            Product product = new Product();

            product.id = int.Parse(tBoxAddID.Text);
            product.name = tBoxName.Text;
            product.dateOfArival = dtpDateOfArival.Value;
            product.dateOfShipment = checkBoxShipmentEmpty.Checked ? DateTime.MinValue : dtpDateOfShipment.Value;
            product.purchasePrice = double.Parse(tBoxPurchasePrice.Text);
            product.sellingPrice = double.Parse(tBoxSellPrice.Text);
            product.numberAvalible = double.Parse(tBoxAmount.Text);
            product.weight = double.Parse(tBoxWeight.Text);
            product.description = rtbDescription.Text;
            product.size.x = double.Parse(tBoxAddSizeX.Text);
            product.size.y = double.Parse(tBoxAddSizeY.Text);
            product.size.z = double.Parse(tBoxAddSizeZ.Text);
            product.barcode = tBoxBarcode.Text;

            try
            {
                //Add it do products list
                ProductsHolder.products.Add(product);
                Debug.WriteLine("Adding product from product form");

                ProductClient.InsertProduct(product);

                //Set new ID          
                tBoxAddID.Text = (ProductsHolder.products.Count == 0 ? 0 : (from elem in ProductsHolder.products select elem.id).Max() + 1).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Failed to insert product");
            }
            
        }

        private void checkBoxShipmentEmpty_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateOfShipment.Enabled = checkBoxShipmentEmpty.Checked ? false : true;
        }

        private void btnEditSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllProductsForm allProductsForm = new AllProductsForm(false);
            allProductsForm.Location = this.Location;
            allProductsForm.StartPosition = this.StartPosition;
            allProductsForm.FormClosing += delegate {
                AddProductToEditForm(allProductsForm.SelectedProducts().FirstOrDefault());
                this.Show();
            };
            allProductsForm.ShowDialog();
        }

        private void AddProductToEditForm(Product product)
        {
            if (product == null)
            {
                return;
            }
            tBoxAddID.Text = product.id.ToString();
            tBoxBarcode.Text = product.barcode;
            tBoxName.Text = product.name;
            dtpDateOfArival.Value = product.dateOfArival;
            dtpDateOfShipment.Value = product.dateOfShipment;
            rtbDescription.Text = product.description;
            tBoxPurchasePrice.Text = product.purchasePrice.ToString();
            tBoxSellPrice.Text = product.sellingPrice.ToString();
            tBoxAmount.Text = product.numberAvalible.ToString();
            tBoxWeight.Text = product.weight.ToString();
            tBoxAddSizeX.Text = product.size.x.ToString();
            tBoxAddSizeY.Text = product.size.y.ToString();
            tBoxAddSizeZ.Text = product.size.z.ToString();
        }

        private Product GetProductFromForm()
        {
            Product product = new Product();
            product.id = int.Parse(tBoxAddID.Text);
            product.barcode = tBoxBarcode.Text;
            product.name = tBoxName.Text;
            product.dateOfArival = dtpDateOfArival.Value;
            product.dateOfShipment = dtpDateOfShipment.Value;
            product.description = rtbDescription.Text;
            product.purchasePrice = double.Parse(tBoxPurchasePrice.Text);
            product.sellingPrice = double.Parse(tBoxSellPrice.Text);
            product.numberAvalible = double.Parse(tBoxAmount.Text);
            product.weight = double.Parse(tBoxWeight.Text);
            product.size.x = double.Parse(tBoxAddSizeX.Text);
            product.size.y = double.Parse(tBoxAddSizeY.Text);
            product.size.z = double.Parse(tBoxAddSizeZ.Text);

            return product;

        }

        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            try
            {
                ProductClient.UpdateProduct(GetProductFromForm());
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to update product");
            }            
        }

        private void btnProductClearForm_Click(object sender, EventArgs e)
        {
            foreach (TextBox item in AddProductTab.Controls.OfType<TextBox>())
            {
                if (item.Name != "tBoxAddID")
                {
                    item.Text = "";
                }
                                     
            }
        }

        #endregion

        #region Documents

        private void clearDocumentsForm()
        {
            foreach (TextBox item in tabPageDocuments.Controls.OfType<TextBox>())
            {
                if (item.Name != "tBoxAddID")
                {
                    item.Text = "";
                }

            }
        }

        private void AddProductToReceivingForm(List<Product> products, double amount)
        {
            if (products == null)
            {
                return;
            }
            foreach (Product item in products)
            {
                documentProducts.Add(new ProductDisplay(item, amount));
            }
            dgv_receiving.Refresh();
            source.ResetBindings(false);
        }

        private void btnDocumentForm_Click(object sender, EventArgs e)
        {
            foreach (TextBox item in tabPageDocuments.Controls.OfType<TextBox>())
            {
                    item.Text = "";
            }
        }

        private void btnCompleteDocument_Click(object sender, EventArgs e)
        {
           

            Document document = new Document();
            document.name = tbox_document_name.Text;
            document.date = dtp_document_date.Value;
            document.remark = rtb_document_remark.Text;
            try
            {
                switch (selectedDocument)
                {
                    case DocumentTypes.receipt:
                        //Finish document props
                        document.supplier = (Partner)cmb_document_option1.SelectedItem;
                        document.transporter = (Partner)cmb_document_option2.SelectedItem;
                        document.type = DocumentTypes.receipt;

                        //Action for document type
                        documentReceiveAction();
                        break;
                    case DocumentTypes.intermediateWarehouse:
                        //Finish document props
                        document.type = DocumentTypes.intermediateWarehouse;
                        document.originWarehouse = (Warehouse)cmb_document_option1.SelectedItem;
                        document.destinationWarehouse = (Warehouse)cmb_document_option2.SelectedItem;

                        //Action for document
                        documentIntermediateWarehouseAction();
                        break;
                    case DocumentTypes.writeOff:
                        document.type = DocumentTypes.writeOff;

                        //Action for document
                        documentRemoveitemsAction();
                        break;
                    case DocumentTypes.returnToSupplier:
                        //finish document props
                        document.type = DocumentTypes.returnToSupplier;
                        document.supplier = (Partner)cmb_document_option1.SelectedItem;

                        //Action for document
                        documentRemoveitemsAction();
                        break;
                    default:
                        break;
                }
                document.products = documentProducts;

                DocumentClient.insertDocument(document);

                foreach (ProductDisplay product in document.products)
                {
                    DocumentProductConnection connection = new DocumentProductConnection(
                        DocumentConnectionHolder.documentProductConnections.Count == 0 ? 0 : DocumentConnectionHolder.documentProductConnections.Count + 1,
                        product.id, document.name, product.inUnit);

                    DocumentConnectionHolder.documentProductConnections.Add(connection);
                    DocumentClient.InsertDocumentProductConnection(connection);
                }

                clearDocumentsForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to complete document");
            }
            

        }

        private void btnDocumentProductSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllProductsForm allProductsForm = new AllProductsForm(true);
            if (selectedDocument != DocumentTypes.receipt)
            {
               allProductsForm.warehouseFilter = WarehouseHolder.selectedWarehouse.id;
            }            
            allProductsForm.Location = this.Location;
            allProductsForm.StartPosition = this.StartPosition;
            allProductsForm.FormClosing += delegate {
                AddProductToReceivingForm(allProductsForm.SelectedProducts(), allProductsForm.Amount());
                this.Show();
            };
            allProductsForm.ShowDialog();
        }

        private void setupOptions()
        {
            cmb_document_option1.Items.Clear();
            cmb_document_option1.Text = null;
            cmb_document_option2.Items.Clear();
            cmb_document_option2.Text = null;
            switch (selectedDocument)
            {
                case DocumentTypes.receipt:
                case DocumentTypes.returnToSupplier:
                case DocumentTypes.writeOff:
                    setPartners();
                    break;
                case DocumentTypes.intermediateWarehouse:
                    cmb_document_option1.Items.AddRange(WarehouseHolder.warehouses.ToArray());
                    cmb_document_option1.ValueMember = "name";
                    cmb_document_option2.Items.AddRange(WarehouseHolder.warehouses
                        .FindAll((elem) => elem.name != WarehouseHolder.selectedWarehouse.name).ToArray());
                    cmb_document_option2.ValueMember = "name";
                    break;
                default:
                    break;
            }
            void setPartners()
            {
                cmb_document_option1.Items.AddRange(DeliveryHolder.partners
                .Where((elem) => elem.type == Enums.PartnerType.supplier).ToArray());
                cmb_document_option1.ValueMember = "name";
                cmb_document_option2.Items.AddRange(DeliveryHolder.partners
                    .Where((elem) => elem.type == Enums.PartnerType.transporter).ToArray());
                cmb_document_option2.ValueMember = "name";
            }
            
        }

        private void dgv_receiving_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            tbox_document_amount.Enabled = true;
            tbox_document_amount.Text =
                ((ProductDisplay)dgv_receiving.Rows[e.RowIndex].DataBoundItem)
                .inUnit.ToString();
        }

        #region Document action functions

        /// <summary>
        /// Adds products to selected warehouse
        /// </summary>
        private void documentReceiveAction()
        {
            foreach (ProductDisplay product in documentProducts)
            {
                //Check if connection exist
                if (WarehouseHolder.warehouseProductConnections.Exists(
                    (elem) => elem.productId == product.id
                    && elem.warehouseId == WarehouseHolder.selectedWarehouse.id))
                {
                    //Connection exist, get it's index
                    int index = WarehouseHolder.warehouseProductConnections.FindIndex((elem) => elem.productId == product.id
                    && elem.warehouseId == WarehouseHolder.selectedWarehouse.id);

                    //Create temp connection object to update database
                    WarehouseProductConnection connection = new WarehouseProductConnection();
                    connection.connectionId = WarehouseHolder.warehouseProductConnections.Find((elem) => elem.productId == product.id
                    && elem.warehouseId == WarehouseHolder.selectedWarehouse.id).connectionId;
                    connection.productId = product.id;
                    connection.warehouseId = WarehouseHolder.selectedWarehouse.id;
                    connection.amount = WarehouseHolder.warehouseProductConnections[index].amount + product.inUnit;

                    WarehouseHolder.warehouseProductConnections[index].amount += product.inUnit;
                    DatabaseManagers.WarehouseClient.CreateWarehouseProductConnection(connection);                   

                }
                //Connection does not exist create it and add amounts
                else
                {
                    WarehouseProductConnection connection = new WarehouseProductConnection();
                    connection.connectionId = WarehouseHolder.warehouseProductConnections.Count == 0 ? 1 : 
                        WarehouseHolder.warehouseProductConnections.Count +1;
                    connection.productId = product.id;
                    connection.warehouseId = WarehouseHolder.selectedWarehouse.id;
                    connection.amount = product.inUnit;

                    WarehouseHolder.warehouseProductConnections.Add(connection);
                    DatabaseManagers.WarehouseClient.CreateWarehouseProductConnection(connection);
                }

            }
        }

        /// <summary>
        /// Transfer products from one warehouse to another
        /// </summary>
        private void documentIntermediateWarehouseAction()
        {
            foreach (ProductDisplay product in documentProducts)
            {
                //Get origin warehouse connection index
                int originIndex = WarehouseHolder.warehouseProductConnections.FindIndex((elem) => elem.productId == product.id
                && elem.warehouseId == ((Warehouse)cmb_document_option1.SelectedItem).id);
                

                //Create temp origin warehouse connection object to update database
                WarehouseProductConnection connectionOrigin = new WarehouseProductConnection();
                connectionOrigin.connectionId = WarehouseHolder.warehouseProductConnections.Find((elem) => elem.productId == product.id
                && elem.warehouseId == ((Warehouse)cmb_document_option1.SelectedItem).id).connectionId;
                connectionOrigin.productId = product.id;
                connectionOrigin.warehouseId = ((Warehouse)cmb_document_option1.SelectedItem).id;
                connectionOrigin.amount = WarehouseHolder.warehouseProductConnections[originIndex].amount - product.inUnit;

                WarehouseHolder.warehouseProductConnections[originIndex].amount -= product.inUnit;
                DatabaseManagers.WarehouseClient.CreateWarehouseProductConnection(connectionOrigin);

                //Create temp destination warehouse connection object to update database
                WarehouseProductConnection connectionDestination = new WarehouseProductConnection();
                if (WarehouseHolder.warehouseProductConnections.Exists((elem) => elem.productId == product.id
                && elem.warehouseId == ((Warehouse)cmb_document_option2.SelectedItem).id))
                {
                    //Connection already exists
                    connectionDestination.connectionId = WarehouseHolder.warehouseProductConnections.Find((elem) => elem.productId == product.id
                && elem.warehouseId == ((Warehouse)cmb_document_option2.SelectedItem).id).connectionId;
                }
                else
                {
                    //Connection does not exist
                    connectionDestination.connectionId = WarehouseHolder.warehouseProductConnections.Count == 0 ? 1 : WarehouseHolder.warehouseProductConnections.Count + 1;
                }
                connectionDestination.productId = product.id;
                connectionDestination.warehouseId = ((Warehouse)cmb_document_option2.SelectedItem).id;
                connectionDestination.amount = WarehouseHolder.warehouseProductConnections[originIndex].amount + product.inUnit;

                WarehouseHolder.warehouseProductConnections[originIndex].amount -= product.inUnit;
                DatabaseManagers.WarehouseClient.CreateWarehouseProductConnection(connectionOrigin);

                if (WarehouseHolder.warehouseProductConnections.Exists((elem) => elem.productId == product.id
                && elem.warehouseId == ((Warehouse)cmb_document_option2.SelectedItem).id))
                {
                    //Get destination warehouse connection index
                    int destinationIndex = WarehouseHolder.warehouseProductConnections.FindIndex((elem) => elem.productId == product.id
                    && elem.warehouseId == ((Warehouse)cmb_document_option2.SelectedItem).id);

                    WarehouseHolder.warehouseProductConnections[destinationIndex].amount += product.inUnit;
                }
                else
                {
                    WarehouseHolder.warehouseProductConnections.Add(connectionDestination);
                }
               
                DatabaseManagers.WarehouseClient.CreateWarehouseProductConnection(connectionDestination);

            }
        }

        /// <summary>
        /// Removes items from warehouse
        /// </summary>
        private void documentRemoveitemsAction()
        {
            foreach (ProductDisplay product in documentProducts)
            {
                //Connection exist, get it's index
                int index = WarehouseHolder.warehouseProductConnections.FindIndex((elem) => elem.productId == product.id
                && elem.warehouseId == WarehouseHolder.selectedWarehouse.id);

                //Create temp connection object to update database
                WarehouseProductConnection connection = new WarehouseProductConnection();
                connection.connectionId = WarehouseHolder.warehouseProductConnections.Find((elem) => elem.productId == product.id
                && elem.warehouseId == WarehouseHolder.selectedWarehouse.id).connectionId;
                connection.productId = product.id;
                connection.warehouseId = WarehouseHolder.selectedWarehouse.id;
                connection.amount = WarehouseHolder.warehouseProductConnections[index].amount - product.inUnit;

                WarehouseHolder.warehouseProductConnections[index].amount -= product.inUnit;
                DatabaseManagers.WarehouseClient.CreateWarehouseProductConnection(connection);
            }
        }

        #endregion

        #endregion


    }
}
