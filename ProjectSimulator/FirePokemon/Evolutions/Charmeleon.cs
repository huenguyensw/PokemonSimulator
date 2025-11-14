using PokemonSimulator.Attack;
using PokemonSimulator.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.FirePokemon.Evolutions
{
    internal class Charmeleon : FirePokemon, IEvolvable
    {
        public Charmeleon(int level, List<AttackBase> attacks) : base("Charmeleon", level, attacks)
        {
        }

         public Pokemon Evolve()
        {
            Console.WriteLine($"Now it's a Charizard at level {this.Level + 10}");
            return new Charizard(this.Level + 10, this.Attacks);
        }

        public override void Speak()

        {
            Console.WriteLine($"{Name} says: Charme charme!");
        }

        public override Pokemon RaiseLevel()
        {
            int _evolveAtLevel = 40;
            base.RaiseLevel();
            if (Level >= _evolveAtLevel)
            {
                Console.WriteLine($"{Name} is evolving...");
                return Evolve();
            }

            return this;
        }
    }
}
