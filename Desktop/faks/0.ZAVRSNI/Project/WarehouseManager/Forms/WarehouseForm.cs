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
using Newtonsoft.Json;
using static Models.DatabaseManagerEnums;

namespace WarehouseManager.Forms
{
    public partial class WarehouseForm : Form
    {
        BindingSource source;
        List<ProductDisplay> warehouseProducts;

        public WarehouseForm()
        {
            InitializeComponent();
            tbox_addWarehouse_id.Text = (WarehouseHolder.warehouses.Count == 0 ? 0 : WarehouseHolder.warehouses.Count).ToString();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            //Set tab so tab pages aren't displayed
            warehouseTab.Appearance = TabAppearance.FlatButtons;
            warehouseTab.ItemSize = new System.Drawing.Size(0, 1);
            warehouseTab.SizeMode = TabSizeMode.Fixed;

            tbox_addWarehouse_id.Text = (WarehouseHolder.warehouses.Count == 0 ? 0 : WarehouseHolder.warehouses.Count +1).ToString();
        }

        #region menu buttons
        private void btnAddWarehouse_tab_Click(object sender, EventArgs e)
        {
            warehouseTab.SelectedTab = warehouseTab.TabPages[0];
            btn_addWarehouse_add.Visible = true;
            btn_editWarehosue_search.Visible = false;
            btnSave.Visible = false;
        }
        private void btnEditWarehoseTab_Click(object sender, EventArgs e)
        {
            warehouseTab.SelectedTab = warehouseTab.TabPages[0];
            btn_addWarehouse_add.Visible = false;
            btn_editWarehosue_search.Visible = true;
            btnSave.Visible = true;
        }
        #endregion

        #region tab add/edit warehouse
        private void btn_addWarehouse_add_Click(object sender, EventArgs e)
        {
            try
            {
                Warehouse warehouse = new Warehouse();
                warehouse.id = int.Parse(tbox_addWarehouse_id.Text);
                warehouse.name = tbox_addWarahouse_name.Text;
                warehouse.adress = tbox_addWarehouse_adress.Text;
                warehouse.capacity = int.Parse(tbox_addWarehouse_capacity.Text);

                WarehouseHolder.warehouses.Add(warehouse);
                DatabaseManagers.WarehouseClient.InsertWarehouse(warehouse);
                tbox_addWarehouse_id.Text = (WarehouseHolder.warehouses.Count == 0 ? 0 : WarehouseHolder.warehouses.Count + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to add warehouse");
            }                        
        }
        private void AddWarehouseToEditForm(Warehouse warehouse)
        {
            if (warehouse == null) { return; }

            tbox_addWarehouse_id.Text = warehouse.id.ToString();
            tbox_addWarahouse_name.Text = warehouse.name;
            tbox_addWarehouse_adress.Text = warehouse.adress;
            tbox_addWarehouse_capacity.Text = warehouse.capacity.ToString();
        }
        private void btn_editWarehosue_search_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm(Enums.Searchable.warehouse);
            searchForm.Location = this.Location;
            searchForm.StartPosition = this.StartPosition;
            searchForm.FormClosing += delegate {
                AddWarehouseToEditForm(searchForm.selectedItem<Warehouse>());
                this.Show();
            };
            searchForm.ShowDialog();
        }
        #endregion
    }
}
