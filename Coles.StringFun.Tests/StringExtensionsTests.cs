using Coles.StringFun.Domain.Extensions;

namespace Coles.StringFun.Tests
{
	public class StringExtensionsTests
	{
		[Theory]
		[InlineData(null, "")]
		[InlineData("I am Testing", "gnitseT ma I")]
		[InlineData("Anna", "annA")]
		public void Test_Reverses_Sentence(string sentence, string expectedReverse)
		{
			var actualReversed = sentence.Reverse();
			Assert.True(expectedReverse.Equals(actualReversed));
		}
	}
}