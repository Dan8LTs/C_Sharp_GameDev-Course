namespace _13
{
    internal class Fighter
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Damage { get; private set; }
        private int _armor;

        public Fighter(string name, int health, int damage, int armor)
        {
            Name = name;
            Health = health;
            Damage = damage;
            _armor = armor;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Fighter - {Name}, health: {Health}, damage: {Damage}, armor: {_armor}");
        }

        public void ShowCurrentHealth()
        {
            Console.WriteLine($"Fighter - {Name}, health: {Health}");
        }

        public void TakeDamage(int damage)
        {
            if (damage >= _armor)
            {
                Health -= damage - _armor;
            }
        }
    }
}
