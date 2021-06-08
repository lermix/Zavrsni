using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.DataHolders
{
    public static class WorkerHolder
    {
        public static List<Worker> workers;
        public static List<Worker> avaliableWorkers;

        static WorkerHolder()
        {
            workers = new List<Worker>();
            avaliableWorkers = new List<Worker>();
        }
    }
}
