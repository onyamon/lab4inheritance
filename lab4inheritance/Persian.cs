using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4inheritance
{
    public class Persian : Pokemon
    {
        public Persian() {
            name = "Persian";
            id = 53;
            level = 1;
            Type = PokemonType.Electr;
        }
    }
}
