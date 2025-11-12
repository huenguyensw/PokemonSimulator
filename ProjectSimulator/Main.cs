
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
            AddCharmander(4, new List<Attack>
            {
                new Attack("Flamethrower", ElementType.Fire, 12),
                 new Attack("Ember", ElementType.Fire, 6)

            });

            AddSquirtle(3, new List<Attack>
            {
                new Attack("Splashwave", ElementType.Water, 15),
                new Attack("Drizzle", ElementType.Water, 5)
            });

            AddBulbasaur(3, new List<Attack>
            {
                new Attack("Leafbladev", ElementType.Grass, 5),
                new Attack("Sprout", ElementType.Grass, 10)
            });
        }

        private void AddSquirtle(int level, List<Attack> attacks)
        {
            team.Add(new Squirtle(level, attacks));
        }

        private void AddCharmander(int level, List<Attack> attacks)
        {
            team.Add(new Charmander(level, attacks));
        }

        private void AddBulbasaur(int level, List<Attack> attacks)
        {
            team.Add(new Bulbasaur(level, attacks));
        }
    }
}