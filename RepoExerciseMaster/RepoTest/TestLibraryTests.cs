using System;
using System.Linq;
using Xunit;

namespace RepoTest
{
    public class TestLibraryTests
    {
        [Theory]
        [InlineData(2,1,3)]
        [InlineData(3,7,10)]
        [InlineData(1,1,2)]
        public void PassingTestAddIntegerAsyncPassing(int value1, int value2, int expected)
        {
            int actual = TestLibrary.ComputeModule.AddIntegerAsync(value1, value2).Result;
            Assert.True((actual == expected));
        }

        [Theory]
        [InlineData(2, 1, 7)]
        [InlineData(3, 7, 20)]
        [InlineData(1, 1, 3)]
        public void FailingTestAddSIntegerAsyncFaili(int value1, int value2, int expected)
        {
            int actual = TestLibrary.ComputeModule.AddIntegerAsync(value1, value2).Result;
            Assert.True((actual != expected));
        }
    }
}
