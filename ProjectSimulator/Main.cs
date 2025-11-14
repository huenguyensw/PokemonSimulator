using PokemonSimulator.Attack;
using PokemonSimulator.FirePokemon.Evolutions;
using PokemonSimulator.GrassPokemon.Evolutions;
using PokemonSimulator.WaterPokemon.Evolutions;
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
            //AddAttackLegen();
        }

        private void AddAttackLegen()
        {
            AttackBase attack = new AttackBase("Firethrower", ElementType.Fire, 10);
            LegendaryAttack legenattack = new LegendaryAttack("Legenattack", ElementType.Fire, 20);
        }

        private void BattleLoop()
        {
            for (int i = 0; i< team.Count; i++)
            {
                try
                {
                    Console.WriteLine("");
                    team[i] = team[i].RaiseLevel();
                    team[i].Speak();
                    team[i].RandomAttack();
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
            AddCharmander(16, new List<AttackBase>
            {
                new AttackBase("Flamethrower", ElementType.Fire, 12),
                new AttackBase("Ember", ElementType.Fire, 6),
                new AttackBase("Fire Spin", ElementType.Fire, 4),
                new AttackBase("Heat Wave", ElementType.Fire, 8)
            });

            AddSquirtle(3, new List<AttackBase>
            {
                new AttackBase("Water Gun", ElementType.Water, 15),
                new AttackBase("Bubble Beam", ElementType.Water, 5),
                new AttackBase("Aqua Tail", ElementType.Water, 14),
                new AttackBase("Hydro Pump", ElementType.Water, 18),
            });

            AddBulbasaur(3, new List<AttackBase>
            {
                new AttackBase("Vine Whip", ElementType.Grass, 5),
                new AttackBase("Razor Leaf", ElementType.Grass, 10),
                new AttackBase("Solar Beam", ElementType.Grass, 7),
                new AttackBase("Seed Bomb", ElementType.Grass, 5),
            });
        }

        private void AddSquirtle(int level, List<AttackBase> attacks)
        {
            team.Add(new Squirtle(level, attacks));
        }

        private void AddCharmander(int level, List<AttackBase> attacks)
        {
            team.Add(new Charmander(level, attacks));
        }

        private void AddBulbasaur(int level, List<AttackBase> attacks)
        {
            team.Add(new Bulbasaur(level, attacks));
        }
    }
}