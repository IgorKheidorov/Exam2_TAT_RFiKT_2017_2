using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    /// <summary>
    /// This class describes the complex number with operations on them.
    /// </summary>
    public class ComplexNumber
    {
        public double re { get; set; }
        public double im { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ComplexNumber() { }

        /// <summary>
        /// Constractor that initialise complex number by got parameters.
        /// </summary>
        /// <param name="re"> Imaginary part of number. </param>
        /// <param name="im"> Real part of number. </param>
        public ComplexNumber(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Copy meanings of got parameter.
        /// </summary>
        /// <param name="complexNumber"> Get complex number to copy. </param>
        public ComplexNumber(ComplexNumber complexNumber)
        {
            re = complexNumber.re;
            im = complexNumber.im;
        }

        /// <summary>
        /// Returns exception if summ of im or re parts out of double range.
        /// </summary>
        /// <param name="cOne"></param>
        /// <param name="cTwo"></param>
        /// <returns></returns>
        public static ComplexNumber operator +(ComplexNumber cOne, ComplexNumber cTwo)
        {
            if (cOne.re > Double.MaxValue - cTwo.re || cOne.im > Double.MaxValue - cTwo.im)
            {
                throw new FormatException();
            }
            return new ComplexNumber(cOne.re + cTwo.re, cOne.im + cTwo.im);
        }

        /// <summary>
        /// Returns exception if difference of im or re parts out of range.
        /// </summary>
        /// <param name="cOne"> Minuend. </param>
        /// <param name="cTwo"> Subtrahend. </param>
        /// <returns> Returns difference between two complex numbers. </returns>
        public static ComplexNumber operator -(ComplexNumber cOne, ComplexNumber cTwo)
        {
            if (cOne.re < Double.MinValue + cTwo.re || cOne.im < Double.MaxValue + cTwo.im)
            {
                throw new FormatException();
            }
            return new ComplexNumber(cOne.re - cTwo.re, cOne.im - cTwo.im);
        }

        /// <summary>
        /// Multiply one number on another. Returns exception if number out of range.
        /// </summary>
        /// <param name="cOne"> Multiplied. </param>
        /// <param name="cTwo"> Factor. </param>
        /// <returns> Multiplication of numbers. </returns>
        public static ComplexNumber operator *(ComplexNumber cOne, ComplexNumber cTwo)
        {
            if (cOne.re * cTwo.re > Double.MaxValue || cOne.re * cTwo.im < Double.MinValue ||
                cOne.im * cTwo.re > Double.MaxValue || cOne.im * cTwo.im < Double.MinValue ||
                cOne.re * cTwo.re - cOne.im * cTwo.im > Double.MaxValue ||
                cOne.re * cTwo.im + cOne.im * cTwo.re < Double.MinValue)
            {
                throw new FormatException();
            }
            return new ComplexNumber(cOne.re * cTwo.re - cOne.im * cTwo.im, cOne.re * cTwo.im + cOne.im * cTwo.re);
        }

        /// <summary>
        /// Returns exception if module of complex number is out of range.
        /// </summary>
        /// <returns> Module of complex number. </returns>
        public double GetAbs()
        {
            if (Math.Pow(im * im + re * re, 0.5) > Double.MaxValue)
            {
                throw new FormatException();
            }
            return Math.Pow(im * im + re * re, 0.5);
        }

        public bool Compare(ComplexNumber toCompare)
        {
            if (im.Equals(toCompare.im) && re.Equals(toCompare.re))
            {

            }
        }

        /// <summary>
        /// Print number on console.
        /// </summary>
        public void OnConsole()
        {
            Console.WriteLine("{0} + i{1}",re, im);
        }
    }
}
