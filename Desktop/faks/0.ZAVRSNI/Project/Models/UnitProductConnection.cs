using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UnitProductConnection
    {
        public int ConnectionId { get; set; }
        public int ButtonId { get; set; }
        public int ProductId { get; set; }
        public double  amount { get; set; }

    }
}
