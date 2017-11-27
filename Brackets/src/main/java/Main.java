import java.util.Scanner;

/**
 * Contains start point of the program.
 * Determines whether an expression is valid.
 */
public class Main {
  public static void main(String[] args) {
    Scanner in = new Scanner(System.in);
    System.out.println("print algebraic expression:");
    String stringExpression = in.nextLine();
    Expression expression = new Expression(stringExpression);
    if (expression.isValid()) {
      System.out.println("Expression is valid");
    } else {
      System.out.println("Expression is INVALID");
    }
  }
}
