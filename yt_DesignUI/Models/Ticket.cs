using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class Ticket
    {
        public Account LoggedAccount {  get; private set; }
        public Route SelectedRoute { get; private set; }
        public Carriage SelectedCarriage { get; private set; }
        public int SelectedCarriageSeat { get; private set; }
        public List<CityStop> SelectedCities { get; private set; }

        public Ticket(Account loggedAccount, Route selectedRoute, Carriage selectedCarriage, int selectedCarriageSeat, List<CityStop> selectedCities)
        {
            LoggedAccount = loggedAccount;
            SelectedRoute = selectedRoute;
            SelectedCarriage = selectedCarriage;
            SelectedCarriageSeat = selectedCarriageSeat;
            SelectedCities = selectedCities;
        }
    }
}
