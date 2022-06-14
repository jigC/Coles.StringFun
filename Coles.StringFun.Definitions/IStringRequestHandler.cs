namespace Coles.StringFun.Application
{
	public interface IStringRequestHandler
	{
		string GetReverse(string sentence);

		bool CheckIfAreAnagrams(string[] word);
	}
}