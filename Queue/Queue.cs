Queue<string> patients = new Queue<string>();

patients.Enqueue("Ivan");
patients.Enqueue("Maxim");
patients.Enqueue("Sergio");

Console.WriteLine("Now on reception goes: " + patients.Dequeue());
Console.WriteLine("Next on reception: " + patients.Peek());

foreach (var patient in patients)
{
    Console.WriteLine(patient);
}