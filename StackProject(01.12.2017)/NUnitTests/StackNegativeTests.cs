using NUnit.Framework;
using StackProject;
using System;

namespace NUnitTests
{
    [TestFixture]
    class StackNegativeTests
    {
        private static object[] forCountTestDataSource =
        {
            new object[] { new int[] {1,2,3,4,5}, 4},
            new object[] { new int[] { }, 2 },
            new object[] { new int[] {1}, 2}
        };

        [Test, TestCaseSource("forCountTestDataSource")]
        public void TestElementsCount(int[] values, int expectedCount)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var value in values)
            {
                stack.Push(value);
            }
            Assert.AreNotEqual(stack.Count, expectedCount);
        }

        [Test]
        public void TestPeekInEmptyStack_expect_InvalidOperationEx()
        {
            Stack<int> stack = new Stack<int>();

            Assert.Throws<InvalidOperationException>(delegate { stack.Peek(); });
        }

        [Test]
        public void TestPopInEmptyStack_expect_InvalidOperationEx()
        {
            Stack<int> stack = new Stack<int>();

            Assert.Throws<InvalidOperationException>(delegate { stack.Pop(); });
        }

        private static object[] forContainsMethodTestDataSource =
        {
            new object[] { new int[] {1,2,3,4,5}, 5 , false},
            new object[] { new int[] { }, 1 , true },
            new object[] { new int[] { 1 } , 2 , true },
            new object[] { new int[] { 1,2 }, 2 , false}
        };

        [Test, TestCaseSource("forContainsMethodTestDataSource")]
        public void TestContainsMethod(int[] values, int checkedValue, bool isContains)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var value in values)
            {
                stack.Push(value);
            }
            Assert.AreNotEqual(stack.Contains(checkedValue), isContains);
        }

        private static object[] forPushMethodTestDataSource =
        {
            new object[] { new int[] {1,2,3,4,5}, 4},
            new object[] { new int[] { }, 10},
            new object[] { new int[] { 1 } , 2},
            new object[] { new int[] { 1,2 }, 3}
        };

        [Test, TestCaseSource("forPushMethodTestDataSource")]
        public void TestPushMethod(int[] values, int expectedCount)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var value in values)
            {
                stack.Push(value);
            }
            Assert.AreNotEqual(stack.Count, expectedCount);
        }


    }
}
