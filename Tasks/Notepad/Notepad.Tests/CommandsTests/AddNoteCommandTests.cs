using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Notepad.Tests.CommandsTests
{
  [TestFixture]
  public class AddNoteCommandTests
  {
    private static object[] sourceCreate =
    {
      new object[] {"title", ""},
      new object[] {"", "content"},
      new object[] {"title","content"},
    };

    [Test]
    public void AddNoteInNotebookAdded()
    {
    }
  }
}
