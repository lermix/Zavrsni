using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Route
    {
        public int id { get; set; }
        public Location startingPoint { get; set; }
        public Location destination { get; set; }
        public double distance { get; set; }
        public Worker driver { get; set; }
        public Vehicle vehicle { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool finished { get; set; }        
    }

    public class RouteDisplay
    {
        public int id { get; set; }
        public string startingPoint { get; set; }
        public string destination { get; set; }
        public double distance { get; set; }
        public string driver { get; set; }
        public string vehicle { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool finished { get; set; }
    }

    public class RouteHelper
    {
        public static List<RouteDisplay> makeRoutesDisplayable(List<Route> routes)
        {
            List<RouteDisplay> routeDisplays = new List<RouteDisplay>();
            foreach (Route route in routes)
            {
                RouteDisplay routeDisplay = new RouteDisplay();
                routeDisplay.id = route.id;
                routeDisplay.startingPoint = route.startingPoint.name;
                routeDisplay.destination = route.destination.name;
                routeDisplay.distance = route.distance;
                routeDisplay.driver = route.driver.name + " " + route.driver.surname;
                routeDisplay.vehicle = route.vehicle.registration;
                routeDisplay.startDate = route.startDate;
                routeDisplay.endDate = route.endDate;
                routeDisplay.finished = route.finished;

                routeDisplays.Add(routeDisplay);
            }

            return routeDisplays;
        }
    }
}
