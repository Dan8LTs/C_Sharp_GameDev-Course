for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i++);
}

Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(++i);
}

Console.WriteLine();
int a = 0;
Console.WriteLine(a++ + ++a);

// Increment and decrement have the highest priority in calculations.