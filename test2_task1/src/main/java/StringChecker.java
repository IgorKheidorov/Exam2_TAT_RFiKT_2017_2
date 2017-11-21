/**
 * This class check is it possible to present string in integer value and if it possible
 * output it on the screen.
 */
public class StringChecker {
  /**
   * This method check is string can be presented as integer for two cases:
   * negative integer and positive.
   * numbers 48 - 57 is number's code from ASCII table.
   * @param string input string.
   * @return - true if string can be presented in integer, and false if cannot.
   */
  private boolean canPresentAsInteger(String string) {
    int countIntegerSymbols = 0;
    if (string.charAt(0) == '-') {
      for (int i = 1; i < string.length(); i++) {
        if (string.charAt(i) >= 48 && string.charAt(i) <= 57) {
          countIntegerSymbols++;
        }
      } return countIntegerSymbols == string.length() - 1;
    } else {
      for (int i = 0; i < string.length(); i++) {
        if (string.charAt(i) >= 48 && string.charAt(i) <= 57) {
          countIntegerSymbols++;
        }
      }
      return countIntegerSymbols == string.length();
    }
  }

  /**
   * This method convert string to integer by symbols.
   * @param string - input string.
   * @return integer presentation of string.
   */
  private int convertStringSymbolsToInt(String string) {
    int converted = 0;
    for (int i = string.length() - 1; i >= 0; i--) {
      converted += (string.charAt(i) - 48) * Math.pow(10.0, (string.length() - i - 1));
    }
    return converted;
  }

  /**
   * Convert integer presentation of string if convertation this string is possible
   * with sign.
   * @param string - input string
   * @return - integer presentation of string with a sign.
   */
  public int convertIntegerValuesWithSign(String string) {
    if (canPresentAsInteger(string)) {
      if (string.charAt(0) == '-') {
        string = string.substring(1);
        return convertStringSymbolsToInt(string) * (-1);
      }
    }
    return convertStringSymbolsToInt(string);
  }
}