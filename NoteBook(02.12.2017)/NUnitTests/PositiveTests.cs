using NUnit.Framework;
using System;
using NoteBookProject;

namespace NUnitTests
{
    [TestFixture]
    public class PositiveTests
    {
        [Test]
        public void TestIsNoteBookProviderSingle()
        {
            int creatingsAmount = new Random().Next(10);
            NoteBookProvider provider = NoteBookProvider.GetProvider();
            while ( creatingsAmount != 0)
            {
                Assert.AreEqual(provider, NoteBookProvider.GetProvider());
            }
        }

    }
}
