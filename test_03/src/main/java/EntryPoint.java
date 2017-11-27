/**
 * This is entry point class
 */
public class EntryPoint {
  public static void main(String[] args) {
    ValidatorOfTheAlgebraicExpression validatorOfTheAlgebraicExpression = new ValidatorOfTheAlgebraicExpression("{a}");
    if (validatorOfTheAlgebraicExpression.makeCheck()) {
      System.out.println("Valid expression");
    } else {
      System.out.println("Not a valid expression");
    }
  }
}
