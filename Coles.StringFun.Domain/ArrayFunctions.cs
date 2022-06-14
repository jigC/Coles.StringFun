namespace Coles.StringFun.Domain
{
	public class ArrayFunctions<T> where T : IEquatable<T>
	{
		public T[] Distinct(T[] elements)
		{

			if (elements == null || elements.Length < 1) return elements;

			var distinctElements = new List<T>();
			foreach(var element in elements)
			{
				if (!distinctElements.Contains(element)) distinctElements.Add(element);
			}

			return distinctElements.ToArray();
		}
	}
}