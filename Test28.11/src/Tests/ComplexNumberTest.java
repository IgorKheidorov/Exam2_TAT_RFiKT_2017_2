import static org.junit.Assert.*;

public class ComplexNumberTest {
  private ComplexNumber firstNumber = new ComplexNumber(1.0, 0.5);
  private ComplexNumber secondNumber = new ComplexNumber(0.25, 1.5);

  @org.junit.Test
  public void additionPositiveTest() throws Exception {
    new ComplexNumber().comparison(new ComplexNumber(1.25,2), new ComplexNumber().addition(firstNumber, secondNumber));
  }

  @org.junit.Test
  public void subtractionPositiveTest() throws Exception {
    new ComplexNumber().comparison(new ComplexNumber(0.75,1), new ComplexNumber().subtraction(firstNumber, secondNumber));
  }

  @org.junit.Test
  public void multiplicationPositiveTest() throws Exception {
    new ComplexNumber().comparison(new ComplexNumber(0.75,1), new ComplexNumber().multiplication(firstNumber, secondNumber));
  }
}
