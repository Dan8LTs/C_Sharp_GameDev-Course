int[] sectors = { 6, 32, 16, 16, 26 };

while (true)
{
    Console.SetCursorPosition(0, 12);
    for (int i = 0; i < sectors.Length; i++)
    {
        Console.WriteLine($"There are {sectors[i]} places available in the sector #{i + 1}.");
    }

    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Flight registration.");

    int userSector, userPlaceAmount;
    Console.Write("In what sector do you want to fly? ");
    userSector = Convert.ToInt32(Console.ReadLine()) - 1;
    if(sectors.Length <= userSector || userSector < 0)
    {
        Console.WriteLine("There is no such sector. ");
        continue;
    }
    Console.Write("How many seats do you want to book? ");
    userPlaceAmount = Convert.ToInt32(Console.ReadLine());
    if (userPlaceAmount <= 0)
    {
        Console.WriteLine("Incorrect number of seats.");
        break;
    }
    if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
    {
        Console.WriteLine($"The are not enough seats in sector #{userSector + 1}. " + $"There are {sectors[userSector]} places left.");
        break;
    }
    sectors[userSector] -= userPlaceAmount;
    Console.WriteLine("Success!");
    break;
}