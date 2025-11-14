using PokemonSimulator.Attack;

namespace PokemonSimulator.WaterPokemon.Evolutions
{
    internal sealed class Blastoise : WaterPokemon
    {
        

        public Blastoise(int level, List<AttackBase> attacks) : base("Blastoise", level, attacks)
        {
        }

        public override void Speak()

        {
            Console.WriteLine($"{Name} says: Bla bla!");
        }


    }
}