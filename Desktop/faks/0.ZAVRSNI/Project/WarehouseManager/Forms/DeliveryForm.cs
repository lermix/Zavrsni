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
using WarehouseManager.DataHolders;
using DatabaseManagers;

namespace WarehouseManager.Forms
{
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            //Set tab so tab pages aren't displayed
            tabControlPartners.Appearance = TabAppearance.FlatButtons;
            tabControlPartners.ItemSize = new System.Drawing.Size(0, 1);
            tabControlPartners.SizeMode = TabSizeMode.Fixed;

            lblDistance.Text = PropertiesHolder.distanceUnit;

            #region Partner
            cmb_addPartner_type.Items.Add(Enums.PartnerType.transporter);
            cmb_addPartner_type.Items.Add(Enums.PartnerType.supplier);

            //On load set next id [last+1]          
            tBox_addPartner_id.Text = (DeliveryHolder.partners.Count == 0 ? 0 : (from elem in DeliveryHolder.partners select elem.id).Max() + 1).ToString();

            #endregion

            #region Route
            setupRouteCmb();
            tbox_addRoute_id.Text = DeliveryHolder.routes.Count == 0 ? "1" : 
                (DeliveryHolder.routes.Count + 1).ToString();            
            #endregion

            #region Vehicle
            #endregion

