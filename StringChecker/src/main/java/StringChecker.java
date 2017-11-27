/**
 * This class validate string above brackets it consist.
 */

public class StringChecker {
  private String input;
  private Stack stack;

  public StringChecker(String input) {
    this.input = input;
    stack = new Stack(input.length());
  }

  /**
   * This method validate string, that must contains open and close brackets.
   * @return true if string is valid.
   */
  public boolean validateString() {
    for (int i = 0; i < input.length(); i++) {
      char openBrackets = input.charAt(i);
      switch (openBrackets) {
        case '{':
        case '[':
        case '(':
          stack.addElement(openBrackets);
          break;
        case '}':
        case ']':
        case ')':
          if (!stack.isEmpty()) {
            char closeBracket = (char) stack.deleteElement();
            return !((openBrackets == '{' && closeBracket != '{') ||
                   (openBrackets == '[' && closeBracket != '[') ||
                   (openBrackets == '(' && closeBracket != '('));
          }
          break;
        default:
          break;
      }
    }
   return (stack.isEmpty());
  }
}