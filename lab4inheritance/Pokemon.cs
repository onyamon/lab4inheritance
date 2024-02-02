using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lab4inheritance
{
    public class Pokemon 
    {
        protected int id;
        protected string name;
        protected Image pic;
        protected int level;
        protected PokemonType Type;
        protected PokemonAbilities Abilities;
        protected int HP;
        protected int Att;
        protected int Def;
        protected int SAtt;
        protected int SDef;
        protected int Speed;

        public string Name()
        { 
            return name; 
        }
        public Image Picture()
        {
            return pic;
        }
    }
   public enum PokemonType {
        Grass,Poison,Electr,Fire,
    }
    public enum PokemonAbilities{
        Overgrow,chlorophyII,Static,Lightning_Rod
    }
}
