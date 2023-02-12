using _11;

Table[] tables = { new Table(1, 4), new Table(2, 8), new Table(3, 12) };

while (true)
{
    Console.WriteLine("Cafe administration");

    Console.WriteLine();
    foreach (var table in tables)
        table.ShowInfo();

    Console.Write("\nEnter table number: ");
    int wishTable = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nEnter count of seats you would like to reserve: ");
    int count = Convert.ToInt32(Console.ReadLine());

    bool isReservationCompleted = false;
    foreach (var table in tables)
    {
        if (table.Number == wishTable)
        {
            isReservationCompleted = table.Reserve(count);
            break;
        }
    }

    if (isReservationCompleted)
    {
        Console.WriteLine("Successfully!");
    }
    else
    {
        Console.WriteLine("Not enough seats.");
    }
    Console.ReadKey();
    Console.Clear();
}