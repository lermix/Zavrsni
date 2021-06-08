using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Size
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Size()
        { }

        public Size(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double SurfaceArea()
        {
            return x * y;
        }
        public double Volume()
        {
            return x * y * z;
        }

        override
        public string ToString()
        {
            return ("x:" + x + ", y:" + y + ", z:" + z);
        }


    }
}
