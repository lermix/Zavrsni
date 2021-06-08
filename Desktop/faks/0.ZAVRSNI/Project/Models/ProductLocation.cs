using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductLocation : Product
    {
        public int inUnit { get; set; }
        public int storageUnitId { get; set; }
        public string storageUnitName { get; set; }
                
        public ProductLocation() { }

        public ProductLocation(Product product,int inUnit, int storageUnitId, string storageUnitName) : base(product)
        {
            this.inUnit = inUnit;
            this.storageUnitId = storageUnitId;
            this.storageUnitName = storageUnitName;
        }
    }
}
