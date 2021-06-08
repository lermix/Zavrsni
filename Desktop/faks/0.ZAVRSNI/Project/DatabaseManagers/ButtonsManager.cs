using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagers
{
    public class ButtonsManager : DatabaseConnection
    {
        public static void AddButtonToAllButtons(DragButtonTransfer button)
        {
            MySqlCommand cmd = new MySqlCommand("AddToAllButtons", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_id", button.Tag));
            cmd.Parameters.Add(new MySqlParameter("_text", button.Text));
            cmd.Parameters.Add(new MySqlParameter("_name", button.Name));
            cmd.Parameters.Add(new MySqlParameter("_x", button.Left));
            cmd.Parameters.Add(new MySqlParameter("_y", button.Top));
            cmd.Parameters.Add(new MySqlParameter("_type", button.Type));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<DragButtonTransfer> GetButtons()
        {
            MySqlCommand cmd = new MySqlCommand("GetButtons", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<DragButtonTransfer> buttons = new List<DragButtonTransfer>();

            while (rdr.Read())
            {
                DragButtonTransfer button = new DragButtonTransfer();

                button.Tag = int.Parse(rdr[0].ToString());
                button.Text = rdr[1].ToString();
                button.Name = rdr[2].ToString();
                button.Left = int.Parse(rdr[3].ToString());
                button.Top = int.Parse(rdr[4].ToString());
                button.Type = rdr[5].ToString() == "0" ? Enums.ButtonTypes.Unit : Enums.ButtonTypes.Collection;

                buttons.Add(button);

            }
            rdr.Close();

            return buttons;
        }

        public static void AddUnitProuductConnection(UnitProductConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("CreateUnitProductConnection", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_bondID", connection.ConnectionId));
            cmd.Parameters.Add(new MySqlParameter("_btnID", connection.ButtonId));
            cmd.Parameters.Add(new MySqlParameter("_productID", connection.ProductId));
            cmd.Parameters.Add(new MySqlParameter("_amount", connection.amount));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<UnitProductConnection> GetUnitPorductConnections()
        {
            MySqlCommand cmd = new MySqlCommand("GetUnitProductConnection", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<UnitProductConnection> connections = new List<UnitProductConnection>();

            while (rdr.Read())
            {
                UnitProductConnection connection = new UnitProductConnection();

                connection.ConnectionId = int.Parse(rdr[0].ToString());
                connection.ButtonId = int.Parse(rdr[1].ToString());
                connection.ProductId = int.Parse(rdr[2].ToString());
                connection.amount = double.Parse(rdr[3].ToString());

                connections.Add(connection);
            }
            rdr.Close();

            return connections;
        }

        public static List<ButtonConnection> GetButtonConnections()
        {
            MySqlCommand cmd = new MySqlCommand("GetButtonConnections", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<ButtonConnection> connections = new List<ButtonConnection>();

            while (rdr.Read())
            {
                ButtonConnection connection = new ButtonConnection();

                connection.ConnectionID = int.Parse(rdr[0].ToString());
                connection.CollectionButtonId = int.Parse(rdr[1].ToString());
                connection.UnitButtonID = int.Parse(rdr[2].ToString());

                connections.Add(connection);
            }
            rdr.Close();

            return connections;
        }

        public static void AddButtonConnection(ButtonConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("CreateButtonConnection", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_bondID", connection.ConnectionID));
            cmd.Parameters.Add(new MySqlParameter("_collection_btnID", connection.CollectionButtonId));
            cmd.Parameters.Add(new MySqlParameter("_unit_buttonID", connection.UnitButtonID));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static void UpdateUnitProductConnection(int btnId, int productId, double amount)
        {
            MySqlCommand cmd = new MySqlCommand("UpdateButtonConnection", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_btnId", btnId));
            cmd.Parameters.Add(new MySqlParameter("_productId", productId));
            cmd.Parameters.Add(new MySqlParameter("_amount", amount));


            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void DeleteButtonConnection(int btnId)
        {
            MySqlCommand cmd = new MySqlCommand("DeleteButtonConnection", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_btnId", btnId));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }




    }
}
