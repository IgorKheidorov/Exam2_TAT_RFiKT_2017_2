using NUnit.Framework;


namespace Project.Tests
{
  [TestFixture]
  public class CustomListTests
  {
    private static object[] sourceAddingTestCount =
    {
      new object[] { new CustomList<int> (),new int[] {} , 0},
      new object[] { new CustomList<int> (),new int[] {1} , 1},
      new object[] { new CustomList<int> (),new int[] {1,2} , 2},
    };

    [Test, TestCaseSource("sourceAddingTestCount")]
    public void AddItemInListCountIncrement(CustomList<int> list, int[] items, int count)
    {
      foreach (var item in items)
      {
        list.Add(item);
      }
      Assert.That(list.Count == count);
    }

    [Test, TestCaseSource("sourceAddingTestCount")]
    public void AddItemInListCheckLastElem(CustomList<int> list, int[] items, int lastValue)
    {
      foreach (var item in items)
      {
        list.Add(item);
      }
      Assert.That(list.IndexOf(lastValue) == list.Count - 1);
    }

    [Test, TestCaseSource("sourceAddingTestCount")]
    public void AddItemInFirstPositionListCheckFirstElem(CustomList<int> list, int[] items, int lastValue)
    {
      foreach (var item in items)
      {
        list.AppendFirst(item);
      }
      Assert.That(list.IndexOf(lastValue) == 0);
    }
  }
}
