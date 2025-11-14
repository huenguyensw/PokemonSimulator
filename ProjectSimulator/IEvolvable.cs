using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator
{
    internal interface IEvolvable
    {
        Pokemon Evolve();
        Pokemon RaiseLevel();
    }
}
