using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using PokemonSimulator.Attack;

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

        public ElementType Type { get; }

        protected List<AttackBase> Attacks;

        public Pokemon(string name, int level, ElementType type, List<AttackBase> attacks)
        {
            Attacks = attacks;
            Level = level;
            Type = type;
            Name = name;
        }

        public void RandomAttack()
        {
            // Väljer en slumpmässig attack från listan och anropar dess .Use-method
            // Pick a random attack from list of attacks
            var random = new Random();
            int index = random.Next(Attacks.Count);
            Attacks[index].Use(Level);
        }

        public void Attack()
        {
            //Låter användaren välja en attack från listan och anropar dess .Use-method
            bool success = false;
            do
            {
                Console.WriteLine($"Enter a number to execute attack for {Name}");
                for (int i = 0; i < Attacks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{Attacks[i].Name}");
                }

                string opt = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(opt))
                    Console.WriteLine("Invalid option. Please choose again");
                if (int.TryParse(opt, out int val))
                {
                    if (val < 1 || val > Attacks.Count)
                        Console.WriteLine("Invalid option. Please choose again");
                    else
                    {
                        Attacks[val - 1].Use(Level);
                        success = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose again");
                }
            } while (!success);
        }

        public virtual Pokemon RaiseLevel()
        {
            //Öka nivån på Pokemon och skriver ut att den har levlat upp
            Level += 1;
            Console.WriteLine($"{Name} har leveled up! New level: {Level}");
            return this;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name} {Environment.NewLine} Type: {Type} {Environment.NewLine} Level: {Level}");
            Console.Write($" Attacks: ");
            foreach (var attack in Attacks)
            {
                Console.Write($"{attack.Name}, ");
            }
            Console.WriteLine();

        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} says: Char char!");
        }

    }

}
