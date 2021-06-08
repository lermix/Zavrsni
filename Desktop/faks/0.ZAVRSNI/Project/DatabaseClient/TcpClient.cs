using Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager
{
    class TcpClient
    {
        const int PORT_NO = 23117;
        const string SERVER_IP = "127.0.0.1";

        private static string returnString;

        public static List<T> sendMsg<T>(string textToSend)
        {
            //---create a TCPClient object at the IP and port no.---
            System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient(SERVER_IP, PORT_NO);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            //---send the text---
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            //---read back the text---
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            returnString = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);

            if (returnString == "null")
            {
                return new List<T>();
            }

            client.Close();

            return JsonConvert.DeserializeObject<List<T>>(returnString);            

        }
        public static List<T> sendObject<T>(DBMsg objectToSend)
        {
            return sendMsg<T>(JsonConvert.SerializeObject(objectToSend));
        }
    }
}
