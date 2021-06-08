using Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager;
using static Models.DatabaseManagerEnums;

namespace DatabaseManagers
{
    public class WarehouseClient
    {
        public static List<Warehouse> GetWarehouses()
        {
            return TcpClient.sendObject<Warehouse>(new DBMsg(ManagerType.WarehouseManager, "GetWarehouses", ""));
        }

        public static void InsertWarehouse(Warehouse warehouse)
        {
            TcpClient.sendObject<Warehouse>(new DBMsg(ManagerType.WarehouseManager, "InsertWarehouse", JsonConvert.SerializeObject(warehouse)));
        }

        public static List<WarehouseProductConnection> GetWarehouseProductConnection()
        {
            return TcpClient.sendObject<WarehouseProductConnection>(new DBMsg(ManagerType.WarehouseManager, "GetWarehouseProductConnection", ""));
        }

        public static void CreateWarehouseProductConnection(WarehouseProductConnection connection)
        {
            TcpClient.sendObject<WarehouseProductConnection>(new DBMsg(ManagerType.WarehouseManager, "CreateWarehouseProductConnection", JsonConvert.SerializeObject(connection)));
        }
    }
}
