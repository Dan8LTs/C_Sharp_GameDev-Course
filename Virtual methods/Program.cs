using Virtual_methods;

NonPlayerCharacter[] characters =
{
    new NonPlayerCharacter(),
    new Farmer(),
    new Knight(),
    new Child()
};

foreach (var character in characters)
{
    character.ShowDescription();
    Console.WriteLine(new string('-', 62));
}