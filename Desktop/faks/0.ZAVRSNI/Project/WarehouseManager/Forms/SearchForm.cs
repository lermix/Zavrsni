using DatabaseManagers;
using Models;
using System;
using System.Collections;
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
using static Models.Enums;

namespace WarehouseManager.Forms
{

    public partial class SearchForm : Form
    {
        private Searchable searchable;
        private SearchOption searchOption;

        public SearchForm(Searchable searchable)
        {
            InitializeComponent();

            this.searchable = searchable;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            cmbWhere.Items.AddRange(Enum.GetValues(typeof(SearchOption)).Cast<Enum>().ToArray());
            tboxValue.Enabled = false;
            switch (searchable)
            {
                case Searchable.products:
                    cmbSearchBy.Items.AddRange(typeof(Product).GetProperties().Select(ele => ele.Name).ToArray());
                    dgv.DataSource = ProductsHolder.products;
                    break;
                case Searchable.routes:
                    cmbSearchBy.Items.AddRange(typeof(Route).GetProperties().Select(ele => ele.Name).ToArray());
                    dgv.DataSource = RouteHelper.makeRoutesDisplayable(DeliveryHolder.routes);
                    break;
                case Searchable.workers:
                    cmbSearchBy.Items.AddRange(typeof(Worker).GetProperties().Select(ele => ele.Name).ToArray());
                    dgv.DataSource = WorkerHolder.workers;
                    break;
                case Searchable.avaliableWorkers:
                    cmbSearchBy.Items.AddRange(typeof(Worker).GetProperties().Select(ele => ele.Name).ToArray());
                    dgv.DataSource = WorkerHolder.avaliableWorkers;
                    break;
                case Searchable.locations:
                    cmbSearchBy.Items.AddRange(typeof(Location).GetProperties().Select(ele => ele.Name).ToArray());
                    dgv.DataSource = DeliveryHolder.locations;
                    break;
                case Searchable.vehicles:
                    cmbSearchBy.Items.AddRange(typeof(Location).GetProperties().Select(ele => ele.Name).ToArray());
                    dgv.DataSource = DeliveryHolder.vehicles;
                    break;
                case Searchable.avaliableVehicles:
                    cmbSearchBy.Items.AddRange(typeof(Location).GetProperties().Select(ele => ele.Name).ToArray());
                    dgv.DataSource = DeliveryHolder.avaliableVehicles;
                    break;
                case Searchable.partner:
                    cmbSearchBy.Items.AddRange(typeof(Partner).GetProperties().Select(ele => ele.Name).ToArray());
                    dgv.DataSource = DeliveryHolder.partners;
                    break;
                case Searchable.warehouse:
                    cmbSearchBy.Items.AddRange(typeof(Warehouse).GetProperties().Select(ele => ele.Name).ToArray());
                    dgv.DataSource = WarehouseHolder.warehouses;
                    break;
                case Searchable.avaliableDrivers:
                    cmbSearchBy.Items.AddRange(typeof(Worker).GetProperties().Select(ele => ele.Name).ToArray());
                    dgv.DataSource = WorkerHolder.avaliableWorkers.FindAll((worker) => worker.position == WorkerPosition.driver);
                    break;
                default:
                    break;
            }

        }

