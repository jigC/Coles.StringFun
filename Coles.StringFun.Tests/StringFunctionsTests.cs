using Coles.StringFun.Domain;

namespace Coles.StringFun.Tests
{
	public class StringFunctionsTests
	{
		private StringFunctions _functions;

		public StringFunctionsTests()
		{
			_functions = new StringFunctions();
		}

		[Theory]
		[InlineData(null, "", false)]
		[InlineData(null, null, true)]
		[InlineData("Anna", "anna", true)]
		[InlineData("silent", "LISTEN", true)]
		[InlineData("listen Marc", "silent Cram", true)]
		public void Test_Identifies_Anagram(string word1, string word2, bool areAnagrams)
		{
			var anagramsFound = _functions.AreAnagrams(word1, word2);
			Assert.True(anagramsFound.Equals(areAnagrams));
		}
	}
}