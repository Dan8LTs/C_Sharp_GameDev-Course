Random rand = new Random();
int health1 = rand.Next(90, 100);
int damage1 = rand.Next(12, 48);
int armor1 = rand.Next(45, 60);

int health2 = rand.Next(80, 120);
int damage2 = rand.Next(15, 60);
int armor2 = rand.Next(26, 48);

Console.WriteLine($"Gladiator 1 - {health1} health, {damage1} damage, {armor1} armor.");
Console.WriteLine($"Gladiator 2 - {health2} health, {damage2} damage, {armor2} armor.");

int health1temp = health1;
int health2temp = health2;

while (health1temp > 0 && health2temp > 0)
{
    health1temp -= rand.Next(0, damage2) * (health1 - armor1) / 100;
    health2temp -= rand.Next(0, damage1) * (health2 - armor2) / 100;

    Console.WriteLine("Gladiator Health 1: " + health1temp);
    Console.WriteLine("Gladiator Health 2: " + health2temp);
}

if (health1temp <= 0 && health2temp <= 0)
{
    Console.WriteLine("Draw. Both gladiators died.");
}
else if (health1temp <= 0)
{
    Console.WriteLine("Gladiator 1 died.");
}
else if (health2temp <= 0)
{
    Console.WriteLine("Gladiator 2 died.");
}