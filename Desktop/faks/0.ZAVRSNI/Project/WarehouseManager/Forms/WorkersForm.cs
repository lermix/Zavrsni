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
using WarehouseManager.DataHolders;
using static Models.Enums;

namespace WarehouseManager.Forms
{
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            //Set tab so tab pages aren't displayed
            tabControlWorkers.Appearance = TabAppearance.FlatButtons;
            tabControlWorkers.ItemSize = new System.Drawing.Size(0, 1);
            tabControlWorkers.SizeMode = TabSizeMode.Fixed;

            #region AddWorkerSetup
            cmb_addWorker_position.Items.AddRange(Enum.GetValues(typeof(WorkerPosition)).Cast<Enum>().ToArray());
            cmb_addWorker_warehouse.Items.AddRange(WarehouseHolder.warehouses.ToArray());
            cmb_addWorker_warehouse.ValueMember = "name";

            tbox_addWorker_id.Text = WorkerHolder.workers.Count == 0 ? "1" : (WorkerHolder.workers.Count + 1).ToString();
            #endregion
        }

        #region menuBtns
        private void btnAddWorker_tab_Click(object sender, EventArgs e)
        {
            tabControlWorkers.SelectedTab = tabControlWorkers.TabPages[0];
            btnSearch.Visible = false;
            addWorkerClearTab();
        }
        private void btnEditWorker_Click(object sender, EventArgs e)
        {
            tabControlWorkers.SelectedTab = tabControlWorkers.TabPages[0];
            btnSearch.Visible = true;
            addWorkerClearTab();
        }
        #endregion

        #region AddWorker
        private void btn_addWorkere_complete_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.id = int.Parse(tbox_addWorker_id.Text);
            worker.name = tbox_addWorker_name.Text;
            worker.surname = tbox_addWorker_surname.Text;
            worker.username = tbox_addWorker_username.Text;
            worker.dateOfBirth = dtp_addWorker.Value;
            worker.city = tbox_addWorker_city.Text;
            worker.position = (WorkerPosition)cmb_addWorker_position.SelectedItem;
            worker.warehouse = (Warehouse)cmb_addWorker_warehouse.SelectedItem;

            try
            {
                WorkerHolder.workers.Add(worker);
                WorkerClient.InsertWorker(worker);

                addWorkerClearTab();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to add worker");
            }
            
        }

        private void addWorkerClearTab()
        {
            foreach (TextBox item in tabPageAddWorker.Controls.OfType<TextBox>())
            {
                if (item.Name != "tbox_addWorker_id")
                {
                    item.Text = "";
                }

            }
            foreach (ComboBox item in tabPageAddWorker.Controls.OfType<ComboBox>())
            {
                item.Text = "";                
            }
            tbox_addWorker_id.Text = WorkerHolder.workers.Count == 0 ? "1" : (WorkerHolder.workers.Count + 1).ToString();

        }

        private void addWorkerToForm(Worker worker)
        {
            tbox_addWorker_id.Text = worker.id.ToString();
            tbox_addWorker_name.Text = worker.name;
            tbox_addWorker_surname.Text = worker.surname;
            tbox_addWorker_username.Text = worker.username;
            dtp_addWorker.Value = worker.dateOfBirth;
            tbox_addWorker_city.Text = worker.city;
            cmb_addWorker_position.SelectedItem = worker.position;
            cmb_addWorker_warehouse.SelectedItem = worker.warehouse;
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm(Enums.Searchable.workers);
            searchForm.Location = this.Location;
            searchForm.StartPosition = this.StartPosition;
            searchForm.FormClosing += delegate {
                addWorkerToForm(searchForm.selectedItem<Worker>());
                this.Show();
            };
            searchForm.ShowDialog();
        }

        
    }
}
