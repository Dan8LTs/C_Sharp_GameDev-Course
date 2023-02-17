namespace Abstract_classes
{
    internal class Car : Vehicle
    {
        public Car(int speed)
        {
            Speed = speed;
        }

        public override void Move()
        {
            Console.WriteLine("The car is driving on asphalt.");
        }
    }
}
