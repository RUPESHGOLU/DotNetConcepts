//find out occurence of each letter and write count

using System.Collections;
using System.Text;

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

//input: abcd , 
//output: a ab abc abcd b bc bcd c cd d
string inputNew = "abcd";
int skip = 0;

for (int i = 0; i < inputNew.Length; i++)
{
    int length = inputNew.Length - skip;
    while (length > 0)
    {
        string subString = inputNew.Substring(i, length);
        Console.WriteLine(subString);
        length--;
    }
    Console.WriteLine();
    skip++;
}
// reverse each word of a sentence
string sentence = "this is a ball";//Output : siht si a llab
string[] arrayWords = new string[10];
arrayWords = sentence.Split(" ");
StringBuilder stringBuilder = new StringBuilder();
foreach (string word in arrayWords)
{
    for (int i = word.Length - 1; i >= 0; i--)
    {
        stringBuilder.Append(word[i]);
    }
    stringBuilder.Append(" ");
}
Console.WriteLine(stringBuilder.ToString());
Console.WriteLine();

int[] intArrayToFindMaxConsecutiveNumbers = [3, 4, 1, 4, 4, 1, 2, 4, 4, 1, 1, 1, 1, 4, 1, 1, 1];

var results = intArrayToFindMaxConsecutiveNumbers.GroupBy(s => s).
ToDictionary(x => new { Letter = x.Key, Count = x.Count() }).Where(s => s.Key.Count > (intArrayToFindMaxConsecutiveNumbers.Length / 2)).ToList();
foreach (var result in results)
{
    Console.WriteLine("integer {0} count is :{1}", result.Key.Letter, result.Key.Count);
}

//Integer array to find out the triplets whose sum value is 9 using c# 
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int targetSum = 9;

for (int i = 0; i < array.Length - 2; i++)
{

    for (int j = i + 1; j < array.Length - 1; j++)
    {
        for (int k = j + 1; k < array.Length; k++)
        {
            if ((array[i] + array[j] + array[k]) == targetSum)
            {
                Console.WriteLine("Triplet is " + array[i] + ", " + array[j] + ", " + array[k]);
            }
        }
    }

}
//reverse a string
string stringToReverse = "Ganesh";
StringBuilder sb = new StringBuilder();
for (int i = stringToReverse.Length - 1; i >= 0; i--)
{
    sb.Append(input[i]);

}
Console.WriteLine(sb.ToString());

//Sum all digits of a number and do until it become single digit
Console.WriteLine("Sum of all digits in a single digit");
ArrayClass arrayClass = new ArrayClass();
int sumofDigits = 8899996;
do
{
    sumofDigits = arrayClass.SumofAllDigits(sumofDigits.ToString());
    Console.WriteLine($"{sumofDigits}");
}
while (sumofDigits > 9);

Console.ReadKey();
public class ArrayClass
{
    public int SumofAllDigits(string number)
    {
        var charArray = number.ToCharArray();
        int sum = 0;
        for (int i = 0; i < charArray.Length; i++)
        {
            int digitValue = Convert.ToInt32( charArray[i].ToString());
            sum += digitValue;
        }
        return sum;
    }

}


