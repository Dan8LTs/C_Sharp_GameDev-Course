using Enum;

List<Game> games = new List<Game>();
games.Add(new Game("Black and White", Genre.Strategy));
games.Add(new Game("The Witcher 3: Wild Hunt", Genre.RPG));
games.Add(new Game("Sid Miser's Civilization VI", Genre.Strategy));
games.Add(new Game("Ori and the Will of the Wisps", Genre.Action));

foreach (var game in games)
{
    game.ShowInfo();
}
Console.WriteLine((Genre)2);

enum Genre : uint
{
    Strategy = 1,
    RPG,
    Action
}