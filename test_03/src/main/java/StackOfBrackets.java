/**
 * This class is make a stack and commands.
 */
public class StackOfBrackets {
  private int algebraicExpressionSize;
  private int[] stackArray;
  private int top;

  /**
   * This is constructor.
   * @param size is size of the algebraic expression.
   */
  public StackOfBrackets(int size) {
    this.algebraicExpressionSize = size;
    stackArray = new int[algebraicExpressionSize];
    top = - 1;
  }

  /**
   * This function fills the stack
   * @param element is an element putting into stack.
   */
  public void addElement (int element) {
    stackArray[++top] = element;
  }

  /**
   * This function delete elements of a stack
   * @return stack without deleted element.
   */
  public int deleteElement() {
    return stackArray[top--];
  }

  /**
   * This function is reads top of stack.
   * @return top of stack.
   */
  public int readTop() {
    return stackArray[top];
  }

  /**
   * This function checks if stack is empty
   * @return true if stack is empty, false otherwise
   */
  public boolean isEmpty() {
    return (top == - 1);
  }

  /**
   * This function full the stack
   * @return fulled stack.
   */
  public boolean isFull() {
    return (top == algebraicExpressionSize - 1);
  }
}
