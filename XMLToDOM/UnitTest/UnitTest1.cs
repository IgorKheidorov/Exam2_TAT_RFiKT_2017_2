using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMLToDOM;

namespace UnitTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      private static readonly string PATH = @"E:\Desktop";
      Assert.Equals(false, new SearcherTags().GetStringFromTXT());
    }
  }
}

