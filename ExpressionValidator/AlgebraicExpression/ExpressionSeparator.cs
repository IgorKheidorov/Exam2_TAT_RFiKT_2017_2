using System.Linq;
using System.Text;

namespace AlgebraicExpression
{
    /// <summary>
    /// Class is nessesary to separate expression by struct
    /// </summary>
    public class ExpressionSeparator
    {
        string expression;
        public readonly char[] validParentheses = { '{', '(', '[', '}', ')', ']' };

        public ExpressionSeparator(string expression)
        {
            this.expression = expression;
        }
        /// <summary>
        /// Delete all symbols which not contained in validParentheses
        /// </summary>
        /// <returns>string with only brackets, which show expression struct</returns>
        public string GetExpressionStruct()
        {
            StringBuilder expressionStruct = new StringBuilder();
            foreach ( var sign in expression)
            {
                if ( validParentheses.Contains(sign))
                {
                    expressionStruct.Append(sign);
                }
            }
            return expressionStruct.ToString();
        }
    }
}
