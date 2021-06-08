using Models.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.DataHolders
{
    public static class ReportHolder
    {
        public static List<VehicleReport> vehicleReports;
        public static List<Models.RouteDisplay> routeDisplays;
        public static List<WorkerReport> workerReports;
        public static List<ReceiveReport> receiveReports;
        public static List<WriteOffReport> writeOffReports;
        public static List<IWReport> iWReports;
        public static List<ReturnToSupplierReport> returnReports;



        static ReportHolder()
        {            
            vehicleReports = new List<Models.Reports.VehicleReport>();
            routeDisplays = new List<Models.RouteDisplay>();
            workerReports = new List<WorkerReport>();
            receiveReports = new List<ReceiveReport>();
            writeOffReports = new List<WriteOffReport>();
            iWReports = new List<IWReport>();
            returnReports = new List<ReturnToSupplierReport>();
        }
    }
}
