/**
 * This class is working with complex number.
 */
public class ComplexNumber {
  private double realPart;
  private double imaginaryPart;

  /**
   * This constructor initializes the parts of the complex number by (0.0).
   */
  public ComplexNumber() {
    realPart = 0.0;
    imaginaryPart = 0.0;
  }

  /**
   * This constructor initializes the parts of the complex number by parameters values.
   *
   * @param realPart      the real part of the complex number
   * @param imaginaryPart the imaginary part of the complex number
   */
  public ComplexNumber(double realPart, double imaginaryPart) {
    this.realPart = realPart;
    this.imaginaryPart = imaginaryPart;
  }

  /**
   * This constructor copies the value of the created object to the newly created object.
   *
   * @param complexNumber the created object
   */
  public ComplexNumber(ComplexNumber complexNumber) {
    this(complexNumber.getRealPart(), complexNumber.getImaginaryPart());
  }

  public double getRealPart() {
    return realPart;
  }

  public void setRealPart(double realPart) {
    this.realPart = realPart;
  }

  public double getImaginaryPart() {
    return imaginaryPart;
  }

  public void setImaginaryPart(double imaginaryPart) {
    this.imaginaryPart = imaginaryPart;
  }

  /**
   * Sums up two complex numbers.
   *
   * @param firstNumber  the first complex number
   * @param secondNumber the second complex number
   * @return summation result
   */
  public ComplexNumber addition(ComplexNumber firstNumber, ComplexNumber secondNumber) {
    return new ComplexNumber(firstNumber.realPart + secondNumber.realPart, firstNumber.imaginaryPart + secondNumber.imaginaryPart);
  }

  /**
   * Subtracts two complex numbers.
   *
   * @param firstNumber  the first complex number
   * @param secondNumber the second complex number
   * @return subtraction result
   */
  public ComplexNumber subtraction(ComplexNumber firstNumber, ComplexNumber secondNumber) {
    return new ComplexNumber(firstNumber.realPart - secondNumber.realPart, firstNumber.imaginaryPart - secondNumber.imaginaryPart);
  }

  /**
   * Multiplies two complex numbers.
   *
   * @param firstNumber  the first complex number
   * @param secondNumber the second complex number
   * @return multiplication result
   */
  public ComplexNumber multiplication(ComplexNumber firstNumber, ComplexNumber secondNumber) {
    ComplexNumber result = new ComplexNumber();
    result.realPart = firstNumber.realPart * secondNumber.realPart - firstNumber.imaginaryPart * secondNumber.imaginaryPart;
    result.imaginaryPart = firstNumber.realPart * secondNumber.imaginaryPart + firstNumber.imaginaryPart * secondNumber.realPart;
    return result;
  }

  /**
   * Divides two complex numbers.
   *
   * @param firstNumber  the first complex number
   * @param secondNumber the second complex number
   * @return result of division
   */
  public ComplexNumber division(ComplexNumber firstNumber, ComplexNumber secondNumber) {
    // to do - realization of division
    return new ComplexNumber();
  }

  private double moduleComplexNumber(ComplexNumber complexNumber) {
    return Math.sqrt(Math.pow(complexNumber.realPart, 2) + Math.pow(complexNumber.imaginaryPart, 2));
  }

  public int comparison(ComplexNumber firstNumber, ComplexNumber secondNumber) {
    return (Double.compare(moduleComplexNumber(firstNumber), moduleComplexNumber(secondNumber)));
  }
}
