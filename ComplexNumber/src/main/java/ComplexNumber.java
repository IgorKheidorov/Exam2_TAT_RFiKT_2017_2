/**
 * This class discribes complex number, has methods for add, multiple, division,
 * substrat, compare and output on the screen.
 */
public class ComplexNumber {
  private double real;
  private double imaginary;

  public double getReal() {
    return this.real;
  }
  public double getImaginary() {
    return this.real;
  }
  public void setReal() {
    this.real = real;
  }
  public void setImaginary() {
    this.imaginary = imaginary;
  }

  public ComplexNumber() {
  }

  public ComplexNumber(double real, double imaginary) {
    this.real = real;
    this.imaginary = imaginary;
  }

  /**
   * This constructor make new object, that is copy of object from param.
   * @param complexNumber - object, that will be copied in new object.
   */
  public ComplexNumber(ComplexNumber complexNumber) {
    real = complexNumber.real;
    imaginary = complexNumber.imaginary;
  }

  /**
   * This method add one complex number to another.
   * @param first - complex number.
   * @param second - complex number.
   * @return - complex number, that is result of add first complex number to second.
   */
  public ComplexNumber add(ComplexNumber first, ComplexNumber second) {
    return new ComplexNumber(first.real + second.real, first.imaginary + second.imaginary);
  }

  /**
   * This method substract one complex number to another.
   * @param first - complex number.
   * @param second - complex number.
   * @return - complex number, that is result of substract first complex number to another.
   */
  public ComplexNumber substract(ComplexNumber first, ComplexNumber second) {
    return new ComplexNumber(first.real - second.real, first.imaginary - second.imaginary);
  }

  /**
   * This method multiple one complex number to another.
   * @param first - complex number.
   * @param second - complex number.
   * @return - complex number, that is result of multiple first complex number to another.
   */
  public ComplexNumber multiple(ComplexNumber first, ComplexNumber second) {
    return new ComplexNumber(first.real * second.real, first.imaginary * second.imaginary);
  }

  /**
   * This method division one complex number to another.
   * @param first - complex number.
   * @param second - complex number.
   * @return - complex number, that is result of division  first complex number to another.
   */
  public ComplexNumber division(ComplexNumber first, ComplexNumber second) {
    return new ComplexNumber((first.real * second.real + first.imaginary * second.imaginary) /
                              (second.real * second.real + second.imaginary * second.imaginary),
                              (first.imaginary * second.real - first.real * second.imaginary) /
                              (second.real * second.real + second.imaginary * second.imaginary));
  }

  /**
   * This method compare one complex number to another.
   * @param first - complex number.
   * @param second - complex number.
   * @return - true if first and second are equals, false in another case.
   */
  public boolean equals(ComplexNumber first, ComplexNumber second) {
    int tempResult = Double.compare((Math.sqrt(first.real * first.real + first.imaginary + first.imaginary)),
                    Math.sqrt(second.real * second.real + second.imaginary * second.imaginary));
    return (tempResult == 0);
  }

  /**
   * This number output complex number on the screen in typical vision.
   * @param complexNumber - complex number.
   */
  public void outputOnScreen(ComplexNumber complexNumber) {
    System.out.println(complexNumber.real + "i" + complexNumber.imaginary);
  }
}
