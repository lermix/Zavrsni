using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductDisplay : Product
    {
        public double inUnit { get; set; }

        public ProductDisplay(Product product, double amount) : base(product)
        {
            inUnit = amount;
        }
    }
}
