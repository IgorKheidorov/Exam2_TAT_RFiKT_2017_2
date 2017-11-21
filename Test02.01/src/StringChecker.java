/**
 * This class checks if the entered string can be transformed to Integer.
 */
public class StringChecker {
  static private final int CONST_ZERO = 48;
  static private final int CONST_LOWA = 97;
  static private final int CONST_LOWZ = 122;

  /**
   * Converts a string to an Integer.
   * @param string a string that was entered by a user
   * @return intValue a result of converting
   */
  public int stringToInt(String string) {
    string = string.split("\\.|\\,")[0];
    int intValue = 0;
    int maxLength = string.length() - 1;
    for (int i = 0; i <= maxLength; i++) {
      String lowerCaseString = string.toLowerCase();
      int numeral = lowerCaseString.charAt(i);
      if (checkForLetters(numeral)) {
        intValue = intValue + ((numeral - CONST_ZERO) * (int) Math.pow(10, maxLength - i));
      }
    }
    return intValue;
  }

  private boolean checkForLetters(int numeral) {
    for (int j = CONST_LOWA; j <= CONST_LOWZ; j++) {
      if (numeral == j) {
        return false;
      }
    }
    return true;
  }
}
