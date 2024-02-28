using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
        public List<String> Additional {  get; private set; }
        public Double Price {  get; private set; }

        [JsonConstructor]
        public Ticket(Account loggedAccount, Route selectedRoute, Carriage selectedCarriage, int selectedCarriageSeat, List<CityStop> selectedCities, List<string> additional, double price)
        {
            LoggedAccount = loggedAccount;
            SelectedRoute = selectedRoute;
            SelectedCarriage = selectedCarriage;
            SelectedCarriageSeat = selectedCarriageSeat;
            SelectedCities = selectedCities;
            Additional = additional;
            Price = price;
        }

        public Ticket(Account loggedaccount, Route selectedroute, List<CityStop> selectedcities, List<string> additional) 
        {
            LoggedAccount = loggedaccount;
            SelectedRoute = selectedroute;
            SelectedCities = selectedcities;
            Additional = additional;
        }

        public void AddPlace(Carriage selectedcarriage, int selectedcarriageseat)
        {
            SelectedCarriage = selectedcarriage;
            SelectedCarriageSeat = selectedcarriageseat;
        }
        public void SetPrice (double price)
        {
            Price = price;
        }

        public void AddAdditionalInfo(string info)
        {
            Additional.Add(info);
        }

        public void RemoveAdditionalInfo(string info)
        {
            Additional.Remove(info);
        }
    }
}
