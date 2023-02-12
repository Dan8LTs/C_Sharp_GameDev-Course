List<int> numbers = new List<int>();

numbers.Add(12);
numbers.Add(13);
numbers.Add(14);
numbers.Add(15);
numbers.Add(16);

numbers.AddRange(new int[] { 2, 5, 6, 7 });
numbers.RemoveAt(3);
numbers.Remove(13);
numbers.Insert(4, 62);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine();
Console.WriteLine(numbers.IndexOf(12));
Console.WriteLine(numbers.IndexOf(13));

numbers.Clear();