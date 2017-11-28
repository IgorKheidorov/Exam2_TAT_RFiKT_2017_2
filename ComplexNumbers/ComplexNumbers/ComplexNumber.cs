using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
  /*
   * This class of complex number
   */
  public class ComplexNumber
  {
    private double im;
    private double re;

    public double GetIm()
    {
      return this.im;
    }

    public double GetRe()
    {
      return this.re;
    }

    public void SetRe(ComplexNumber complexNumber)
    {
      re = complexNumber.re;
    }

    public void SetIm(ComplexNumber complexNumber)
    {
      im = complexNumber.im;
    }
    /*
     * default constructor 
     */
    public ComplexNumber()
    {
      im = 0;
      re = 0;
    }

    /*
     * constructor with params
     * 
     * @param double re
     * @param double im
     */
    public ComplexNumber(double re, double im)
    {
      this.im = im;
      this.re = re;
    }

    /*
     * constructor which copy object 
     * 
     * @param ComplexNumber number(which we want copy)
     */
    public ComplexNumber(ComplexNumber complexNumber)
    {
      this.re = complexNumber.re;
      this.im = complexNumber.im;
    }

    /*
     * This method sum two complex numbers
     * 
     * @param ComplexNumber firstNumber
     * @param ComplexNumber SecondNumber
     * @return ComplexNumber thirdNumber (complex number which is sum of numbers from params)
     */
    public ComplexNumber Sum(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      ComplexNumber thirdNumber = new ComplexNumber
      {
        re = firstNumber.re + secondNumber.re,
        im = firstNumber.im + secondNumber.im
      };
      return thirdNumber;
    }

    /*
     * This method multiplucate two complex numbers
     * 
     * @param ComplexNumber firstNumber
     * @param ComplexNumber SecondNumber
     * @return ComplexNumber thirdNumber (complex number which is multiplicaion of numbers from params)
     */
    public ComplexNumber Multiplication(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      ComplexNumber thirdNumber = new ComplexNumber
      {
        re = firstNumber.re * secondNumber.re,
        im = firstNumber.im * secondNumber.im
      };
      return thirdNumber;
    }

    /*
     * This method substract two complex numbers
     * 
     * @param ComplexNumber firstNumber (from which we want substract)
     * @param ComplexNumber SecondNumber (which we want subctrack)
     * @return ComplexNumber thirdNumber (complex number which is substract of numbers from params)
     */
    public ComplexNumber Subtract(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      ComplexNumber thirdNumber = new ComplexNumber
      {
        re = firstNumber.re - secondNumber.re,
        im = firstNumber.im - secondNumber.im
      };
      return thirdNumber;
    }

    /*
     * This method dision two complex numbers. This methode check second number on zero
     * 
     * @param ComplexNumber firstNumber ( which we want division)
     * @param ComplexNumber SecondNumber (on which we divicion)
     * @return ComplexNumber thirdNumber (complex number which is divicon of numbers from params)
     */
    public ComplexNumber Division(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      try
      {
        ComplexNumber thirdNumber = new ComplexNumber
        {
          re = (firstNumber.re * secondNumber.re + firstNumber.im * secondNumber.im) / ((secondNumber.re * secondNumber.re) + (secondNumber.im * secondNumber.im)),
          im = (secondNumber.re * firstNumber.im - firstNumber.re * secondNumber.im) / ((secondNumber.re * secondNumber.re) + (secondNumber.im * secondNumber.im))
        };
        return thirdNumber;
      }
      catch (DivideByZeroException)
      {
        throw new DivideByZeroException();
      }
    }

    /*
    * This method override sum two complex numbers
    * 
    * @param ComplexNumber firstNumber
    * @param ComplexNumber SecondNumber
    * @return ComplexNumber thirdNumber (complex number which is sum of numbers from params)
    */
    public static ComplexNumber operator +(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      return new ComplexNumber().Sum(firstNumber, secondNumber);
    }

    /*
     * This method override substract two complex numbers
     * 
     * @param ComplexNumber firstNumber (from which we want substract)
     * @param ComplexNumber SecondNumber (which we want subctrack)
     * @return ComplexNumber thirdNumber (complex number which is substract of numbers from params)
     */
    public static ComplexNumber operator -(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      return new ComplexNumber().Subtract(firstNumber, secondNumber);
    }

    /*
     * This method override multiplucate two complex numbers
     * 
     * @param ComplexNumber firstNumber
     * @param ComplexNumber SecondNumber
     * @return ComplexNumber thirdNumber (complex number which is multiplicaion of numbers from params)
     */
    public static ComplexNumber operator *(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      return new ComplexNumber().Multiplication(firstNumber, secondNumber);
    }

    /*
     * This method override dision two complex numbers
     * 
     * @param ComplexNumber firstNumber ( which we want division)
     * @param ComplexNumber SecondNumber (on which we divicion)
     * @return ComplexNumber thirdNumber (complex number which is divicon of numbers from params)
     */
    public static ComplexNumber operator /(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      return new ComplexNumber().Division(firstNumber, secondNumber);
    }

    /*
     * This method override output of string
     * 
     * @return String which is our complex number
     */
    public override String ToString()
    {
      String number = "";
      if (re != 0.0)
      {
        number = re.ToString();
      }
      if (im != 0.0)
      {
        if (im > 0)
        {
          number += "+";
        }
        number += im.ToString() + "i";
      }
      return number;
    }

    /*
     * This method give you model of your complex number
     */
    public double GetModule()
    {
      return Math.Sqrt(Math.Pow(re, 2) + Math.Pow(im, 2));
    }

    /*
     * This methode compare numbers
     * 
     * @param ComplexNumber number (with wich we want compare)
     * @return 0 if same numbers, if first more tha
     */
    public int Compare(ComplexNumber number)
    {
      int result = 0;
      if (this.GetModule() - number.GetModule() > double.Epsilon)
      {
        result = 1;
      }
      if (this.GetModule() - number.GetModule() < double.Epsilon)
      {
        result = -1;
      }
      return result;
    }
  }
}
