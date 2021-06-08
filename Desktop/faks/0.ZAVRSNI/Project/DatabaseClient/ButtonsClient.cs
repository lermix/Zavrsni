using Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager;
using static Models.DatabaseManagerEnums;

namespace DatabaseManagers
{
    public class ButtonsClient
    {
        public static void AddButtonToAllButtons(DragButtonTransfer button)
        {
            TcpClient.sendObject<DragButtonTransfer>(new DBMsg(ManagerType.ButtonsManager, "AddButtonToAllButtons", JsonConvert.SerializeObject(button)));
        }

        public static List<DragButtonTransfer> GetButtons()
        {
            return TcpClient.sendObject<DragButtonTransfer>(new DBMsg(ManagerType.ButtonsManager, "GetButtons", ""));
        }

        public static void AddUnitProuductConnection(UnitProductConnection connection)
        {
            TcpClient.sendObject<UnitProductConnection>(new DBMsg(ManagerType.ButtonsManager, "AddUnitProuductConnection", JsonConvert.SerializeObject(connection)));
        }

        public static List<UnitProductConnection> GetUnitPorductConnections()
        {
            return TcpClient.sendObject<UnitProductConnection>(new DBMsg(ManagerType.ButtonsManager, "GetUnitPorductConnections", ""));
        }

        public static List<ButtonConnection> GetButtonConnections()
        {
            return TcpClient.sendObject<ButtonConnection>(new DBMsg(ManagerType.ButtonsManager, "GetButtonConnections", ""));
        }

        public static void AddButtonConnection(ButtonConnection connection)
        {
            TcpClient.sendObject<ButtonConnection>(new DBMsg(ManagerType.ButtonsManager, "AddButtonConnection", JsonConvert.SerializeObject(connection)));
        }

        public static void UpdateUnitProductConnection(int btnId, int productId, double amount)
        {
            List<double> args = new List<double>();
            args.Add(double.Parse(btnId.ToString()));
            args.Add(double.Parse(productId.ToString()));
            args.Add(amount);
            TcpClient.sendObject<UnitProductConnection>(new DBMsg(ManagerType.ButtonsManager, "UpdateUnitProductConnection", JsonConvert.SerializeObject(args)));
        }

        public static void DeleteButtonConnection(int btnId)
        {
            TcpClient.sendObject<ButtonConnection>(new DBMsg(ManagerType.ButtonsManager, "DeleteButtonConnection", JsonConvert.SerializeObject(btnId)));

        }




    }
}
