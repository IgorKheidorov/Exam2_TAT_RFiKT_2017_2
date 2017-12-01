import java.util.NoSuchElementException;

/**
 * This class is stack from scratch.
 * @param <E> - type of data, that are contains in stack.
 */

public class MyStack<E> {
  private int size = 0;
  private Node top = null;

  /**
   *  This method checks if stack is empty.
   *  @return - true is stack is empty, false - in another case.
   */
  public boolean isEmpty()
  {
    return top == null;
  }
  /**
   *  Function to get the size of the stack
   *  @return - size of stack.
   */
  public int getSize()
  {
    return size;
  }

  /**
   * This method push object in stack.
   * @param value - object, that is pushed in stack.
   */
  public void push(E value)
  {
    Node temp = new Node (value, null);
    if (top == null)
      top = temp;
    else
    {
      temp.setNext(top);
      top = temp;
    }
    size++ ;
  }

  /**
   *  This method pop element from the stack
   *  @return - object, that is popped.
   */
  public E pop()
  {
    if (isEmpty() )
      throw new NoSuchElementException("Underflow Exception") ;
    Node temp = top;
    top = temp.getNext();
    size-- ;
    return (E)temp.getData();
  }

  /**
   *  This method check the top element of the stack.
   *  @return - object, that is the top of stack.
   */
  public E peek()
  {
    if (isEmpty() )
      throw new NoSuchElementException("Underflow Exception") ;
    return (E)top.getData();
  }

  /**
   * THis method clear stack.
   * @param myStack - input stack.
   */
  public void clear(MyStack myStack) {
    if (!myStack.isEmpty()) {
      for (int i = 0; i < myStack.getSize(); i++) {
        myStack.pop();
      }
    }
  }
}