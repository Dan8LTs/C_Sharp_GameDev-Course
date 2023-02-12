namespace _11
{
    internal class Table
    {
        public int Number;
        public int MaxPlaces;
        public int FreePlaces;

        public Table(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Table {Number}. Free places: {FreePlaces} from {MaxPlaces}.");
        }

        public bool Reserve(int seats)
        {
            if (FreePlaces >= seats)
            {
                FreePlaces -= seats;
                return true;
            }
            return false;
        }
    }
}
