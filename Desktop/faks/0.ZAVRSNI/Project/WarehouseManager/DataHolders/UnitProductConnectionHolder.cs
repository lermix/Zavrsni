using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.DataHolders
{
    public static class UnitProductConnectionHolder
    {
        public static List<Models.UnitProductConnection> Connections;

        static UnitProductConnectionHolder()
        {
            Connections = new List<Models.UnitProductConnection>();
        }
    }
}
