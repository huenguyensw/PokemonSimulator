using PokemonSimulator.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.WaterPokemon.Evolutions
{
    internal class Wartortle : WaterPokemon, IEvolvable
    {
        public  Wartortle(int level, List<AttackBase> attacks) : base("Wartortle", level, attacks)
        {
        }

        public Pokemon Evolve()
        {
            Console.WriteLine($"Now it's a Blastoise at level {this.Level + 10}");
            return new Blastoise(this.Level + 10, this.Attacks);
        }

        public override void Speak()

        {
            Console.WriteLine($"{Name} says: Wart wart!");
        }

        public override Pokemon RaiseLevel()
        {
            int _evolveAtLevel = 50;
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
