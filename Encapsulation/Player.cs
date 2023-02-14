namespace Encapsulation
{
    internal class Player
    {
        public int X { get; private set; }
        private int _y;

        public Player(int x, int y)
        {
            X = x;
            _y = y;
        }

        public int GetY()
        {
            return _y;
        }
    }
}
