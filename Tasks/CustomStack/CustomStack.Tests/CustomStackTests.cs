using System;
using NUnit.Framework;

namespace CustomStack.Tests
{
  [TestFixture]
  public class CustomStackTests
  {
    private static object[] sourcePush = new object[]
    {
      new object[] {new int[] {1}},
      new object[] {new int[] {1, 2}},
      new object[] {new int[] {1, 2, 3, 4, 5}},
    };

    private static object[] sourcePushPeakStack = new object[]
    {
      new object[] {new int[] {1}, 1},
      new object[] {new int[] {1, 2, 3, 4, 5}, 5},
    };

    private static object[] sourcePopPeakStack = new object[]
    {
      new object[] {new int[] {1, 2}, 1},
      new object[] {new int[] {1, 2, 3, 4, 5}, 4},
    };

    // Push tests
    [Test, TestCaseSource("sourcePush")]
    public void PushElemsCountEqualStackCount(int[] elems)
    {
      CustomStack<int> stack = new CustomStack<int>();
      foreach (var elem in elems)
      {
        stack.Push(elem);
      }
      Assert.AreEqual(stack.Count, elems.Length);
    }

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

    // Pop tests
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

    [Test, TestCaseSource("sourcePush")]
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

    // Clear tests
    [Test]
    public void ClearEmptyStackIsEmpty()
    {
      CustomStack<int> stack = new CustomStack<int>();
      stack.Clear();
      Assert.True(stack.IsEmpty());
    }

    [Test, TestCaseSource("sourcePush")]
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

    // Operation Exception tests
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

    [Test, TestCaseSource("sourcePush")]
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
      Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }
  }
}
