namespace Interface
{
    internal class Car : Vehicle, IMovable, IBreakable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }

        public void Break()
        {
            Console.WriteLine("The car is breaking.");
        }
    }
}
