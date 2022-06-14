using Coles.StringFun.Domain;

namespace Coles.StringFun.Tests
{
	public class ArrayFunctionsTests
	{
	
		[Fact]
		public void Test_Distinct_List_Of_Numbers()
		{
			var numbers = new int[] { 12, 34, 12, 67, 89, 89, 12 };
			
			var arrayExtensions = new ArrayFunctions<int>();

			var distinctNumberList = arrayExtensions.Distinct(numbers);
			Assert.NotNull(distinctNumberList);
			Assert.Equal(distinctNumberList, new int[] { 12, 34, 67, 89 });

		}

		[Fact]
		public void Test_Distinct_List_Of_Strings()
		{
			var strings = new string[] { "talk", "eat", "play", "eat", null, "eat", "eat" };

			var arrayExtensions = new ArrayFunctions<string>();

			var distinctList = arrayExtensions.Distinct(strings);
			Assert.NotNull(distinctList);
			Assert.Equal(distinctList, new string[] { "talk", "eat", "play", null });

		}

		private class Test : IEquatable<Test>
		{
			public int id { get; set; }
			public string name { get; set; }

			public bool Equals(Test? other)
			{
				return other != null && this.id == other.id && name == other.name;
			}
		}

		[Fact]
		public void Test_Distinct_List_Of_UserDefinedType()
		{
		

			var arrayExtensions = new ArrayFunctions<Test>();

			var testList = new Test[]
			{
				new Test { name = "Mark", id = 1},
				new Test { name = "John", id = 2},
				new Test { name = "John", id = 2},
				new Test { name = "Sumo", id = 2}
			};

			var distinctList = arrayExtensions.Distinct(testList);
			Assert.NotNull(distinctList);
			Assert.Equal(distinctList.Length, 3);
			Assert.Equal(distinctList[0].name + distinctList[0].id, "Mark1");
			Assert.Equal(distinctList[1].name + distinctList[1].id, "John2");
			Assert.Equal(distinctList[2].name + distinctList[2].id, "Sumo2");
		}
	}
}