using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class Carriage
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int SeatsCount { get; private set; }
        public bool Available { get; private set; }

        public Carriage(string name, string type, int seatsCount, bool available)
        {
            Name = name;
            Type = type;
            SeatsCount = seatsCount;
            Available = available;
        }

    }
}
