namespace Has_a
{
    internal class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowTasks()
        {
            foreach (var task in Tasks)
            {
                task.ShowInfo();
            }
        }
    }
}
