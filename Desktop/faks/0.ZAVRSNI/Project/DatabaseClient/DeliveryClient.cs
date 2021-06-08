using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using WarehouseManager;
using static Models.DatabaseManagerEnums;

namespace DatabaseManagers
{
    public class DeliveryClient
    {

        public static List<Partner> GetPartners()
        {
            return TcpClient.sendObject<Partner>(new DBMsg(ManagerType.DeliveryManager, "GetPartners", ""));
        }

        public static void InsertPartner(Partner partner)
        {
            TcpClient.sendObject<Partner>(new DBMsg(ManagerType.DeliveryManager, "InsertPartner", JsonConvert.SerializeObject(partner)));
        }

        public static List<Vehicle> GetVehicles()
        {
            return TcpClient.sendObject<Vehicle>(new DBMsg(ManagerType.DeliveryManager, "GetVehicles", ""));
        }

        public static List<Vehicle> GetAvalibleVehicles()
        {
            return TcpClient.sendObject<Vehicle>(new DBMsg(ManagerType.DeliveryManager, "GetAvalibleVehicles", ""));
        }

        public static void InsertVehicle(Vehicle vehicle)
        {
            TcpClient.sendObject<Vehicle>(new DBMsg(ManagerType.DeliveryManager, "InsertVehicle", JsonConvert.SerializeObject(vehicle)));
        }

        public static List<Location> GetLocations()
        {
            return TcpClient.sendObject<Location>(new DBMsg(ManagerType.DeliveryManager, "GetLocations", ""));
        }

        public static void InsertLocation(Location location)
        {
            TcpClient.sendObject<Location>(new DBMsg(ManagerType.DeliveryManager, "InsertLocation", JsonConvert.SerializeObject(location)));

        }

        public static List<Route> GetRoutes()
        {
            return TcpClient.sendObject<Route>(new DBMsg(ManagerType.DeliveryManager, "GetRoutes", ""));

        }

        public static void InsertRoute(Route route)
        {
            TcpClient.sendObject<Route>(new DBMsg(ManagerType.DeliveryManager, "InsertRoute", JsonConvert.SerializeObject(route)));
        }


    }
}
