using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Models;

namespace DatabaseManagers
{
    public class ProductManager : DatabaseConnection
    {
   
        public static List<Product> GetProducts()
        {
            MySqlCommand cmd = new MySqlCommand("GetAllProducts", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Product> products = new List<Product>();

            while (rdr.Read())
            {
                Product product = new Product();

                product.id = int.Parse(rdr[0].ToString());
                product.name = rdr[1].ToString();
                product.description = rdr[2].ToString();
                product.purchasePrice = double.Parse(rdr[3].ToString());
                product.sellingPrice = double.Parse(rdr[4].ToString());
                product.size.x = double.Parse(rdr[5].ToString());
                product.size.y = double.Parse(rdr[6].ToString());
                product.size.z = double.Parse(rdr[7].ToString());
                product.weight = double.Parse(rdr[10].ToString());
                product.dateOfArival = DateTime.Parse(rdr[9].ToString());
                product.dateOfShipment = DateTime.Parse(rdr[8].ToString());
                product.numberAvalible = double.Parse(rdr[11].ToString());
                product.barcode = rdr[12].ToString();

                products.Add(product);

            }
            rdr.Close();

            return products;
        }

        public static void InsertProduct(Product product)

        {
            List<string> propertyesToIgnore = new List<string> { "mesuringUnit", "size" };

            MySqlCommand cmd = new MySqlCommand("InsertProduct", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (PropertyInfo property in typeof(Product).GetProperties())
            {
                if (!propertyesToIgnore.Contains(property.Name))
                {
                    cmd.Parameters.Add(new MySqlParameter(("_"+property.Name), property.GetValue(product)));
                }
                if (property.PropertyType == typeof(Size))
                {
                    Size temp = ((Size)property.GetValue(product));
                    cmd.Parameters.Add(new MySqlParameter("_sizeX", temp.x));
                    cmd.Parameters.Add(new MySqlParameter("_sizeY", temp.y));
                    cmd.Parameters.Add(new MySqlParameter("_sizeZ", temp.z));

                }                
            }

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }         
        

        public static int DeleteProduct(int id)

        {

            MySqlCommand cmd = new MySqlCommand("DeleteProduct", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_id", id));

            cmd.Connection.Open();

            int i = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return i;

        }

        public static int DeleteProductUnitConnection(int productId, int btnId)

        {
            MySqlCommand cmd = new MySqlCommand("DeleteProductUnitConnection", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_productID", productId));
            cmd.Parameters.Add(new MySqlParameter("_btnId", btnId));

            cmd.Connection.Open();

            int i = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return i;

        }

        public static int UpdateProduct(Product product)

        {
            MySqlCommand cmd = new MySqlCommand("UpdateProduct", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_id", product.id));
            cmd.Parameters.Add(new MySqlParameter("_name", product.name));
            cmd.Parameters.Add(new MySqlParameter("_description", product.description));
            cmd.Parameters.Add(new MySqlParameter("_purchasePrice", product.purchasePrice));
            cmd.Parameters.Add(new MySqlParameter("_sellingPrice", product.sellingPrice));
            cmd.Parameters.Add(new MySqlParameter("_sizeX", product.size.x));
            cmd.Parameters.Add(new MySqlParameter("_sizeY", product.size.y));
            cmd.Parameters.Add(new MySqlParameter("_sizeZ", product.size.z));
            cmd.Parameters.Add(new MySqlParameter("_weight", product.weight));
            cmd.Parameters.Add(new MySqlParameter("_dateOfArival", product.dateOfArival));
            cmd.Parameters.Add(new MySqlParameter("_dateOfShipment", product.dateOfShipment));
            cmd.Parameters.Add(new MySqlParameter("_numberAvalible", product.numberAvalible));
            cmd.Parameters.Add(new MySqlParameter("_barcode", product.barcode));

            cmd.Connection.Open();

            int i = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return i;

        }

        public static List<ProductLocation> GetProductsWithLocation()
        {
            MySqlCommand cmd = new MySqlCommand("GetProductsWithLocation", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<ProductLocation> productsLocation = new List<ProductLocation>();

            while (rdr.Read())
            {
                Product product = new Product();
               

                product.id = int.Parse(rdr[0].ToString());
                product.name = rdr[1].ToString();
                product.description = rdr[2].ToString();
                product.purchasePrice = double.Parse(rdr[3].ToString());
                product.sellingPrice = double.Parse(rdr[4].ToString());
                product.size.x = double.Parse(rdr[5].ToString());
                product.size.y = double.Parse(rdr[6].ToString());
                product.size.z = double.Parse(rdr[7].ToString());
                product.weight = double.Parse(rdr[10].ToString());
                product.dateOfArival = DateTime.Parse(rdr[9].ToString());
                product.dateOfShipment = DateTime.Parse(rdr[8].ToString());
                product.numberAvalible = double.Parse(rdr[11].ToString());
                product.barcode = rdr[12].ToString();

                ProductLocation productLocation = new ProductLocation
                    (
                    product,
                    int.Parse(rdr[13].ToString()),
                    int.Parse(rdr[14].ToString()),
                    rdr[15].ToString()
                     );

                productsLocation.Add(productLocation);

            }
            rdr.Close();

            return productsLocation;
        }

    }
}
