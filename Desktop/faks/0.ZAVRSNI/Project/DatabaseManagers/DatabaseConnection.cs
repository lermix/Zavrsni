using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagers
{
    public class DatabaseConnection
    {
        protected static string server = "localhost";
        protected static string database = "warehousedatabase";
        protected static string user = "root";
        protected static string password = "root";
        protected static string port = "3306";

        protected static string connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; ", server, port, user, password, database);

    }
}
