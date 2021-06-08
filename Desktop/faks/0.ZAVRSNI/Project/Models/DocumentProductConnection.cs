using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DocumentProductConnection
    {
        public int connectionId { get; set; }
        public int productId { get; set; }
        public string documentName { get; set; }
        public double amount { get; set; }

        public DocumentProductConnection(int connectionId, int productId, string documentName, double amount)
        {
            this.connectionId = connectionId;
            this.productId = productId;
            this.documentName = documentName;
            this.amount = amount;
        }

        public DocumentProductConnection() { }
    }
}