        private void tboxValue_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void cmbWhere_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbWhere.Text) || string.IsNullOrEmpty(cmbSearchBy.Text))
            {
                tboxValue.Enabled = false;
                return;
            }
            else
            {
                tboxValue.Enabled = true;
            }
            searchOption = (SearchOption)cmbWhere.SelectedItem;
            refresh();
        }
        private void cmbSearchBy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbWhere.Text) || string.IsNullOrEmpty(cmbSearchBy.Text))
            {
                tboxValue.Enabled = false;
                return;
            }
            else
            {
                tboxValue.Enabled = true;
            }
            refresh();
        }

        public T selectedItem<T>()
        {
            if (dgv.CurrentCell != null)
                if (typeof(T) == typeof(Route))
                {
                    return (T)Convert.ChangeType(DeliveryHolder.routes
                    .Find((route) => route.id == ((RouteDisplay)dgv.Rows[dgv.CurrentCell.RowIndex].DataBoundItem).id), typeof(T));
                }
                else
                {
                    return (T)dgv.Rows[dgv.CurrentCell.RowIndex].DataBoundItem;
                }

            else
                return default(T);
        }



        private void refresh()
        {
            switch (searchOption)
            {
                case SearchOption.StartsWith:
                    switch (searchable)
                    {
                        case Searchable.products:
                            dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbSearchBy.Text, ProductsHolder.products);
                            break;
                        case Searchable.routes:
                            dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbSearchBy.Text, RouteHelper.makeRoutesDisplayable(DeliveryHolder.routes));
                            break;
                        case Searchable.workers:
                            dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.workers);
                            break;
                        case Searchable.avaliableWorkers:
                            dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.avaliableWorkers);
                            break;
                        case Searchable.locations:
                            dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.locations);
                            break;
                        case Searchable.vehicles:
                            dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.vehicles);
                            break;
                        case Searchable.avaliableVehicles:
                            dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.avaliableVehicles);
                            break;
                        case Searchable.partner:
                            dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.partners);
                            break;
                        case Searchable.warehouse:
                            dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbSearchBy.Text, WarehouseHolder.warehouses);
                            break;
                        case Searchable.avaliableDrivers:
                            dgv.DataSource = SearchManager.StartsWith(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.avaliableWorkers.FindAll((worker) => worker.position == WorkerPosition.driver));
                            break;
                        default:
                            break;
                    }
                    break;
                case SearchOption.EndsWith:
                    switch (searchable)
                    {
                        case Searchable.products:
                            dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbSearchBy.Text, ProductsHolder.products);
                            break;
                        case Searchable.routes:
                            dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbSearchBy.Text, RouteHelper.makeRoutesDisplayable(DeliveryHolder.routes));
                            break;
                        case Searchable.workers:
                            dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.workers);
                            break;
                        case Searchable.avaliableWorkers:
                            dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.avaliableWorkers);
                            break;
                        case Searchable.locations:
                            dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.locations);
                            break;
                        case Searchable.vehicles:
                            dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.vehicles);
                            break;
                        case Searchable.avaliableVehicles:
                            dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.avaliableVehicles);
                            break;
                        case Searchable.partner:
                            dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.partners);
                            break;
                        case Searchable.warehouse:
                            dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbSearchBy.Text, WarehouseHolder.warehouses);
                            break;
                        case Searchable.avaliableDrivers:
                            dgv.DataSource = SearchManager.EndsWith(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.avaliableWorkers.FindAll((worker) => worker.position == WorkerPosition.driver));
                            break;
                        default:
                            break;
                    }
                    break;
                case SearchOption.GreaterThan:
                    switch (searchable)
                    {
                        case Searchable.products:
                            dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbSearchBy.Text, ProductsHolder.products);
                            break;
                        case Searchable.routes:
                            dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbSearchBy.Text, RouteHelper.makeRoutesDisplayable(DeliveryHolder.routes));
                            break;
                        case Searchable.workers:
                            dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.workers);
                            break;
                        case Searchable.avaliableWorkers:
                            dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.avaliableWorkers);
                            break;
                        case Searchable.locations:
                            dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.locations);
                            break;
                        case Searchable.vehicles:
                            dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.vehicles);
                            break;
                        case Searchable.avaliableVehicles:
                            dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.avaliableVehicles);
                            break;
                        case Searchable.partner:
                            dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.partners);
                            break;
                        case Searchable.warehouse:
                            dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbSearchBy.Text, WarehouseHolder.warehouses);
                            break;
                        case Searchable.avaliableDrivers:
                            dgv.DataSource = SearchManager.GreaterThan(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.avaliableWorkers.FindAll((worker) => worker.position == WorkerPosition.driver));
                            break;
                        default:
                            break;
                    }
                    break;
                case SearchOption.LessThan:
                    switch (searchable)
                    {
                        case Searchable.products:
                            dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbSearchBy.Text, ProductsHolder.products);
                            break;
                        case Searchable.routes:
                            dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbSearchBy.Text, RouteHelper.makeRoutesDisplayable(DeliveryHolder.routes));
                            break;
                        case Searchable.workers:
                            dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.workers);
                            break;
                        case Searchable.avaliableWorkers:
                            dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.avaliableWorkers);
                            break;
                        case Searchable.locations:
                            dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.locations);
                            break;
                        case Searchable.vehicles:
                            dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.vehicles);
                            break;
                        case Searchable.avaliableVehicles:
                            dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.avaliableVehicles);
                            break;
                        case Searchable.partner:
                            dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbSearchBy.Text, DeliveryHolder.partners);
                            break;
                        case Searchable.warehouse:
                            dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbSearchBy.Text, WarehouseHolder.warehouses);
                            break;
                        case Searchable.avaliableDrivers:
                            dgv.DataSource = SearchManager.LessThan(tboxValue.Text, cmbSearchBy.Text, WorkerHolder.avaliableWorkers.FindAll((worker) => worker.position == WorkerPosition.driver));
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnAddToForm_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells == null)
            {
                MessageBox.Show("Please select row to add");
                return;
            }
            else
            {
                this.Close();
            }
        }

        private IList getList()
        {
            switch (searchable)
            {
                case Searchable.products:
                    return ProductsHolder.products;
                case Searchable.routes:
                    return RouteHelper.makeRoutesDisplayable(DeliveryHolder.routes);
                case Searchable.workers:
                    return WorkerHolder.workers;
                case Searchable.avaliableWorkers:
                    return WorkerHolder.avaliableWorkers;
                case Searchable.locations:
                    return DeliveryHolder.locations;
                case Searchable.vehicles:
                    return DeliveryHolder.vehicles;
                case Searchable.avaliableVehicles:
                    return DeliveryHolder.avaliableVehicles;
                case Searchable.partner:
                    return DeliveryHolder.partners;
                case Searchable.warehouse:
                    return WarehouseHolder.warehouses;
                default:
                    return default;
            }
        }

    }
    
}
