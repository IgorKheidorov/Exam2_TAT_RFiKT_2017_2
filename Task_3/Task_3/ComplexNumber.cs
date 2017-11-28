using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
  /// <summary>
  /// This class created for work with coplex number.
  /// </summary>
  public class ComplexNumber
  {
    private double realPartOfNumber;
    private double imaginaryPartOfNumber;

    /// <summary>
    /// This constructor initializes complex number.
    /// </summary>
    public ComplexNumber()
    {
      realPartOfNumber = 0.0;
      imaginaryPartOfNumber = 0.0;
    }

    /// <summary>
    /// This constructor assigns the complex number of parameter values.
    /// </summary>
    /// <param name="realPartOfNumber">The real part of the complex number</param>
    /// <param name="imaginaryPartOfNumber">The imaginary part of the complex number</param>
    public ComplexNumber(double realPartOfNumber, double imaginaryPartOfNumber)
    {
      this.realPartOfNumber = realPartOfNumber;
      this.imaginaryPartOfNumber = imaginaryPartOfNumber;
    }

    /// <summary>
    /// This constructor copies value of created object in new object.
    /// </summary>
    /// <param name="complexNumber">Created object.</param>
    public ComplexNumber(ComplexNumber complexNumber)
    {
      realPartOfNumber = complexNumber.realPartOfNumber;
      imaginaryPartOfNumber = complexNumber.imaginaryPartOfNumber;
    }

    public double RealPartOfNumber { get { return realPartOfNumber; } set { realPartOfNumber = value; } }
    public double ImaginaryPartOfNumber { get { return imaginaryPartOfNumber; } set { imaginaryPartOfNumber = value; } }

    /// <summary>
    /// This method sums up two complex numbers.
    /// </summary>
    /// <param name="firstNumber">First complex number.</param>
    /// <param name="secondNumber">Second complex number.</param>
    /// <returns>Returns the sum of complex number.</returns>
    public ComplexNumber SumComplexNumber(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      ComplexNumber complexNumber = new ComplexNumber();
      complexNumber.realPartOfNumber = firstNumber.realPartOfNumber + secondNumber.realPartOfNumber;
      complexNumber.imaginaryPartOfNumber = firstNumber.imaginaryPartOfNumber + secondNumber.imaginaryPartOfNumber;
      return complexNumber;
    }

    /// <summary>
    /// This method subtracted two complex numbers.
    /// </summary>
    /// <param name="firstNumber">First complex number.</param>
    /// <param name="secondNumber">Second complex number.</param>
    /// <returns>Returns the difference of complex number.</returns>
    public ComplexNumber SubtractComplexNumber(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      ComplexNumber complexNumber = new ComplexNumber();
      complexNumber.realPartOfNumber = firstNumber.realPartOfNumber - secondNumber.realPartOfNumber;
      complexNumber.imaginaryPartOfNumber = firstNumber.imaginaryPartOfNumber - secondNumber.imaginaryPartOfNumber;
      return complexNumber;
    }

    /// <summary>
    /// This method multiplies two complex numbers.
    /// </summary>
    /// <param name="firstNumber">First complex number.</param>
    /// <param name="secondNumber">Second complex number.</param>
    /// <returns>Returns multiplied complex number.</returns>
    public ComplexNumber MultiplicationComplexNumber(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      ComplexNumber complexNumber = new ComplexNumber();
      complexNumber.realPartOfNumber = firstNumber.realPartOfNumber * secondNumber.realPartOfNumber - firstNumber.imaginaryPartOfNumber * secondNumber.imaginaryPartOfNumber;
      complexNumber.imaginaryPartOfNumber = firstNumber.imaginaryPartOfNumber * secondNumber.realPartOfNumber + firstNumber.realPartOfNumber * secondNumber.imaginaryPartOfNumber;
      return complexNumber;
    }

    private double ModulOfComplexNumber(ComplexNumber complexNumber)
    {
      return Math.Sqrt(Math.Pow(complexNumber.realPartOfNumber, 2) + Math.Pow(complexNumber.imaginaryPartOfNumber, 2));
    }

    /// <summary>
    /// This method compares two complex numbers.
    /// </summary>
    /// <param name="firstNumber">First complex number.</param>
    /// <param name="secondNumber">Second complex number.</param>
    /// <returns>Returns true if numbers are equals.</returns>
    public bool Equals(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      return ModulOfComplexNumber(firstNumber).Equals(ModulOfComplexNumber(secondNumber));
    }

  }
}
