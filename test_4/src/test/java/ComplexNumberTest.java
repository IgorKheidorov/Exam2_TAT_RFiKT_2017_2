import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.testng.Assert.*;
/**
 * This is test class for ComplexNumber class.
 */
public class ComplexNumberTest {

  @Test
  public void testAddUpComplexNumbers() throws Exception {
  }

  @Test
  public void testSubtractValue() throws Exception {
  }

  @Test
  public void testMultiplyTwoNumbers() throws Exception {
  }

  @Test
  public void testDivisionOfTwoNumbersPositiveNumbers() throws Exception {
    ComplexNumber expectedResult = new ComplexNumber(0.6,0.8);
    ComplexNumber compare = new ComplexNumber();
    ComplexNumber first = new ComplexNumber(3,9);
    ComplexNumber second = new ComplexNumber(9,3);
    assertEquals(compare.compareTwoNumbers(compare.divisionOfTwoNumbers(first,second),expectedResult),0);
  }

  @Test
  public void testCompareTwoEqualNumbers() throws Exception {
  ComplexNumber compare = new ComplexNumber();
  ComplexNumber first = new ComplexNumber(123,123);
  ComplexNumber second = new ComplexNumber(123,123);
    assertEquals(compare.compareTwoNumbers(first,second),0);
  }
  public void testCompareTwoNumbersIfTheFirstBigger() throws Exception {
    ComplexNumber compare = new ComplexNumber();
    ComplexNumber first = new ComplexNumber(123,123);
    ComplexNumber second = new ComplexNumber(7,6);
    assertEquals(compare.compareTwoNumbers(first,second),1);
  }
  public void testCompareTwoEqualNumbersIfTheFirstSmaller() throws Exception {
    ComplexNumber compare = new ComplexNumber();
    ComplexNumber first = new ComplexNumber(1,-1);
    ComplexNumber second = new ComplexNumber(19,123);
    assertEquals(compare.compareTwoNumbers(first,second),0);
  }
}