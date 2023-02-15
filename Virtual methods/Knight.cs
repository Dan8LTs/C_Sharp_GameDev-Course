namespace Virtual_methods
{
    internal class Knight : NonPlayerCharacter
    {
        public override void ShowDescription()
        {
            Console.WriteLine("I am a knight. I can only fight.");
        }
    }
}
