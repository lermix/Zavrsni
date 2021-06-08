using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.DataHolders
{
    public static class DocumentConnectionHolder
    {
        public static List<DocumentProductConnection> documentProductConnections { get; set; }

        static DocumentConnectionHolder()
        {
            documentProductConnections = new List<DocumentProductConnection>();
        }

    
    }
}
