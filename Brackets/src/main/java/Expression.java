import java.util.*;

/**
 * An expression to validate.
 */
public class Expression {
  private String expression;
  private final char[] brackets = {'(', '[', '{', ')', ']', '}'};

  /**
   * Initializes {@link Expression#expression} by gotten string expression.
   * @param expression expression to initialize.
   */
  public Expression(String expression) {
    this.expression = expression;
  }

  /**
   * Determines whether brackets location is valid.
   * Returns true if valid and false if it is not.
   */
  public boolean isValidBracketAlignment() {
    Stack<Character> openingBracket = getOpeningBrackets();
    Queue<Character> closingBracket = getClosingBrackets();
    for (int i = 0; i < countBrackets(); i++) {
      if (openingBracket.pop() != closingBracket.poll()) {
        return false;
      }
    }
    return true;
  }

  private Stack<Character> getOpeningBrackets() {
    Stack<Character> stack = new Stack<Character>();
    int i = 0;
    while (stack.size() != countBrackets() / 2) {
      for (char bracket : brackets) {
        if (expression.charAt(i) == bracket) {
          stack.push(expression.charAt(i));
        }
      }
      i++;
    }
    return stack;
  }

  private Queue<Character> getClosingBrackets() {
    Queue<Character> queue = new PriorityQueue<Character>();
    int i = expression.length() - 1;
    while (queue.size() != countBrackets() / 2) {
      for (char bracket : brackets) {
        if (expression.charAt(i) == bracket) {
          queue.add(expression.charAt(i));
        }
      }
      i--;
    }
    return queue;
  }

  private int countBrackets() {
    int counter = 0;
    for(char character : expression.toCharArray()) {
      for (char bracket : brackets) {
        if (character == bracket) {
          counter++;
        }
      }
    }
    return counter;
  }


}
