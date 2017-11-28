import org.junit.Test;

/**
 * Created by Dasha on 28.11.2017.
 */
public class ComplexNumberTest {
  @Test
  public void ComplexNumber() {
    ComplexNumber complexNumber = new ComplexNumber(2.3, 3.6);
    ComplexNumber copy = new ComplexNumber(complexNumber);
    complexNumber.equals(copy);
  }
  @Test
  public void addTypicalNumbers() throws Exception {
    ComplexNumber first = new ComplexNumber(1.2, 3.1);
    ComplexNumber second = new ComplexNumber(3.4, 4.6);
    first.add(first, second).equals(new ComplexNumber(4.6,7.7));
  }

  @Test
  public void substract() throws Exception {
    ComplexNumber first = new ComplexNumber(1.2, 3.1);
    ComplexNumber second = new ComplexNumber(3.4, 4.6);
    first.substract(first, second).equals(new ComplexNumber(-2.2, -1.5));
  }

  @Test
  public void multiple() throws Exception {
    ComplexNumber first = new ComplexNumber(1.1, 2.2);
    ComplexNumber second = new ComplexNumber(3.3, 2.2);
    first.multiple(first, second).equals(new ComplexNumber(3.63, 4.84));
  }

  @org.junit.Test
  public void division() throws Exception {

  }

  @org.junit.Test
  public void outputOnScreen() throws Exception {
   ComplexNumber complexNumber = new ComplexNumber(2.2,3.3);
   
  }
}