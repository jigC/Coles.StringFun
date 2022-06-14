
namespace Coles.StringFun.Host
{ 
	public static class Helper
	{
		public static bool HasSelectedRightOption(List<string> options, string answer)
		{
			return options.Where(x => x.ToLower().Trim() == answer.ToLower().Trim()).Any();
		}
	}
}
