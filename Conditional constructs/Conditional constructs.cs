int age;
Console.Write("Enter your age:");
age = Convert.ToInt16(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("Welcome to our bar!");
}
else
{
    Console.WriteLine("You are too young.");
    Console.WriteLine("Come to our bar after: " + (18 - age) + " years.");
}

string dayOfWeek;
Console.WriteLine("Enter the day of week: ");
dayOfWeek = Console.ReadLine();
/*
if (dayOfWeek == "Monday")
{
    Console.WriteLine("You should take courses.");
}
else if(dayOfWeek == "Thursday")
{
    Console.WriteLine("You should do hometask.");
}
*/

switch (dayOfWeek)
{
    case "Monday":
        Console.WriteLine("Let's take courses.");
        break;

    case "Thursday":
    case "Friday":
        Console.WriteLine("Let's do hometask.");
        break;

    default: Console.WriteLine("You are free!"); break;
}

string password = "123qwe";
string userInput;

Console.Write("Enter password: ");
userInput = Console.ReadLine(); 

if (userInput == password)
{
    Console.WriteLine("Database access is allowed.");
}
else
{
    Console.WriteLine("The password is wrong");
}
