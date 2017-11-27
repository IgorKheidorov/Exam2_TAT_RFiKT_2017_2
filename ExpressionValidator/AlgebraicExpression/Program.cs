using System;

namespace AlgebraicExpression
{
    /// <summary>
    /// Class with program starting point
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program starting point
        /// </summary>
        /// <param name="args">command line arguments</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression: ");
            ExpressionSeparator separator = new ExpressionSeparator(Console.ReadLine());
            ExpressionValidator validator = new ExpressionValidator(separator.GetExpressionStruct());
            if (validator.IsExpressionValid())
            {
                Console.WriteLine("Expression valid!");
            }
            else
            {
                Console.WriteLine("Expression is not valid!");
            }
        }
    }
}
