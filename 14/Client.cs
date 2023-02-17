namespace _14
{
    internal class Client
    {
        private int _money;
        private int _moneyToPay;

        public int DesiredMinutes { get; private set; }
        public Client(int money, Random random)
        {
            _money = money;
            DesiredMinutes = random.Next(8, 32);
        }
        public bool CheckSolvency(Computer computer)
        {
            _moneyToPay = DesiredMinutes * computer.PricePerMinute;
            if (_money >= _moneyToPay)
            {
                return true;
            }
            else
            {
                _moneyToPay = 0;
                return false;
            }
        }

        public int Pay()
        {
            _money -= _moneyToPay;
            return _moneyToPay;
        }
    }
}
