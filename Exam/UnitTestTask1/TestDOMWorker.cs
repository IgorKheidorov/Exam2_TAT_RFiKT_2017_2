using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1InGroup;
using System.Collections.Generic;

namespace UnitTestTask1
{
    [TestClass]
    public class TestDOMWorker
    {
        [TestMethod]
        public void TestWriteToDOM()
        {
            string list = "<A>\n<B>\n</B>\n<B>\n</B>\n</A>";
            Node<string> expect = new Node<string>();
            List<Node<string>> childs = new List<Node<string>> { new Node<string>("B"), new Node<string>("B") };
            expect.parent = "A";
            expect.childs = childs;
            

            DOMWorker<string> worker = new DOMWorker<string>();

            worker.WriteToDOM(list);

            Assert.AreEqual(expect, worker.GetList());
        }

        [TestMethod]
        public void TestWriteToDOMEmptyList()
        {
            string list = "";
            Node<string> expect = new Node<string>();
            DOMWorker<string> worker = new DOMWorker<string>();

            worker.WriteToDOM(list);

            Assert.AreEqual(expect, worker.GetList());
        }

        [TestMethod]
        public void TestWriteToDOMUncorrectList()
        {
            string list = "asdfg";
            Node<string> expect = new Node<string>();
            DOMWorker<string> worker = new DOMWorker<string>();

            worker.WriteToDOM(list);

            Assert.AreEqual(expect, worker.GetList());
        }
    }
}
