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
using static Models.Enums;

namespace DatabaseManagers
{
    public class WorkerClient
    {
        public static List<Worker> GetWorkers()
        {
            return TcpClient.sendObject<Worker>(new DBMsg(ManagerType.WorkerManager, "GetWorkers", ""));
        }

        public static List<Worker> GetAavalibleWorkers()
        {
            return TcpClient.sendObject<Worker>(new DBMsg(ManagerType.WorkerManager, "GetAavalibleWorkers", ""));
        }

        public static void InsertWorker(Worker worker)
        {
            TcpClient.sendObject<Worker>(new DBMsg(ManagerType.WorkerManager, "InsertWorker", JsonConvert.SerializeObject(worker)));
        }
    }
}
