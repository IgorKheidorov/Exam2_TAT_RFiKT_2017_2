import java.util.Stack;

/**
 * This class checks the correct alignment of brackets.
 */
public class Validator {

  private String openingBrackets = "([{";
  private String closingBrackets = ")]}";
  private Stack bracketStack = new Stack();

  /**
   * Checks the correct alignment of brackets.
   *
   * @param string a entered string
   * @return true if the brackets are arranged correctly
   */
  public boolean checkBracketsAlignment(String string) {
    for (char bracket : string.toCharArray()) {
      if (bracket == openingBrackets.toCharArray()[0]
              || bracket == openingBrackets.toCharArray()[1]
              || bracket == openingBrackets.toCharArray()[2]) {
        bracketStack.push(bracket);
      }
      if (bracket == closingBrackets.toCharArray()[0]
              || bracket == closingBrackets.toCharArray()[1]
              || bracket == closingBrackets.toCharArray()[2] && bracketStack.size() != 0) {
        deleteBracket(bracketStack.peek(), bracket);
      }
    }
    return (bracketStack.empty());
  }

  private void deleteBracket(Object openingBracket, char closingBracket) {
    for (int i = 0; i < openingBrackets.length(); i++) {
      if (openingBracket == openingBrackets.toCharArray()[i]
              && closingBracket == closingBrackets.toCharArray()[i]) {
        bracketStack.pop();
      }
    }
  }
}
