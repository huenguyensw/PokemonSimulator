using PokemonSimulator.Attack;
using PokemonSimulator.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.FirePokemon.Evolutions
{
    internal sealed class Charizard : FirePokemon
    {
        public Charizard( int level, List<AttackBase> attacks) : base("Charizard", level, attacks)
        {
        }

        public override void Speak()

        {
            Console.WriteLine($"{Name} says: Chari chari!");
        }
    }
}
