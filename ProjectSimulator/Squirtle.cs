using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator
{
    internal class Squirtle : WaterPokemon, IEvolvable
    {
        public Squirtle(int v, List<Attack> attacks) : base("Squirtle", v, attacks)
        {
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
