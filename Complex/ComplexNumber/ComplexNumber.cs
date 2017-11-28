using System;

namespace TaskComplexNumber
{
  /// <summary>
  /// Work with complex numbers.
  /// </summary>
  public class ComplexNumber
  {
    const double EPSILON = 0.01;
    public double RealPart { get; set; }
    public double ImaginaryPart { get; set; }
    double realPart;
    double imaginaryPart;    
    public ComplexNumber() { }
   
    public ComplexNumber(double realPart, double imaginaryPart)
    {
      this.realPart = realPart;
      this.imaginaryPart = imaginaryPart;
    }
    public ComplexNumber(ComplexNumber previousComplexNumber)
    {
      realPart = previousComplexNumber.realPart;
      imaginaryPart = previousComplexNumber.imaginaryPart;
    }

    /// <summary>
    /// The overload of operator +.
    /// </summary>
    /// <param name="a">first complex number</param>
    /// <param name="b">second complex number</param>
    /// <returns></returns>
    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
      ComplexNumber complexNumber = new ComplexNumber();
      complexNumber.realPart = a.realPart + b.realPart;
      complexNumber.imaginaryPart = a.imaginaryPart + b.imaginaryPart;
      return complexNumber;
    }

    /// <summary>
    /// The overload of operator -.
    /// </summary>
    /// <param name="a">first complex number</param>
    /// <param name="b">second complex number</param>
    /// <returns></returns>
    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {
      ComplexNumber complexNumber = new ComplexNumber();
      complexNumber.realPart = a.realPart - b.realPart;
      complexNumber.imaginaryPart = a.imaginaryPart - b.imaginaryPart;
      return complexNumber;
    }

    /// <summary>
    /// The overload of operator *.
    /// </summary>
    /// <param name="a">first complex number</param>
    /// <param name="b">second complex number</param>
    /// <returns></returns>
    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {      
      ComplexNumber complexNumber = new ComplexNumber();
      complexNumber.realPart = a.RealPart * b.RealPart - a.ImaginaryPart * b.ImaginaryPart;
      complexNumber.imaginaryPart = a.ImaginaryPart * b.RealPart + a.RealPart * b.ImaginaryPart;
      return complexNumber;
    }

    /// <summary>
    /// The overload of operator /.
    /// </summary>
    /// <param name="a">first complex number</param>
    /// <param name="b">second complex number</param>
    /// <returns></returns>
    public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
    {
      ComplexNumber complexNumber = new ComplexNumber();
      double denominator = a.realPart * a.realPart + b.ImaginaryPart * b.ImaginaryPart;
      complexNumber.realPart = (a.realPart * b.realPart + b.ImaginaryPart * b.ImaginaryPart) / denominator;
      complexNumber.imaginaryPart = (b.realPart * a.ImaginaryPart - a.realPart * b.ImaginaryPart) / denominator;
      return complexNumber;
    }

    /// <summary>
    /// Compare two complex numbers.
    /// </summary>
    /// <param name="a">first complex number</param>
    /// <param name="b">second complex number</param>
    /// <returns></returns>
    public int CompareComplexNumbers(ComplexNumber a, ComplexNumber b)
    {
      if (Math.Sqrt((a.realPart - b.realPart) * (a.realPart - b.realPart) + (a.imaginaryPart - b.imaginaryPart) * (a.imaginaryPart - b.imaginaryPart)) < EPSILON)
      {
        return -1;
      }
      else if (Math.Sqrt((a.realPart - b.realPart) * (a.realPart - b.realPart) + (a.imaginaryPart - b.imaginaryPart) * (a.imaginaryPart - b.imaginaryPart)) > EPSILON)
      {
        return 1;
      }
      else
      {
        return 0;
      }      
    }

    /// <summary>
    /// Add up two complex numbers.
    /// </summary>
    /// <param name="a">first complex number</param>
    /// <param name="b">second complex number</param>
    /// <returns></returns>
    public ComplexNumber AddUp(ComplexNumber a, ComplexNumber b)
    {
      return (a + b);
    }

    /// <summary>
    /// Deduct two complex numbers.
    /// </summary>
    /// <param name="a">first complex number</param>
    /// <param name="b">second complex number</param>
    /// <returns></returns>
    public ComplexNumber Deduct(ComplexNumber a, ComplexNumber b)
    {
      return (a - b);
    }

    /// <summary>
    /// Multiply two complex numbers.
    /// </summary>
    /// <param name="a">first complex number</param>
    /// <param name="b">second complex number</param>
    /// <returns></returns>
    public ComplexNumber Multiply(ComplexNumber a, ComplexNumber b)
    {
      return (a * b);
    }

    /// <summary>
    /// Divide two complex numbers.
    /// </summary>
    /// <param name="a">first complex number</param>
    /// <param name="b">second complex number</param>
    /// <returns></returns>
    public ComplexNumber Divide(ComplexNumber a, ComplexNumber b)
    {
      return (a / b);
    }  
  }
}
