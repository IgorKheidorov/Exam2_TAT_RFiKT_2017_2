using System;
using System.Text;

namespace TaskAboutComplexNumber
{
  /// <summary>
  /// Representation of complex number.
  /// </summary>
  public class ComplexNumber : IComparable
  {
    private double real { get; set; }
    private double imaginary { get; set; }
  
    /// <summary>
    /// Default contructor.
    /// Creates an instance of ComplexNumber.
    /// </summary>
    public ComplexNumber()
    {
      this.real = 0;
      this.imaginary = 0;
    }

    /// <summary>
    /// Contructor with parametrs.
    /// Creates an instance of ComplexNumber.
    /// </summary>
    public ComplexNumber(double real, double imaginary)
    {
      this.real = real;
      this.imaginary = imaginary;      
    }

    /// <summary>
    /// Copy contructor.
    /// Creates an instance of ComplexNumber.
    /// </summary>
    public ComplexNumber(ComplexNumber complexNumber)
    {
      this.real = complexNumber.real;
      this.imaginary = complexNumber.imaginary;    
    }

    /// <summary>
    /// Addition of two complex numbers.
    /// </summary>
    /// <param name="firstComplexNumber">First term</param>
    /// <param name="secondComplexNumber">Second term.</param>
    /// <returns>New ComplexNumber with the result of addition.</returns>
    public static ComplexNumber operator +(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber)
    {
      ComplexNumber result = new ComplexNumber();
      result.real = firstComplexNumber.real + secondComplexNumber.real;
      result.imaginary = firstComplexNumber.imaginary + secondComplexNumber.imaginary;
      return result;
    }

    /// <summary>
    /// Substraction of two complex numbers.
    /// </summary>
    /// <param name="firstComplexNumber">Reduced</param>
    /// <param name="secondComplexNumber">Substrahend.</param>
    /// <returns>New ComplexNumber with the result of substraction.</returns>
    public static ComplexNumber operator -(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber)
    {
      ComplexNumber result = new ComplexNumber();
      result.real = firstComplexNumber.real - secondComplexNumber.real;
      result.imaginary = firstComplexNumber.imaginary - secondComplexNumber.imaginary;
      return result;
    }

    /// <summary>
    /// Multiplication of two complex numbers.
    /// </summary>
    /// <param name="firstComplexNumber">Multiplied.</param>
    /// <param name="secondComplexNumber">Multiplied.</param>
    /// <returns>New ComplexNumber with the result of multiplication.</returns>
    public static ComplexNumber operator *(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber)
    {
      ComplexNumber result = new ComplexNumber();
      result.real = firstComplexNumber.real * secondComplexNumber.real - firstComplexNumber.imaginary * secondComplexNumber.imaginary;
      result.imaginary = firstComplexNumber.real * secondComplexNumber.real + firstComplexNumber.imaginary * secondComplexNumber.imaginary;
      return result;
    }

    /// <summary>
    /// Division of two complex numbers.
    /// </summary>
    /// <param name="firstComplexNumber">Dividend.</param>
    /// <param name="secondComplexNumber">Divider.</param>
    /// <returns>New ComplexNumber with the result of division.</returns>
    public static ComplexNumber operator /(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber)
    {
      if (secondComplexNumber.real == 0 && secondComplexNumber.imaginary == 0)
      {
        throw new DivideByZeroException();
      }
      ComplexNumber result = new ComplexNumber();
      result.real = (firstComplexNumber.real * secondComplexNumber.real + firstComplexNumber.imaginary * secondComplexNumber.imaginary) / (Math.Pow(firstComplexNumber.real, 2) + Math.Pow(secondComplexNumber.real, 2));
      result.imaginary = (secondComplexNumber.real * firstComplexNumber.imaginary - firstComplexNumber.real * secondComplexNumber.imaginary) / (Math.Pow(firstComplexNumber.real, 2) + Math.Pow(secondComplexNumber.real, 2));
      return result;
    }

    /// <summary>
    /// Calculates the module of complex number.
    /// </summary>
    /// <returns>Module of complex number.</returns>
    public double Abs()
    {
      return Math.Sqrt(Math.Pow(this.real, 2) + Math.Pow(this.imaginary, 2));
    }

    /// <summary>
    /// Compares two complex numbers.
    /// </summary>
    /// <param name="obj">Object to compare.</param>
    /// <returns>Result of comparison in integer.</returns>
    public int CompareTo(object obj)
    {
      ComplexNumber complexNumber = new ComplexNumber();
      if (obj is ComplexNumber)
      {
        complexNumber = (ComplexNumber)obj;
      }
      else
      {
        throw new ArgumentException();
      }
      return this.Abs().CompareTo(complexNumber.Abs());
    }

    /// <summary>
    /// Returns string representation of complex number.
    /// </summary>
    /// <returns>String with representation of complex number.</returns>
    public override string ToString()
    {
      StringBuilder result = new StringBuilder();
      result.Append(this.real);
      result.Append(" + ");
      result.Append(this.imaginary);
      result.Append("i");
      return result.ToString();
    }

    /// <summary>
    /// Compares this instance and other object.
    /// </summary>
    /// <param name="obj">Object to compare</param>
    /// <returns>True if equals;false otherwise.</returns>
    public override bool Equals(object obj)
    {
      ComplexNumber complexNumber = new ComplexNumber();
      if (obj is ComplexNumber)
      {
        complexNumber = (ComplexNumber)obj;
      }
      else
      {
        throw new ArgumentException();
      }
      return this.real.Equals(complexNumber.real) && this.imaginary.Equals(complexNumber.imaginary);
    }
  }
}
