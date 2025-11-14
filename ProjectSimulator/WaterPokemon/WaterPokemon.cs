using PokemonSimulator.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.WaterPokemon
{
    internal class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, int level, List<AttackBase> attacks) : base(name, level, ElementType.Water, attacks)
        {
        }
    }
}
