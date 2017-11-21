using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertStringToInt;
namespace UnitTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Assert.Equals("23", new ConvertorToInt("qweqw 23").GetValideNumbersInString()[0]);
    }
  }
}
