

using Coles.StringFun.Host;
using Coles.StringFun.Domain;

Console.WriteLine("\nWelcome to Coles Fun With Strings");

var options = new List<string>() { "1", "2", "3", "4", "X" };
var userChoiceValid = true;
var userChoice = "";
Console.WriteLine("\n\n\nChoose your option from:");
do
{
    if (!userChoiceValid)
        Console.WriteLine("\n\nInvalid choice, please choose your option from following or press 'X' to Quit:");

    Console.WriteLine("\n\t 1. Reverse the letters of words within the sentence");
    Console.WriteLine("\n\t 2. Detect if two sets of characters are anagrams");
    Console.WriteLine("\n\t 3. Remove the repeated elements of an array");
    Console.WriteLine("\n Press X to QUIT");

    userChoice = Console.ReadLine();
    userChoiceValid = Helper.HasSelectedRightOption(options, userChoice ?? "");
    Console.Clear();

} while (!userChoiceValid);

switch (userChoice?.ToLower())
{
    case "1":
        Console.WriteLine($"\nEnter sentence to reverse:");
        var sentence = Console.ReadLine();
        if (sentence?.Length < 1)
        {
            Console.WriteLine("\nInvalid sentence");
            break;
        }
        Console.WriteLine($"\n Reveresed {sentence?.Reverse()}");
        break;

    case "2":
        Console.WriteLine($"\nEnter first word to test for anagrams:");
        var word1 = Console.ReadLine();
        Console.WriteLine($"\nEnter second word to test for anagrams:");
        var word2 = Console.ReadLine();
        var areAnagrams = StringFunctions.AreAnagrams(word1, word2) == true ? "" : " not ";
        Console.WriteLine($"\n The words {word1} and {word2} are{areAnagrams} anagrams");
        break;

    case "3":
        Console.WriteLine($"\nEnter words to remove repeated elements (seperated by commas):");
        var words = Console.ReadLine();

        if (words?.Length < 1)
        {
            Console.WriteLine("\nInvalid list");
            break;
        }

        var arrayExtensions = new ArrayFunctions<string>();
        var wordArray = words?.Split(',');
        var distinctList = arrayExtensions.Distinct(wordArray);
        Console.WriteLine($"\nDistinct string list: {string.Join(",", distinctList)}");
        break;

    default:
        break;
}

Console.WriteLine("\n\n\n\t THANK YOU FOR PLAYING");