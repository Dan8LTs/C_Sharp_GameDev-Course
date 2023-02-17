namespace _14
{
    internal class Computer
    {
        private Client _client;
        private int _minutesRamaining;

        public int PricePerMinute { get; private set; }
        public bool IsTaken
        {
            get
            {
                return _minutesRamaining > 0;
            }
        }

        public Computer(int pricePerMinute)
        {
            PricePerMinute = pricePerMinute;
        }

        public void BecomeTaken(Client client)
        {
            _client = client;
            _minutesRamaining = _client.DesiredMinutes;
        }
        public void BecomeFree()
        {
            _client = null;
        }
        public void SpendOneMinute()
        {
            _minutesRamaining--;
        }
        public void ShowState()
        {
            if (IsTaken)
                Console.WriteLine($"Computer is busy, {_minutesRamaining} minutes left.");
            else
                Console.WriteLine($"Computer is free, price per minute: {PricePerMinute}.");
        }
    }
}
