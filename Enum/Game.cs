namespace Enum
{
    internal class Game
    {
        private string _title;
        private Genre _genre;

        public Game(string title, Genre genre)
        {
            _title = title;
            _genre = genre;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"This is {_title} in {(int)_genre} genre.");
        }
    }
}
