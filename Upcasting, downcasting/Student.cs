namespace Upcasting__downcasting
{
    public class Student : Person
    {
        public int AverageScore { get; private set; }
        public Student(string name, int averageScore) : base(name)
        {
            AverageScore = averageScore;
        }
    }
}
