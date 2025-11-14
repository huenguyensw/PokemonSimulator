using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Attack
{
    internal class LegendaryAttack: AttackBase
    {
        public LegendaryAttack(string name, ElementType type, int basePower) : base( name, type, basePower)
        {
        }

        public override void Use(int level)
        {
            Console.WriteLine($"{Name} hit with a total power of {BasePower + level*2}");

        }
    }
}
