namespace Static_constructor
{
    internal class MyClass
    {
        public static float StaticField;

        static MyClass()
        {
            StaticField = 8;
            Console.WriteLine("Static constructor.");
        }

        public MyClass()
        {
            Console.WriteLine("Constructor.");
        }
    }
}
