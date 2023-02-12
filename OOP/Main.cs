using OOP;

Car ferrari = new Car("F40", 30, 240);
Car mercedes = new Car("GLE", 4, 367, 250);
Car tesla = new Car();

ferrari.ShowTechnicalPassport();

Console.WriteLine();

mercedes.ShowTechnicalPassport();

Console.WriteLine();

mercedes.Name = "ML";
mercedes.BecomeOlder(8, 128);
mercedes.ShowTechnicalPassport();

Console.WriteLine();
tesla.ShowTechnicalPassport();