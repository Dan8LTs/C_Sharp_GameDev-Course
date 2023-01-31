int number1 = 1;
int number2 = 2;

Console.WriteLine(number1 == number2);
Console.WriteLine(number1 != number2);
Console.WriteLine(number1 <= number2);
Console.WriteLine(number1 >= number2);

bool less =number1 < number2;
bool more = number1 > number2;

Console.WriteLine();
// && equals *
// || equals +
Console.WriteLine(less && more);
Console.WriteLine(less || more);

int money = 500;
int level = 10;
if (money >= 500 || level >= 10)
{
    Console.WriteLine(level += 1);
}
else
{
    Console.WriteLine(level);
}