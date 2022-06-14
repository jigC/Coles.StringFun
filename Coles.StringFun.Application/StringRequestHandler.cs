using Coles.StringFun.Definitions;

namespace Coles.StringFun.Application
{

	public class StringRequestHandler : IStringRequestHandler
	{
		private readonly IStringFunctions _stringFunctions;

		public StringRequestHandler(IStringFunctions stringFunctions)
		{
			_stringFunctions = stringFunctions;
		}

		public string GetReverse(string sentence)
		{
			return _stringFunctions.Reverse(sentence);
		}

		public bool CheckIfAreAnagrams(string[] word)
		{
			if (word.Length <= 1) throw new ApplicationException("Invalid Input");
			return _stringFunctions.AreAnagrams(word[0], word[1]);
		}
	}
}