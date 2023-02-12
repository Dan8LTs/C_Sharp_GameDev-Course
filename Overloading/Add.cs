namespace Overloading
{
    internal class Add
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static string Sum(string x, string y, string z)
        {
            return x + " " + y + " " + z;
        }
    }
}