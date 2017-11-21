import static org.junit.Assert.*;

public class StringCheckerTest {
  @org.junit.Test
  public void stringToIntPositiveTests() throws Exception {
    assertEquals(45, new StringChecker().stringToInt("45"));
    assertEquals(75, new StringChecker().stringToInt("75.00"));
    assertEquals(5, new StringChecker().stringToInt("5,56"));
    assertEquals(0, new StringChecker().stringToInt("string"));
    assertEquals(0, new StringChecker().stringToInt(""));
  }
}