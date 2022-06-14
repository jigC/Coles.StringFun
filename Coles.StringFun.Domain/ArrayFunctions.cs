namespace Coles.StringFun.Domain
{
	/*
	 * Simple class that works with Array of objects - objrcts can be of any type string/numbers or user defined as long as they 
	 * implementing IEquatable interface
	 */
	public class ArrayFunctions<T> where T : IEquatable<T>
	{
		/*
		 * Function to find distinct objects from array of objects
		 */
		public T[] Distinct(T[] elements)
		{

			if (elements == null || elements.Length < 1) return elements;

			var distinctElements = new List<T>();
			foreach (var element in elements)
			{
				if (!distinctElements.Contains(element)) distinctElements.Add(element);
			}

			return distinctElements.ToArray();
		}
	}
}