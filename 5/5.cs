int number;
int lower, higher;
int triesCount = 5;
int userInput;
Random rand = new Random();

number = rand.Next(1, 101);
if (number - 10 > 0)
{
    lower = rand.Next(number - 10, number);
}
else
{
    lower = rand.Next(0, number);
}
higher = rand.Next(number + 1, number + 10);

Console.WriteLine($"I guessed a number from 1 to 100. It is greater than {lower} but less than {higher}.");

Console.WriteLine($"What is the number? You have {triesCount} tries.");
while (triesCount-- > 0)
{
    Console.Write("Your answer: ");
    userInput = Convert.ToInt16(Console.ReadLine());
    if(userInput == number)
    {
        Console.WriteLine("You guessed right: " + number + ".");
    }
    else
    {
        Console.WriteLine("Wrong. Try again.");
    }
}

if (triesCount < 0)
{
    Console.WriteLine($"You lose. It was a number: {number}");
}