            #region Location
            tbox_addLocation_id.Text = DeliveryHolder.locations.Count == 0 ? "1" :
                (DeliveryHolder.locations.Count + 1).ToString();
            #endregion

        }

        #region MenuButtons
        private void btnAddPartner_tab_Click(object sender, EventArgs e)
        {
            tabControlPartners.SelectedTab = tabControlPartners.TabPages[0];
            btnAddPartner.Visible = true;
            btnSavePartner.Visible = false;
            btnSearchPartners.Visible = false;
            clearTab(tabPagePartner);
            tBox_addPartner_id.Text = (DeliveryHolder.partners.Count == 0 ? 0 : (from elem in DeliveryHolder.partners select elem.id).Max() + 1).ToString();
        }
        private void btnEditPartnert_Click(object sender, EventArgs e)
        {
            tabControlPartners.SelectedTab = tabControlPartners.TabPages[0];
            btnAddPartner.Visible = false;
            btnSavePartner.Visible = true;
            btnSearchPartners.Visible = true;
            clearTab(tabPagePartner);
        }
        private void btnAddRouteTab_Click(object sender, EventArgs e)
        {
            tabControlPartners.SelectedTab = tabControlPartners.TabPages[1];
            btnAddRoute.Visible = true;
            btnSaveRoute.Visible = false;
            btnSearchRoute.Visible = false;

            try
            {
                WorkerHolder.avaliableWorkers = WorkerClient.GetAavalibleWorkers();
                DeliveryHolder.avaliableVehicles = DeliveryClient.GetAvalibleVehicles();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to get avaliable vehicles or workers");               
            }
            

            clearTab(tabPageRoutes);
            tbox_addRoute_id.Text = DeliveryHolder.routes.Count == 0 ? "1" :
               (DeliveryHolder.routes.Count + 1).ToString();
            setupRouteCmb();
        }
        private void btnEditRouteTab_Click(object sender, EventArgs e)
        {
            tabControlPartners.SelectedTab = tabControlPartners.TabPages[1];
            btnAddRoute.Visible = false;
            btnSaveRoute.Visible = true;
            btnSearchRoute.Visible = true;
            clearTab(tabPageRoutes);
        }
        private void btnAddVehicleTab_Click(object sender, EventArgs e)
        {
            tabControlPartners.SelectedTab = tabControlPartners.TabPages[2];
            btnAddVehicle.Visible = true;
            btnSaveVehicle.Visible = false;
            btnSearchVehicle.Visible = false;
            clearTab(tabPageVehicle);
        }
        private void btnEditVehicleTab_Click(object sender, EventArgs e)
        {
            tabControlPartners.SelectedTab = tabControlPartners.TabPages[2];
            btnAddVehicle.Visible = false;
            btnSaveVehicle.Visible = true;
            btnSearchVehicle.Visible = true;
            clearTab(tabPageVehicle);

        }
        private void btnAddLocationTab_Click(object sender, EventArgs e)
        {
            tabControlPartners.SelectedTab = tabControlPartners.TabPages[3];
            btnAddLocation.Visible = true;
            btnSaveLoaction.Visible = false;
            btnSearchLocation.Visible = false;
            clearTab(tabPageLocation);

        }
        private void btnEditLocationTab_Click(object sender, EventArgs e)
        {
            tabControlPartners.SelectedTab = tabControlPartners.TabPages[3];
            btnAddLocation.Visible = false;
            btnSaveLoaction.Visible = true;
            btnSearchLocation.Visible = true;
            clearTab(tabPageLocation);
            tbox_addLocation_id.Text = DeliveryHolder.locations.Count == 0 ? "1" :
                (DeliveryHolder.locations.Count + 1).ToString();
        }
        private void btnRouteManagerTab_Click(object sender, EventArgs e)
        {
            tabControlPartners.SelectedTab = tabControlPartners.TabPages[4];

        }
        #endregion


        #region Partner
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            clearTab(tabPagePartner);
            tBox_addPartner_id.Text = (DeliveryHolder.partners.Count == 0 ? 0 : (from elem in DeliveryHolder.partners select elem.id).Max() + 1).ToString();
        }
        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            Partner partner = new Partner();
            partner.id = int.Parse(tBox_addPartner_id.Text);
            partner.name = tBox_AddPartner_name.Text;
            partner.adress = tBox_AddPartner_adress.Text;
            partner.headquarters = tBox_AddPartner_headquarters.Text;
            partner.phoneNumber = tBox_AddPartner_phoneNum.Text;
            partner.identificationNumber = tBox_AddPartner_IdentificationNum.Text;
            partner.director = tBox_addPartner_director.Text;
            partner.type = (Enums.PartnerType)cmb_addPartner_type.SelectedItem;

            //Add it do products list
            DeliveryHolder.partners.Add(partner);
            try
            {
                DeliveryClient.InsertPartner(partner);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to insert partner to database");
            }
            

            clearTab(tabPagePartner);
            tBox_addPartner_id.Text = (DeliveryHolder.partners.Count == 0 ? 0 : 
                (from elem in DeliveryHolder.partners select elem.id).Max() + 1).ToString();

        }
        private void AddPartnerToEditForm(Partner partner)
        {
            if (partner == null) { return; }

            tBox_addPartner_id.Text = partner.id.ToString();
            tBox_AddPartner_name.Text = partner.name;
            tBox_AddPartner_adress.Text = partner.adress;
            tBox_addPartner_director.Text = partner.director;
            tBox_AddPartner_headquarters.Text = partner.headquarters;
            tBox_AddPartner_IdentificationNum.Text = partner.identificationNumber;
            tBox_AddPartner_phoneNum.Text = partner.phoneNumber;
            cmb_addPartner_type.SelectedItem = partner.type;
        }
        private void btnSearchPartners_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm(Enums.Searchable.partner);
            searchForm.Location = this.Location;
            searchForm.StartPosition = this.StartPosition;
            searchForm.FormClosing += delegate {
                AddPartnerToEditForm(searchForm.selectedItem<Partner>());
                this.Show();
            };
            searchForm.ShowDialog();
        }
        #endregion

        #region Route
        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            Route route = new Route();
            route.id = int.Parse(tbox_addRoute_id.Text);
            route.startingPoint = (Location)cmb_addRoute_startingPoint.SelectedItem;
            route.destination = (Location)cmb_addRoute_destination.SelectedItem;
            route.distance = double.Parse(tbox_addRoute_distance.Text);
            route.driver = (Worker)cmb_addRoute_driver.SelectedItem;
            route.vehicle = (Vehicle)cmb_addRoute_Vehicle.SelectedItem;
            route.startDate = dtp_addRoute_startDate.Value;
            route.finished = false;

            
            try
            {
                DeliveryHolder.routes.Add(route);
                DeliveryClient.InsertRoute(route);

                clearTab(tabPageRoutes);
                tbox_addRoute_id.Text = DeliveryHolder.routes.Count == 0 ? "1" :
                    (DeliveryHolder.routes.Count + 1).ToString();

                WorkerHolder.avaliableWorkers = WorkerClient.GetAavalibleWorkers();
                DeliveryHolder.avaliableVehicles = DeliveryClient.GetAvalibleVehicles();

                setupRouteCmb();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to add route");
            }
            
        }
        private void btnClearRoute_Click(object sender, EventArgs e)
        {
            clearTab(tabPageRoutes);
            setupRouteCmb();
            tbox_addRoute_id.Text = DeliveryHolder.routes.Count == 0 ? "1" :
                (DeliveryHolder.routes.Count + 1).ToString();
        }
        private void setupRouteCmb ()
        {
            cmb_addRoute_destination.Items.Clear();
            cmb_addRoute_driver.Items.Clear();
            cmb_addRoute_startingPoint.Items.Clear();
            cmb_addRoute_Vehicle.Items.Clear();

            cmb_addRoute_startingPoint.Items.AddRange(DeliveryHolder.locations.ToArray());
            cmb_addRoute_startingPoint.ValueMember = "name";

            cmb_addRoute_destination.Items.AddRange(DeliveryHolder.locations.ToArray());
            cmb_addRoute_destination.ValueMember = "name";

            cmb_addRoute_driver.Items.AddRange(WorkerHolder.avaliableWorkers
                .FindAll((worker) => worker.position == Enums.WorkerPosition.driver)
                .ToArray());
            cmb_addRoute_driver.ValueMember = "surname";

            cmb_addRoute_Vehicle.Items.AddRange(DeliveryHolder.avaliableVehicles.ToArray());
            cmb_addRoute_Vehicle.ValueMember = "registration";
        }
        private void AddRouteToEditForm(Route route)
        {
            if (route == null){return;}
            tbox_addRoute_id.Text = route.id.ToString();
            tbox_addRoute_distance.Text = route.distance.ToString();
            cmb_addRoute_destination.SelectedItem = DeliveryHolder.locations.Find((e) => e.id == route.destination.id);
            cmb_addRoute_startingPoint.SelectedItem = DeliveryHolder.locations.Find((e) => e.id == route.startingPoint.id);
            cmb_addRoute_driver.Items.Add(route.driver);
            cmb_addRoute_driver.SelectedItem = route.driver;
            cmb_addRoute_Vehicle.Items.Add(route.vehicle);
            cmb_addRoute_Vehicle.SelectedItem = route.vehicle;
            dtp_addRoute_startDate.Value = route.startDate;

        }

        private void btn_routesSearchStartingPoint_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm(Enums.Searchable.locations);
            searchForm.Location = this.Location;
            searchForm.StartPosition = this.StartPosition;
            searchForm.FormClosing += delegate {
                cmb_addRoute_startingPoint.SelectedItem = searchForm.selectedItem<Location>();
                this.Show();
            };
            searchForm.ShowDialog();
        }
        private void btn_routesSearchDestination_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm(Enums.Searchable.locations);
            searchForm.Location = this.Location;
            searchForm.StartPosition = this.StartPosition;
            searchForm.FormClosing += delegate {
                cmb_addRoute_destination.SelectedItem = searchForm.selectedItem<Location>();
                this.Show();
            };
            searchForm.ShowDialog();
        }
        private void btn_routesSearchDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm(Enums.Searchable.avaliableDrivers);
            searchForm.Location = this.Location;
            searchForm.StartPosition = this.StartPosition;
            searchForm.FormClosing += delegate {
                cmb_addRoute_driver.SelectedItem = searchForm.selectedItem<Worker>();
                this.Show();
            };
            searchForm.ShowDialog();
        }
        private void btn_routesSearchVehicle_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm(Enums.Searchable.avaliableVehicles);
            searchForm.Location = this.Location;
            searchForm.StartPosition = this.StartPosition;
            searchForm.FormClosing += delegate {
                cmb_addRoute_Vehicle.SelectedItem = searchForm.selectedItem<Vehicle>();
                this.Show();
            };
            searchForm.ShowDialog();
        }


        private void btnSearchRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm(Enums.Searchable.routes);
            searchForm.Location = this.Location;
            searchForm.StartPosition = this.StartPosition;
            searchForm.FormClosing += delegate {
                AddRouteToEditForm(searchForm.selectedItem<Route>());
                this.Show();
            };
            searchForm.ShowDialog();
        }
        #endregion

        #region Vehicle
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.registration = tbox_addVehicle_registration.Text;
            vehicle.cargoSpace = int.Parse(tbox_addVehicle_CarsoSpace.Text);
            vehicle.fuelConsumption = double.Parse(tbox_addVehicle_fuelConsumption.Text);
            vehicle.brand = tbox_addVehicle_brand.Text;
            vehicle.model = tbox_addVehicle_model.Text;

            DeliveryHolder.vehicles.Add(vehicle);
            DeliveryClient.InsertVehicle(vehicle);

            clearTab(tabPageVehicle);
            setupRouteCmb();
        }
        private void btnClearVehicle_Click(object sender, EventArgs e)
        {
            clearTab(tabPageVehicle);
        }
        private void AddVehicleToEditForm(Vehicle vehicle)
        {
            if (vehicle == null) { return; }

            tbox_addVehicle_registration.Text = vehicle.registration;
            tbox_addVehicle_fuelConsumption.Text = vehicle.fuelConsumption.ToString();
            tbox_addVehicle_CarsoSpace.Text = vehicle.cargoSpace.ToString();
            tbox_addVehicle_model.Text = vehicle.model;
            tbox_addVehicle_brand.Text = vehicle.brand;
        }
        private void btnSearchVehicle_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm(Enums.Searchable.vehicles);
            searchForm.Location = this.Location;
            searchForm.StartPosition = this.StartPosition;
            searchForm.FormClosing += delegate {
                AddVehicleToEditForm(searchForm.selectedItem<Vehicle>());
                this.Show();
            };
            searchForm.ShowDialog();
        }
        #endregion

        #region Location
        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            Location location = new Location();

            location.id = int.Parse(tbox_addLocation_id.Text);
            location.name = tbox_addLocation_name.Text;
            location.zipCode = tbox_addLocation_zipCode.Text;
            location.adress = tbox_addLocation_adress.Text;

            try
            {
                DeliveryHolder.locations.Add(location);
                DeliveryClient.InsertLocation(location);

                clearTab(tabPageLocation);
                tbox_addLocation_id.Text = DeliveryHolder.locations.Count == 0 ? "1" :
                    (DeliveryHolder.locations.Count + 1).ToString();

                setupRouteCmb();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to add location");
            }
            

        }
        private void btnClearLocation_Click(object sender, EventArgs e)
        {
            clearTab(tabPageLocation);
            tbox_addLocation_id.Text = DeliveryHolder.locations.Count == 0 ? "1" :
                (DeliveryHolder.locations.Count + 1).ToString();
        }   
        private void AddLocationToEditForm(Location location)
        {
            if (location == null) { return; }

            tbox_addLocation_id.Text = location.id.ToString();
            tbox_addLocation_name.Text = location.name;
            tbox_addLocation_adress.Text = location.adress;
            tbox_addLocation_zipCode.Text = location.zipCode;
        }
        private void btnSearchLocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm(Enums.Searchable.locations);
            searchForm.Location = this.Location;
            searchForm.StartPosition = this.StartPosition;
            searchForm.FormClosing += delegate {
                AddLocationToEditForm(searchForm.selectedItem<Location>());
                this.Show();
            };
            searchForm.ShowDialog();
        }
        #endregion

        #region RouteManager
        private void chb_activeRoutes_CheckedChanged(object sender, EventArgs e)
        {
            refreshRouteManager();
        }

        private void btnMarkAsFinished_Click(object sender, EventArgs e)
        {
            try
            {
                Route selectedRoute = DeliveryHolder.routes
                    .Find((route) => route.id == ((RouteDisplay)dgvRouteManager.Rows[dgvRouteManager.CurrentCell.RowIndex].DataBoundItem).id);
                int index = DeliveryHolder.routes.FindIndex((route) => route.id == selectedRoute.id);
                selectedRoute.finished = true;
                selectedRoute.endDate = dtp_routeManager_endDate.Value;
                DeliveryHolder.routes.RemoveAt(index);
                DeliveryHolder.routes.Add(selectedRoute);

                DeliveryClient.InsertRoute(selectedRoute);


                refreshRouteManager();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to update route");
            }
            
        }

        private void refreshRouteManager()
        {
            if (chbFinisheRoutes.Checked && !chb_activeRoutes.Checked)
            {
                dgvRouteManager.DataSource = RouteHelper.makeRoutesDisplayable(DeliveryHolder.routes.FindAll((route) => route.finished));
            }
            else if (chb_activeRoutes.Checked && !chbFinisheRoutes.Checked)
            {
                dgvRouteManager.DataSource = RouteHelper.makeRoutesDisplayable(DeliveryHolder.routes.FindAll((route) => route.finished == false));
            }
            else if (chbFinisheRoutes.Checked && chb_activeRoutes.Checked)
            {
                dgvRouteManager.DataSource = RouteHelper.makeRoutesDisplayable(DeliveryHolder.routes);
            }
            else
            {
                dgvRouteManager.DataSource = null;
            }
        }
        #endregion

        private void clearTab(TabPage tabPage)
        {
            foreach (TextBox item in tabPage.Controls.OfType<TextBox>())
            {
                if (!item.Name.Contains("id"))
                {
                    item.Text = "";
                }

            }

            foreach (ComboBox item in tabPage.Controls.OfType<ComboBox>())
            {               
                    item.SelectedItem = null;                
            }
        }

        
    }
}
