import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.testng.Assert.*;

/**
 * Created by User on 27.11.2017.
 */
public class ValidatorOfTheAlgebraicExpressionTest {

  @DataProvider(name = "ValidAlgebraicExpression")
  public static Object[][] testValidData() {
    return new Object[][] {
            { "{}" },
            { "[a * d]"},
            {"{[]a + s}"},
            {"[((a))]"},
            {"{[()]}"}

    };
  }
  @Test(dataProvider = "ValidAlgebraicExpression")
  public void testIsValidAlgebraicExpression (String string) {
    ValidatorOfTheAlgebraicExpression validator = new ValidatorOfTheAlgebraicExpression(string);
    assertTrue(validator.makeCheck());
  }
  @DataProvider(name = "invalidAlgebraicExpression")
  public static Object[][] testInvalidData() {
    return new Object[][] {
            { "{[}" },
            { "[a({)"},
            {"{[*)}"},
            {"a[s(}){"},

    };
  }
  @Test(dataProvider = "invalidAlgebraicExpression")
  public void testIsInvalidAlgebraicExpression (String string) {
    ValidatorOfTheAlgebraicExpression validator = new ValidatorOfTheAlgebraicExpression(string);
    assertFalse(validator.makeCheck());
  }

}
