using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteBook;

namespace UnitTestNoteBook
{
  [TestClass]
  public class PositiveTests
  {
    [TestMethod]
    public void CheckOnOverrideEqualsOfNote()
    {
      Assert.IsTrue((new Note("Today", "Write a task well").Equals(new Note("Today", "Write a task well"))));
    }

    [TestMethod]
    public void CheckOnOverrideEqualsOfNoteBook()
    {
      Notebook firstNotebook = new Notebook();
      Notebook secondNotebook = new Notebook();
      firstNotebook.AddNote("Friday", "Write a task well");
      firstNotebook.AddNote("today", "Write a task well");
      secondNotebook.AddNote("Friday", "Write a task well");
      secondNotebook.AddNote("today", "Write a task well");
      Assert.IsTrue((firstNotebook.Equals(secondNotebook)));
    }

    [TestMethod]
    public void ChechOnOverrideToStringNote()
    {
      Assert.IsTrue((new Note("Today", "Write a task well").ToString().Equals(new Note("Today", "Write a task well").ToString())));
    }
  }
}
