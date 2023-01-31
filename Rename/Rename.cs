string source = @"C:\Users\Данил\source\repos\GameDev Course\GameDev Course";
string[] directories = Directory.GetDirectories(source);

foreach (string d in directories)
{
    string[] dest = d.Split("\\");
    int nl = dest.Count() - 1;
    string destination = d + "\\" + dest[nl] + ".cs";

    string[] files = Directory.GetFiles(d);

    foreach (string file in files)
    {
        if (file.EndsWith("Program.cs"))
        {
            File.Move(file, destination);
        }
    }
}