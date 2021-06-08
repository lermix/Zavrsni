using DatabaseManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Models;
using static Models.DatabaseManagerEnums;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using Newtonsoft.Json;

namespace kolokvij
{
    class Program
    {
        const int PORT_NO = 23117;
        const string SERVER_IP = "127.0.0.1";

        static IList returnValue;

        static void Main(string[] args)
        {
            //---listen at the specified IP and port no.---
            IPAddress localAdd = IPAddress.Parse(SERVER_IP);
            TcpListener listener = new TcpListener(localAdd, PORT_NO);

            Console.WriteLine("Listening...");
            listener.Start();

            while (true)
            {

                //---incoming client connected---
                TcpClient client = listener.AcceptTcpClient();

                //---get the incoming data through a network stream---
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                //---read incoming stream---
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

                //---convert the data received into a string---
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received \n: " + dataReceived);


                DBMsg msg = JsonConvert.DeserializeObject<DBMsg>(dataReceived);

                


                switch (msg.manager)
                {                                            
                    case ManagerType.WarehouseManager:
                        Type warehouseManagerClass = typeof(WarehouseManager);
                        returnValue = null;
                        //RECEIVE
                        //No parametar
                        if (string.IsNullOrEmpty(msg.value))
                        {                            
                            returnValue = (IList)warehouseManagerClass.GetMethod(msg.function)
                                .Invoke(warehouseManagerClass, new object[] { }); 
                        }
                        //Parametar
                        else
                        {
                            if (msg.function.ToLower().Contains("connection"))
                            {
                                returnValue = (IList)warehouseManagerClass.GetMethod(msg.function)
                                .Invoke(warehouseManagerClass, new object[] { JsonConvert.DeserializeObject<WarehouseProductConnection>(msg.value) }); 
                            }
                            else
                            {
                                returnValue = (IList)warehouseManagerClass.GetMethod(msg.function)
                                .Invoke(warehouseManagerClass, new object[] { JsonConvert.DeserializeObject<Warehouse>(msg.value) });
                            }
                            
                        }                 
                       
                        break;
                    case ManagerType.WorkerManager:
                        Type WorkerManagerClass = typeof(WorkerManager);
                        returnValue = null;
                        //RECEIVE
                        //No parametar
                        if (string.IsNullOrEmpty(msg.value))
                        {
                            returnValue = (IList)WorkerManagerClass.GetMethod(msg.function)
                                .Invoke(WorkerManagerClass, new object[] { }); 
                        }
                        //Parametar
                        else
                        {
                            returnValue = (IList)WorkerManagerClass.GetMethod(msg.function)
                            .Invoke(WorkerManagerClass, new object[] { JsonConvert.DeserializeObject<Worker>(msg.value) }); 
                        }
                        
                        break;
                    case ManagerType.ReportManager:
                        Type ReportManagerClass = typeof(ReportManager);
                        List<DateTime> arguments = JsonConvert.DeserializeObject<List<DateTime>>(msg.value);
                        //RECEIVE
                            returnValue = (IList)ReportManagerClass.GetMethod(msg.function)
                            .Invoke(ReportManagerClass, new object[] { arguments[0], arguments[1] }); 
                        break;
                    case ManagerType.PropertiesManager:
                        Type PropertiesManagerClass = typeof(PropertiesManager);
                        returnValue = null;
                        //RECEIVE
                        //No parametar
                        if (string.IsNullOrEmpty(msg.value))
                        {
                            returnValue = (IList)PropertiesManagerClass.GetMethod(msg.function)
                                .Invoke(PropertiesManagerClass, new object[] { }); 
                        }
                        //Parametar
                        else
                        {
                            returnValue = (IList)PropertiesManagerClass.GetMethod(msg.function)
                            .Invoke(PropertiesManagerClass, new object[] { JsonConvert.DeserializeObject<Property>(msg.value) }); 
                        }
                        break;
                    case ManagerType.ProductManager:
                        Type ProductManagerClass = typeof(ProductManager);
                        returnValue = null;
                        //RECEIVE
                        //No parametar
                        if (string.IsNullOrEmpty(msg.value))
                        {
                            returnValue = (IList)ProductManagerClass.GetMethod(msg.function)
                                .Invoke(ProductManagerClass, new object[] { }); 
                        }
                        //Special case
                        else if(msg.function == "DeleteProductUnitConnection")
                        {                            
                            List<int> argumentsProduct = JsonConvert.DeserializeObject<List<int>>(msg.value);
                            ProductManagerClass.GetMethod(msg.function)
                            .Invoke(ProductManagerClass, new object[] { argumentsProduct[0], argumentsProduct[1] }); ;
                        }
                        //special case
                        else if(msg.function == "DeleteProduct")
                        {
                            ProductManagerClass.GetMethod(msg.function)
                            .Invoke(ProductManagerClass, new object[] { JsonConvert.DeserializeObject<int>(msg.value) });
                        }
                        //Parametar
                        else
                        {
                            returnValue = (IList)ProductManagerClass.GetMethod(msg.function)
                            .Invoke(ProductManagerClass, new object[] { JsonConvert.DeserializeObject<Product>(msg.value) }); 
                        }
                        break;
                    case ManagerType.DeliveryManager:
                        Type DeliveryManagerClass = typeof(DeliveryManager);
                        returnValue = null;
                        //RECEIVE
                        //No parametar
                        if (string.IsNullOrEmpty(msg.value))
                        {
                            returnValue = (IList)DeliveryManagerClass.GetMethod(msg.function)
                                .Invoke(DeliveryManagerClass, new object[] { });
                        }
                        //Parametar
                        else
                        {
                            switch (msg.function)
                            {
                                case "InsertPartner":
                                    returnValue = (IList)DeliveryManagerClass.GetMethod(msg.function)
                            .Invoke(DeliveryManagerClass, new object[] { JsonConvert.DeserializeObject<Partner>(msg.value) });
                                    break;
                                case "InsertVehicle":
                                    returnValue = (IList)DeliveryManagerClass.GetMethod(msg.function)
                            .Invoke(DeliveryManagerClass, new object[] { JsonConvert.DeserializeObject<Vehicle>(msg.value) });
                                    break;
                                case "InsertLocation":
                                    returnValue = (IList)DeliveryManagerClass.GetMethod(msg.function)
                            .Invoke(DeliveryManagerClass, new object[] { JsonConvert.DeserializeObject<Location>(msg.value) });
                                    break;
                                case "InsertRoute":
                                    returnValue = (IList)DeliveryManagerClass.GetMethod(msg.function)
                            .Invoke(DeliveryManagerClass, new object[] { JsonConvert.DeserializeObject<Route>(msg.value) });
                                    break;
                                default:
                                    break;
                            }                            
                        }
                        break;
                    case ManagerType.ButtonsManager:
                        Type ButtonManagerClass = typeof(ButtonsManager);
                        returnValue = null;
                        //RECEIVE
                        //No parametar
                        if (string.IsNullOrEmpty(msg.value))
                        {
                            returnValue = (IList)ButtonManagerClass.GetMethod(msg.function)
                                .Invoke(ButtonManagerClass, new object[] { });
                        }
                        //Special case
                        else if (msg.function == "UpdateUnitProductConnection")
                        {
                            List<double> argumentsButton = JsonConvert.DeserializeObject<List<double>>(msg.value);
                            ButtonManagerClass.GetMethod(msg.function)
                            .Invoke(ButtonManagerClass, new object[] { int.Parse(argumentsButton[0].ToString()), int.Parse(argumentsButton[1].ToString()), argumentsButton[2] }); ;
                        }
                        //Parametar
                        else
                        {
                            switch (msg.function)
                            {
                                case "AddButtonToAllButtons":
                                    returnValue = (IList)ButtonManagerClass.GetMethod(msg.function)
                                        .Invoke(ButtonManagerClass, new object[] { JsonConvert.DeserializeObject<DragButtonTransfer>(msg.value) });
                                    break;
                                case "AddUnitProuductConnection":
                                    returnValue = (IList)ButtonManagerClass.GetMethod(msg.function)
                                        .Invoke(ButtonManagerClass, new object[] { JsonConvert.DeserializeObject<UnitProductConnection>(msg.value) });
                                    break;
                                case "AddButtonConnection":
                                    returnValue = (IList)ButtonManagerClass.GetMethod(msg.function)
                                        .Invoke(ButtonManagerClass, new object[] { JsonConvert.DeserializeObject<ButtonConnection>(msg.value) });
                                    break;
                                case "DeleteButtonConnection":
                                    returnValue = (IList)ButtonManagerClass.GetMethod(msg.function)
                                        .Invoke(ButtonManagerClass, new object[] { JsonConvert.DeserializeObject<int>(msg.value) });
                                    break;
                                default:
                                    break;
                            }
                            
                        }

                        break;
                    default:
                        break;
                }


                //---write back the text to the client---
                //RETURN
                if (returnValue != null)
                {
                    byte[] responseBuffer = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(returnValue));
                    nwStream.Write(responseBuffer, 0, responseBuffer.Length);
                    Console.WriteLine("RETURNIG: \n" + JsonConvert.SerializeObject(returnValue));
                }
                else
                {
                    byte[] responseBuffer = Encoding.ASCII.GetBytes("null");
                    nwStream.Write(responseBuffer, 0, responseBuffer.Length);
                    Console.WriteLine("RETURNIG: null");
                }

            }

            //client.Close();
            //listener.Stop();
            //Console.ReadLine();
        }


    }
}
