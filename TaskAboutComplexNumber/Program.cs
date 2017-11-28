using System;

namespace TaskAboutComplexNumber
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber excpectedResultOfAddition = new ComplexNumber(3, 5);
            ComplexNumber firstComplexNumber = new ComplexNumber(2, 3);
            ComplexNumber secondComplexNumber = new ComplexNumber(1, 2);
            ComplexNumber resultOfAddition = firstComplexNumber + secondComplexNumber;
            Console.WriteLine(excpectedResultOfAddition.Equals(resultOfAddition));
        }
    }
}
