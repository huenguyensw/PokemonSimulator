using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonSimulator.Extensions
{
    internal static class PokemonExtension
    {
        public static Pokemon ToEvolvable(this IEvolvable pokemon, string newName, int increaseLevel)
        {
            if(pokemon is Pokemon p)
            {
                string oldName = p.Name;
                p.Name = newName;
                p.Level += increaseLevel;
                Console.WriteLine($"{oldName} is evolving... Now it is a {p.Name} and its level is {p.Level}");

                return p;
            }

            throw new InvalidOperationException("This is not a Pokemon");


        }
    }
}
