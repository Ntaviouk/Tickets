using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yt_DesignUI.Models
{
    public class CityStop
    {
        public string CityName { get; private set; }
        public DateTime ArrivalTime { get; private set; }
        public DateTime DepartureTime { get; private set; }

        public CityStop(string cityName, DateTime arrivalTime, DateTime departureTime)
        {
            CityName = cityName;
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
        }
    }
}
