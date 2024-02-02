using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4inheritance
{
   public class Snorunt : Pokemon
    {
        public Snorunt() {
            name = "Snorunt";
            id = 361;
            level = 1;
            Type = PokemonType.Electr;
        }
    }
}
