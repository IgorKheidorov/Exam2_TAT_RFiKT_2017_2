using System;
using NUnit.Framework;
using Notepad.CommandExceptions;
using Notepad.Commands;

namespace Notepad.Tests.CommandsTests
{
  [TestFixture]
  public class AddNoteCommandTests
  {
    private static object[] sourceNotes =
    {
      new object[] {"title", ""},
      new object[] {"", "content"},
      new object[] {"title","content"},
    };

    [Test]
    public void CreateAddCommandWithInvalidParams()
    {
      Assert.Throws<CommandTypeException>(() => new AddNoteCommand(
                                               new NoteBookProvider(
                                               new NoteBook(String.Empty)), String.Empty));
    }
  }
}
