using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class Carriage
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public double Price { get; private set; }
        public List<int> Seats { get; private set; }

        [JsonConstructor]
        public Carriage(string name, string type,double price, List<int> seats)
        {
            Name = name;
            Type = type;
            Price = price;
            Seats = seats;
        }

        public void BuySeat(int seatNumber)
        {
            Seats.Remove(seatNumber);
        }
    }
}
