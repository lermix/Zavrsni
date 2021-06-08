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
using WarehouseManager;
using static Models.DatabaseManagerEnums;
using Newtonsoft.Json;

namespace DatabaseManagers
{
    public class ProductClient
    {
   
        public static List<Product> GetProducts()
        {
            return TcpClient.sendObject<Product>(new DBMsg(ManagerType.ProductManager, "GetProducts", ""));
        }

        public static void InsertProduct(Product product)
        {
            TcpClient.sendObject<Product>(new DBMsg(ManagerType.ProductManager, "InsertProduct", JsonConvert.SerializeObject(product)));
        }

        public static void DeleteProduct(int id)
        {
            TcpClient.sendObject<Product>(new DBMsg(ManagerType.ProductManager, "DeleteProduct", JsonConvert.SerializeObject(id)));
        }

        public static void DeleteProductUnitConnection(int productId, int btnId)
        {
            List<int> args = new List<int>();
            args.Add(productId);
            args.Add(btnId);
            TcpClient.sendObject<Product>(new DBMsg(ManagerType.ProductManager, "DeleteProductUnitConnection", JsonConvert.SerializeObject(args)));
        }

        public static void UpdateProduct(Product product)
        {
            TcpClient.sendObject<Product>(new DBMsg(ManagerType.ProductManager, "UpdateProduct", JsonConvert.SerializeObject(product)));
        }

        public static List<ProductLocation> GetProductsWithLocation()
        {
            return TcpClient.sendObject<ProductLocation>(new DBMsg(ManagerType.ProductManager, "GetProductsWithLocation", ""));
        }

    }
}
