using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;

namespace MyAirport.Pim.Models
{
    public abstract class AbstractDefinition
    {
        public abstract BagageDefinition GetBagage(int idBagage);
        public abstract List<BagageDefinition> GetBagage(string codeIataBagage);
    }

}
