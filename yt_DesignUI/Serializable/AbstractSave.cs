using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Serializable
{
    internal abstract class AbstractSave
    {
        public abstract void Save<T>(string fileName, List<T> data);
        public abstract List<T> Load<T>(string fileName);
    }
}
