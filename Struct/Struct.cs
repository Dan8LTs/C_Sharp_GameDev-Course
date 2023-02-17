using Struct;

Vector2 position1;
position1.X = 8;
position1.Y = 8;

Vector2 position2 = new Vector2(12);
Vector2 position3 = default(Vector2);

Console.WriteLine(position1.X);
Console.WriteLine(position2.X);
Console.WriteLine(position3.X);

Vector2 playerPosition = new Vector2(4, 4);
Vector2 targetPosition = playerPosition;
playerPosition.X += 8;
Console.WriteLine(targetPosition.X);

GameObject bullet = new GameObject();
Console.WriteLine(bullet.Position.X);
Vector2 newPosition = bullet.Position;
newPosition.X = 80;
bullet.Position = newPosition;
Console.WriteLine(bullet.Position.X);

struct Vector2
{
    public int X, Y;
    public Vector2(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Vector2(int x) : this()
    {
        X = x;
    }
}