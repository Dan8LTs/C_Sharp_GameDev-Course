int money;
int food;
int foodUnitPrice = 10;
bool isAbleToPay;

Console.WriteLine($"Welcome to our bakery. Today food is {foodUnitPrice} coins.");
Console.Write("How many coins do you have?");
money = Convert.ToInt16(Console.ReadLine());
Console.Write("How much food do you need?");
food = Convert.ToInt16(Console.ReadLine());

isAbleToPay = money >= food * foodUnitPrice;
food *= Convert.ToInt16(isAbleToPay);
money -= food * foodUnitPrice;
Console.WriteLine($"You have {food} units of food, and {money} coins.");