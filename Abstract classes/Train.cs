namespace Abstract_classes
{
    internal class Train : Vehicle
    {
        public Train(int speed)
        {
            Speed = speed;
        }
        public override void Move()
        {
            Console.WriteLine("The train is driving by rail.");
        }
    }
}
