using PokemonSimulator.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.GrassPokemon.Evolutions
{
    internal class Bulbasaur : GrassPokemon
    {
        public Bulbasaur(int v, List<AttackBase> attacks ) : base("Bulbasaur", v, attacks)
        {
            
        }

        public override void Speak()

        {
            Console.WriteLine($"{Name} says: Bul bul!");
        }
    }
}
