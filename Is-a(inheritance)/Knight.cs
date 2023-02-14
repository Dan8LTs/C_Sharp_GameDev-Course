namespace Is_a_inheritance_
{
    internal class Knight : Warrior
    {
        public Knight(int health, int armor, int damage) : base(health, armor, damage){ }
        public void ContactTheBlacksmith()
        {
            Armor += 2;
        }
    }
}
