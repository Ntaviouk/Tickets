using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class Route
    {
        public string RouteName { get; private set; }
        public Train Train { get; private set; }
        public List<CityStop> Stops { get; private set; }
        public DateTime DepartureDate {  get; private set; }
        public Route(string routeName, Train train,List<CityStop> stops, DateTime departureDate)
        {
            RouteName = routeName;
            Train = train;
            Stops = stops;
            DepartureDate = departureDate;
        }

        public void AddStop(string cityName, DateTime arrivalTime, DateTime departureTime)
        {
            Stops.Add(new CityStop(cityName, arrivalTime, departureTime));
        }
    }

}
