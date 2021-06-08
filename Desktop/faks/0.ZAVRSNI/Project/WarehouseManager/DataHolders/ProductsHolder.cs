using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.DataHolders
{
    static class ProductsHolder
    {
        public static List<Models.Product> products;

        static ProductsHolder()
        {
            products = new List<Models.Product>();
        }

    }
}
