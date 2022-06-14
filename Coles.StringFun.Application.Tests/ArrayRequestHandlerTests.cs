using Coles.StringFun.Application;
using Coles.StringFun.Domain;
using Xunit;

namespace Coles.StringFun.Tests
{
	public class ArrayRequestHandlerTests
	{
		private IArrayRequestHandler<int> arrayRequestHandler;

		public ArrayRequestHandlerTests()
		{
			var arrayFunctions = new ArrayFunctions<int>();
			this.arrayRequestHandler = new ArrayRequestHandler<int>(arrayFunctions);
		}


		[Fact]
		public void Test_Distinct_List_Of_Numbers()
		{
			var numbers = new int[] { 12, 34, 12, 67, 89, 89, 12 };


			var distinctNumberList = arrayRequestHandler.GetDistinct(numbers);			
			Assert.NotNull(distinctNumberList);
			Assert.Equal(distinctNumberList, new int[] { 12, 34, 67, 89 });

		}
	}
}