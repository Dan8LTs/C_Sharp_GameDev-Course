namespace Interface
{
    internal class Train : IMovable, IBreakable
    {
        public void Move()
        {
            Console.WriteLine("The train is moving.");
        }

        public void Break()
        {
            Console.WriteLine("The train is breaking.");
        }
    }
}
