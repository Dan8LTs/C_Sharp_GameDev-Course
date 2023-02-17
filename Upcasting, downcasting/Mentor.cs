namespace Upcasting__downcasting
{
    public class Mentor : Person
    {
        public int NumberOfStudents { get; private set; }
        public Mentor(string name, int numberOfStudents) : base(name)
        {
            NumberOfStudents = numberOfStudents;
        }
    }
}
