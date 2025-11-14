using PokemonSimulator.Extensions;
using PokemonSimulator.FirePokemon;
using PokemonSimulator.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.FirePokemon.Evolutions
{
    internal class Charmander : FirePokemon, IEvolvable
    {
        public Charmander(int level, List<AttackBase> attacks ) : base("Charmander", level, attacks )
        {
            
        }

        public Pokemon Evolve()
        {
            Console.WriteLine($"Now it's a Charmmeleon at level {this.Level + 10}");
            return new Charmeleon(this.Level + 10, this.Attacks);
        }

        public override void Speak()

        {
            Console.WriteLine($"{Name} says: Char char!");
        }

        public override Pokemon RaiseLevel()
        {
            int _evolveAtLevel = 16;
            base.RaiseLevel();
            if(Level >= _evolveAtLevel)
            {
                Console.WriteLine($"{Name} is evolving...");
                return Evolve();
            }

            return this;
        }

    }
}
