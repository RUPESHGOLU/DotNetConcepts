//find out occurence of each letter and write count

using System.Collections;

List<String> inputList = ["success", "Rupesh"];

Console.WriteLine("Using Dictionary");
Console.WriteLine();

foreach (string inputString in inputList)
{
    Dictionary<char, int> charCount = new Dictionary<char, int>();
    Console.WriteLine(inputString);

    foreach (char c in inputString)
    {
        if (charCount.ContainsKey(c))
            charCount[c]++;
        else
            charCount[c] = 1;
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
    s =>
    {
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

string input = "successfully";
//find out letter appeared more than once
Console.WriteLine();
Console.WriteLine("Find out letter appeared more than once");
Console.WriteLine();
var letterCounts = input.GroupBy(c => c).ToDictionary(x => new { Letter = x.Key, Count = x.Count() }).Where(s => s.Key.Count > 1);
foreach (var letter in letterCounts)
{
    Console.WriteLine($"Character '{letter.Key.Letter}' appeared more than once {letter.Key.Count}.");
}

//find out consecutive letters 
Console.WriteLine();
Console.WriteLine("Find out consecutive letters");
Console.WriteLine();
char lastLetter = new char();
int counter = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == lastLetter)
    {
        Console.WriteLine("{0} consecutive letter", lastLetter);
        counter++;
    }
    lastLetter = input[i];
}
Console.WriteLine("Total consecutive letters appeared {0}", counter);
Console.WriteLine();

Console.WriteLine("Sort these numbers in ascending order 10,35,15,25,20,30,5");
//Sort these numbers in ascending order 10,35,15,25,20,30,5 without using any inbuilt function
int[] intArray = [10, 35, 15, 25, 20, 30, 5];
//Array.Sort(intArray); // Array.Sort() function sorts  
int temp = 0;
int iCounter = 0;
int jCounter = 0;
for (int i = 0; i < intArray.Length; i++)
{
    iCounter++;
    for (int j = i + 1; j < intArray.Length; j++)
    {
        jCounter++;
        if (intArray[i] > intArray[j])// use less than '<' to sort in descending
        {
            temp = intArray[i];
            intArray[i] = intArray[j];
            intArray[j] = temp;
        }
    }
}
Console.WriteLine("Array sort in asscending order, i Counter = {0} j Counter = {1}", iCounter, jCounter);
Console.WriteLine(string.Join(",", intArray));
Console.WriteLine();

//find maximum number without using any inbuilt function
Console.WriteLine("Find maximum number 70, 10, 35, 15, 25, 20, 30, 5, 40");
intArray = [70, 10, 35, 15, 25, 20, 30, 5, 40];
temp = 0;
for (int i = 0; i < intArray.Length; i++)
{
    if (temp < intArray[i])
        temp = intArray[i];
}
Console.WriteLine("Maximum number is: {0}", temp);