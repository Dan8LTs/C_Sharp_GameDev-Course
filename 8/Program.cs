using System.Collections.Generic;

string[,] books =
{
    { "E. Hunt, D. Thomas", "John Sonmez", "Geoffrey Richter"},
    { "Charles Petzold", "Robert Martin", "Igor Savchuk"},
    { "Joel Spolsky", "Maxim Dorofeev", "Corey Althoff"},
};

while (true)
{
    Console.SetCursorPosition(0, 8);
    Console.WriteLine("\nAll list of authors\n");
    for (int i = 0; i < books.GetLength(0); i++)
    {
        for (int j = 0; j < books.GetLength(1); j++)
        {
            Console.Write(books[i, j] + " | ");
        }
        Console.WriteLine();
    }

    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Library");
    Console.WriteLine("\n1 - find out the name of the author by the index of the book." +
                               "\n2 - find out book by the author.");
    Console.Write("Enter command number: ");
    switch (Console.ReadLine())
    {
        case "1":
            int line, column;
            Console.Write("Enter shelf number: ");
            line = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Enter column number: ");
            column = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine(books[line, column]);
            break;
        case "2":
            string author;
            bool authorIsFound = false;
            Console.Write("Enter author: ");
            author = Console.ReadLine();
            for (int i = 0; i < books.GetLength(0); i++)
            {
                for (int j = 0; j < books.GetLength(1); j++)
                {
                    if(author.ToLower() == books[i, j].ToLower())
                    {
                        Console.Write($"Author {books[i, j]} is on the {i+1} shelf, in column {j + 1}.");
                        authorIsFound = true;
                    }
                }
            }
            if (!authorIsFound)
            {
                Console.WriteLine("There isn't such author.");
            }
            break;
        default:
            Console.WriteLine("You entered wrong command.");
            break;
    }
    Console.ReadKey();
    Console.Clear();
}