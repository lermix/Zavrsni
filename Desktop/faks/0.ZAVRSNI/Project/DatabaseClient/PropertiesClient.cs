using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using WarehouseManager;
using static Models.DatabaseManagerEnums;

namespace DatabaseManagers
{
    public class PropertiesClient
    {
        public static List<Property> GetProperties()
        {
            return TcpClient.sendObject<Property>(new DBMsg(ManagerType.PropertiesManager, "GetProperties", ""));
        }

        public static void InsertProperty(Property property)
        {
            TcpClient.sendObject<WarehouseProductConnection>(new DBMsg(ManagerType.PropertiesManager, "InsertProperty", JsonConvert.SerializeObject(property)));
        }
    }
}
