
namespace PokemonSimulator
{
    internal class Main
    {
        List<Pokemon> team = new List<Pokemon>();
        internal void Run()
        {
            SeedData(); // fill team
            PrintTeam(); //skriva ut all pokemons
            BattleLoop();
        }

        private void BattleLoop()
        {
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
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }

        private void PrintTeam()
        {
            Console.WriteLine($"There are {team.Count} pokemons in team");
            for (int i = 0; i < team.Count; i++)
            {
                Console.Write($"{i + 1}.");
                team[i].Print();
            }
        }

        private void SeedData()
        {

            var charmander = new FirePokemon("Charmander", 4, new List<Attack>
            {
                {new Attack("Flamethrower", ElementType.Fire, 12) },
                { new Attack("Flamethrower", ElementType.Fire, 12)}

            });
            team.Add(charmander);

            var splashwave = new Attack("Splashwave", ElementType.Water, 15);
            var drizzle = new Attack("Drizzle", ElementType.Water, 5);

            var waterAttacks = new List<Attack> { splashwave, drizzle };
            var squirtle = new WaterPokemon("Squirtle", 3, waterAttacks);
            team.Add(squirtle);

            var leafbladev = new Attack("Leafbladev", ElementType.Grass, 5);
            var sprout = new Attack("Sprout", ElementType.Grass, 10);

            var grassAttacks = new List<Attack> { leafbladev, sprout };
            var bulbasaur = new GrassPokemon("Bulbasaur", 2, grassAttacks);
            team.Add(bulbasaur);
        }
    }
}