import java.util.NoSuchElementException;
/**
 * This class is my realisation of Stack.
 */
public class MyStack<E>  {
  private Node<E> top ;
  private int size ;

  /**
   * This is constructor.
   */
  public MyStack() {
    top = null;
    size = 0;
  }

  /**
   * Function to check if stack is empty
   * @return true if function is empty, false otherwise.
   */
  public boolean isEmpty() {
    return top == null;
  }

  /**
   * Function to get the size of the stack
   * @return size of the stack.
   */
  public int getSize() {
    return size;
  }

  /**
   * Function to push an element to the stack
   * @param data is element for pushing to stack.
   */
  public void push(E data) {
    Node pushValue = new Node (data, null);
    if (top == null)
      top = pushValue;
    else {
      pushValue.setNext(top);
      top = pushValue;
    }
    size++ ;
  }

  /**
   * Function to pop an element from the stack
   * @return
   */
  public E pop() {
    if (isEmpty() )
      throw new NoSuchElementException("Underflow Exception");
    Node deletingValue = top;
    top = deletingValue.getNext();
    size-- ;
    return (E) deletingValue.getData();
  }

  /**
   * Function to check the top element of the stack
   * @return return object at the top of this stack without removing it from the stack.
   */
  public E peek() {
    if (isEmpty() )
      throw new NoSuchElementException("Underflow Exception") ;
    return top.getData();
  }

  /**
   * This function clear stack.
   */
  public void clear() {
    if (isEmpty())
      throw new NoSuchElementException("Underflow Exception");
    while (size != 0) {
      Node deletingValue = top;
      top = deletingValue.getNext();
      size--;
    }
  }
}