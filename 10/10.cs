static void DrawBar(int value, int maxValue, ConsoleColor color,ref int position, string symbol = " ")
{
    ConsoleColor defaultColor = Console.BackgroundColor;
    string bar = "";
    for (int i = 0; i < value; i++)
    {
        bar += symbol;
    }

    Console.SetCursorPosition(0, position);
    Console.Write('[');
    Console.BackgroundColor = color;
    Console.Write(bar);
    Console.BackgroundColor = defaultColor;

    bar = "";

    for (int i = value; i < maxValue; i++)
    {
        bar += symbol;
    }

    Console.Write(bar + ']');
    position += 1;
}

int health1 = 4;
int health2 = 8;
int maxHealth = 10;
int position = 0;

DrawBar(health2, maxHealth, ConsoleColor.Magenta, ref position, "*");

while (true)
{
    DrawBar(health1, maxHealth, ConsoleColor.Magenta, ref position);
    Console.WriteLine();
    Console.Write("Enter health: ");
    health1 += Convert.ToInt16(Console.ReadLine());
}

