namespace PokemonSimulator.Attack
{
    internal class AttackBase
    {
        public string Name { get; private set; }
        public ElementType Type { get; private set; }
        public int BasePower { get; private set; }


        public AttackBase(string name, ElementType type, int basePower )
        {
            if (basePower <= 0)
            {
                throw new ArgumentException("BasePower must be greater than 0.");
            }

            Name = name;
            Type = type;
            BasePower = basePower;
        }


        public virtual void Use(int level)
        {
            Console.WriteLine($"{Name} hit with a total power of {BasePower + level}");
        }
    }
}