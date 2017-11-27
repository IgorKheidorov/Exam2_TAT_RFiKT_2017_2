public class Main {

  public static void main(String[] args) {
    try {
      if (new Validator().checkBracketsAlignment("(){}[]")) {
        System.out.println("The brackets are arranged correctly.");
      }
    } catch (Exception e) {
      System.out.println("Exception" + e.getMessage());
    }
  }
}
