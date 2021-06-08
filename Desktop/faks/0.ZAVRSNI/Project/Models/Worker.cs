using System;
using static Models.Enums;

namespace Models
{
    public class Worker
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string city { get; set; }
        public WorkerPosition position { get; set; }
        public Warehouse warehouse { get; set; }
    }
}