using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class Train
    {
        public string Name { get; private set; }
        public string Model {  get; private set; }
        public List<Carriage> Carriages { get; private set; }
        public string Photo { get; private set; }

        public Train(string name, string model, List<Carriage> carriages, string photo)
        {
            Name = name;
            Model = model;
            Carriages = carriages;
            Photo = photo;
        }

        public void AddCarriage(Carriage carriage)
        {
            Carriages.Add(carriage);
        }

        public void AddPhoto(string photo)
        {
            Photo = photo;
        }

    }
}
