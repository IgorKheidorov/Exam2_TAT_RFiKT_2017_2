import static org.junit.Assert.*;

public class ValidatorTest {

  @org.junit.Test
  public void positiveTest() throws Exception {
    assertTrue(new Validator().checkBracketsAlignment("()"));
    assertTrue(new Validator().checkBracketsAlignment("[]"));
    assertTrue(new Validator().checkBracketsAlignment("{}"));
    assertTrue(new Validator().checkBracketsAlignment("(())"));
    assertTrue(new Validator().checkBracketsAlignment("{[()]}"));
    assertTrue(new Validator().checkBracketsAlignment("(){}[]"));
    assertTrue(new Validator().checkBracketsAlignment("1+1"));
    assertTrue(new Validator().checkBracketsAlignment(""));
  }

  @org.junit.Test
  public void negativeTest() throws Exception {
    assertFalse(new Validator().checkBracketsAlignment("(]"));
    assertFalse(new Validator().checkBracketsAlignment("[(]"));
    assertFalse(new Validator().checkBracketsAlignment("{"));
  }
}
