/* Upcasting
Person person1;
Mentor mentor = new Mentor("Maxim", 32);
person1 = mentor;
*/

/* Downcasting
Person person2 = new Student("Tim", 5);
Student student;
student = (Student)person2; 
*/


using Upcasting__downcasting;

Person person = new Student("Tom", 8);
Mentor mentor = person as Mentor;
Student student = person as Student;

if (mentor != null)
{
    mentor.ShowName();
    Console.WriteLine(mentor.NumberOfStudents + "students");
}
if (student != null)
{
    student.ShowName();
    Console.WriteLine("Average score: " + student.AverageScore);
}

Person person2 = new Mentor("Albert", 12);

/*
Mentor mentor2;
if (person2 is Mentor)
{
    mentor2 = (Mentor)person2;
    mentor2.ShowName();
    Console.WriteLine(mentor2.NumberOfStudents);
}
*/
if (person2 is Mentor mentor2)
{
    mentor2.ShowName();
    Console.WriteLine(mentor2.NumberOfStudents + " students.");
}

Person person3 = new Student("Gleb", 5);
switch (person3)
{
    case Student student3:
        student3.ShowName();
        Console.WriteLine("Average score: " + student3.AverageScore);
        break;
    case Mentor mentor3:
        mentor3.ShowName();
        Console.WriteLine(mentor3.NumberOfStudents);
        break;
}