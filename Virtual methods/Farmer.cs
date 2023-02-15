namespace Virtual_methods
{
    internal class Farmer : NonPlayerCharacter
    {
        public override void ShowDescription()
        {
            base.ShowDescription();
            Console.WriteLine("I am also a farmer and I can work in the field.");
        }
    }
}
