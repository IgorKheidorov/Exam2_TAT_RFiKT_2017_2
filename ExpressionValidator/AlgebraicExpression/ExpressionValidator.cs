using System.Collections.Generic;

namespace AlgebraicExpression
{
    /// <summary>
    /// Class get expressions struct
    /// </summary>
    public class ExpressionValidator
    {
        string expressionStruct;
        Stack<char> openingBrackets;
        private Dictionary<char, char> appropriateBrackets;

        /// <summary>
        /// Constructor assigns expressionsStructs field, initialize dictionary and stack
        /// </summary>
        /// <param name="expressionStruct"></param>
        public ExpressionValidator(string expressionStruct)
        {
            this.expressionStruct = expressionStruct;
            openingBrackets = new Stack<char>();
            InitializeDictionary();
        }
        /// <summary>
        /// Method check is expression has valid struct
        /// </summary>
        /// <returns>is expression struct meets the requirements</returns>
        public bool IsExpressionValid()
        {
            if ( expressionStruct == string.Empty )
            {
                return false;
            }
            char closingBracket;
            foreach ( var sign in expressionStruct )
            {
                if (appropriateBrackets.ContainsKey(sign))
                {
                    openingBrackets.Push(sign);
                }
                else if ( openingBrackets.Count == 0)
                {
                    return false;
                }
                else
                {
                    appropriateBrackets.TryGetValue(openingBrackets.Peek(), out closingBracket);
                    if ( sign == closingBracket )
                    {
                        openingBrackets.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return openingBrackets.Count == 0;
        }

       private void InitializeDictionary()
        {
            appropriateBrackets = new Dictionary<char, char>();
            appropriateBrackets.Add('{', '}');
            appropriateBrackets.Add('(', ')');
            appropriateBrackets.Add('[', ']');
        }

    }
}
