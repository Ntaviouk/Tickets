using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
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

        private string CalculateTimeDifference(DateTime time1, DateTime time2)
        {

            TimeSpan difference = time2 - time1;
            difference = difference.Duration();

            int hoursDifference = difference.Hours;
            int minutesDifference = difference.Minutes;

            string result = $"{hoursDifference} год. {minutesDifference} хв.";

            return result;
        }
    }
}
