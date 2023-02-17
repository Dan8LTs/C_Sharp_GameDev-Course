namespace Static
{
    internal class User
    {
        public static int IDs;
        public int ID;
        public static int MenHourPrice;

        public User()
        {
            ID = ++IDs;
        }

        public void ShowInfo()
        {
            Console.WriteLine(ID);
        }

        public static int GetSalaryPerDay(int workedHours)
        {
            return MenHourPrice * workedHours;
        }

        public int GetSalaryPerMonth(int workedHours)
        {
            return GetSalaryPerDay(8) * workedHours;
        }
    }
}
