string inputString = "hello world";
List<String> inputList = ["success", "Rupesh", "INDIA",];

Console.WriteLine("Using Dictionary");
Console.WriteLine();

foreach (string s in inputList)
{
    Dictionary<char, int> charCount = new Dictionary<char, int>();
    Console.WriteLine(s);

    foreach (char c in s)
    {
        if(charCount.ContainsKey(c))
            charCount[c]++;
        else
            charCount[c]=1;
    }
    foreach (var entry in charCount)
    {
        Console.WriteLine($"Character '{entry.Key}' occurs {entry.Value} times.");
    }
}

Console.WriteLine();
Console.WriteLine("Using Linq");
Console.WriteLine();

inputList.ForEach(
    s => {
        Console.WriteLine(s);
        var charCount = s
        .GroupBy(c => c);
        //.ToDictionary(g => g.Key, g => g.Count());
        foreach (var entry in charCount)
        {
            Console.WriteLine($"Character '{entry.Key}' occurs {entry.Count()} times.");
        }
    }
);

