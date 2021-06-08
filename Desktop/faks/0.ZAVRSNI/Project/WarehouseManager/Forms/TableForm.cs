using DatabaseManagers;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManager.Managers;

namespace WarehouseManager.Forms
{
    public partial class TableForm : Form
    {
        List<ProductLocation> productLocations;

        public TableForm()
        {
            InitializeComponent();

            productLocations = new List<ProductLocation>();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            try
            {
                productLocations = ProductClient.GetProductsWithLocation();
                dgv.DataSource = productLocations;

                cmbWhere.Items.AddRange(typeof(ProductLocation).GetProperties().ToArray());
                cmbWhere.ValueMember = "name";

                cmbSearchOption.Items.AddRange(Enum.GetValues(typeof(Enums.SearchOption)).Cast<Enum>().ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load form");
                this.Close();
            }
            
        }

        private void checkIfSearchoptionsSelected(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbWhere.Text) ||string.IsNullOrEmpty(cmbSearchOption.Text))
            {
                tboxValue.Enabled = false;
            }
            else
            {
                tboxValue.Enabled = true;
            }
        }

        private void tboxValue_TextChanged(object sender, EventArgs e)
        {
            switch ((Enums.SearchOption)cmbSearchOption.SelectedItem)
            {
                case Enums.SearchOption.StartsWith:
                    dgv.DataSource = null;
                    dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbWhere.Text, productLocations);
                    break;
                case Enums.SearchOption.EndsWith:
                    dgv.DataSource = null;
                    dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbWhere.Text, productLocations);
                    break;
                case Enums.SearchOption.GreaterThan:
                    dgv.DataSource = null;
                    dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbWhere.Text, productLocations);
                    break;
                case Enums.SearchOption.LessThan:
                    dgv.DataSource = null;
                    dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbWhere.Text, productLocations);
                    break;
                default:
                    break;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string saveLocation = "";

            if (string.IsNullOrEmpty(tboxFileName.Text))
            {
                MessageBox.Show("Please enter file name");
                return;
            }

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    saveLocation = fbd.SelectedPath + @"\" + tboxFileName.Text + ".pdf";
                }
            }
            if (string.IsNullOrEmpty(saveLocation))
            {
                return;
            }

            PDFManager.createPDFfromList<ProductLocation>((List<ProductLocation>)dgv.DataSource,tboxFileName.Text,saveLocation); 
        }
    }
}
