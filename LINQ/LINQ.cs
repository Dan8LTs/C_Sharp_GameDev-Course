using LINQ;

List<Player> players = new List<Player>()
{
    new Player("Bill", 100),
    new Player("Max", 128),
    new Player("Ivan", 88),
    new Player("Vlad", 256)
};

List<Player> players2 = new List<Player>()
{
    new Player("Nick", 123),
    new Player("Roman", 234)
};

var unitedTeam = players.Union(players2).ToList();
foreach (var player in unitedTeam)
{
    Console.WriteLine(player.Login);
}

Console.WriteLine();

/*
List<Player> filteredPlayers = new List<Player>();
foreach (Player player in players)
{
    if (player.Level > 128)
        filteredPlayers.Add(player);
}
*/
var filteredPlayers = from Player player in players where player.Level > 128 select player.Login;
var filteredPlayers2 = players.Where(player => player.Level > 128).Select(player => player);
var filteredPlayers3 = players.Where(player => player.Login.ToUpper().StartsWith("I"));
var orderedPlayersByLevel = players.OrderBy(player => player.Level);

foreach (var player in filteredPlayers)
{
    Console.WriteLine(player);
}

Console.WriteLine();

foreach (var player in filteredPlayers3)
{
    Console.WriteLine(player.Login);
}

Console.WriteLine();

foreach (var player in orderedPlayersByLevel)
{
    Console.WriteLine(player.Login);
}

var maxLevelPlayer = players.Max(player => player.Level);
Console.WriteLine(maxLevelPlayer);

var newPlayers = from Player player in players select new { Name = player.Login, dateOfBirth = DateTime.Now };
var newPlayers2 = players.Select(player => new { Name = player.Login, dateOfBirth = "Sunday" });

foreach (var player in newPlayers)
{
    Console.WriteLine(player.Name + " " + player.dateOfBirth);
    Thread.Sleep(1000);
}

foreach (var player in newPlayers2)
{
    Console.WriteLine(player.Name + " " + player.dateOfBirth);
}

var filteredPlayers4 = players.Take(2);
foreach (var player in filteredPlayers4)
{
    Console.WriteLine(player.Login);
}

Console.WriteLine();

var filteredPlayers5 = players.SkipWhile(player => player.Login.StartsWith("V"));
foreach (var player in filteredPlayers5)
{
    Console.WriteLine(player.Login);
}