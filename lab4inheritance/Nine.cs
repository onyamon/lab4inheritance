using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4inheritance
{
    public class Nine : Pokemon
    {
        public Nine() {
            name = "Nine";
            id = 38;
            level = 1;
            Type = PokemonType.Fire;
        }
    }
}
