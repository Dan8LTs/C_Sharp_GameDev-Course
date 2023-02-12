namespace OOP
{
    internal class Car
    {
        // default - private
        public string Name;
        private int _horsePower;
        internal int Age;
        protected double _maxSpeed;

        public Car(string name, int age, int horsePower, double maxSpeed = 200)
        {
            Name = name;
            if (age <= 0)
            {
                throw new ArgumentException("Invalid age");
            }
            Age = age;
            if (horsePower <= 0)
            {
                throw new ArgumentException("Invalid horse power");
            }
            _horsePower = horsePower;
            _maxSpeed = maxSpeed;
        }

        public Car()
        {
            Age = 1000;
            _horsePower = 1000;
            _maxSpeed = 1000;
        }

        public void ShowTechnicalPassport()
        {
            Console.WriteLine("Name: " + Name + "\nAge: " + Age + "\nHorse power: " + _horsePower + "\nMax speed: " + _maxSpeed);
        }

        public void BecomeOlder(int years, int runAwayHorses)
        {
            // this means referencing a class field
            Age = this.Age + years;
            _horsePower -= runAwayHorses;
            _maxSpeed -= runAwayHorses * 0.1;
        }
    }
}
