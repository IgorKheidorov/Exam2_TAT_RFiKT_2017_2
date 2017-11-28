namespace Test_3.Task_3

{
  /// <summary>
  /// This class created for work with complex number.
  /// </summary>
  public class ComplexNumber
  {
    private double realPart;
    private double imaginaryPart;

    /// <summary>
    ///This constructor initializes complex number (0, 0).
    /// </summary>
    public ComplexNumber()
    {
      realPart = 0.0;
      imaginaryPart = 0.0;
    }

    /// <summary>
    /// This constructor initializes the parts of complex number by parameter values.
    /// </summary>
    /// <param name="realPart">Real part of complex number.</param>
    /// <param name="imaginaryPart">Imaginary part of complex number.</param>
    public ComplexNumber(double realPart, double imaginaryPart)
    {
      this.realPart = realPart;
      this.imaginaryPart = imaginaryPart;
    }

    /// <summary>
    /// This constructor copies value of created object in new object.
    /// </summary>
    /// <param name="complexNumber">Created object.</param>
    public ComplexNumber(ComplexNumber complexNumber)
    {
      realPart = complexNumber.realPart;
      imaginaryPart = complexNumber.imaginaryPart;
    }

    public double RealPart { get { return realPart; } set { realPart = value; } }
    public double ImaginaryPart { get { return imaginaryPart; } set { imaginaryPart = value; } }

    /// <summary>
    /// This method sums two complex numbers.
    /// </summary>
    /// <param name="firstNumber">First complex number.</param>
    /// <param name="secondNumber">Second complex number.</param>
    /// <returns>Returns sum of two complex numbers.</returns>
    public ComplexNumber FoldComplexNumbers(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      ComplexNumber result = new ComplexNumber();
      result.realPart = firstNumber.realPart + secondNumber.realPart;
      result.imaginaryPart = firstNumber.imaginaryPart + secondNumber.imaginaryPart;
      return result;
    }

    /// <summary>
    /// This method multiplies two complex numbers.
    /// </summary>
    /// <param name="firstNumber">First complex number.</param>
    /// <param name="secondNumber">Second complex number.</param>
    /// <returns>Returns multiply of two complex numbers.</returns>
    public ComplexNumber MultiplyComplexNumbers(ComplexNumber firstNumber, ComplexNumber secondNumber)
    {
      ComplexNumber result = new ComplexNumber();
      result.realPart = firstNumber.realPart * secondNumber.realPart - firstNumber.imaginaryPart * secondNumber.imaginaryPart;
      result.imaginaryPart = firstNumber.imaginaryPart * secondNumber.realPart + firstNumber.realPart * secondNumber.ImaginaryPart;
      return result;
    }
  }
}
