using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Reports
{
    public class VehicleReport
    {
        public string vehicleRegistration { get; set; }
        public string vehicleBrand { get; set; }
        public string vehicleModel { get; set; }
        public double fuelConsumption { get; set; }
        public double totalDistance { get; set; }
        public double totalFuelConsumption 
        {
            get { return (totalDistance/100)*fuelConsumption; }
        }
        public double totalFuelPrice
        {
            get { return totalFuelConsumption * 10; } 
        }
    }
}
