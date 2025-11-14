using PokemonSimulator.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.WaterPokemon.Evolutions
{
    internal class Squirtle : WaterPokemon, IEvolvable
    {
        public Squirtle(int v, List<AttackBase> attacks) : base("Squirtle", v, attacks)
        {
        }

        public Pokemon Evolve()
        {
            Console.WriteLine($"Now it's a Wartortle at level {this.Level + 10}");
            return new Wartortle(this.Level + 10, this.Attacks);
        }

        public override void Speak()

        {
            Console.WriteLine($"{Name} says: Squir squir!");
        }


        public override Pokemon RaiseLevel()
        {
            int _evolveAtLevel = 19;
            
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
