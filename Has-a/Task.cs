namespace Has_a
{
    internal class Task
    {
        public Performer Worker;
        public string Description;

        public Task(Performer worker, string description)
        {
            Worker = worker;
            Description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Responsible: {Worker.Name}.\n Task: {Description}");
        }
    }
}
