// Pseudo - random number generator.
Random rand = new Random();
// 0 - 8
int value;

while (true)
{
    value = rand.Next(0, 9);
    Console.WriteLine(value);
    Console.ReadKey();
}


// Invalid way to generate random numbers.
/*
for (int i = 0; i < 4; i++)
{
    Random rand1 = new Random();
    Console.WriteLine(rand1.Next(0, 4));
}
*/