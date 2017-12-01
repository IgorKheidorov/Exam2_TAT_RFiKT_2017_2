/**
 * This class is entry point.
 */
public class EntryPoint {
  public static void main(String[] args) {
    MyStack stack = new MyStack();
    stack.push("First" );
    stack.peek();
    System.out.println("Empty status = " + stack.isEmpty());
    System.out.println("Stack size : " + stack.getSize());
  }
}

