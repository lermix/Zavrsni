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
using WarehouseManager.Forms;
using static Models.DatabaseManagerEnums;

namespace WarehouseManager
{
    public partial class StartingForm : Form
    {

        public StartingForm()
        {
            InitializeComponent();

            try
            {
                //Get all Products
                DataHolders.ProductsHolder.products = ProductClient.GetProducts();

                //Get all connections 
                DataHolders.ButtonConnectionHolder.connections = ButtonsClient.GetButtonConnections();
                DataHolders.UnitProductConnectionHolder.Connections = ButtonsClient
                    .GetUnitPorductConnections();

                //Documents
                DataHolders.DocumentConnectionHolder.documentProductConnections = DocumentClient
                    .GetAllDocumnetProductConnections();

                //Warehouse            
                DataHolders.WarehouseHolder.warehouses = DatabaseManagers.WarehouseClient.GetWarehouses();


                //DatabaseManagers.WarehouseManager.GetWarehouses();
                DataHolders.WarehouseHolder.warehouseProductConnections = DatabaseManagers.WarehouseClient
                    .GetWarehouseProductConnection();

                //workers
                DataHolders.WorkerHolder.workers = WorkerClient.GetWorkers();
                DataHolders.WorkerHolder.avaliableWorkers = WorkerClient.GetAavalibleWorkers();

                //Delivery
                DataHolders.DeliveryHolder.partners = DeliveryClient.GetPartners();
                DataHolders.DeliveryHolder.locations = DeliveryClient.GetLocations();
                DataHolders.DeliveryHolder.vehicles = DeliveryClient.GetVehicles();
                DataHolders.DeliveryHolder.routes = DeliveryClient.GetRoutes();
                DataHolders.DeliveryHolder.avaliableVehicles = DeliveryClient.GetAvalibleVehicles();

                //properties
                if (PropertiesClient.GetProperties().Exists((e) => e.name == Enums.PropertyName.distance))
                    DataHolders.PropertiesHolder.distanceUnit = PropertiesClient.GetProperties()
                        .Find((e) => e.name == Enums.PropertyName.distance).value;
                if (PropertiesClient.GetProperties().Exists((e) => e.name == Enums.PropertyName.weight))
                    DataHolders.PropertiesHolder.weightUnit = PropertiesClient.GetProperties()
                        .Find((e) => e.name == Enums.PropertyName.weight).value;
            }
            catch (Exception)
            {
                MessageBox.Show("Error connecting to database, initial data couldn't be load");
                Environment.Exit(1);
            }           
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {
            cmb_start_selectWarehouse.Items.AddRange(DataHolders.WarehouseHolder.warehouses.ToArray());
            cmb_start_selectWarehouse.ValueMember = "name";
        }

        private void btnOpenGui_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI gui = new GUI();
            gui.Location = this.Location;
            gui.StartPosition = this.StartPosition;
            gui.FormClosing += delegate { this.Show(); };
            gui.ShowDialog();
            
            

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {            
            this.Hide();
            ProductsForm productsForm = new ProductsForm();
            productsForm.Location = this.Location;
            productsForm.StartPosition = this.StartPosition;
            if (cmb_start_selectWarehouse.SelectedItem != null)
            {
                productsForm.Text = "Warehouse: " + ((Warehouse)cmb_start_selectWarehouse.SelectedItem).name;
            }            
            productsForm.FormClosing += delegate { this.Show(); };
            productsForm.ShowDialog();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryForm deliveryForm = new DeliveryForm();
            deliveryForm.Location = this.Location;
            deliveryForm.StartPosition = this.StartPosition;
            deliveryForm.FormClosing += delegate { this.Show(); };
            deliveryForm.ShowDialog();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarehouseForm warehouse = new WarehouseForm();
            warehouse.Location = this.Location;
            warehouse.StartPosition = this.StartPosition;
            warehouse.FormClosing += delegate { this.Show(); };
            warehouse.ShowDialog();
        }

        private void cmb_start_selectWarehouse_SelectedValueChanged(object sender, EventArgs e)
        {
            DataHolders.WarehouseHolder.selectedWarehouse = (Warehouse)cmb_start_selectWarehouse.SelectedItem;
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkersForm workers = new WorkersForm();
            workers.Location = this.Location;
            workers.StartPosition = this.StartPosition;
            workers.FormClosing += delegate { this.Show(); };
            workers.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm reports = new ReportsForm();
            reports.Location = this.Location;
            reports.StartPosition = this.StartPosition;
            reports.FormClosing += delegate { this.Show(); };
            reports.ShowDialog();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableForm table = new TableForm();
            table.Location = this.Location;
            table.StartPosition = this.StartPosition;
            table.FormClosing += delegate { this.Show(); };
            table.ShowDialog();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            this.Hide();
            PropertiesForm properties = new PropertiesForm();
            properties.Location = this.Location;
            properties.StartPosition = this.StartPosition;
            properties.FormClosing += delegate { this.Show(); };
            properties.ShowDialog();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            //TcpClient.sendMsg("test");
        }
    }
}
