using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string name;
Console.Write("Enter your name: ");
name = Console.ReadLine();
Console.WriteLine(name);

string greeting = "Hello,";
int age = 15;
// string + string = string
// string + number = string
Console.WriteLine($"""{greeting} {name} You are: """ + age);

Console.ReadKey();

Console.SetCursorPosition(0, 8);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.BackgroundColor = ConsoleColor.Yellow;
Console.Clear();
Console.WriteLine("Hello, Andrew!\nWhere were you yesterday?\nI was at home.]\b \b");
Console.ReadKey();
Console.Clear();