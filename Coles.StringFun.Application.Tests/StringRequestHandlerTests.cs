using Coles.StringFun.Application;
using Coles.StringFun.Domain;
using Xunit;

namespace Coles.StringFun.Tests
{
	public class StringRequestHandlerTests
	{
		private readonly IStringRequestHandler _handler;

		public StringRequestHandlerTests()
		{
			var _functions = new StringFunctions();
			_handler = new StringRequestHandler(_functions);
		}

		[Theory]
		[InlineData(null, "", false)]
		[InlineData(null, null, true)]
		[InlineData("Anna", "anna", true)]
		[InlineData("silent", "LISTEN", true)]
		[InlineData("listen Marc", "silent Cram", true)]
		public void Test_Identifies_Anagram(string word1, string word2, bool areAnagrams)
		{
			var anagramsFound = _handler.CheckIfAreAnagrams(new string[] { word1, word2 });
			Assert.True(anagramsFound.Equals(areAnagrams));
		}
	}
}