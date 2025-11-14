using PokemonSimulator.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.FirePokemon
{
    internal class FirePokemon : Pokemon
    {
        public FirePokemon(string name, int level, List<AttackBase> attacks ) : base(name, level, ElementType.Fire, attacks )
        {
        }

        
    }
}
