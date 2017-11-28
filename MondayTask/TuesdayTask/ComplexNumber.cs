using System;
using System.Text;

namespace TuesdayTask
{
    /// <summary>
    /// Class realizes complex number and its properties.
    /// </summary>
    public class ComplexNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }
        public ComplexNumber()
        {
        }
        /// <summary>
        /// Constructor with two parametrs.
        /// </summary>
        /// <param name="realPart">Real part</param>
        /// <param name="imaginaryPart">Imaginary part</param>
        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }
        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="newCompNumb">Object that should be copied.</param>
        public ComplexNumber(ComplexNumber newCompNumb)
        {
            RealPart = newCompNumb.RealPart;
            ImaginaryPart = newCompNumb.ImaginaryPart;
        }
        /// <summary>
        /// Addition of two complex numbers.
        /// Generates OwerflowException.
        /// </summary>
        /// <param name="firstNumb">First complex number.</param>
        /// <param name="secondNumb">Second complex number</param>
        /// <returns>Result of addition in new ComplexNumber object.</returns>
        public static ComplexNumber operator + (ComplexNumber firstNumb, ComplexNumber secondNumb)
        {
            checked
            {
                return new ComplexNumber(firstNumb.RealPart + secondNumb.RealPart,
                    firstNumb.ImaginaryPart + secondNumb.ImaginaryPart);
            }
        }
        /// <summary>
        /// Subtracts two complex numbers.
        /// Generates OwerflowException.
        /// </summary>
        /// <param name="firstNumb">First complex number.</param>
        /// <param name="secondNumb">Second complex number</param>
        /// <returns>Result of substraction in new Complex Number object</returns>
        public static ComplexNumber operator - (ComplexNumber firstNumb, ComplexNumber secondNumb)
        {
            checked
            {
                ComplexNumber newNumb = new ComplexNumber();
                newNumb.RealPart = firstNumb.RealPart - secondNumb.RealPart;
                newNumb.ImaginaryPart = firstNumb.ImaginaryPart - secondNumb.ImaginaryPart;
                return newNumb;
            }
        }
        /// <summary>
        /// Multiplicates two complex numbers.
        /// </summary>
        /// <param name="firstNumb">First complex number.</param>
        /// <param name="secondNumb">Second complex number</param>
        /// <returns>New object of complex number that has value of multiplication.</returns>
        public static ComplexNumber operator * (ComplexNumber firstNumb, ComplexNumber secondNumb)
        {
            ComplexNumber newNumb = new ComplexNumber();
            newNumb.RealPart = (firstNumb.RealPart * secondNumb.RealPart)
                - (firstNumb.ImaginaryPart * secondNumb.ImaginaryPart);
            newNumb.ImaginaryPart = (firstNumb.ImaginaryPart * secondNumb.RealPart)
                + (firstNumb.RealPart * secondNumb.ImaginaryPart);
            return newNumb;
        }
        /// <summary>
        /// Devides two complex numbers.
        /// Throw ArgumentException if the calculated values are NAN.
        /// </summary>
        /// <param name="firstNumb">Dividend</param>
        /// <param name="secondNumb">Quotient</param>
        /// <returns>New object of complex number that has value of division.</returns>
        public static ComplexNumber operator /(ComplexNumber firstNumb, ComplexNumber secondNumb)
        {
            ComplexNumber newNumb = new ComplexNumber();
            newNumb.RealPart = ((firstNumb.RealPart * secondNumb.RealPart)
                + (firstNumb.ImaginaryPart * secondNumb.ImaginaryPart))
                / ((secondNumb.RealPart * secondNumb.RealPart) 
                + (secondNumb.ImaginaryPart * secondNumb.ImaginaryPart));

            newNumb.ImaginaryPart = ((firstNumb.ImaginaryPart * secondNumb.RealPart)
                - (firstNumb.RealPart * secondNumb.ImaginaryPart))
                / ((secondNumb.RealPart * secondNumb.RealPart)
                + (secondNumb.ImaginaryPart * secondNumb.ImaginaryPart));
            if (Double.IsNaN(newNumb.RealPart) || Double.IsNaN(newNumb.ImaginaryPart))
            {
                throw new ArgumentException();
            }
            return newNumb;
        }
        /// <summary>
        /// Compares this instance to a complex number numb.
        /// Return the integer that indicates whether this instance 
        /// is less than, equal to, greater than the value of complex number.
        /// </summary>
        /// <param name="numb">First complex number.</param>
        /// <param name="secondNumb">Second complex number</param>
        /// <returns>-1 - is less.
        /// 0 - equals
        /// 1 - is greater.
        /// </returns>
        public int CompareTo(ComplexNumber numb)
        {
            return GetAbsoluteValue(this).CompareTo(GetAbsoluteValue(numb));
        }
        /// <summary>
        /// Gets Absolute value of the complex number.
        /// </summary>
        /// <param name="numb">Complex number</param>
        /// <returns>Double value of complex number absolute value.</returns>
        private double GetAbsoluteValue(ComplexNumber numb)
        {
            return Math.Sqrt((numb.RealPart * numb.RealPart)
                + (numb.ImaginaryPart * numb.ImaginaryPart));
        }
        /// <summary>
        /// Returns string value of complex number.
        /// </summary>
        /// <returns>String of complex number value.</returns>
         public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.RealPart);
            sb.Append(" + ");
            sb.Append(this.ImaginaryPart);
            sb.Append("i");
            return sb.ToString();
        }
        /// <summary>
        /// Outputs object value in string.
        /// </summary>
        public void ToDisplay()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
