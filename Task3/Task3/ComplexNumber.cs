using System;
using System.Text;

namespace Task3
{
    /// <summary>
    /// Complex number.
    /// </summary>
    public class ComplexNumber
    {
        private double re;
        private double im;

        public double Re
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }
        public double Im
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ComplexNumber() { }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="re">
        /// Real part of number
        /// </param>
        /// <param name="im">
        /// Imaginary part of number
        /// </param>
        public ComplexNumber(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="number">
        /// Number for copying
        /// </param>
        public ComplexNumber(ComplexNumber number)
        {
            re = number.Re;
            im = number.Im;
        }

        /// <summary>
        /// Calculated sum
        /// </summary>
        /// <param name="first">
        /// first term
        /// </param>
        /// <param name="second">
        /// second term
        /// </param>
        /// <returns>
        /// sum
        /// </returns>
        public ComplexNumber CalculateSum(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber sum = new ComplexNumber();
            if (Math.Abs(first.Re + second.Re).CompareTo(double.MaxValue) >= 0 || Math.Abs(first.Im + second.Im).CompareTo(double.MaxValue) >= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                sum.Re = first.Re + second.Re;
                sum.Im = first.Im + second.Im;
            }

            return sum;
        }

        /// <summary>
        /// Calculated difference
        /// </summary>
        /// <param name="first">
        /// minuend
        /// </param>
        /// <param name="second">
        /// subtrahend
        /// </param>
        /// <returns>
        /// difference
        /// </returns>
        public ComplexNumber CalculateDifference(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber diff = new ComplexNumber();
            if (Math.Abs(first.Re - second.Re).CompareTo(double.MaxValue) >= 0 || Math.Abs(first.Im - second.Im).CompareTo(double.MaxValue) >= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                diff.Re = first.Re - second.Re;
                diff.Im = first.Im - second.Im;
            }

            return diff;
        }

        /// <summary>
        /// Calculated module
        /// </summary>
        /// <returns>
        /// module
        /// </returns>
        public double CalculateModule()
        {
            return Math.Sqrt(Re*Re + Im*Im);
        }

        /// <summary>
        /// Compared two complex number by module
        /// </summary>
        /// <param name="first">
        /// first complex number
        /// </param>
        /// <param name="second">
        /// second complex number
        /// </param>
        /// <returns></returns>
        public int CompareByModule (ComplexNumber first, ComplexNumber second)
        {
            return first.CalculateModule().CompareTo(second.CalculateModule());
        }

        /// <summary>
        /// Divided complex numbers
        /// </summary>
        /// <param name="first">
        /// divident
        /// </param>
        /// <param name="second">
        /// divider
        /// </param>
        /// <returns>
        /// quotient
        /// </returns>
        public ComplexNumber Divide(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber result = new ComplexNumber();
            if (Math.Abs(first.Re * second.Re + first.Im * second.Im).CompareTo(double.MaxValue) >= 0
                || Math.Abs(first.Im * second.Re - first.Re * second.Im).CompareTo(double.MaxValue) >= 0
                || Math.Abs(second.Re * second.Re + second.Im * second.Im).CompareTo(double.MaxValue) >= 0
                || Math.Abs(second.Re * second.Re + second.Im * second.Im).CompareTo(0) == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                result.Re = (first.Re * second.Re + first.Im * second.Im) / (second.Re * second.Re + second.Im * second.Im);
                result.Im = (first.Im * second.Re - first.Re * second.Im) / (second.Re * second.Re + second.Im * second.Im);
            }
            return result;
        }

        /// <summary>
        /// Multiply complex numbers
        /// </summary>
        /// <param name="first">
        /// first multiplier
        /// </param>
        /// <param name="second">
        /// second multiplier
        /// </param>
        /// <returns>
        /// composition
        /// </returns>
        public ComplexNumber Multiply(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber result = new ComplexNumber();
            if (Math.Abs(first.Re * second.Re).CompareTo(double.MaxValue) >= 0
               || Math.Abs(first.Im * second.Im).CompareTo(double.MaxValue) >= 0
               || Math.Abs(first.Im * second.Re).CompareTo(double.MaxValue) >= 0
               || Math.Abs(first.Re * second.Im).CompareTo(double.MaxValue) >= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                result.Re = (first.Re * second.Re - first.Im * second.Im);
                result.Im = (first.Im * second.Re + first.Re * second.Im);
            }
            return result;
        }

        /// <summary>
        /// Displayed number
        /// </summary>
        public void DisplayNumber()
        {
            char sign;
            if (im >= 0)
            {
                sign = '+';
            }
            else
            {
                sign = '-';
            }
            StringBuilder line = new StringBuilder(Re.ToString() + " " + sign + " " + Im.ToString() + 'i');
            Console.WriteLine(line);
        }
    }
}