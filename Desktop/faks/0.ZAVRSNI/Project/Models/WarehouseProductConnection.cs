using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WarehouseProductConnection
    {
        public int connectionId { get; set; }
        public int warehouseId { get; set; }
        public int productId { get; set; }
        public double amount { get; set; }
    }
}
