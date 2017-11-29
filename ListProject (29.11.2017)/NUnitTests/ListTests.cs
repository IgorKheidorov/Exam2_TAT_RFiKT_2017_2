using NUnit.Framework;
using ListProject;

namespace NUnitTests
{
    [TestFixture]
    public class ListTests
    {
        private static object[] countPositiveDataSource =
        {
            new object[] { new List<int>(),0},
            new object[] { new List<int>(), 3},
            new object[] { new List<int>(), 10}
        };

        [Test, TestCaseSource("countPositiveDataSource")]
        public void TestListCountPositive(List<int> list, int expectedCount)
        {
            for ( int i = 0; i < expectedCount; i++)
            {
                list.Add(i);
            }
            Assert.AreEqual(list.Count, expectedCount);
        }

        private static object[] getNextPositiveDataSource =
        {
            new object[] { new List<int>(),0, null},
            new object[] { new List<int>(), 2,2},
            new object[] { new List<int>(), 10,10}
        };

        [Test, TestCaseSource("getNextPositiveDataSource")]
        public void TestGetNextPositive(List<int> list, int valueAmount,int expectedValue)
        {
            int value;
            for (int i = 1; i <= valueAmount; i++)
            {
                list.Add(i);
                value = list.GetNext();
            }
            Assert.AreEqual(value, expectedValue);
        }

        private static object[] getNextNegativeDataSource =
        {
            new object[] { new List<int>(),0, 1},
            new object[] { new List<int>(), 3,4},
            new object[] { new List<int>(), 10,11},
        };

        [Test, TestCaseSource("getNextNegativeDataSource")]
        public void TestListCountNegative(List<int> list, int valueAmount, int expectedValue)
        {
            int value;
            for (int i = 0; i <= valueAmount; i++)
            {
                list.Add(i);
                value = list.GetNext();
            }
            Assert.AreNotEqual(value, expectedValue);
        }
    }
}
