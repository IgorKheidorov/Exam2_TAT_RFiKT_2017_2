import java.util.Scanner;

/**
 * This is entry point class
 */
public class EntryPoint {
  public static void main(String[] args) {
    Scanner scanner  = new Scanner(System.in);
    System.out.println("Enter your line");
     String line = scanner.nextLine();
     IntegerConverter integerConverter = new IntegerConverter(line) ;
     System.out.println("Converted line" + integerConverter.convertLineIntoInteger());
  }
}
