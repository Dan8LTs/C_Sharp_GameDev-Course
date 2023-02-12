Console.WriteLine("Hello!");
Console.WriteLine("Are you here?");
// "No internet connection(" - argument
WriteError("No internet connection(", symbol: '#');
Console.WriteLine("Strange...");
WriteError("The Internet tariff has expired.", ConsoleColor.Yellow);

// text - parameter
static void WriteError(string text, ConsoleColor color = ConsoleColor.Magenta, char symbol = '!')
{
    ConsoleColor defaultColor = Console.ForegroundColor;
    Console.ForegroundColor = color;
    Console.WriteLine(symbol + text);
    Console.ForegroundColor = defaultColor;
}

int number = 8;
Console.WriteLine(Root(number) + 128);
static double Root(int x)
{
    return Math.Sqrt(x);
}

int sum, x = 1, y = 5;
Add(out sum, x, y);
Console.WriteLine(sum);

static void Add(out int sum, int x, int y)
{
    sum = x + y;
}


static void Prod(ref int product, int x1, int y1)
{
    product = x1 * y1;
}
int product = 0, x1 = 1, y1 = 5;
Prod(ref product, x1, y1);
Console.WriteLine(product);

static int[] EditArray(ref int[] array, int index, int value)
{
    int[] TempArray = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        TempArray[i] = array[i];
    }

    TempArray[index] = value;
    array = TempArray;
    return array;
}

int[] array = { 4, 2, 3, 5, 6 };
EditArray(ref array, 2, 6);
foreach (var el in array)
{
    Console.Write(el + " ");
}