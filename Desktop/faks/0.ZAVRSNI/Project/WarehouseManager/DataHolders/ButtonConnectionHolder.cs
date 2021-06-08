using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.DataHolders
{
    public static class ButtonConnectionHolder
    {
        public static List<Models.ButtonConnection> connections;

        static ButtonConnectionHolder()
        {
            connections = new List<Models.ButtonConnection>();
        }
    }
}
