using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4inheritance
{
    public class Dragonite : Pokemon
    {
        public Dragonite() {
            name = "Dragonite";
            id = 149;
            level = 1;
            Type = PokemonType.Electr;
        }
    }
}
