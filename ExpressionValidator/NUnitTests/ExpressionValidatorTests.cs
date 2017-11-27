using NUnit.Framework;
using AlgebraicExpression;

namespace NUnitTests
{
    [TestFixture]
    class ExpressionValidatorTests
    {

        private ExpressionValidator validator;
        private static object[] validExpressions =
        {
            new object[] {"{}"},
            new object[] {"{[()]()}"},
            new object[] {"{}{}{}{}{}{}"},
            new object[] {"{[({[()]})]}"},
            new object[] {"[{}][({})]"}
        };
 
        [Test, TestCaseSource("validExpressions")]
        public void TestIsExpressionValid_PositiveTests(string expression)
        {
            validator = new ExpressionValidator(expression);
            Assert.IsTrue(validator.IsExpressionValid());
        }

        private static object[] invalidExpressions =
        {
            new object[] {"{"},
            new object[] {"{[)]()}"},
            new object[] {"{})"},
            new object[] {"}[]}"},
            new object[] {"]{}][["},
            new object[] {""},
            new object[] {"((("}
        };

        [Test, TestCaseSource("invalidExpressions")]
        public void TestIsExpressionValid_NegativeTests(string expression)
        {
            validator = new ExpressionValidator(expression);
            Assert.IsFalse(validator.IsExpressionValid());
        }
    }
}
