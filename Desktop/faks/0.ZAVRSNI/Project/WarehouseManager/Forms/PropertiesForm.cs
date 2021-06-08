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

namespace WarehouseManager.Forms
{
    public partial class PropertiesForm : Form
    {
        public PropertiesForm()
        {
            InitializeComponent();
        }

        private void PropertiesForm_Load(object sender, EventArgs e)
        {
            cmbDistanceUnit.Items.AddRange(Enum.GetValues(typeof(Enums.DistanceUnits)).Cast<Enum>().ToArray());
            cmbWeightUnit.Items.AddRange(Enum.GetValues(typeof(Enums.WeightUnits)).Cast<Enum>().ToArray());
        }

        private void cmbDistanceUnit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PropertiesClient.InsertProperty(new Property(Enums.PropertyName.distance, cmbDistanceUnit.Text));
                PropertiesHolder.distanceUnit = cmbDistanceUnit.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to insert property");
            }
            
        }

        private void cmbWeightUnit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PropertiesClient.InsertProperty(new Property(Enums.PropertyName.weight, cmbWeightUnit.Text));
                PropertiesHolder.weightUnit = cmbWeightUnit.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to insert property");
            }            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
