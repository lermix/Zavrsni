using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Enums;

namespace Models
{
    public class Document
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public string remark { get; set; }
        public Partner supplier { get; set; }
        public Partner transporter { get; set; }
        public DocumentTypes type { get; set; }
        public List<ProductDisplay> products { get; set; }
        public Warehouse originWarehouse { get; set; }
        public Warehouse destinationWarehouse { get; set; }
    }
}
