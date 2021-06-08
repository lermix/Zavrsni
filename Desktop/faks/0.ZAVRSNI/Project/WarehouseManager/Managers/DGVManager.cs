using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManager.Managers
{
    public static class DGVManager
    {
        public static void dgvSetForObjectType(Type objectType, DataGridView dgv)
        {
            var properties = objectType.GetProperties();
            dgv.ColumnCount = properties.Length;
            for (int i = 0; i < properties.Length; i++)
            {
                dgv.Columns[i].Name = properties[i].Name;
            }
        }

        public static void dgvAddObject<T>(T objectToAdd, DataGridView dgv)
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
