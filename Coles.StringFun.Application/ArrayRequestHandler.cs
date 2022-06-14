using Coles.StringFun.Definitions;

namespace Coles.StringFun.Application
{

	public class ArrayRequestHandler<T> : IArrayRequestHandler<T> where T : IEquatable<T>
	{
		private readonly IArrayFunctions<T> _arrayFunctions;
		
		public ArrayRequestHandler(IArrayFunctions<T> arrayFunctions)
		{
			_arrayFunctions = arrayFunctions;
		}		

		public T[] GetDistinct(T[] elements)
		{
			if (elements.Length < 1) throw new ApplicationException("Invalid Input");
			return _arrayFunctions.Distinct(elements);
		}

	}
}