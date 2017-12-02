using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteBook;

namespace UnitTestNoteBook
{
  [TestClass]
  public class NegativeTests
  {
    [TestMethod]
    public void CheckOnOverrideEqualsOfNoteNegativeResult()
    {
      Notebook notebook = new Notebook();
      Assert.IsFalse((new Note("Friday", "Write a task well").Equals(new Note("Today", "Write a task well"))));
    }

    [TestMethod]
    public void CheckOnOverrideEqualsOfNoteBookNegativeResult()
    {
      Notebook firstNotebook = new Notebook();
      Notebook secondNotebook = new Notebook();
      firstNotebook.AddNote("1", "Write a task well");
      firstNotebook.AddNote("today", "Write a task well");
      secondNotebook.AddNote("Friday", "Write a task well");
      secondNotebook.AddNote("today", "Write a task well");
      Assert.IsFalse((firstNotebook.Equals(secondNotebook)));
    }
  }
}
