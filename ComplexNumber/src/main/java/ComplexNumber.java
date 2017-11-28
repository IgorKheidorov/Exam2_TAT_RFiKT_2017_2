/**
 * Created by siarhey on 28.11.17.
 */
public class ComplexNumber implements Comparable<ComplexNumber> {
  private double real;
  private  double imaginary;

  public ComplexNumber() {}

  public ComplexNumber(double real, double imaginary) throws NullPointerException {
    if(Double.isNaN(real) || Double.isNaN(imaginary)) {
      throw new IllegalArgumentException("Object cannot be initialized by NaN");
    } else if (Double.isInfinite(real) || Double.isInfinite(imaginary)){
      throw new IllegalArgumentException("Object cannot be initialized by infinity");
    }
    this.real = real;
    this.imaginary = imaginary;
  }

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

  public ComplexNumber add(ComplexNumber other) {
    return new ComplexNumber(this.real + other.real, this.imaginary + other.imaginary);
  }

  public ComplexNumber takeAway(ComplexNumber other) {
    return new ComplexNumber(this.real - other.real, this.imaginary - other.imaginary);
  }

  public ComplexNumber divide(ComplexNumber other) {
    double denominator = Math.pow(other.real, 2) + Math.pow(other.imaginary, 2);
    double tempReal = ((this.real * other.real) - (this.imaginary * other.imaginary)) / denominator;
    double tempImaginary = (other.imaginary * this.imaginary) - (this.real * other.imaginary) / denominator;
    return new ComplexNumber(tempReal, tempImaginary);
  }

  public ComplexNumber multiply(ComplexNumber other) {
    double tempReal = (this.real * other.real) - (this.imaginary * other.imaginary);
    double tempImaginary = this.real * other.imaginary + this.imaginary * other.real;
    return new ComplexNumber(tempReal, tempImaginary);
  }

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
