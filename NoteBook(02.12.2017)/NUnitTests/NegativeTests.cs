using NoteBookProject;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    class NegativeTests
    {
        private static object[] commandHandlerDataSource =
        {
            new object[] {""},
            new object[] {"add  node"},
            new object[] {"213"}
        };

        [Test, TestCaseSource("commandHandlerDataSource")]
        public void TestCommandHandlerGetCommand_throwException(string commandKey)
        {
            CommandHandler handler = new CommandHandler();
            Assert.Throws<KeyNotFoundException>(delegate { handler.GetCommand(commandKey); });
        }


    }
}
