namespace Coles.StringFun.Definitions
{
	public interface IArrayFunctions<T> where T : IEquatable<T>
	{
		T[] Distinct(T[] elements);
	}
}