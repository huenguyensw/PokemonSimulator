using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator
{
    internal class Charmander : FirePokemon, IEvolvable
    {
        public Charmander(int level, List<Attack> attacks ) : base(nameof(Charmander), level, attacks )
        {
            
        }

        public void Evolve()
        {
            this.EvolveTo("Chamerloon", 10);
        }
    }
}
