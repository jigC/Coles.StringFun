namespace Coles.StringFun.Application
{
	public interface IArrayRequestHandler<T> where T : IEquatable<T> 
	{
		T[] GetDistinct(T[] elements);
	}
}