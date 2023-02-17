using Pattern_Update_Cycle;

Behaviour[] behaviours =
{
    new Walker(),
    new Jumper()
};

while (true)
{
    foreach (var behavior in behaviours)
    {
        behavior.Update();
        Thread.Sleep(1000);
    }
}