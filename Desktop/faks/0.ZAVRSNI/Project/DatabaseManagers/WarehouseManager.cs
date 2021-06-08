using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagers
{
    public class WarehouseManager: DatabaseConnection
    {
        public static List<Warehouse> GetWarehouses()
        {
            MySqlCommand cmd = new MySqlCommand("GetWarehouses", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Warehouse> warehouses = new List<Warehouse>();

            while (rdr.Read())
            {
                Warehouse warehouse = new Warehouse();

                warehouse.id = int.Parse(rdr[0].ToString());
                warehouse.name = rdr[1].ToString();
                warehouse.adress = rdr[2].ToString();
                warehouse.capacity = int.Parse(rdr[3].ToString());
                
                warehouses.Add(warehouse);

            }
            rdr.Close();

            return warehouses;
        }

        public static void InsertWarehouse(Warehouse warehouse)
        {
            List<string> propertyesToIgnore = new List<string> { };

            MySqlCommand cmd = new MySqlCommand("InsertWarehouse", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (PropertyInfo property in typeof(Warehouse).GetProperties())
            {
                if (!propertyesToIgnore.Contains(property.Name))
                {
                    cmd.Parameters.Add(new MySqlParameter(("_" + property.Name), property.GetValue(warehouse)));
                }
            }
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<WarehouseProductConnection> GetWarehouseProductConnection()
        {
            MySqlCommand cmd = new MySqlCommand("GetWarehouseProductConnection", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<WarehouseProductConnection> connections = new List<WarehouseProductConnection>();

            while (rdr.Read())
            {
                WarehouseProductConnection connection = new WarehouseProductConnection();

                connection.connectionId = int.Parse(rdr[0].ToString());
                connection.warehouseId = int.Parse(rdr[1].ToString());
                connection.productId = int.Parse(rdr[2].ToString());
                connection.amount = double.Parse(rdr[3].ToString());

                connections.Add(connection);

            }
            rdr.Close();

            return connections;
        }

        public static void CreateWarehouseProductConnection(WarehouseProductConnection connection)
        {
            List<string> propertyesToIgnore = new List<string> { };

            MySqlCommand cmd = new MySqlCommand("CreateWarehouseProductConnection", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (PropertyInfo property in typeof(WarehouseProductConnection).GetProperties())
            {
                if (!propertyesToIgnore.Contains(property.Name))
                {
                    cmd.Parameters.Add(new MySqlParameter(("_" + property.Name), property.GetValue(connection)));
                }
            }
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
