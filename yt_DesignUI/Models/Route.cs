using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yt_DesignUI.Models
{
    public class Route
    {
        public string RouteName { get; private set; }
        public Train Train { get; private set; }
        public List<CityStop> Stops { get; set; }

        public Route(string routeName, Train train)
        {
            RouteName = routeName;
            Train = train;
            Stops = new List<CityStop>();
        }

        public void AddStop(string cityName, DateTime arrivalTime, DateTime departureTime)
        {
            Stops.Add(new CityStop(cityName, arrivalTime, departureTime));
        }
    }

}
