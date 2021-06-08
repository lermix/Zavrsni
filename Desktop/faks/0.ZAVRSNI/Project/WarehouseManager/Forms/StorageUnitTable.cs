using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DatabaseManagers;
using Models;
using WarehouseManager.DataHolders;

namespace WarehouseManager.Forms
{

    public partial class StorageUnitTable : Form
    {
        int btnId;
        int connectionID;

        //Products contained in this unit, [fetchd at form load]
        List<ProductDisplay> unitProducts;

        public StorageUnitTable(int btnId)
        {
            InitializeComponent();
            this.btnId = btnId;

            unitProducts = new List<ProductDisplay>();

        }

        private void StorageUnitTable_Load(object sender, EventArgs e)
        {
            //Get last 10 products
            cmbMostUsed.DataSource = ProductsHolder.products.Skip(ProductsHolder.products.Count() - 10).Select(elem => elem.name).ToList();

            List<int> thisUnitProductsID = UnitProductConnectionHolder.Connections.FindAll(conn => conn.ButtonId == btnId).Select(prop => prop.ProductId).ToList();

            LoadTable(thisUnitProductsID);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMostUsed.Text))
            {
                return;
            }

            int productId = ProductsHolder.products.Find(p => p.name == cmbMostUsed.Text).id;
            double amount = 1;
            if (string.IsNullOrEmpty(tboxAmount.Text) || !double.TryParse(tboxAmount.Text, out amount))
            {
                MessageBox.Show("Amount must be number");
                return;
            }
            AddProductToUnit(productId, amount);



        }

        private void btnViewAllProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllProductsForm allProductsForm = new AllProductsForm(true);
            allProductsForm.Location = this.Location;
            allProductsForm.StartPosition = this.StartPosition;
            allProductsForm.FormClosing += delegate {
                AddProductRangeToUnit(allProductsForm.SelectedProducts(), allProductsForm.Amount());
                this.Show();
            };
            allProductsForm.ShowDialog();
        }

        private void AddProductToUnit(int id, double amount)
        {
            Product productToAdd = ProductsHolder.products.Find(p => p.id == id);
            //Product already exists
            if (unitProducts.FindAll(product => product.id == productToAdd.id).Count > 0)
            {
                //increase amount localy
                unitProducts.Where(product => product.id == productToAdd.id).FirstOrDefault().inUnit += amount;
                //get connection info              
                int productId = unitProducts.Where(product => product.id == productToAdd.id).FirstOrDefault().id;
                double increasedAmount = unitProducts.Where(product => product.id == productToAdd.id).FirstOrDefault().inUnit;
                //increase amount in database
                try
                {
                    ButtonsClient.UpdateUnitProductConnection(btnId, productId, increasedAmount);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to update database");
                }
                

            }
            //product does not exists in this unit
            else
            {
                //add to local
                unitProducts.Add(new ProductDisplay(productToAdd, amount));

                //Get connectionID
                connectionID = UnitProductConnectionHolder.Connections.Count == 0 ? 0 : UnitProductConnectionHolder.Connections.Max(con => con.ConnectionId) + 1;

                //create connection
                var connection = new UnitProductConnection
                {
                    ConnectionId = connectionID,
                    ButtonId = btnId,
                    ProductId = productToAdd.id,
                    amount = amount
                };

                //add to database
                try
                {
                    ButtonsClient.AddUnitProuductConnection(connection);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to add to database");
                }                
                //add to holder
                UnitProductConnectionHolder.Connections.Add(connection);
            }           
            dgvUnitProducts.DataSource = null;
            dgvUnitProducts.DataSource = unitProducts;//get from local         
            
        }

        private void AddProductRangeToUnit(List<Product> products, double amount)
        {
            foreach (Product product in products)
            {
                AddProductToUnit(product.id, amount);
            }
        }

        private void LoadTable(List<int> thisUnitProductsID)
        {
            List<UnitProductConnection> unitConnections = new List<UnitProductConnection>();

            try
            {
                unitConnections = ButtonsClient.GetUnitPorductConnections();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to get product for unit from database");
            }
                
                

            //Go through all products and add those that belong in this unit
            foreach (Product product in ProductsHolder.products)
            {
                if (thisUnitProductsID.Contains(product.id))
                {
                    unitProducts.Add(new ProductDisplay(product,
                        unitConnections.Where(conn => conn.ProductId == product.id && conn.ButtonId == btnId).FirstOrDefault().amount));
                }
            }
            if (unitProducts.Count > 0)
            {
                //dipslay unit products
                dgvUnitProducts.DataSource = null;
                dgvUnitProducts.DataSource = unitProducts;
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUnitProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select row");
                    return;
                }
                foreach (DataGridViewRow row in dgvUnitProducts.SelectedRows)
                {
                    var Product = (Product)row.DataBoundItem;
                    unitProducts.RemoveAt(row.Index);
                    ProductClient.DeleteProductUnitConnection(Product.id, btnId);
                    UnitProductConnectionHolder.Connections.Remove(UnitProductConnectionHolder.Connections.Find(
                        conn => conn.ProductId == Product.id && conn.ButtonId == btnId));
                }
                dgvUnitProducts.DataSource = null;
                dgvUnitProducts.DataSource = unitProducts;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to delete button");
            }
            
        }


    }
}
