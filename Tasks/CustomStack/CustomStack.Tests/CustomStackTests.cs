using System;
using NUnit.Framework;

namespace CustomStack.Tests
{
  [TestFixture]
  public class CustomStackTests
  {
    private static object[] sourcePushPeakStack = new object[]
    {
      new object[] {new int[] {1}, 1},
      new object[] {new int[] {1, 2}, 2},
      new object[] {new int[] {1, 2, 3, 4, 5}, 5},
    };

    private static object[] sourcePopPeakStack = new object[]
    {
      new object[] {new int[] {1, 2}, 1},
      new object[] {new int[] {1, 2, 3, 4, 5}, 4},
    };

    private static object[] sourcePopIsEmpty = new object[]
    {
      new object[] {new int[] {1}},
      new object[] {new int[] {1, 2}},
      new object[] {new int[] {1, 2, 3, 4, 5}},
    };

    [Test, TestCaseSource("sourcePushPeakStack")]
    public void PushElemsPeekElemIsLast(int[] elems, int lastElem)
    {
      CustomStack<int> stack = new CustomStack<int>();
      foreach (var elem in elems)
      {
        stack.Push(elem);
      }
      Assert.AreEqual(stack.Peek(), lastElem);
    }

    [Test, TestCaseSource("sourcePushPeakStack")]
    public void PopElemValidValue(int[] elems, int deletedValue)
    {
      CustomStack<int> stack = new CustomStack<int>();
      foreach (var elem in elems)
      {
        stack.Push(elem);
      }
      Assert.AreEqual(stack.Pop(), deletedValue);
    }

    [Test, TestCaseSource("sourcePopPeakStack")]
    public void PopElemPeekElemIsValid(int[] elems, int currentLastElem)
    {
      CustomStack<int> stack = new CustomStack<int>();
      foreach (var elem in elems)
      {
        stack.Push(elem);
      }
      stack.Pop();
      Assert.AreEqual(stack.Peek(), currentLastElem);
    }

    [Test, TestCaseSource("sourcePopIsEmpty")]
    public void PopAllElemsStackIsEmpty(int[] elems)
    {
      CustomStack<int> stack = new CustomStack<int>();
      foreach (var elem in elems)
      {
        stack.Push(elem);
      }
      for (int i = 0; i < elems.Length; i++)
      {
        stack.Pop();
      }
      Assert.True(stack.IsEmpty());
    }

    [Test, TestCaseSource("sourcePopIsEmpty")]
    public void ClearStackIsEmpty(int[] elems)
    {
      CustomStack<int> stack = new CustomStack<int>();
      foreach (var elem in elems)
      {
        stack.Push(elem);
      }
      stack.Clear();
      Assert.True(stack.IsEmpty());
    }

    [Test]
    public void PopEmptyStackThrowsOperationException()
    {
      CustomStack<int> stack = new CustomStack<int>();

      Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Test]
    public void PeakEmptyStackThrowsOperationException()
    {
      CustomStack<int> stack = new CustomStack<int>();

      Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }

    [Test, TestCaseSource("sourcePopIsEmpty")]
    public void PopMoreThanAddedElemsThrowsOperationException(int[] elems)
    {
      CustomStack<int> stack = new CustomStack<int>();
      foreach (var elem in elems)
      {
        stack.Push(elem);
      }
      for (int i = 0; i < elems.Length; i++)
      {
        stack.Pop();
      }
      Assert.True(stack.IsEmpty());
    }
  }
}
