using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator
{
    internal abstract class Pokemon
    {
        private string _name;
        public string Name
        {
            get => _name;
            [MemberNotNull(nameof(_name))]
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 15)
                    throw new ArgumentException("Name must contain between 2 and 15 characters.");
                _name = value;
            }
        }

        private int _level;
        public int Level
        {
            get => _level;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Level must be larger than or equal to 1");
                _level = value;
            }
        }

        public ElementType Type { get;  }

        public List<Attack> Attacks { get;  }

        public Pokemon(string name, int level, ElementType type, List<Attack> attacks)
        {
            Attacks = attacks;
            Level = level;
            Type = type;
            Name = name;
        }

        public void RandomAttack()
        {
            // Väljer en slumpmässig attack från listan och anropar dess .Use-method
        }

        public void Attack()
        {
            //Låter användaren välja en attack från listan och anropar dess .Use-method
            bool success = false;
            do
            {
                Console.WriteLine($"Enter a number to choose attack for {Name}");
                for (int i = 0; i < Attacks.Count; i++)
                {
                    Console.WriteLine($"{i}.{Attacks[i].Name}");
                }

                string opt = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(opt))
                    Console.WriteLine("Invalid option. Please choose again");
                if (int.TryParse(opt, out int val))
                {
                    if (val < 0 || val >= Attacks.Count)
                        Console.WriteLine("Invalid option. Please choose again");
                    else
                    {
                        Attacks[val].Use(Level);
                        success = true;
                    }
                } else
                {
                    Console.WriteLine("Invalid option. Please choose again");
                }
            } while (!success);
        }

        public void RaiseLevel()
        {
            //Öka nivån på Pokemon och skriver ut att den har levlat upp
            Level += 1;
            Console.WriteLine($"{Name} har leveled up! New level: {Level}");
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, {Environment.NewLine} Type: {Type},{Environment.NewLine} Level: {Level}, ");
            Console.Write($" Attacks: ");
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.Write($"{Attacks[i].Name}, ");
            }
            Console.WriteLine();

        }
    }

}
