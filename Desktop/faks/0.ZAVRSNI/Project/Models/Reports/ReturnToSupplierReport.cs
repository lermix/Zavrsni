using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Reports
{
    public class ReturnToSupplierReport
    {
        public string documentName { get; set; }
        public DateTime date { get; set; }
        public string remark { get; set; }
        public string supplierName { get; set; }
    }
}
