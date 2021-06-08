using Models.Reports;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagers
{
    public class ReportManager : DatabaseConnection
    {
        public static List<VehicleReport> GetVehicleReport(DateTime dateFrom, DateTime dateTo)
        {
            MySqlCommand cmd = new MySqlCommand("GetVehicleReport", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter(("_dateFrom"), dateFrom));
            cmd.Parameters.Add(new MySqlParameter(("_dateTo"), dateTo));


            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);            

            List<VehicleReport> vehicleReports = new List<VehicleReport>();

            while (rdr.Read())
            {
                VehicleReport vehicleReport = new VehicleReport();
                
                vehicleReport.vehicleRegistration = rdr[0].ToString();
                vehicleReport.vehicleBrand = rdr[1].ToString();
                vehicleReport.vehicleModel = rdr[2].ToString();
                vehicleReport.fuelConsumption = double.Parse(rdr[3].ToString());
                vehicleReport.totalDistance = double.Parse(rdr[4].ToString());

                vehicleReports.Add(vehicleReport);

            }
            rdr.Close();

            return vehicleReports;
        }

        public static List<WorkerReport> GetWorkerReport(DateTime dateFrom, DateTime dateTo)
        {
            MySqlCommand cmd = new MySqlCommand("GetWorkerReport", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter(("_dateFrom"), dateFrom));
            cmd.Parameters.Add(new MySqlParameter(("_dateTo"), dateTo));


            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<WorkerReport> workerReports = new List<WorkerReport>();

            while (rdr.Read())
            {
                WorkerReport workerReport = new WorkerReport();

                workerReport.workerName = rdr[0].ToString();
                workerReport.workerSurname = rdr[1].ToString();
                workerReport.date = DateTime.Parse(rdr[2].ToString());
                workerReport.distance = double.Parse(rdr[3].ToString());

                workerReports.Add(workerReport);

            }
            rdr.Close();

            return workerReports;
        }

        public static List<ReceiveReport> GetReceiveReport(DateTime dateFrom, DateTime dateTo)
        {
            MySqlCommand cmd = new MySqlCommand("GetReceiveReport", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter(("_dateFrom"), dateFrom));
            cmd.Parameters.Add(new MySqlParameter(("_dateTo"), dateTo));


            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<ReceiveReport> receiveReports = new List<ReceiveReport>();

            while (rdr.Read())
            {
                ReceiveReport receive = new ReceiveReport();

                receive.documentName = rdr[0].ToString();
                receive.remark = rdr[1].ToString();
                receive.date = DateTime.Parse(rdr[2].ToString());
                receive.supplierName = rdr[3].ToString();
                receive.transporterName = rdr[4].ToString();
                

                receiveReports.Add(receive);

            }
            rdr.Close();

            return receiveReports;
        }

        public static List<IWReport> GetIWReport(DateTime dateFrom, DateTime dateTo)
        {
            MySqlCommand cmd = new MySqlCommand("GetIWReport", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter(("_dateFrom"), dateFrom));
            cmd.Parameters.Add(new MySqlParameter(("_dateTo"), dateTo));


            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<IWReport> IwReports = new List<IWReport>();

            while (rdr.Read())
            {
                IWReport IWReport = new IWReport();

                IWReport.documentName = rdr[0].ToString();
                IWReport.remark = rdr[1].ToString();
                IWReport.date = DateTime.Parse(rdr[2].ToString());
                IWReport.destinationWarehouse = rdr[3].ToString();
                IWReport.originWarehouse = rdr[4].ToString();


                IwReports.Add(IWReport);

            }
            rdr.Close();

            return IwReports;
        }

        public static List<WriteOffReport> GetWriteOffReport(DateTime dateFrom, DateTime dateTo)
        {
            MySqlCommand cmd = new MySqlCommand("GetWriteOffReport", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter(("_dateFrom"), dateFrom));
            cmd.Parameters.Add(new MySqlParameter(("_dateTo"), dateTo));


            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<WriteOffReport> writeOffReports = new List<WriteOffReport>();

            while (rdr.Read())
            {
                WriteOffReport writeOffReport = new WriteOffReport();

                writeOffReport.documentName = rdr[0].ToString();
                writeOffReport.remark = rdr[1].ToString();
                writeOffReport.date = DateTime.Parse(rdr[2].ToString());

                writeOffReports.Add(writeOffReport);

            }
            rdr.Close();

            return writeOffReports;
        }

        public static List<ReturnToSupplierReport> GetReturnToSupplierReport(DateTime dateFrom, DateTime dateTo)
        {
            MySqlCommand cmd = new MySqlCommand("GetReturnToSupplierReport", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter(("_dateFrom"), dateFrom));
            cmd.Parameters.Add(new MySqlParameter(("_dateTo"), dateTo));


            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<ReturnToSupplierReport> returns = new List<ReturnToSupplierReport>();

            while (rdr.Read())
            {
                ReturnToSupplierReport returnToSupplier = new ReturnToSupplierReport();

                returnToSupplier.documentName = rdr[0].ToString();
                returnToSupplier.remark = rdr[1].ToString();
                returnToSupplier.date = DateTime.Parse(rdr[2].ToString());
                returnToSupplier.supplierName = rdr[3].ToString();

                returns.Add(returnToSupplier);

            }
            rdr.Close();

            return returns;
        }
    }
}
