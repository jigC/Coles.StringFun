namespace Coles.StringFun.Domain.Extensions
{
	public static class StringExtensions
	{
		/*
		 * Function to reverse string passed to it
		*/
		public static string Reverse(this string sentence)
		{
			if (string.IsNullOrEmpty(sentence)) return string.Empty;

			var arr = sentence.ToCharArray();
			Array.Reverse(arr);

			return new string(arr);
		}
	}
}