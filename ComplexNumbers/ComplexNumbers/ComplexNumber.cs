using System;
using System.Text;

namespace ComplexNumbers
{
  /// <summary>
  /// This is class for complex number.
  /// </summary>
  public class ComplexNumber
  {
    private static readonly double EPSILON = double.Epsilon;

    public double Re { get; set; }

    public double Im { get; set; }

    /// <summary>
    /// This is default constructor.
    /// </summary>
    public ComplexNumber()
    {
      Re = 0;
      Im = 0;
    }

    /// <summary>
    /// This is constructor with parameters.
    /// </summary>
    /// <param name="re"> real part of complex number </param>
    /// <param name="im"> imaginary part of complex number </param>
    public ComplexNumber(double re, double im)
    {
      Re = re;
      Im = im;
    }

    /// <summary>
    /// This is copy constructor.
    /// </summary>
    /// <param name="complexNumber"> complex number </param>
    public ComplexNumber(ComplexNumber complexNumber)
    {
      Re = complexNumber.Re;
      Im = complexNumber.Im;
    }

    /// <summary>
    /// This is override for operator +.
    /// </summary>
    /// <param name="obj1"> first complex number </param>
    /// <param name="obj2"> second complex number </param>
    /// <returns> sum of two complex numbers </returns>
    public static ComplexNumber operator +(ComplexNumber obj1, ComplexNumber obj2)
    {
      return new ComplexNumber
      {
        Re = obj1.Re + obj2.Re,
        Im = obj1.Im + obj2.Im
      };
    }

    /// <summary>
    /// This is override for operator -.
    /// </summary>
    /// <param name="obj1"> first complex number </param>
    /// <param name="obj2"> second complex number </param>
    /// <returns> difference of two complex numbers </returns>
    public static ComplexNumber operator -(ComplexNumber obj1, ComplexNumber obj2)
    {
      return new ComplexNumber
      {
        Re = obj1.Re - obj2.Re,
        Im = obj1.Im - obj2.Im
      };
    }

    /// <summary>
    /// This is override for operator *.
    /// </summary>
    /// <param name="obj1"> first complex number </param>
    /// <param name="obj2"> second complex number </param>
    /// <returns> multiplication of two complex numbers </returns>
    public static ComplexNumber operator *(ComplexNumber obj1, ComplexNumber obj2)
    {
      return new ComplexNumber
      {
        Re = obj1.Re * obj2.Re - obj1.Im * obj2.Im,
        Im = obj1.Re * obj2.Re + obj1.Im * obj2.Im
      };
    }

    /// <summary>
    /// This is override for operator *. If there is division by zero - method will throw exception. This is happens 
    /// if re and im parts of divisor is 0.
    /// </summary>
    /// <param name="obj1"> first complex number - dividend </param>
    /// <param name="obj2"> second complex number - divisor </param>
    /// <returns> division of two complex numbers </returns>
    public static ComplexNumber operator /(ComplexNumber obj1, ComplexNumber obj2)
    {
        return new ComplexNumber
        {
          Re = (obj1.Re * obj2.Re + obj1.Im * obj2.Im) / (Math.Pow(obj2.Re, 2) + Math.Pow(obj2.Im, 2)),
          Im = (obj2.Re * obj1.Im - obj1.Re * obj2.Im) / (Math.Pow(obj2.Re, 2) + Math.Pow(obj2.Im, 2))
        };
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

    /// <summary>
    /// This method gets module of complex number.
    /// </summary>
    /// <returns> module of complex number </returns>
    public double GetModule()
    {
      return Math.Sqrt(Math.Pow(Re, 2) * Math.Pow(Im, 2));
    }

    /// <summary>
    /// This is compare method.
    /// </summary>
    /// <param name="complexNumber"> complex number </param>
    /// <returns> 1 if first complex number is higher, -1 if it is lower than second complex number and 0 if they are equal. </returns>
    public int Compare(ComplexNumber complexNumber)
    {
      int result = 0;
      if (GetModule() - complexNumber.GetModule() > EPSILON)
      {
        result = 1;
      }
      if (GetModule() - complexNumber.GetModule() < EPSILON)
      {
        result = -1;
      }
      return result;
    }
  }
}