using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4inheritance
{
    public class jolteon: Pokemon
    {
        public jolteon() {
            name = "Jolteon";
            id = 135;
            level = 1;
            Type = PokemonType.Electr;
        }
    }
}
