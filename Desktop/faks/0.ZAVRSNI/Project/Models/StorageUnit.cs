using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StorageUnit
    {
        public int id { get; set; }
        public string name { get; set; }
        public Dictionary<Product, int> products { get; set; }
        public Size size { get; set; }
        public bool avalible { get; set; }
    }
}
