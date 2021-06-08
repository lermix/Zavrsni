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
    public class DeliveryManager: DatabaseConnection
    {

        public static List<Partner> GetPartners()
        {
            MySqlCommand cmd = new MySqlCommand("GetAllPartners", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Partner> partners = new List<Partner>();

            while (rdr.Read())
            {
                Partner partner = new Partner();

                partner.id = int.Parse(rdr[0].ToString());
                partner.name = rdr[1].ToString();
                partner.adress = rdr[2].ToString();
                partner.headquarters = rdr[3].ToString();
                partner.phoneNumber = rdr[4].ToString();
                partner.identificationNumber = rdr[5].ToString();
                partner.director = rdr[6].ToString();
                partner.type = rdr[7].ToString() == "0" ? Enums.PartnerType.supplier : Enums.PartnerType.transporter;

                partners.Add(partner);

            }
            rdr.Close();

            return partners;
        }

        public static void InsertPartner(Partner partner)
        {
            List<string> propertyesToIgnore = new List<string> { };

            MySqlCommand cmd = new MySqlCommand("InsertPartner", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (PropertyInfo property in typeof(Partner).GetProperties())
            {
                if (!propertyesToIgnore.Contains(property.Name))
                {
                    cmd.Parameters.Add(new MySqlParameter(("_" + property.Name), property.GetValue(partner)));
                }
            }
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<Vehicle> GetVehicles()
        {
            MySqlCommand cmd = new MySqlCommand("GetAllVehicles", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Vehicle> vehicles = new List<Vehicle>();

            while (rdr.Read())
            {
                Vehicle vehicle = new Vehicle();

                vehicle.registration = rdr[0].ToString();
                vehicle.cargoSpace = int.Parse(rdr[1].ToString());
                vehicle.fuelConsumption = double.Parse(rdr[2].ToString());
                vehicle.brand = rdr[3].ToString();
                vehicle.model = rdr[4].ToString();

                vehicles.Add(vehicle);

            }
            rdr.Close();

            return vehicles;
        }

        public static List<Vehicle> GetAvalibleVehicles()
        {
            MySqlCommand cmd = new MySqlCommand("GetAvalibleVehicles", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Vehicle> vehicles = new List<Vehicle>();

            while (rdr.Read())
            {
                Vehicle vehicle = new Vehicle();

                vehicle.registration = rdr[0].ToString();
                vehicle.cargoSpace = int.Parse(rdr[1].ToString());
                vehicle.fuelConsumption = double.Parse(rdr[2].ToString());
                vehicle.brand = rdr[3].ToString();
                vehicle.model = rdr[4].ToString();

                vehicles.Add(vehicle);

            }
            rdr.Close();

            return vehicles;
        }

        public static void InsertVehicle(Vehicle vehicle)
        {
            List<string> propertyesToIgnore = new List<string> { };

            MySqlCommand cmd = new MySqlCommand("InsertVehicle", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (PropertyInfo property in typeof(Vehicle).GetProperties())
            {
                if (!propertyesToIgnore.Contains(property.Name))
                {
                    cmd.Parameters.Add(new MySqlParameter(("_" + property.Name), property.GetValue(vehicle)));
                }
            }
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<Location> GetLocations()
        {
            MySqlCommand cmd = new MySqlCommand("GetAllLocations", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Location> locations = new List<Location>();

            while (rdr.Read())
            {
                Location location = new Location();

                location.id = int.Parse(rdr[0].ToString());
                location.name = rdr[1].ToString();
                location.zipCode = rdr[2].ToString();
                location.adress = rdr[3].ToString();

                locations.Add(location);

            }
            rdr.Close();

            return locations;
        }

        public static void InsertLocation(Location location)
        {
            List<string> propertyesToIgnore = new List<string> { };

            MySqlCommand cmd = new MySqlCommand("InsertLocation", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (PropertyInfo property in typeof(Location).GetProperties())
            {
                if (!propertyesToIgnore.Contains(property.Name))
                {
                    cmd.Parameters.Add(new MySqlParameter(("_" + property.Name), property.GetValue(location)));
                }
            }
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<Route> GetRoutes()
        {
            MySqlCommand cmd = new MySqlCommand("GetRoutes", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Route> routes = new List<Route>();

            while (rdr.Read())
            {
                Route route = new Route();
                route.startingPoint = new Location();
                route.destination = new Location();
                route.driver = new Worker();
                route.vehicle = new Vehicle();
                route.driver.warehouse = new Warehouse();

                route.id = int.Parse(rdr[0].ToString());

                route.startingPoint.id = int.Parse(rdr[1].ToString());
                route.startingPoint.name = rdr[2].ToString();
                route.startingPoint.zipCode = rdr[3].ToString();
                route.startingPoint.adress = rdr[4].ToString();

                route.destination.id = int.Parse(rdr[5].ToString());
                route.destination.name = rdr[6].ToString();
                route.destination.zipCode = rdr[7].ToString();
                route.destination.adress = rdr[8].ToString();

                route.distance = double.Parse(rdr[9].ToString());

                route.driver.id = int.Parse(rdr[10].ToString());
                route.driver.name = rdr[11].ToString();
                route.driver.surname = rdr[12].ToString();
                route.driver.username = rdr[13].ToString();
                route.driver.dateOfBirth = DateTime.Parse(rdr[14].ToString());
                route.driver.city = rdr[15].ToString();
                route.driver.position = (WorkerPosition)int.Parse(rdr[16].ToString());
                route.driver.warehouse.id = int.Parse(rdr[17].ToString());
                route.driver.warehouse.name = rdr[18].ToString();
                route.driver.warehouse.adress = rdr[19].ToString();
                route.driver.warehouse.capacity = int.Parse(rdr[20].ToString());

                route.vehicle.registration = rdr[21].ToString();
                route.vehicle.cargoSpace = int.Parse(rdr[22].ToString());
                route.vehicle.fuelConsumption = double.Parse(rdr[23].ToString());
                route.vehicle.brand = rdr[24].ToString();
                route.vehicle.model = rdr[25].ToString();

                route.startDate = DateTime.Parse(rdr[26].ToString());
                route.endDate = DateTime.Parse(rdr[27].ToString());
                route.finished = bool.Parse(rdr[28].ToString());

                routes.Add(route);

            }
            rdr.Close();

            return routes;
        }

        public static void InsertRoute(Route route)
        {
            List<string> propertyesToIgnore = new List<string> { "startingPoint", "destination", "driver", "vehicle" };

            MySqlCommand cmd = new MySqlCommand("InsertRoute", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (PropertyInfo property in typeof(Route).GetProperties())
            {
                if (!propertyesToIgnore.Contains(property.Name))
                {
                    cmd.Parameters.Add(new MySqlParameter(("_" + property.Name), property.GetValue(route)));
                }
                if (property.PropertyType == typeof(Location))
                {
                    cmd.Parameters.Add(new MySqlParameter("_" + property.Name, ((Location)property.GetValue(route)).id));
                }
                if (property.PropertyType == typeof(Worker))
                {
                    cmd.Parameters.Add(new MySqlParameter("_" + property.Name, ((Worker)property.GetValue(route)).id));
                }
                if (property.PropertyType == typeof(Vehicle))
                {
                    cmd.Parameters.Add(new MySqlParameter("_" + property.Name, ((Vehicle)property.GetValue(route)).registration));
                }
            }
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }


    }
}
