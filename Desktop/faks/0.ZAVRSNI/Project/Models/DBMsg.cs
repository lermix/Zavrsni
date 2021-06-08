using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.DatabaseManagerEnums;

namespace Models
{
    public class DBMsg
    {
        public ManagerType manager { get; set; }
        public string function { get; set; }
        public string value { get; set; }

        public DBMsg(ManagerType manager, string function, string value)
        {
            this.manager = manager;
            this.function = function;
            this.value = value;
        }
    }
}
