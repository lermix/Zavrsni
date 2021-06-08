using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skladiste
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double purchasePrice { get; set; }
        public double sellingPrice { get; set; }
        public double size { get; set; }
        public string mesuringUnit { get; set; }
        public double weight { get; set; }
        public DateTime dateOfArival { get; set; }
        public DateTime dateOfShipment { get; set; }
        public double numberAvalible { get; set; }
    }
}
