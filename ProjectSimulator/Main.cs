
namespace PokemonSimulator
{
    internal class Main
    {
        List<Pokemon> team = new List<Pokemon>();
        internal void Run()
        {
            SeedData();
            PrintPokemons();
           
            foreach (var pokemon in team)
            {
                try
                {
                    Console.WriteLine("");
                    pokemon.Attack();
                    pokemon.RaiseLevel();

                    if (pokemon is IEvolvable evolvable)
                    {
                        evolvable.Evolve();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }

        }

        private void PrintPokemons()
        {
            Console.WriteLine($"There are {team.Count} pokemons");
            for (int i = 0; i < team.Count; i++)
            {
                Console.Write($"{i + 1}.");
                team[i].Print();
            }
        }

        private void SeedData()
        {
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);

            var fireAttacks = new List<Attack> { flamethrower, ember };
            var charmander = new FirePokemon("Charmander", fireAttacks, 4);
            team.Add(charmander);

            var splashwave = new Attack("Splashwave", ElementType.Water, 15);
            var drizzle = new Attack("Drizzle", ElementType.Water, 5);

            var waterAttacks = new List<Attack> { splashwave, drizzle };
            var squirtle = new WaterPokemon("Squirtle", waterAttacks, 3);
            team.Add(squirtle);

            var leafblade = new Attack("Leafbladev", ElementType.Grass, 5);
            var sprout = new Attack("Sprout", ElementType.Grass, 10);

            var grassAttacks = new List<Attack> { leafblade, sprout };
            var bulbasaur = new GrassPokemon("Bulbasaur", grassAttacks, 2);
            team.Add(bulbasaur);
        }
    }
}