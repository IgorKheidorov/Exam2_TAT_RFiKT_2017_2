public class Main {

  public static void main(String[] args) {
    try {
      new Validator().checkBracketsAlignment("(){}[]");
    } catch (Exception e) {
      System.out.println("Exception" + e.getMessage());
    }
  }
}
