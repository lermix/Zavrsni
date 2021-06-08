using Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager;
using static Models.DatabaseManagerEnums;

namespace DatabaseManagers
{
    public class DocumentClient
    {
        public static void insertDocument(Document document)
        {
            TcpClient.sendObject<Document>(new DBMsg(ManagerType.DocumentManager, "insertDocument", JsonConvert.SerializeObject(document)));

        }

        public static List<DocumentProductConnection> GetAllDocumnetProductConnections()
        {
            return TcpClient.sendObject<DocumentProductConnection>(new DBMsg(ManagerType.DocumentManager, "GetAllDocumnetProductConnections", ""));

        }

        public static void InsertDocumentProductConnection(DocumentProductConnection connection)
        {
            TcpClient.sendObject<DocumentProductConnection>(new DBMsg(ManagerType.DocumentManager, "InsertDocumentProductConnection", JsonConvert.SerializeObject(connection)));
        }
    }
}
