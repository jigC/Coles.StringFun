namespace Coles.StringFun.Domain
{

	public static class StringFunctions
	{
		public static bool AreAnagrams(this string word1, string word2)
		{
			if (word1 == null && word2 == null) return true;

			if (word1?.Length != word2?.Length) return false;

			var word1Characters = word1?.ToLower().ToCharArray();
			var word2Characters = word2?.ToLower().ToCharArray();

			Array.Sort(word1Characters);
			Array.Sort(word2Characters);

			var sortedString1 = new string(word1Characters);
			var sortedString2 = new string(word2Characters);

			return sortedString1.Equals(sortedString2, StringComparison.CurrentCultureIgnoreCase);
		}
	}
}