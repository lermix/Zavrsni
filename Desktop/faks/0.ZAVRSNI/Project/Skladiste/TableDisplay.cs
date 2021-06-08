using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste
{
    public partial class TableDisplay : Form
    {
        public TableDisplay()
        {
            InitializeComponent();
        }

        private void TableDisplay_Load(object sender, EventArgs e)
        {
            Product product1 = new Product();
            product1.id = 0;
            product1.name = "greda";
            product1.description = "160x150x3000mm hrastovina";
            product1.purchasePrice = 100;
            product1.sellingPrice = 150;
            product1.size = 0.072;
            product1.mesuringUnit = "m^2";
            product1.weight = 20;
            product1.dateOfArival = DateTime.Now;
            product1.dateOfShipment = new DateTime(2021, 02, 25);
            product1.numberAvalible = 10;

            dgvSetForObjectType(typeof(Product));
            dgvAddObject<Product>(product1);
        }

        private void dgvSetForObjectType(Type objectType, DataGridView dgv)
        {
            var properties = objectType.GetProperties();
            dgv.ColumnCount = properties.Length;
            for (int i = 0; i < properties.Length; i++)
            {
                dgv.Columns[i].Name = properties[i].Name;
            }
        }

        private void dgvAddObject<T>(T objectToAdd, DataGridView dgv)
        {
            var properties = typeof(T).GetProperties();

            string[] propertiesValues = new string[properties.Length];

            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].PropertyType == typeof(DateTime))
                {
                    DateTime date = (DateTime)properties[i].GetValue(objectToAdd);
                    propertiesValues[i] = (date.ToString("dd-mm-yyyy"));
                }
                if (properties[i].PropertyType != typeof(string))
                {
                    propertiesValues[i] = (properties[i].GetValue(objectToAdd).ToString());
                }
                else
                {
                    propertiesValues[i] = (string)properties[i].GetValue(objectToAdd);
                }                
            }

            dgv.Rows.Add(propertiesValues);
        }
    }
}
