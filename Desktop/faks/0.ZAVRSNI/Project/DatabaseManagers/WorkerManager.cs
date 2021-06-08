using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Models.Enums;

namespace DatabaseManagers
{
    public class WorkerManager: DatabaseConnection
    {
        public static List<Worker> GetWorkers()
        {
            MySqlCommand cmd = new MySqlCommand("GetAllWorkers", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Worker> workers = new List<Worker>();

            while (rdr.Read())
            {
                Worker worker = new Worker();
                worker.warehouse = new Warehouse();

                worker.id = int.Parse(rdr[0].ToString());
                worker.name = rdr[1].ToString();
                worker.surname = rdr[2].ToString();
                worker.username = rdr[3].ToString();
                worker.dateOfBirth = DateTime.Parse(rdr[4].ToString());
                worker.city = rdr[5].ToString();
                worker.position = (WorkerPosition)int.Parse(rdr[6].ToString());
                worker.warehouse.id = int.Parse(rdr[7].ToString());
                worker.warehouse.name = rdr[8].ToString();
                worker.warehouse.adress = rdr[9].ToString();
                worker.warehouse.capacity = int.Parse(rdr[10].ToString());


                workers.Add(worker);

            }
            rdr.Close();

            return workers;
        }

        public static List<Worker> GetAavalibleWorkers()
        {
            MySqlCommand cmd = new MySqlCommand("GetAavalibleWorkers", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Worker> workers = new List<Worker>();

            while (rdr.Read())
            {
                Worker worker = new Worker();
                worker.warehouse = new Warehouse();

                worker.id = int.Parse(rdr[0].ToString());
                worker.name = rdr[1].ToString();
                worker.surname = rdr[2].ToString();
                worker.username = rdr[3].ToString();
                worker.dateOfBirth = DateTime.Parse(rdr[4].ToString());
                worker.city = rdr[5].ToString();
                worker.position = (WorkerPosition)int.Parse(rdr[6].ToString());
                worker.warehouse.id = int.Parse(rdr[7].ToString());
                worker.warehouse.name = rdr[8].ToString();
                worker.warehouse.adress = rdr[9].ToString();
                worker.warehouse.capacity = int.Parse(rdr[10].ToString());


                workers.Add(worker);

            }
            rdr.Close();

            return workers;
        }

        public static void InsertWorker(Worker worker)

        {
            List<string> propertyesToIgnore = new List<string> { "warehouse" };

            MySqlCommand cmd = new MySqlCommand("InsertWorker", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (PropertyInfo property in typeof(Worker).GetProperties())
            {
                if (!propertyesToIgnore.Contains(property.Name))
                {
                    cmd.Parameters.Add(new MySqlParameter(("_" + property.Name), property.GetValue(worker)));
                }
                if (property.PropertyType == typeof(Warehouse))
                {
                    cmd.Parameters.Add(new MySqlParameter("_warehouseId", ((Warehouse)property.GetValue(worker)).id));


                }
            }

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
