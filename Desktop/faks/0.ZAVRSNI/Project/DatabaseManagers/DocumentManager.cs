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
    public class DocumentManager : DatabaseConnection
    {
        public static void insertDocument(Document document)

        {
            List<string> propertyesToIgnore = new List<string> { "products", "supplier", "transporter", "originWarehouse", "destinationWarehouse" };

            MySqlCommand cmdInsertDocument = new MySqlCommand("Insertdocument", new MySqlConnection(connectionString));

            cmdInsertDocument.CommandType = CommandType.StoredProcedure;

            foreach (PropertyInfo property in typeof(Document).GetProperties())
            {
                if (!propertyesToIgnore.Contains(property.Name))
                {
                    cmdInsertDocument.Parameters.Add(new MySqlParameter(("_" + property.Name), property.GetValue(document)));
                }
                if (property.PropertyType == typeof(Partner))
                {
                    if (property.GetValue(document) != null)
                    {
                        cmdInsertDocument.Parameters.Add(new MySqlParameter(("_" + property.Name), ((Partner)property.GetValue(document)).id));
                    }
                    else
                    {
                        cmdInsertDocument.Parameters.Add(new MySqlParameter(("_" + property.Name), null));
                    }                                                          
                }
                if (property.PropertyType == typeof(Warehouse))
                {
                    if (property.GetValue(document) != null)
                    {
                        cmdInsertDocument.Parameters.Add(new MySqlParameter(("_" + property.Name), ((Warehouse)property.GetValue(document)).id));
                    }
                    else
                    {
                        cmdInsertDocument.Parameters.Add(new MySqlParameter(("_" + property.Name), null));
                    }                    
                }
            }
            cmdInsertDocument.Connection.Open();
            cmdInsertDocument.ExecuteNonQuery();
            cmdInsertDocument.Connection.Close();

        }

        public static List<DocumentProductConnection> GetAllDocumnetProductConnections()
        {
            MySqlCommand cmd = new MySqlCommand("GetAllDocumnetProductConnections", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<DocumentProductConnection> connections = new List<DocumentProductConnection>();

            while (rdr.Read())
            {
                DocumentProductConnection connection = new DocumentProductConnection();

                connection.connectionId = int.Parse(rdr[0].ToString());
                connection.documentName =  rdr[1].ToString();
                connection.connectionId = int.Parse(rdr[2].ToString());

                connections.Add(connection);

            }
            rdr.Close();

            return connections;
        }

        public static void InsertDocumentProductConnection(DocumentProductConnection connection)
        {
            List<string> propertyesToIgnore = new List<string> {  };

            MySqlCommand cmdInsertConnection = new MySqlCommand("InsertDocumentProductConnection", new MySqlConnection(connectionString));

            cmdInsertConnection.CommandType = CommandType.StoredProcedure;

            cmdInsertConnection.Parameters.Add(new MySqlParameter(("_id"), connection.connectionId));
            cmdInsertConnection.Parameters.Add(new MySqlParameter(("_document_name"), connection.documentName));
            cmdInsertConnection.Parameters.Add(new MySqlParameter(("_product_id"), connection.productId));
            cmdInsertConnection.Parameters.Add(new MySqlParameter(("_amount"), connection.amount));

            cmdInsertConnection.Connection.Open();
            cmdInsertConnection.ExecuteNonQuery();
            cmdInsertConnection.Connection.Close();

        }
    }
}
