using _13;

Fighter[] fighters =
    {
        new Fighter("Ivan", 1400, 118, 54),
        new Fighter("Mark", 1120, 128, 28),
        new Fighter("John", 1600, 118, 24),
    };

int fighterNumber;

for (int i = 0; i < fighters.Length; i++)
{
    Console.Write((i + 1 + " "));
    fighters[i].ShowStats();
}

Console.WriteLine("\n** " + new string('-', 26) + " **");
Console.Write("\nChoose first fighter: ");
fighterNumber = Convert.ToInt32(Console.ReadLine());
Fighter firstFighter = fighters[fighterNumber - 1];

Console.Write("\nChoose second fighter: ");
fighterNumber = Convert.ToInt32(Console.ReadLine());
Fighter secondFighter = fighters[fighterNumber - 1];

while (firstFighter.Health > 0 && secondFighter.Health > 0)
{
    firstFighter.TakeDamage(secondFighter.Damage);
    secondFighter.TakeDamage(firstFighter.Damage);
    firstFighter.ShowCurrentHealth();
    secondFighter.ShowCurrentHealth();
}

if (firstFighter.Health < 0 && secondFighter.Health < 0)
{
    Console.WriteLine($"Draw!");
}
else if (firstFighter.Health < 0)
{
    Console.WriteLine(secondFighter.Name + " won!");
}
else
{
    Console.WriteLine(firstFighter.Name + " won!");
}