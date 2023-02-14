using Is_a_inheritance_;

Knight warrior1 = new Knight(100, 10, 10);
Barbarian warrior2 = new Barbarian(100, 1, 8, 2);

warrior1.TakeDamage(500);
warrior2.TakeDamage(250);

Console.Write("Knight: ");
warrior1.ShowInfo();
Console.Write("Barbarian: ");
warrior2.ShowInfo();