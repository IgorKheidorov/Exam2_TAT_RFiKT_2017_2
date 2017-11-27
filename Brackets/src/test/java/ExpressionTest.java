import java.util.Scanner;

import static org.junit.Assert.*;

/**
 * Created by siarhey on 27.11.17.
 */
public class ExpressionTest {
  @org.junit.Test
  public void isValid() throws Exception {
    String stringExpression = "(asd){adsf]";
    Expression expression = new Expression(stringExpression);
    System.out.println(expression.isValid());
  }

}