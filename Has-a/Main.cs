using Has_a;

Performer worker1 = new Performer("Ivan");
Performer worker2 = new Performer("Alexey");

Has_a.Task[] tasks = { new Has_a.Task(worker1, "Prepare for the exam."), new Has_a.Task(worker2, "Make a presentation.") };
Board schedule = new Board(tasks);
schedule.ShowTasks();