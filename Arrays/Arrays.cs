using System.Diagnostics.CodeAnalysis;

int[] cucumbers = new int[8];
Console.WriteLine(cucumbers[0]);

Random rand = new Random();


Console.WriteLine(cucumbers.Length);
for (int i = 0; i < cucumbers.Length; i++)
{
    cucumbers[i] = rand.Next(0, 100);
    Console.WriteLine(cucumbers[i]);
}

Console.ReadKey();
Console.Clear();

int[] tomatoes = new int[8] { 1, 4, 2, 5, 1, 2, 24, 42 };
for (int i = 0; i < tomatoes.Length; i++)
{
    Console.WriteLine(tomatoes[i]);
}

Console.ReadKey();
Console.Clear();

int sum = 0;
int max = int.MinValue;
int[] array = { 2, 4, 8, 12, 26, 32 };
foreach (var el in array)
{
    sum += el;
    if (el > max)
    {
        max = el;
    }
}
Console.WriteLine(sum);
Console.WriteLine(max);

Console.ReadKey();
Console.Clear();

int[,] MultiArray;
int[,] MultiArray2 = new int[8, 8];

int[,] MultiArray3 = {
    { 2, 3, 4 },
    { 1, 4, 5 },
    { 2, 5, 7 }
};

int[,] MultiArray4 = new int[2, 3]
{
    {1, 2, 5},
    {3, 4, 6},
};

Console.WriteLine(MultiArray4.Length);
Console.WriteLine(MultiArray4.GetLength(0));
Console.WriteLine(MultiArray4.GetLength(1));

foreach (var el in MultiArray4)
{
    Console.WriteLine(el);
}

for (int i = 0; i < MultiArray2.GetLength(0); i++)
{
    for (int j = 0; j < MultiArray2.GetLength(1); j++)
    {
        MultiArray2[i, j] = rand.Next(0, 10);
        Console.Write(MultiArray2[i, j] + " ");
    }
    Console.WriteLine();
}

Console.ReadKey();
Console.Clear();

// array is a reference type.
int[] array1 = new int[8];
int[] array2;
array2 = array1;
array1[0] = 1;
Console.WriteLine(array2[0]);

Console.ReadKey();
Console.Clear();

int[] bag = new int[1];
bag[0] = 1;
int[] tempBag = new int[bag.Length + 1];
for (int i = 0; i < bag.Length; i++)
{
    tempBag[i] = bag[i];
    Console.WriteLine(bag[i]);
}
Console.WriteLine();
bag = tempBag;
for (int i =0; i < bag.Length; i++)
{
    Console.WriteLine(bag[i]);
}