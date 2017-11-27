import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class StringCheckerTest {
  @Test
  public void validateStringWithIncludeBrackets() throws Exception {
    StringChecker stringChecker = new StringChecker("{{}}");
    assertEquals(stringChecker.validateString(), true);
  }
  @Test
  public void validateStringWithConsistentBrackets() {
    StringChecker stringChecker = new StringChecker("(){}[]");
    assertEquals(stringChecker.validateString(), true);
  }
  @Test
  public void validateStringWithIncludeBracketsAndSymbols() {
    StringChecker stringChecker = new StringChecker("(aa(aa)aa)");
    assertEquals(stringChecker.validateString(), true);
  }
  @Test
  public void validateStringWithConsistentBracketsWithSymbols() {
    StringChecker stringChecker = new StringChecker("(a){v}[b]");
    assertEquals(stringChecker.validateString(), true);
  }
  @Test
  public void validateStringWithIncludeBracketsWithoutCloseBracket() {
    StringChecker stringChecker = new StringChecker("((())");
    assertEquals(stringChecker.validateString(), false);
  }
  @Test
  public void validateStringWithConsistentBracketsWithoutCloseBrackets() {
    StringChecker stringChecker = new StringChecker("{}[]{(");
    assertEquals(stringChecker.validateString(), false);
  }
  @Test
  public void validateStringEmpty() {
    StringChecker stringChecker = new StringChecker("");
    assertEquals(stringChecker.validateString(), true);
  }
  @Test
  public void validateStringWithoutBrackets() {
    StringChecker stringChecker = new StringChecker("////");
    assertEquals(stringChecker.validateString(), true);
  }
}