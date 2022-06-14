
namespace Coles.StringFun.Host
{
	public static class Helper
	{
		public static List<string> GetUserOptions()
		{
			/*
			 1. Reverse the letters of words within the sentence
			 2. Detect if two sets of characters are anagrams
			 3. Remove the repeated elements of an array
			X to QUIT");
		   */
			return new List<string>() { "1", "2", "3", "X" };
		}

		public static bool HasSelectedRightOption(List<string> options, string answer)
		{
			return options.Where(x => x.ToLower().Trim() == answer.ToLower().Trim()).Any();
		}

		public static string? GetUserChoice(LogWriter writer, List<string> options)
		{
			var isChoiceValid = true;
			var userChoice = "";
			do
			{
				if (!isChoiceValid)
					writer.Write("\n\nInvalid choice, please choose your option from following or press 'X' to Quit:");

				writer.Write("\n\t 1. Reverse the letters of words within the sentence");
				writer.Write("\n\t 2. Detect if two sets of characters are anagrams");
				writer.Write("\n\t 3. Remove the repeated elements of an array");
				writer.Write("\n Press X to QUIT");

				userChoice = Console.ReadLine();
				isChoiceValid = Helper.HasSelectedRightOption(options, userChoice ?? "");
				Console.Clear();

			} while (!isChoiceValid);

			return userChoice;
		}

		public static bool GetReverse(List<string> options, string answer)
		{
			return options.Where(x => x.ToLower().Trim() == answer.ToLower().Trim()).Any();
		}
	}
}
