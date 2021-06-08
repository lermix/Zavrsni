using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Warehouse
    {
        public int id { get; set; }
        public string  name { get; set; }
        public string adress { get; set; }
        public int capacity { get; set; }
    }
}
