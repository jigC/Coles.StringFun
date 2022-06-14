﻿namespace Coles.StringFun.Domain
{
	public static class StringExtensions
	{
		public static string Reverse(this string sentence)
		{
			if (string.IsNullOrEmpty(sentence)) return string.Empty;

			var arr = sentence.ToCharArray();
			Array.Reverse(arr);
			
			return new string(arr);
		}	
	}
}