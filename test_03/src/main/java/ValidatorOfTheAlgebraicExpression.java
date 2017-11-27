import java.util.Stack;

/**
 * This class is a checker of an algebraic expression
 */
public class ValidatorOfTheAlgebraicExpression {
  private String input;
  private int lengthInput;
  private StackOfBrackets stack;

  /**
   * This function is constructor
   * @param input is a checking expression.
   */
  public ValidatorOfTheAlgebraicExpression(String input) {
    this.input = input;
    this.lengthInput = input.length();
    stack = new StackOfBrackets(lengthInput);
  }

  /**
   * This function checks if expression is valid
   * @return true if expression is valid, false otherwise
   */
  public boolean makeCheck() {
    for (int i = 0; i < lengthInput; i++) {
      char singleElement = input.charAt(i);
      switch (singleElement) {
        case '{':
        case '[':
        case '(':
          stack.addElement(singleElement);
          break;
        case '}':
        case ']':
        case ')':
          if (!stack.isEmpty()) {
            char elementClosed = (char) stack.deleteElement();
            return !((singleElement == '}' && elementClosed != '{') || (singleElement == ']' && elementClosed != '[')
                    || (singleElement == ')' && elementClosed != '('));
          } else
            return false;
        default:
          break;
      }
    }
    return true;
  }
}
