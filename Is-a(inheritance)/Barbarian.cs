namespace Is_a_inheritance_
{
    internal class Barbarian : Warrior
    {
        public Barbarian(int health, int armor, int damage, int attackSpeed) : base(health, armor, damage * attackSpeed) { }
        public void Shout()
        {
            Armor -= 2;
            Health += 8;
        }
    }
}
