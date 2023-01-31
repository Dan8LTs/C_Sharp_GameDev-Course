float rublesInWallet;
float dollarsInWallet;

int rubToUsd = 64, usdToRub = 66;

float exchangeCurrencyCount;

string desiredOperation;

Console.WriteLine("Welcome to currency exchange!");

Console.Write("Enter the balance of rubles: ");
rublesInWallet = Convert.ToSingle(Console.ReadLine());

Console.Write("Enter the balance of dollars: ");
dollarsInWallet = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Choose necessary operation. ");
Console.WriteLine("1 - exchange rubles for dollars");
Console.WriteLine("2 - exchange dollars for rubles");

Console.WriteLine("Your choice: ");
desiredOperation = Console.ReadLine();
switch (desiredOperation)
{
    case "1":
        Console.Write("How much do you want to exchange? ");
        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
        if (rublesInWallet >= exchangeCurrencyCount)
        {
            rublesInWallet -= exchangeCurrencyCount;
            dollarsInWallet += exchangeCurrencyCount / rubToUsd;
        }
        else
        {
            Console.WriteLine("Invalid amount of rubles.");
        }
        break;
    case "2":
        Console.Write("How much do you want to exchange? ");
        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
        if (dollarsInWallet >= exchangeCurrencyCount)
        {
            dollarsInWallet -= exchangeCurrencyCount;
            rublesInWallet += exchangeCurrencyCount * usdToRub;
        }
        else
        {
            Console.WriteLine("Invalid amount of dollars.");
        }
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}

Console.WriteLine($"Your balance: {rublesInWallet} rubles, {dollarsInWallet} dollars.");