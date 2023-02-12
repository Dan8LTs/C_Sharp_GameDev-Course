Console.CursorVisible = false;
char[,] map =
{
    { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
    { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','$',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ','#','#','#','#',' ',' ',' ',' ',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#' },
    { '#','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    { '#',' ',' ',' ',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
    { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
};

int playerX = 6, playerY = 6;
char[] bag = new char[1];

while (true)
{
    Console.SetCursorPosition(0, 20);
    Console.Write("Bag: ");
    for (int i = 0; i < bag.Length; i++)
    {
        Console.Write(bag[i] + " ");
    }


    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            Console.Write(map[i, j]);
        }
        Console.WriteLine();
    }
    Console.SetCursorPosition(playerY, playerX);
    Console.WriteLine('@');
    ConsoleKeyInfo key = Console.ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.W:
            if (map[playerX - 1, playerY] != '#')
            {
                playerX--;
            }
            break;
        case ConsoleKey.S:
            if (map[playerX + 1, playerY] != '#')
            {
                playerX++;
            }
            break;
        case ConsoleKey.A:
            if (map[playerX, playerY - 1] != '#')
            {
                playerY--;
            }
            break;
        case ConsoleKey.D:
            if (map[playerX, playerY + 1] != '#')
            {
                playerY++;
            }
            break;
    }

    if (map[playerX, playerY] == '$')
    {
        map[playerX, playerY] = '0';
        char[] tempBag = new char[bag.Length + 1];
        for (int i = 0; i < bag.Length; i++)
        {
            tempBag[i] = bag[i];
        }
        tempBag[tempBag.Length - 1] = '$';
        bag = tempBag;
    }
    Console.Clear();
}
