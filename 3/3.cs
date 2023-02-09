int money;
int years;
int percent;

Console.Write("Enter the amount of money on deposit: ");
money = Convert.ToInt16(Console.ReadLine());
Console.Write("For how many years is the deposit open? ");
years = Convert.ToInt16(Console.ReadLine());
Console.Write("At what percentage? ");
percent = Convert.ToInt16(Console.ReadLine());

for (int i = 1; i < years + 1; i++)
{
    money += money / 100 * percent;
    Console.WriteLine($"In {i} year you will have {money}.");
    Console.ReadKey();
}
