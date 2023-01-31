int age;
Console.Write("Enter your age: ");

age = Convert.ToInt32(Console.ReadLine());
int age2 = age;

while (age-- > 0)
{
    if (age == 9)
    {
        continue;
    }
    if (age == 4)
    {
        break;
    }

    Console.WriteLine("Happy birthday! " + age);
}

Console.WriteLine();


for (int i = 1; i <= age2; i++)
{
    Console.WriteLine("Happy birthday! You are: " + i);
}


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 0; i < 10; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

int triesCount = 4;
string password = "123456";
string userInput;

for (int i = 0; i < triesCount; i++)
{
    Console.Write("Enter your password: ");
    userInput = Console.ReadLine();
    if(userInput == password)
    {
        Console.WriteLine("Ok.");
        break;
    }
    else
    {
        Console.WriteLine("Wrong password.");
        Console.WriteLine("You have " + (triesCount - (i + 1) + " tries."));
    }
}