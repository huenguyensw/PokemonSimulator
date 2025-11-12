using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator
{
    internal class GrassPokemon : Pokemon
    {
        public GrassPokemon(string name, List<Attack> attacks, int v) : base(attacks, v)
        {
            Name = name;
            Type = ElementType.Grass;
        }
    }
}
