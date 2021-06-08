using Models;
using Models.Reports;
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
    public class ReportClient
    {
        public static List<VehicleReport> GetVehicleReport(DateTime dateFrom, DateTime dateTo)
        {
            List<DateTime> args = new List<DateTime>();
            args.Add(dateFrom);
            args.Add(dateTo);
            return TcpClient.sendObject<VehicleReport>(new DBMsg(ManagerType.ReportManager, "GetVehicleReport", JsonConvert.SerializeObject(args)));
        }

        public static List<WorkerReport> GetWorkerReport(DateTime dateFrom, DateTime dateTo)
        {
            List<DateTime> args = new List<DateTime>();
            args.Add(dateFrom);
            args.Add(dateTo);
            return TcpClient.sendObject<WorkerReport>(new DBMsg(ManagerType.ReportManager, "GetWorkerReport", JsonConvert.SerializeObject(args)));
        }

        public static List<ReceiveReport> GetReceiveReport(DateTime dateFrom, DateTime dateTo)
        {
            List<DateTime> args = new List<DateTime>();
            args.Add(dateFrom);
            args.Add(dateTo);
            return TcpClient.sendObject<ReceiveReport>(new DBMsg(ManagerType.ReportManager, "GetReceiveReport", JsonConvert.SerializeObject(args)));
        }

        public static List<IWReport> GetIWReport(DateTime dateFrom, DateTime dateTo)
        {
            List<DateTime> args = new List<DateTime>();
            args.Add(dateFrom);
            args.Add(dateTo);
            return TcpClient.sendObject<IWReport>(new DBMsg(ManagerType.ReportManager, "GetIWReport", JsonConvert.SerializeObject(args)));
        }

        public static List<WriteOffReport> GetWriteOffReport(DateTime dateFrom, DateTime dateTo)
        {
            List<DateTime> args = new List<DateTime>();
            args.Add(dateFrom);
            args.Add(dateTo);
            return TcpClient.sendObject<WriteOffReport>(new DBMsg(ManagerType.ReportManager, "GetWriteOffReport", JsonConvert.SerializeObject(args)));
        }

        public static List<ReturnToSupplierReport> GetReturnToSupplierReport(DateTime dateFrom, DateTime dateTo)
        {
            List<DateTime> args = new List<DateTime>();
            args.Add(dateFrom);
            args.Add(dateTo);
            return TcpClient.sendObject<ReturnToSupplierReport>(new DBMsg(ManagerType.ReportManager, "GetReturnToSupplierReport", JsonConvert.SerializeObject(args)));
        }
    }
}
