using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste.objects
{
    class StorageUnit : DragButton
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Dictionary<Product, int> products { get; set; }
        public Size size { get; set; }
        public bool avalible { get; set; }
        public string mesuringUnit { get; set; }

        public StorageUnit()
        {
            MouseDown += openStorageUnitInfo;
        }

        public void openStorageUnitInfo(object sender, MouseEventArgs mouseData)
        {

        }
    }
}
