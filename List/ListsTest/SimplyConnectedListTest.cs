using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace ListsTest
{
  [TestClass]
  public class SimplyConnectedListTest
  {
    [TestMethod]
    public void TestSimplyConnectedListAdd()
    {
      SimplyConnectedList<int> intList = new SimplyConnectedList<int>();
      intList.Add(6);
      Assert.IsTrue(intList.Contains(6));
      Assert.IsTrue(intList.Count == 1);
      intList.Add(7);
      Assert.IsTrue(intList.Contains(6) && intList.Contains(7));
      Assert.IsTrue(intList.Count == 2);

      SimplyConnectedList<string> stringList = new SimplyConnectedList<string>();
      stringList.Add("a");
      Assert.IsTrue(stringList.Contains("a"));
      Assert.IsTrue(stringList.Count == 1);
      stringList.Add("abs");
      Assert.IsTrue(stringList.Contains("a") && stringList.Contains("abs"));
      Assert.IsTrue(stringList.Count == 2);
      stringList.Add(string.Empty);
      Assert.IsTrue(stringList.Contains("a") && stringList.Contains("abs") && stringList.Contains(string.Empty));
      Assert.IsTrue(stringList.Count == 3);
    }
  }
}
