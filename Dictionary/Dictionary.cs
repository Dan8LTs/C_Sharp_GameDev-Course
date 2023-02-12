Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();

countriesCapitals["Russia"] = "Moscow";
countriesCapitals.Add("Sweden", "Stockholm");

foreach (var pair in countriesCapitals)
{
    Console.WriteLine(pair.Value + " (" + pair.Key + ")");
}

if (countriesCapitals.ContainsKey("Russia")) ;
Console.WriteLine(countriesCapitals["Russia"]);

Console.WriteLine();
foreach (var capital in countriesCapitals.Values)
{
    Console.WriteLine(capital);
}

Console.WriteLine();
countriesCapitals.Remove("Russia");
foreach (var pair in countriesCapitals)
{
    Console.WriteLine(pair.Value + " (" + pair.Key + ")");
}