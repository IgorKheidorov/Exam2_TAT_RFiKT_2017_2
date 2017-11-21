import java.util.ArrayList;

/**
 * This class takes an input string, check if it can present an integer value,
 * if yes convert it to integer
 */
public class IntegerConverter {
  final static char[] NOT_INTEGER_SYMBOLS = {'>', '<', '"','/', '|', '?', '*', '@', '!', '=', '-', '+', ')', '(', '&',
          '\\', '%', '$', '`', '~', '#', '№'};
  String line;

  /**
   * This function is constructor
   * @param inputLine entered from console line
   */
  public IntegerConverter(String inputLine) {
     this.line = inputLine;
  }

  /**
   * This function checks if line contains not integer symbols
   * @return true if line doesn't contain not integer symbols, false otherwise
   */
  private boolean isLineDoNotContainInvalidSymbols() {
    for (char singleStringElement : line.toUpperCase().toCharArray()) {
      if (singleStringElement == ' ' || (singleStringElement >= 'A' && singleStringElement <= 'Z')) {
        return false;
      }
      for (char singleCharElement : NOT_INTEGER_SYMBOLS) {
        if (singleCharElement == singleStringElement) {
          return false;
        }
      }
    }
    return true;
  }

  /**
   * This function detect second delimiter
   * @return index of the second delimiter
   */
  private int detectSecondDelimiter(){
    int count = 0;
    int secondDelimiter = 0;
      for (int i = 0; i < line.length(); i++) {
        char[] bufferString = line.toCharArray();
        if (bufferString[i] == '.' || bufferString[i] == ',') {
          count ++;
          if(count == 2) {
            secondDelimiter = i;
            break;
          }
        }
      }
    return secondDelimiter;
  }
  private int isLineIsNotAFractionalNumber() {
    int count = 0;
    for (char singleStringElement : line.toCharArray()) {
      if (singleStringElement == '.' || singleStringElement == ',') {
        count ++;
      }
    }
    return count ;
  }

  /**
   * This function checks if remainder contains only zeros
   * @return true if remainder contains only zeros, false otherwise.
   */
  private boolean isRemainderContainsOnlyZeros() {
    int delimiter = detectSecondDelimiter();
    String[] remainder = line.split("[\\,.]", delimiter);
    for ( int i = 0; i < remainder.length; i++) {
      if (Integer.parseInt(remainder[i]) != 0) {
        return false;
      }
    }
    return true;
  }

  /**
   * This function converts line into integer
   * @return  array list of a single number
   */
  public ArrayList<Integer> convertLineIntoInteger() {
    ArrayList<Integer> resultOfConverting = new ArrayList<Integer>();
    String[] splitedString = {};
    int count = 0;
    if (isLineDoNotContainInvalidSymbols() && isLineIsNotAFractionalNumber() <= 2) {
      for (char singleStringElement : line.toCharArray()) {
        if (singleStringElement == '.' || singleStringElement == ',') {
          splitedString = line.split("[\\,.]");
        }
        for (int i = 0; i < splitedString.length; i++) {
          resultOfConverting.add(Integer.parseInt(splitedString[i]));
        }
      }
      if (isLineDoNotContainInvalidSymbols() && isLineIsNotAFractionalNumber() == 2) {
        if (isRemainderContainsOnlyZeros()) {
          for (char singleStringElement : line.toCharArray()) {
            if (singleStringElement == '.' || singleStringElement == ',') {
              splitedString = line.split("[\\,.]");
              count ++;
              if(count == 2) {
                break;
              }
            }
            for (int i = 0; i < splitedString.length; i++) {
              resultOfConverting.add(Integer.parseInt(splitedString[i]));
            }
          } if (isLineDoNotContainInvalidSymbols() && isLineIsNotAFractionalNumber() == 0) {
            resultOfConverting.add(Integer.parseInt(line));
          }
        }
      }
    }
    return resultOfConverting;
  }
}
