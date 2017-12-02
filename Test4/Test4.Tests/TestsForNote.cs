using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test4.Tests
{
  [TestClass]
  public class TestsForNote
  {
    [TestMethod]
    public void PositiveTestEquals()
    {
      Assert.IsTrue(new Note("Name", "new Year", new DateTime(1, 2, 3)).Equals(new Note("Name", "new Year", new DateTime(1, 2, 3))));
    }

    [TestMethod]
    public void NegativeTestsEquals()
    {
      Assert.IsFalse(new Note("Name1", "new Year", new DateTime(1, 2, 3)).Equals(new Note("Name", "new Year", new DateTime(1, 2, 3))));
      Assert.IsFalse(new Note("Name", "my birthday", new DateTime(1, 2, 3)).Equals(new Note("Name", "new Year", new DateTime(1, 2, 3))));
      Assert.IsFalse(new Note("Name", "new Year", new DateTime(1, 2, 3)).Equals(new Note("Name", "new Year", new DateTime(3, 4, 5))));
      Assert.IsFalse(new Note("Name1", "new Year", new DateTime(1, 2, 3)).Equals("abc"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestException()
    {
      new Note("", "abc", new DateTime(1, 2, 3));
    }

    [TestMethod]
    public void PositiveTestTostring()
    {
      Assert.AreEqual("Name of note: Name, date of creation: 31.12.2012 0:00:00", new Note("Name", "new Year", new DateTime(2012, 12, 31)).ToString());
    }

    [TestMethod]
    public void NegativeTestTostring()
    {
      Assert.AreNotEqual("Name of note: Name, date of creation: 31.12.2012 0:00:00", new Note("Name1", "new Year", new DateTime(2012, 12, 31)).ToString());
      Assert.AreNotEqual("Name of note: Name, date of creation: 31.12.2012 0:00:00", new Note("Name", "new Year", new DateTime(2012, 12, 21)).ToString());
    }

    [TestMethod]
    public void PositiveTestGetHashCode()
    {
      Assert.AreEqual(new Note("Name", "new Year", new DateTime(2012, 12, 31)).GetHashCode(), new Note("Name", "new Year", new DateTime(2012, 12, 31)).GetHashCode());
    }

    [TestMethod]
    public void NegativeTestGetHashCode()
    {
      Assert.AreNotEqual(new Note("Name123", "new Year123", new DateTime(2012, 11, 30)).GetHashCode(), new Note("Name", "new Year", new DateTime(2012, 12, 31)).GetHashCode());
    }
  }
}
