/**
 * This class contains information about given number
 * and .
 */
public class ComplexNumber {
  private double realPart;
  private double imaginaryPart;
  static int count = 0;

  public static void setCounter(int counter) {
    ComplexNumber.count = counter;
  }

  public void setImaginaryPart(double imaginaryPart) {
    this.imaginaryPart = imaginaryPart;
  }

  public void setRealPart(double realPart) {
    this.realPart = realPart;
  }

  public double getImaginaryPart() {
    return imaginaryPart;
  }

  public double getRealPart() {
    return realPart;
  }

  public static int getCounter() {
    return count;
  }

  /**
   * This is default constructor.
   */
  public ComplexNumber() {
  }

  /**
   * This is constructor with parameters.
   * @param transmittedRealPart real part of the complex number transmitted into constructor.
   * @param transmittedImaginaryPart imaginary part of the complex number transmitted into constructor.
   */

  public ComplexNumber(double transmittedRealPart, double transmittedImaginaryPart) {
    this.imaginaryPart = transmittedImaginaryPart;
    this.realPart = transmittedRealPart;
  }

  /**
   * Copy constructor.
   * @param complexNumber object of the class ComplexNumber.
   */
  public ComplexNumber(ComplexNumber complexNumber) {
    realPart = complexNumber.realPart;
    imaginaryPart = complexNumber.imaginaryPart;
  }

  /**
   * This function add up two complex numbers.
   * @param firstComplexNumber first summand
   * @param secondComplexNumber second summand
   * @return result of adding up of two complex numbers.
   */
  public ComplexNumber addUpComplexNumbers(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber) {
    return new ComplexNumber(firstComplexNumber.getRealPart() + secondComplexNumber.getRealPart(),
            firstComplexNumber.getImaginaryPart() + secondComplexNumber.getImaginaryPart());
  }

  /**
   * This function subtracts two complex numbers.
   * @param firstComplexNumber reduced complex number
   * @param secondComplexNumber subtracted complex number.
   * @return result of adding up of two complex numbers.
   */
  public ComplexNumber subtractValue(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber) {
    return new ComplexNumber(firstComplexNumber.getRealPart() - secondComplexNumber.getRealPart(),
            firstComplexNumber.getImaginaryPart() - secondComplexNumber.getImaginaryPart());
  }

  /**
   * This function multiply two complex numbers.
   * @param firstComplexNumber first multiplied
   * @param secondComplexNumber second multiplied
   * @return multiplication result.
   */
  public ComplexNumber multiplyTwoNumbers(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber) {
    return new ComplexNumber((firstComplexNumber.getRealPart() * secondComplexNumber.getRealPart() -
            firstComplexNumber.getImaginaryPart() * secondComplexNumber.getImaginaryPart()),
            (firstComplexNumber.getRealPart() * secondComplexNumber.getImaginaryPart() -
            firstComplexNumber.getRealPart() * secondComplexNumber.getImaginaryPart()));
  }

  /**
   * This function divide two complex numbers.
   * @param firstComplexNumber dividend
   * @param secondComplexNumber divider
   * @return division result.
   */
  public ComplexNumber divisionOfTwoNumbers(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber) {
    return new ComplexNumber((firstComplexNumber.getRealPart() * secondComplexNumber.getRealPart() +
            firstComplexNumber.getImaginaryPart() * secondComplexNumber.getImaginaryPart())
            / (Math. pow((secondComplexNumber.getRealPart() +secondComplexNumber.getImaginaryPart()),2)),
    (firstComplexNumber.getRealPart() * secondComplexNumber.getRealPart() -
            firstComplexNumber.getImaginaryPart() * secondComplexNumber.getImaginaryPart())
            / Math. pow((secondComplexNumber.getRealPart() + secondComplexNumber.getImaginaryPart()),2));
  }

  /**
   * This function compares two numbers .
   * @param firstComplexNumber first number.
   * @param secondComplexNumber second number.
   * @return 1 if the first number bigger than second, -1 if the second bigger, zero if they are equal.
   */
  public int compareTwoNumbers(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber) {
    return (Double.compare(Math.sqrt(Math.pow(firstComplexNumber.getRealPart(), 2)) +
                    Math.sqrt(Math.pow(firstComplexNumber.getImaginaryPart(), 2)),
            (Math.sqrt(Math.pow(secondComplexNumber.getRealPart(), 2)) +
                    Math.sqrt(Math.pow(secondComplexNumber.getImaginaryPart(), 2)))));
    }
}
