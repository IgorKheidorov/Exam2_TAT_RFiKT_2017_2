using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
  /// <summary>
  /// This class is used for create and manipulate with complex numbers.
  /// </summary>
  public class ComplexNumber
  {
    double RealPart { get; set; }
    double ComplexPart { get; set; }
    public ComplexNumber()
    {
      RealPart = 0;
      ComplexPart = 0;
    }
    public ComplexNumber(double real, double complex)
    {
      RealPart = real;
      ComplexPart = complex;
    }
    public ComplexNumber(ComplexNumber number)
    {
      this.RealPart = number.RealPart;
      this.ComplexPart = number.ComplexPart;
    }
    public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
    {
      return checked(new ComplexNumber(num1.RealPart + num2.RealPart, num1.ComplexPart + num2.ComplexPart));
    }
    public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
    {
      return checked(new ComplexNumber(num1.RealPart - num2.RealPart, num1.ComplexPart - num2.ComplexPart));
    }
    public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
    {
      double real = 0;
      double complex = 0;
      checked
      {
        real = (num1.RealPart * num2.RealPart) - (num1.ComplexPart * num2.ComplexPart);
        complex = (num1.RealPart * num2.ComplexPart) + (num1.ComplexPart * num2.RealPart);
      }
      return new ComplexNumber(real, complex);
    }
    public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2)
    {
      double real;
      double complex;
      checked
      {
        real = ((num1.RealPart * num2.RealPart + num1.ComplexPart * num2.ComplexPart)) / (Math.Pow(num2.RealPart, 2) + (Math.Pow(num2.ComplexPart, 2)));
        complex = ((num2.RealPart * num1.ComplexPart) - (num1.RealPart * num2.ComplexPart)) / (Math.Pow(num2.RealPart, 2) + (Math.Pow(num2.ComplexPart, 2)));
      }
      return new ComplexNumber(real, complex);
    }
    /// <summary>
    /// This method is used for compare some complex number with another one.
    /// </summary>
    /// <param name="numberToCompare">
    /// Number to compare.
    /// </param>
    /// <returns>
    /// Return 0, if numbers are equal, 1 if this number is bigger then parametr, -1 if this number
    /// less then parametr
    /// </returns>


    public int CompareTo(ComplexNumber numberToCompare)
    {
      if (Math.Abs(this.GetAbsolute() - numberToCompare.GetAbsolute()) > double.Epsilon)
        return 1;
      if (Math.Abs(this.GetAbsolute() - numberToCompare.GetAbsolute()) < double.Epsilon)
        return -1;
      return 0;
    }

    /// <summary>
    /// Get the absolute value of number.
    /// </summary>
    /// <returns>
    /// Absolute value of this number.
    /// </returns>
    public double GetAbsolute()
    {
      return Math.Sqrt(Math.Pow(RealPart, 2) - Math.Pow(ComplexPart, 2));
    }
    public override string ToString()
    {
      if (ComplexPart > 0)
      {
        return RealPart.ToString() + "+" + ComplexPart.ToString() + "i";
      }
      else if (ComplexPart != 0)
      {
        return RealPart.ToString() + ComplexPart.ToString() + "i";
      }
      else
      {
        return RealPart.ToString();
      }
    }
  }
}
