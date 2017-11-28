public class Main {

  public static void main(String[] args) {
    try {
      ComplexNumber result = new ComplexNumber();
      result.addition(new ComplexNumber(1.0, 0.5), new ComplexNumber(0.25, 1.5));
    } catch (Exception e) {
      System.out.println("Exception " + e.getMessage());
    }
  }
}
