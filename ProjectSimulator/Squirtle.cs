using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator
{
    internal class Squirtle : WaterPokemon, IEvolvable
    {
        public Squirtle(string name, List<Attack> attacks, int v) : base(name, attacks, v)
        {
            Name = "Squirtle";
        }

        public void Evolve()
        {
            string currentName = Name;
            Name = "Charmeleon";
            Level += 10;
            Console.WriteLine($"{currentName} is evolving... Now it is a {Name} and its level is {Level}");
        }
    }
}
