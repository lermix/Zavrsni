using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManager.DataHolders;
using WarehouseManager.Managers;
using Models;
using DatabaseManagers;

namespace WarehouseManager.Forms
{
    public partial class AllProductsForm : Form
    {
        List<string> serachBy;
        List<string> searchOptions;
        public int warehouseFilter { get; set; }

        public AllProductsForm(bool enableAmount, int warehouseFilter = -1)
        {
            InitializeComponent();
            if (enableAmount == false)
            {
                tBoxAmount.Text = 0.ToString();
                tBoxAmount.Visible = false;
                lblAmount.Visible = false;                
            }
            this.warehouseFilter = warehouseFilter;
        }

        private void AllProductsForm_Load(object sender, EventArgs e)
        {
            serachBy = typeof(Product).GetProperties().Select(ele => ele.Name).ToList();
            searchOptions = SearchManager.getOptions();

            if (warehouseFilter != -1)
            {
                List<ProductDisplay> productDisplays = new List<ProductDisplay>();
                List<Product> warehouseProducts = ProductsHolder.products.FindAll((product) =>
                    WarehouseHolder.warehouseProductConnections
                    .FindAll((con) => con.warehouseId == warehouseFilter).Select(con => con.productId).Contains(product.id));

                foreach (Product item in warehouseProducts)
                {
                    productDisplays.Add(
                        new ProductDisplay(
                            item, 
                            WarehouseHolder.warehouseProductConnections
                                .Find((con) => con.warehouseId == warehouseFilter && con.productId == item.id).amount)
                        );
                }
                dgvProducts.DataSource = productDisplays;
            }
            else
            {
                dgvProducts.DataSource = ProductsHolder.products;
            }
            

            cmbSearchBy.DataSource = serachBy;
            cmbSearchOptions.DataSource = searchOptions;

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!serachBy.Contains(cmbSearchBy.Text) || !searchOptions.Contains(cmbSearchOptions.Text) )
            {
                MessageBox.Show("Please use given serach options");
            }
            else
            {
                switch (cmbSearchOptions.Text)
                {
                    case "Starts with":
                        dgvProducts.DataSource = SearchManager.StartsWith(tBoxSearchValue.Text,
                                cmbSearchBy.Text, ProductsHolder.products);
                        break;
                    case "Ends with":
                        dgvProducts.DataSource = SearchManager.EndsWith(tBoxSearchValue.Text,
                                cmbSearchBy.Text, ProductsHolder.products);
                        break;
                    case "Greater than":
                        dgvProducts.DataSource = SearchManager.GreaterThan(tBoxSearchValue.Text,
                                cmbSearchBy.Text, ProductsHolder.products);
                        break;
                    case "Less than":
                    dgvProducts.DataSource = SearchManager.LessThan(tBoxSearchValue.Text,
                                cmbSearchBy.Text, ProductsHolder.products);
                        break;
                    default:
                        break;
                }
                
            }              
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsHolder.products = ProductClient.GetProducts();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to refresh from database");
            }            
            dgvProducts.DataSource = ProductsHolder.products;
        }

        public void btnAddSelected_Click(object sender, EventArgs e)
        {

            if(dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select row to add");
                return;
            }
            setTboxAmountValue();
            if (double.TryParse(tBoxAmount.Text, out double n))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Amount must be number");
            }
            
        }

        public List<Product> SelectedProducts()
        {
            List<Product> seletcedProducts = new List<Product>();
            foreach (DataGridViewRow row in dgvProducts.SelectedRows)
            {
                seletcedProducts.Add(row.DataBoundItem as Product);
            }
            return seletcedProducts;
        }

        public double Amount()
        {
            if (string.IsNullOrEmpty(tBoxAmount.Text))
            {
                return 0;
            }
            else
            {
                double returnValue = 0;
                double.TryParse(tBoxAmount.Text, out returnValue);
                return returnValue;

            }

        }

        private void tBoxAmount_TextChanged(object sender, EventArgs e)
        {
            setTboxAmountValue();
        }

        private void dgvProducts_MouseDown(object sender, MouseEventArgs e)
        {
            setTboxAmountValue();
        }

        private void setTboxAmountValue()
        {
            if (warehouseFilter != -1)
            {
                List<ProductDisplay> seletcedProducts = new List<ProductDisplay>();
                foreach (DataGridViewRow row in dgvProducts.SelectedRows)
                {
                    seletcedProducts.Add(row.DataBoundItem as ProductDisplay);
                }

                if (seletcedProducts.Count > 0 && !string.IsNullOrEmpty(tBoxAmount.Text))
                {
                    double minInUnitValue = seletcedProducts.Min((elem) => elem.inUnit);
                    if (double.Parse(tBoxAmount.Text) > minInUnitValue)
                    {
                        tBoxAmount.Text = minInUnitValue.ToString();
                    }
                }
                

            }
        }

        
    }
}
