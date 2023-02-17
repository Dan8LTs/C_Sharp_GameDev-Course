namespace _14
{
    internal class ComputerClub
    {
        private int _money = 0;
        private List<Computer> _computers = new List<Computer>();
        private Queue<Client> _clients = new Queue<Client>();

        public ComputerClub(int computersCount)
        {
            Random random = new Random();

            for (int i = 0; i < computersCount; i++)
            {
                _computers.Add(new Computer(random.Next(12, 26)));
            }
            CreateNewClients(26, random);
        }

        public void CreateNewClients(int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                _clients.Enqueue(new Client(random.Next(128, 512), random));
            }
        }

        public void Work()
        {
            while (_clients.Count > 0)
            {
                Client newClient = _clients.Dequeue();

                Console.WriteLine($"Computer club balance: {_money} coins. We are waiting for new clients.");
                Console.WriteLine($"We have a new client. He wants to buy {newClient.DesiredMinutes} minutes.");
                ShowAllComputersState();

                Console.Write("\nYou offer him computer number: ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int computerNumber))
                {
                    computerNumber -= 1;

                    if (computerNumber >= 0 && computerNumber < _computers.Count)
                    {
                        if (_computers[computerNumber].IsTaken)
                        {
                            Console.WriteLine("You are trying to put the client on the busy computer. He got angry and left.");
                        }
                        else
                        {
                            if (newClient.CheckSolvency(_computers[computerNumber]))
                            {
                                Console.WriteLine("Client paid for the computer #" + (computerNumber + 1));
                                _money += newClient.Pay();
                                _computers[computerNumber].BecomeTaken(newClient);
                            }
                            else
                            {
                                Console.WriteLine("Client hasn't got enough money. He left.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You do not know which computer to put the client on. He got angry and left.");
                    }
                }
                else
                {
                    CreateNewClients(1, new Random());
                    Console.WriteLine("Wrong format! Please, try again!");
                }
                Console.ReadKey();
                Console.Clear();
                SpentOneMinute();
            }
        }

        private void ShowAllComputersState()
        {
            Console.WriteLine("\nList of all computers:");
            for (int i = 0; i < _computers.Count; i++)
            {
                Console.Write(i + 1 + " - ");
                _computers[i].ShowState();
            }
        }

        private void SpentOneMinute()
        {
            foreach (var computer in _computers)
            {
                computer.SpendOneMinute();
            }
        }
    }
}
