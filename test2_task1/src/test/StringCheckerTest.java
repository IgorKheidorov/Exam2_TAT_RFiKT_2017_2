import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotEquals;

/**
 * Created by Dasha on 21.11.2017.
 */
public class StringCheckerTest {
  @Test
  public void checkPositiveInteger() throws Exception {
    StringChecker s = new StringChecker();
    assertEquals(s.convertIntegerValuesWithSign("47575"), 47575);
  }
  @Test
  public void checkNegativeInteger() {
    StringChecker s = new StringChecker();
    assertEquals(s.convertIntegerValuesWithSign("-35734"), -35734);
  }
  @Test
  public void checkPositiveNumberAndSymbols() {
    StringChecker s = new StringChecker();
    assertNotEquals(s.convertIntegerValuesWithSign("hfhfh57575fhfhf"), 57575);
  }
  @Test
  public void checkNegativeNumberAndSymbols() {
    StringChecker s = new StringChecker();
    assertNotEquals(s.convertIntegerValuesWithSign("-5775hdhdjdjd"), -5775);
  }
}