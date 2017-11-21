import java.util.Scanner;

public class Main {

  public static void main(String[] args) {
    try {
      Scanner scanner = new Scanner(System.in);
      StringChecker checker = new StringChecker();
      System.out.println("Enter a string:");
      int number = checker.stringToInt(scanner.nextLine());
      if (number == 0) {
        System.out.println("Not an integer value.");
      } else {
        System.out.println("Result: " + number);
      }
    } catch (Exception e) {
      System.out.println("Exception " + e.getMessage());
    }
  }
}
