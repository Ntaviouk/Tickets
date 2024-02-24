using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Tickets.Models;

namespace Tickets.Serializable
{
    internal class SaveToJson:AbstractSave
    {
        public override void Save<T>(string fileName, List<T> data)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                JsonSerializer.Serialize(fs, data);
            }
        }

        public override List<T> Load<T>(string fileName)
        {
            List<T> data = new List<T>();

            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    data = JsonSerializer.Deserialize<List<T>>(new StreamReader(fs).ReadToEnd());
                }
            }

            return data;
        }
    }
}
