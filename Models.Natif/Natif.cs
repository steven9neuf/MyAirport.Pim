using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Models;

namespace MyAirport.Pim.Models
{
    public class Natif : AbstractDefinition
    {
        List<Entities.BagageDefinition> bagages = new List<Entities.BagageDefinition>();

        public override Entities.BagageDefinition GetBagage(int idBagage)
        {
            throw new NotImplementedException();
        }

        public override List<Entities.BagageDefinition> GetBagage(string codeIataBagage)
        {
            bagages.Add(new Entities.BagageDefinition() { CodeIata = codeIataBagage, Compagnie = "LH" });
            return bagages;
        }
    }
}

