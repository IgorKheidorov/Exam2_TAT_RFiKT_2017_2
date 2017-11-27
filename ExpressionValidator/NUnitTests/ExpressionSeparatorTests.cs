using NUnit.Framework;
using AlgebraicExpression;

namespace NUnitTests
{
    [TestFixture]
    public class ExpressionSeparatorTests
    {
        private ExpressionSeparator separator;

        private static object[] dataSource =
        {
            new object[] { "dsd*{f[df(sd)]dsf}", "{[()]}"},
            new object[] { "{dsfdf{ ff {", "{{{"},
            new object[] {"",""},
            new object[] { "{}{}{}{}{()}" , "{}{}{}{}{()}"},
            new object[] { "   ([gvvvvv{","([{"}
        };

        [Test, TestCaseSource("dataSource")]
        public void TestGetExpressionStruct(string fullExpression, string expressionStruct)
        {
            separator = new ExpressionSeparator(fullExpression);
            Assert.AreEqual(separator.GetExpressionStruct(), expressionStruct);
        }
    }
}
