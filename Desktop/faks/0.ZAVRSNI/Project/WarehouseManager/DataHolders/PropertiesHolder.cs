using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.DataHolders
{
    public class PropertiesHolder
    {
        public static string distanceUnit { get; set; }
        public static string weightUnit { get; set; }

        PropertiesHolder()
        {
            distanceUnit = "";
            weightUnit = "";
        }
    }
}
