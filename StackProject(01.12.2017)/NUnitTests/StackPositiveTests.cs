using System;
using NUnit.Framework;
using StackProject;

namespace NUnitTests
{
    [TestFixture]
    public class StackPositiveTests
    {

        private static object[] forPushTestDataSource =
        {
             new object[] { new int[] {1,2,3,4,5}, 5},
             new object[] { new int[] {0}, 0 },
             new object[] { new int[] {1,0,-50}, -50}
        };

         [Test, TestCaseSource("forPushTestDataSource")]
         public void TestPushMethod(int[] values, int expectedLastValue)
         {
            Stack<int> stack = new Stack<int>();
            foreach ( var value in values )
            {
                stack.Push(value);
            }
            Assert.AreEqual(stack.Head, expectedLastValue);
        }

        private static object[] forContainsMethodTestDataSource =
        {
            new object[] { new int[] {1,2,3,4,5}, 3 , true},
            new object[] { new int[] { }, 1 , false },
            new object[] { new int[] { 1 } , 1 , true },
            new object[] { new int[] { 1 }, 2 , false}
         };
        [Test, TestCaseSource("forContainsMethodTestDataSource")]
        public void TestContainsMethod(int[] values, int checkedValue, bool isContains)
        {
            Stack<int> stack = new Stack<int>();
            foreach ( var value in values )
            {
                stack.Push(value);
            }
            Assert.AreEqual(stack.Contains(checkedValue), isContains);
        }

        private static object[] forPeekMethodTestDataSource =
        {
            new object[] { new int[] {1,2,3,4,5}, 5},
            new object[] { new int[] { 1 }, 1 },
            new object[] { new int[] { 1 , 0 , 1 , -2 } , -2},
         };
        [Test, TestCaseSource("forPeekMethodTestDataSource")]
        public void TestPeekMethod(int[] values, int expectedValue)
        {
            Stack<int> stack = new Stack<int>();
            foreach ( var value in values )
            {
                stack.Push(value);
            }
            Assert.AreEqual(stack.Peek(), expectedValue);
        }

        private static object[] forPopMethodTestDataSource =
        {
            new object[] { new int[] {1,2,3,4,5}, 2 ,3},
            new object[] { new int[] { 1 }, 0 , 1},
            new object[] { new int[] { 1 , 0 , 1 , -2 } , 2, 0},
         };
        [Test, TestCaseSource("forPopMethodTestDataSource")]
        public void TestPopMethod(int[] values, int popsAmount, int expectedValue)
        {
            Stack<int> stack = new Stack<int>();
            foreach ( var value in values )
            {
                stack.Push(value);
            }
            while ( popsAmount != 0 )
            {
                stack.Pop();
                popsAmount--;
            }
            Assert.AreEqual(stack.Head, expectedValue);
        }

        private static object[] forClearMethodTestDataSource =
        {
            new object[] { new int[] {1,2,3,4,5}},
            new object[] { new int[] { 1 }},
            new object[] { new int[] { } },
        };

        [Test, TestCaseSource("forClearMethodTestDataSource")]
        public void TestClearMethod(int[] values)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var value in values)
            {
                stack.Push(value);
            }
            stack.Clear();
            Assert.AreEqual(stack.Count, 0);
            Assert.Throws<InvalidOperationException>( delegate { stack.Pop();});
        }
    }
}
