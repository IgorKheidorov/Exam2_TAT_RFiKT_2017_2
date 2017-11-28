using System;

namespace ComplexNumber
{
  /// <summary>
  /// Class describes the essence of a complex number
  /// and operations on it
  /// </summary>
  public class ComplexNumber
  {
    public double RealPart { get; set; }

    public double ImaginaryPart { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public ComplexNumber()
    {
      RealPart = 0;
      ImaginaryPart = 0;
    }

    /// <summary>
    /// Constructor with params
    /// </summary>
    /// <param name="realPart"></param>
    /// <param name="imaginaryPart"></param>
    public ComplexNumber(double realPart, double imaginaryPart)
    {
      RealPart = realPart;
      ImaginaryPart = imaginaryPart;
    }

    /// <summary>
    /// Copy constructor
    /// </summary>
    /// <param name="complexNumber"></param>
    public ComplexNumber(ComplexNumber complexNumber)
    {
      this.RealPart = complexNumber.RealPart;
      this.ImaginaryPart = complexNumber.ImaginaryPart;
    }

    /// <summary>
    /// Overrided operator sum of two complex numbers
    /// </summary>
    /// <param name="firstNumber"></param>
    /// <param name="secondNumber"></param>
    /// <returns>New complex number</returns>
    public static ComplexNumber operator +(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      return new ComplexNumber(firstNumber.RealPart + secondNumber.RealPart,
        firstNumber.ImaginaryPart + secondNumber.ImaginaryPart);
    }

    /// <summary>
    /// Overrided operator difference between two complex numbers
    /// </summary>
    /// <param name="firstNumber"></param>
    /// <param name="secondNumber"></param>
    /// <returns>New complex number</returns>
    public static ComplexNumber operator -(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      return new ComplexNumber(firstNumber.RealPart - secondNumber.RealPart,
        firstNumber.ImaginaryPart - secondNumber.ImaginaryPart);
    }

    /// <summary>
    /// Overrided operator composition of two complex numbers
    /// </summary>
    /// <param name="firstNumber"></param>
    /// <param name="secondNumber"></param>
    /// <returns>New complex number</returns>
    public static ComplexNumber operator *(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      return new ComplexNumber(firstNumber.RealPart * secondNumber.RealPart -
                               firstNumber.ImaginaryPart * secondNumber.ImaginaryPart,
                               firstNumber.ImaginaryPart * secondNumber.RealPart +
                               firstNumber.RealPart * secondNumber.ImaginaryPart);
    }

    /// <summary>
    /// Overrided operator quotient between two complex numbers
    /// Throws exception when secondNumber has null absolute value
    /// </summary>
    /// <param name="firstNumber"></param>
    /// <param name="secondNumber"></param>
    /// <returns>New complex number</returns>
    public static ComplexNumber operator /(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      double realPart = (firstNumber.RealPart * secondNumber.RealPart +
                         firstNumber.ImaginaryPart * secondNumber.ImaginaryPart) /
                        Math.Pow((Math.Pow(secondNumber.RealPart, 2) + Math.Pow(secondNumber.ImaginaryPart, 2)), 2);

      double imaginaryPart = (firstNumber.ImaginaryPart * secondNumber.RealPart -
                              firstNumber.RealPart * secondNumber.ImaginaryPart) /
                             Math.Pow((Math.Pow(secondNumber.RealPart, 2) + Math.Pow(secondNumber.ImaginaryPart, 2)), 2);


      return new ComplexNumber(realPart, imaginaryPart);
    }

    /// <summary>
    /// Overrided operator are equal two complex numbers
    /// </summary>
    /// <returns>True if are equal, false otherwise</returns>
    public static bool operator ==(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      if (Math.Abs(firstNumber.RealPart - secondNumber.RealPart) < Double.Epsilon
          && Math.Abs(firstNumber.ImaginaryPart - secondNumber.ImaginaryPart) < Double.Epsilon)
      {
        return true;
      }
      return false;
    }

    /// <summary>
    /// Overrided operator are not equal two complex numbers
    /// </summary>
    /// <returns>True if are not equal, false otherwise</returns>
    public static bool operator !=(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      if (Math.Abs(firstNumber.RealPart - secondNumber.RealPart) < Double.Epsilon
          && Math.Abs(firstNumber.ImaginaryPart - secondNumber.ImaginaryPart) < Double.Epsilon)
      {
        return false;
      }
      return true;
    }

    /// <summary>
    /// Comparator for two complex numbers
    /// </summary>
    /// <param name="complexNumber"></param>
    /// <returns>-1 - absolute value of this instance precedes absolute value of complexNumber.
    /// 0 - absolute value of this instance in the same position as absolute value of complexNumber.
    /// 1 - absolute value of this instance follows absolute value of complexNumber.</returns>
    public int CompareTo(ComplexNumber complexNumber)
    {
      if (this.GetAbsoluteValue() > complexNumber.GetAbsoluteValue())
      {
        return 1;
      }

      if (this.GetAbsoluteValue() < complexNumber.GetAbsoluteValue())
      {
        return -1;
      }

      return 0;
    }
    /// <summary>
    /// Get absolute value of complex number
    /// </summary>
    /// <returns>Value of module</returns>
    public double GetAbsoluteValue()
    {
      return Math.Pow((Math.Pow(RealPart, 2) + Math.Pow(ImaginaryPart, 2)), 0.5);
    }

    /// <summary>
    /// Override method Equals
    /// Check on equal all fields
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {
      // If parameter cannot be cast to ComplexNumber return false.
      ComplexNumber complexNumber = obj as ComplexNumber;
      if ((object)complexNumber == null)
      {
        return false;
      }

      // Return true if the fields match:
      return this.RealPart.Equals(complexNumber.RealPart) && this.ImaginaryPart.Equals(complexNumber.ImaginaryPart);
    }
  }
}
