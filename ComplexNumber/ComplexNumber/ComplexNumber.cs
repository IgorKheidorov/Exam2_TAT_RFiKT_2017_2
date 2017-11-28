using System;
using System.Text;

namespace ComplexNumbers
{
  public class ComplexNumber
  {
    private static readonly double EPSILON = double.Epsilon;
    public int count = 0;

    public double Re { get; set; }
    public double Im { get; set; }

    /// <summary>
    /// default constructor
    /// </summary>
    public ComplexNumber()
    {
      count++;
    }

    /// <summary>
    /// constructor with parameters
    /// </summary>
    /// <param name="re"></param>
    /// <param name="im"></param>
    public ComplexNumber(double re, double im)
    {
      Re = re;
      Im = im;
    }

    /// <summary>
    /// copy constructor
    /// </summary>
    /// <param name="complexNumber"></param>
    public ComplexNumber(ComplexNumber complexNumber)
    {
      Re = complexNumber.Re;
      Im = complexNumber.Im;
    }

    /// <summary>
    /// Override the operator of addition
    /// </summary>
    /// <param name="obj1">the first term is a complex number</param>
    /// <param name="obj2">the second term is a complex number</param>
    /// <returns>the resulting complex number as a result of addition</returns>
    public static ComplexNumber operator +(ComplexNumber obj1, ComplexNumber obj2)
    {
      ComplexNumber complexNumber = new ComplexNumber
      {
        Re = obj1.Re + obj2.Re,
        Im = obj1.Im + obj2.Im
      };
      return complexNumber;
    }

    /// <summary>
    ///  Override the operator of -
    /// </summary>
    /// <param name="obj1">decrementable number</param>
    /// <param name="obj2">subtracted number</param>
    /// <returns>the resulting complex number as a result of subtraction</returns>
    public static ComplexNumber operator -(ComplexNumber obj1, ComplexNumber obj2)
    {
      ComplexNumber complexNumber = new ComplexNumber
      {
        Re = obj1.Re - obj2.Re,
        Im = obj1.Im - obj2.Im
      };
      return complexNumber;
    }

    /// <summary>
    ///  Override the operator *
    /// </summary>
    /// <param name="obj1">decrementable number</param>
    /// <param name="obj2">subtracted number</param>
    /// <returns>the resulting complex number as a result of subtraction</returns>
    public static ComplexNumber operator *(ComplexNumber obj1, ComplexNumber obj2)
    {
      return new ComplexNumber
      {
        Re = obj1.Re * obj2.Re - obj2.Im * obj1.Im,
        Im = obj1.Re * obj2.Im + obj1.Im * obj2.Re
      };
    }

    /// <summary>
    /// overloading of the division operator
    /// </summary>
    /// <param name="obj1">dividend number</param>
    /// <param name="obj2">divisor number</param>
    /// <returns>result of division of complex numbers</returns>
    public static ComplexNumber operator /(ComplexNumber obj1, ComplexNumber obj2)
    {
      try
      {
        ComplexNumber complexNumber = new ComplexNumber
        {
          Re = (obj1.Re * obj2.Re + obj2.Im * obj1.Im) / (obj2.Re * obj2.Re + obj2.Im * obj2.Im),
          Im = (obj2.Re * obj1.Im - obj2.Im * obj1.Re) / (obj2.Re * obj2.Re + obj2.Im * obj2.Im)
        };
        return complexNumber;
      }
      catch (DivideByZeroException)
      {
        throw new DivideByZeroException();
      }
    }

    /// <summary>
    /// this method gives the modulus of a complex number
    /// </summary>
    /// <returns>the modulus of a complex number</returns>
    public double GetToModule()
    {
      return Math.Sqrt(Math.Pow(Re, 2) + Math.Pow(Im, 2));
    }

    /// <summary>
    /// This method compares complex numbers
    /// </summary>
    /// <param name="complexNumber"></param>
    /// <returns></returns>
    public int Compare(ComplexNumber complexNumber)
    {
      int result = 0;
      if (GetToModule() - complexNumber.GetToModule() > EPSILON)
      {
        result = 1;
      }
      else if (GetToModule() - complexNumber.GetToModule() < EPSILON)
      {
        result = -1;
      }
      return result;
    }

    /// <summary>
    /// This is override of ToString() method.
    /// </summary>
    /// <returns> </returns>
    public override string ToString()
    {
      StringBuilder result = new StringBuilder();
      result.Append(Re);
      if (Im >= 0)
      {
        result.Append("+");
      }
      result.Append(Im).Append("i");
      return result.ToString();
    }
  }
}