/**
 * Complex Number.
 */
public class ComplexNumber implements Comparable<ComplexNumber> {
  private double real;
  private  double imaginary;

  public ComplexNumber() {}

  /**
   * Initializes complex number by gotten real and imaginary values.
   * Throws exception if gotten values are NaN or Infinite.
   * @param real to initialize
   * @param imaginary to initialize
   */
  public ComplexNumber(double real, double imaginary) throws NullPointerException {
    if(Double.isNaN(real) || Double.isNaN(imaginary)) {
      throw new IllegalArgumentException("Object cannot be initialized by NaN");
    } else if (Double.isInfinite(real) || Double.isInfinite(imaginary)){
      throw new IllegalArgumentException("Object cannot be initialized by infinity");
    }
    this.real = real;
    this.imaginary = imaginary;
  }

  /**
   * Initializes complex number by gotten object's real and imaginary values.
   * @param other to initialize.
   */
  public ComplexNumber(ComplexNumber other) {
    this.real = other.real;
    this.imaginary = other.imaginary;
  }

  public void setReal(double real) {
    this.real = real;
  }

  public void setImaginary() {
    this.imaginary = imaginary;
  }

  public double getReal() {
    return real;
  }

  public double getImaginary() {
    return imaginary;
  }

  /**
   * Creates a sum of two complex numbers.
   * @param other to add.
   * @return a sum of two complex numbers.
   */
  public ComplexNumber add(ComplexNumber other) {
    return new ComplexNumber(this.real + other.real, this.imaginary + other.imaginary);
  }

  /**
   * Creates a difference of two complex numbers
   * @param other to take away.
   * @return a difference of two complex numbers.
   */
  public ComplexNumber takeAway(ComplexNumber other) {
    return new ComplexNumber(this.real - other.real, this.imaginary - other.imaginary);
  }

  /**
   * Creates a quotient of two complex numbers
   * @param other to divide.
   * @return a quotient of two complex numbers.
   */
  public ComplexNumber divide(ComplexNumber other) {
    double denominator = Math.pow(other.real, 2) + Math.pow(other.imaginary, 2);
    double tempReal = ((this.real * other.real) - (this.imaginary * other.imaginary)) / denominator;
    double tempImaginary = (other.imaginary * this.imaginary) - (this.real * other.imaginary) / denominator;
    return new ComplexNumber(tempReal, tempImaginary);
  }

  /**
   * Creates a composition of two complex numbers
   * @param other to multiply.
   * @return a composition of two complex numbers.
   */
  public ComplexNumber multiply(ComplexNumber other) {
    double tempReal = (this.real * other.real) - (this.imaginary * other.imaginary);
    double tempImaginary = this.real * other.imaginary + this.imaginary * other.real;
    return new ComplexNumber(tempReal, tempImaginary);
  }

  /**
   * Compares modules of two complex numbers
   * @param object to compare
   * Returns true if equal and false if they are not.
   */
  public int compareTo(ComplexNumber object) {
    return Double.compare(getModulus(this), getModulus(object));
  }


  public void print() {
    System.out.println(this.real + " + " + this.imaginary + "i");
  }

  private double getModulus(ComplexNumber object) {
    return Math.pow(object.real * object.real + object.imaginary * object.imaginary, 0.5);
  }


}
