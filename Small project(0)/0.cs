int health;
int armor;
int damage;
const int percentConverter = 100;

Console.Write("Enter amount of health: ");
health = Convert.ToInt16(Console.ReadLine());

Console.Write("Enter amount of armor: ");
armor = Convert.ToInt16(Console.ReadLine());

Console.Write("Enter amount of damage: ");
damage = Convert.ToInt16(Console.ReadLine());

health -= damage * (health - armor) / percentConverter;
Console.WriteLine($"{damage} damage dealt. {health} health left.");