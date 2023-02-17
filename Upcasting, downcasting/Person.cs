namespace Upcasting__downcasting
{
    public class Person
    {
        public string Name { get; private set; }
        public Person(string name)
        {
            Name = name;
        }

        public void ShowName()
        {
            Console.WriteLine("I am - " + Name);
        }
    }
}
