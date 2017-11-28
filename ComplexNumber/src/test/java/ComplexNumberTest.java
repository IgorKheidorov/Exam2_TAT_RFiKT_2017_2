import java.util.Random;

import static org.junit.Assert.*;

/**
 * Created by siarhey on 28.11.17.
 */
public class ComplexNumberTest {

  @org.junit.Test
  public void checkDefaultConstructor() {
    ComplexNumber complexNumber = new ComplexNumber();
  }

  @org.junit.Test
  public void checkConstructorWithParameters() {
    Random random = new Random();
    ComplexNumber complexNumber = new ComplexNumber(random.nextDouble(), random.nextDouble());
  }

  @org.junit.Test
  public void checkCopyingConstructorForReal() {
    Random random = new Random();
    double real = random.nextDouble();
    double imaginary = random.nextDouble();
    ComplexNumber complexNumber = new ComplexNumber(new ComplexNumber(real, imaginary));
    assertEquals(real, complexNumber.getReal(), 0.0000001);
    assertEquals(imaginary, complexNumber.getImaginary(), 0.0000001);
  }

  @org.junit.Test
  public void testConstructorWithParametersForMaxDouble() {
    ComplexNumber complexNumber = new ComplexNumber(Double.MAX_VALUE, Double.MAX_VALUE);
  }

  @org.junit.Test
  public void testConstructorWithParametersForMinDouble() {
    ComplexNumber complexNumber = new ComplexNumber(Double.MIN_VALUE, Double.MIN_VALUE);
  }

  @org.junit.Test(expected = IllegalArgumentException.class)
  public void testConstructorWithParametersForPositiveInfinity() {
    ComplexNumber complexNumber = new ComplexNumber(Double.POSITIVE_INFINITY, Double.POSITIVE_INFINITY);
  }

  @org.junit.Test(expected = IllegalArgumentException.class)
  public void testConstructorWithParametersForNegativeInfinity() {
    ComplexNumber complexNumber = new ComplexNumber(Double.NEGATIVE_INFINITY, Double.NEGATIVE_INFINITY);
  }

  @org.junit.Test(expected = IllegalArgumentException.class)
  public void testConstructorWithParametersForNan() {
    ComplexNumber complexNumber = new ComplexNumber(Double.NaN, Double.NaN);
  }

  @org.junit.Test
  public void testCopyingConstructor() {
    Random random = new Random();
    double real = random.nextDouble();
    double imaginary = random.nextDouble();
    ComplexNumber complexNumber1 = new ComplexNumber(real, imaginary);
    ComplexNumber complexNumber2 = new ComplexNumber(complexNumber1);
    assertEquals(real, complexNumber2.getReal(), 0.00001);
    assertEquals(imaginary, complexNumber2.getImaginary(), 0.000001);
  }

  @org.junit.Test
  public void testAddMethod() throws Exception {
    Random random = new Random();
    double real1 = random.nextDouble();
    double imaginary1 = random.nextDouble();
    double real2 = random.nextDouble();
    double imaginary2 = random.nextDouble();
    ComplexNumber complexNumber = new ComplexNumber(real1, imaginary1).add(new ComplexNumber(real2, imaginary2));
    assertEquals(real1 + real2, complexNumber.getReal(), 00000.1);
    assertEquals(imaginary1 + imaginary2, complexNumber.getImaginary(), 00000.1);
  }

  @org.junit.Test
  public void takeAway() throws Exception {
    Random random = new Random();
    double real1 = random.nextDouble();
    double imaginary1 = random.nextDouble();
    double real2 = random.nextDouble();
    double imaginary2 = random.nextDouble();
    ComplexNumber complexNumber = new ComplexNumber(real1, imaginary1).takeAway(new ComplexNumber(real2, imaginary2));
    assertEquals(real1 - real2, complexNumber.getReal(), 00000.1);
    assertEquals(imaginary1 - imaginary2, complexNumber.getImaginary(), 00000.1);
  }

  @org.junit.Test
  public void divide() throws Exception {
    Random random = new Random();
    double real1 = random.nextDouble();
    double imaginary1 = random.nextDouble();
    double real2 = random.nextDouble();
    double imaginary2 = random.nextDouble();
    ComplexNumber complexNumber = new ComplexNumber(real1, imaginary1).divide(new ComplexNumber(real2, imaginary2));
    double denominator = Math.pow(real2, 2) + Math.pow(imaginary2, 2);
    double tempReal = ((real1 * real2) - (imaginary1 * imaginary2)) / denominator;
    double tempImaginary = (imaginary2 * imaginary1) - (real1 * imaginary2) / denominator;
    assertEquals(tempReal, complexNumber.getReal(), 0.0001);
    assertEquals(tempImaginary, complexNumber.getImaginary(), 0.0001);
  }

  @org.junit.Test
  public void multiply() throws Exception {
    Random random = new Random();
    double real1 = random.nextDouble();
    double imaginary1 = random.nextDouble();
    double real2 = random.nextDouble();
    double imaginary2 = random.nextDouble();
    ComplexNumber complexNumber = new ComplexNumber(real1, imaginary1).multiply(new ComplexNumber(real2, imaginary2));
    double tempReal = (real1 * real2) - (imaginary1 * imaginary2);
    double tempImaginary = real1 * imaginary2 + imaginary1 * real2;
    assertEquals(tempReal, complexNumber.getReal(), 0.0001);
    assertEquals(tempImaginary, complexNumber.getImaginary(), 0.0001);
  }

  @org.junit.Test
  public void compareToPositive() throws Exception {
    Random random = new Random();
    ComplexNumber complexNumber1 = new ComplexNumber(random.nextDouble(), random.nextDouble());
    ComplexNumber complexNumber2 = new ComplexNumber(complexNumber1);
    assertEquals(0, complexNumber1.compareTo(complexNumber2));
  }

  @org.junit.Test
  public void compareToNegative() throws Exception {
    Random random = new Random();
    ComplexNumber complexNumber1 = new ComplexNumber(random.nextDouble(), random.nextDouble());
    ComplexNumber complexNumber2 = new ComplexNumber(random.nextDouble(), random.nextDouble());
    assertEquals(1, complexNumber1.compareTo(complexNumber2));
  }
}