
using System;

namespace PokemonSimulator
{
    internal class Main
    {
        List<Pokemon> team = new List<Pokemon>();
        internal void Run()
        {
            SeedData(); // fylla team data
            PrintTeam(); //skriva ut alla pokemon
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
                    //pokemon.RandomAttack();
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
                new Attack("Ember", ElementType.Fire, 6),
                new Attack("Fire Spin", ElementType.Fire, 4),
                new Attack("Heat Wave", ElementType.Fire, 8)
            });

            AddSquirtle(3, new List<Attack>
            {
                new Attack("Water Gun", ElementType.Water, 15),
                new Attack("Bubble Beam", ElementType.Water, 5),
                new Attack("Aqua Tail", ElementType.Water, 14),
                new Attack("Hydro Pump", ElementType.Water, 18),
            });

            AddBulbasaur(3, new List<Attack>
            {
                new Attack("Vine Whip", ElementType.Grass, 5),
                new Attack("Razor Leaf", ElementType.Grass, 10),
                new Attack("Solar Beam", ElementType.Grass, 7),
                new Attack("Seed Bomb", ElementType.Grass, 5),
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