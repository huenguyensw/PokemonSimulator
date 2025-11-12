using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator
{
    internal class FirePokemon : Pokemon
    {
        public FirePokemon(string name, List<Attack> attacks, int level) : base(attacks, level)
        {
            Name = name;
            Type = ElementType.Fire;
        }
    }
}
