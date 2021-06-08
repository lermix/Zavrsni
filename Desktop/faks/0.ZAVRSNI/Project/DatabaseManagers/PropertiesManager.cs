using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace DatabaseManagers
{
    public class PropertiesManager : DatabaseConnection
    {
        public static List<Property> GetProperties()
        {
            MySqlCommand cmd = new MySqlCommand("GetProperties", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Property> properties = new List<Property>();

            while (rdr.Read())
            {
                Property property = new Property();

                property.name = (Enums.PropertyName)int.Parse(rdr[0].ToString());
                property.value = rdr[1].ToString();


                properties.Add(property);

            }
            rdr.Close();

            return properties;
        }

        public static void InsertProperty(Property property)

        {
            MySqlCommand cmd = new MySqlCommand("InsertProperty", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_name", property.name));
            cmd.Parameters.Add(new MySqlParameter("_value", property.value));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
