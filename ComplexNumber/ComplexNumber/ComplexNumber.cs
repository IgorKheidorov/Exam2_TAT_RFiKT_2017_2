using System;

namespace ActionsWithComplexNumber
{
  /// <summary>
  /// The implementation of subtraction, addition, dividing, comparisons of two numbers.
  /// </summary>
  public class ComplexNumber
  {
    const double EPSILON = 0.001;

    private double imaginaryPart;
    private double ImaginaryPart
    {
      get
      {
        return imaginaryPart;
      }
      set
      {
        imaginaryPart = value;
      }
    }
    private double realPart;
    private double RealPart
    {
      get
      {
        return realPart;
      }
      set
      {
        realPart = value;
      }
    }

    /// <summary>
    /// Default constructor.
    /// </summary>
    public ComplexNumber()
    { }

    public ComplexNumber(double imaginaryPartOfnumber, double realPartOfNumber)
    {
      ImaginaryPart = imaginaryPartOfnumber;
      RealPart = realPartOfNumber;
    }

    /// <summary>
    /// Constructor of copy.
    /// </summary>
    /// <param name="priviousComplexNumber"></param>
    public ComplexNumber(ComplexNumber priviousComplexNumber)
    {
      realPart = priviousComplexNumber.realPart;
      imaginaryPart = priviousComplexNumber.imaginaryPart;
    }

    /// <summary>
    /// Calculate the sum of two numbers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>
    /// Result after calculation.
    /// </returns>
    public ComplexNumber CalculateSumOfNumbers(ComplexNumber a, ComplexNumber b)
    {
      return a + b;
    }

    /// <summary>
    /// Calculate the difference of two numbers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>
    /// Result after calculation.
    /// </returns>
    public ComplexNumber CalculateDifferenceOfNumbers(ComplexNumber a, ComplexNumber b)
    {
      return a - b;
    }

    /// <summary>
    /// Calculate the multiplication of two numbers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>
    /// Result after calculation.
    /// </returns>
    public ComplexNumber CalculateMultiplicationOfNumbers(ComplexNumber a, ComplexNumber b)
    {
      return a * b;
    }

    /// <summary>
    /// Calculate the divide of two numbers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>
    /// Result after calculation.
    /// </returns>
    public ComplexNumber CalculateDivideOfNumbers(ComplexNumber a, ComplexNumber b)
    {
      return a / b;
    }

    /// <summary>
    /// Compare two numbers.
    /// </summary>
    /// <param name="a">First number.</param>
    /// <param name="b">Second number.</param>
    /// <returns>
    /// -1 - if the second number more than first.1 - if the second number less than first. 0 - if they equals.
    /// </returns>
    public int ComparisonOfNumbers(ComplexNumber a, ComplexNumber b)
    {
      if (Math.Sqrt((a.RealPart - b.RealPart) * (a.RealPart - b.RealPart) + (a.ImaginaryPart - b.ImaginaryPart) * (a.ImaginaryPart - b.ImaginaryPart)) < EPSILON)
      {
        return -1;
      }
      else if (Math.Sqrt((a.RealPart - b.RealPart) * (a.RealPart - b.RealPart) + (a.ImaginaryPart - b.ImaginaryPart) * (a.ImaginaryPart - b.ImaginaryPart)) < EPSILON)
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }

    /// <summary>
    /// The overload the sum of two numbers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
      ComplexNumber result = new ComplexNumber()
      {
        RealPart = a.RealPart + b.RealPart,
        ImaginaryPart = a.ImaginaryPart + b.ImaginaryPart
      };
      return result;
    }

    /// <summary>
    /// The overload the minus of two numbers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {
      ComplexNumber result = new ComplexNumber()
      {
        RealPart = a.RealPart - b.RealPart,
        ImaginaryPart = a.ImaginaryPart - b.ImaginaryPart
      };
      return result;
    }

    /// <summary>
    /// The overload the multiplication of two numbers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {
      ComplexNumber result = new ComplexNumber();
      {
        result.RealPart = a.RealPart * b.RealPart - a.ImaginaryPart * b.ImaginaryPart;
        result.ImaginaryPart = a.RealPart * b.RealPart - a.ImaginaryPart * b.ImaginaryPart;
      };
      return result;
      // return new ComplexNumber(a.RealPart * b.RealPart - a.ImaginaryPart * b.ImaginaryPart) + (a.RealPart * b.RealPart - a.ImaginaryPart * b.ImaginaryPart));
    }

    /// <summary>
    /// The overload the dividing of two numbers. There are exception to 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
    {
      ComplexNumber result = new ComplexNumber();
      try
      {
        double denominator = b.ImaginaryPart * b.ImaginaryPart + b.RealPart * b.RealPart;
        result.RealPart = (a.RealPart * b.RealPart + a.ImaginaryPart * b.ImaginaryPart) / denominator;
        result.ImaginaryPart = (b.RealPart * a.ImaginaryPart - a.RealPart * b.ImaginaryPart) / denominator;
      }
      catch (DivideByZeroException ex)
      {
        Console.Write(ex.Message);
      }

      return result;
    }
  }
}
