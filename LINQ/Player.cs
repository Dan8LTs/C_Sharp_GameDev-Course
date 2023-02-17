namespace LINQ
{
    internal class Player
    {
        public string Login { get; private set; }

        public int Level { get; private set; }

        public Player(string login, int level)
        {
            Login = login;
            Level = level;
        }
    }
}
