using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Property
    {
        public Enums.PropertyName name { get; set; }
        public string value { get; set; }

        public Property() {
        }

        public Property(Enums.PropertyName name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
