using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class Train
    {
        public string Name { get; private set; }
        public string Model {  get; private set; }
        public List<Carriage> Carriages { get; private set; }

        public Train(string name, string model)
        {
            Name = name;
            Model = model;
            Carriages = new List<Carriage>();
        }

        public void AddCarriage(Carriage carriage)
        {
            Carriages.Add(carriage);
        }


    }
}
