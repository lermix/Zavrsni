using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.DataHolders
{
    public static class DeliveryHolder
    {
        public static List<Models.Partner> partners;
        public static List<Models.Route> routes;
        public static List<Models.Vehicle> vehicles;
        public static List<Models.Location> locations;
        public static List<Models.Vehicle> avaliableVehicles;

        static DeliveryHolder()
        {
            partners = new List<Models.Partner>();
            routes = new List<Models.Route>();
            vehicles = new List<Models.Vehicle>();
            locations = new List<Models.Location>();
            avaliableVehicles = new List<Models.Vehicle>();
        }
    }
}
