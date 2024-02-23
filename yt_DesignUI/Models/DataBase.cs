using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class DataBase
    {
        public static List<Account> accounts = new List<Account>();
        public static List<Train> trains = new List<Train>();
        public static List<Carriage> carriages = new List<Carriage>();  
        public static List<Route> routes = new List<Route>();
    }
}
