using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Reports
{
    public class WorkerReport
    {
        public string workerName { get; set; }
        public string workerSurname { get; set; }
        public DateTime date { get; set; }
        public double distance { get; set; }
    }
}
