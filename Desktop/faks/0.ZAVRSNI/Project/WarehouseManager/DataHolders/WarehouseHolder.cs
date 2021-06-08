using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.DataHolders
{
    public static class WarehouseHolder
    {
        public static Warehouse selectedWarehouse;
        public static List<Warehouse> warehouses;
        public static List<WarehouseProductConnection> warehouseProductConnections;

        static WarehouseHolder()
        {
            selectedWarehouse = new Warehouse();
            warehouses = new List<Warehouse>();
            warehouseProductConnections = new List<WarehouseProductConnection>();
        }
    }
}
