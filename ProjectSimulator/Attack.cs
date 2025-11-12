namespace PokemonSimulator
{
    internal class Attack
    {
        public string Name { get; private set; }
        public ElementType Type { get; private set; }
        public int BasePower { get; private set; }


        public Attack(string name, ElementType type, int basePower )
        {
            if (basePower <= 0)
            {
                throw new ArgumentException("BasePower must be greater than 0.");
            }

            Name = name;
            Type = type;
            BasePower = basePower;
        }

        public void Use(int level)
        {
            int newPower = BasePower + level;
            Console.WriteLine($"{Name} hit with a total power of {newPower}");
        }
    }
}