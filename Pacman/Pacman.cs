using System.IO;
using System.Threading;

static char[,] ReadMap(string path)
{
    string[] file = File.ReadAllLines(path);
    char[,] map = new char[GetMaxLengthOfLine(file), file.Length];
    for (int x = 0; x < map.GetLength(0); x++)
        for (int y = 0; y < map.GetLength(1); y++)
            map[x, y] = file[y][x];
    return map;
}

static int GetMaxLengthOfLine(string[] lines)
{
    int maxLength = lines[0].Length;

    foreach (var line in lines)
        if (line.Length > maxLength)
            maxLength = line.Length;
    return maxLength;
}


static void DrawMap(char[,] map)
{
    for (int y = 0; y < map.GetLength(1); y++)
    {
        for (int x = 0; x < map.GetLength(0); x++)
        {
            Console.Write(map[x, y]);
        }
        Console.WriteLine();
    }
}


Console.CursorVisible = false;
char[,] map = ReadMap("map.txt");
ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

Task.Run(() =>
{
    while (true)
    {
        pressedKey = Console.ReadKey();
    }
});

int pacmanX = 1;
int pacmanY = 1;
int score = 0;

while (true)
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Green;
    DrawMap(map);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.SetCursorPosition(pacmanX, pacmanY);
    Console.Write("@");

    Console.SetCursorPosition(0, 13);
    Console.Write("Score: " + score);

    HandleInput(pressedKey, ref pacmanX, ref pacmanY, map, ref score);

    Thread.Sleep(256);
}

static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map, ref int score)
{
    switch (pressedKey.Key)
    {
        case ConsoleKey.W:
            if (map[pacmanX, pacmanY - 1] != '#')
                pacmanY -= 1;
                AddScore(ref pacmanX, ref pacmanY, map, ref score);
            break;
        case ConsoleKey.S:
            if (map[pacmanX, pacmanY + 1] != '#')
                pacmanY += 1;
                AddScore(ref pacmanX, ref pacmanY, map, ref score);
            break;
        case ConsoleKey.A:
            if (map[pacmanX - 1, pacmanY] != '#')
                pacmanX -= 1;
                AddScore(ref pacmanX, ref pacmanY, map, ref score);
            break;
        case ConsoleKey.D:
            if (map[pacmanX + 1, pacmanY] != '#')
                pacmanX += 1;
                AddScore(ref pacmanX, ref pacmanY, map, ref score);
            break;
    }
}

static void AddScore(ref int pacmanX, ref int pacmanY, char[,] map, ref int score)
{
    if (map[pacmanX, pacmanY] == '.')
    {
        map[pacmanX, pacmanY] = ' ';
        score += 1;
    }
} 