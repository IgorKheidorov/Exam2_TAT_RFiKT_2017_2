import java.util.EmptyStackException;

/**
 * This class realizes stack.
 */
public class MyStack<E> {
  private Node<E> firstElement;
  private Node<E> lastElement;
  private int count = 0;
  private Node<E> current = new Node<E>();

  /**
   * Pushes an item onto the top of this stack.
   *
   * @param item the item to be pushed onto this stack
   * @return the item argument
   */
  public E push(E item) {
    Node<E> node = new Node<E>();
    node.setValue(item);
    if (firstElement == null) {
      firstElement = node;
      lastElement = node;
    } else {
      node.setNext(lastElement);
      firstElement = node;
    }
    count++;
    return lastElement.getValue();
  }

  /**
   * Removes the object at the top of this stack and returns that object as the value of this function.
   *
   * @return the object at the top of this stack
   * @throws EmptyStackException if the stack is empty
   */
  public E pop() {
    if (isEmpty()) {
      throw new EmptyStackException();
    } else {
      current = lastElement;
      lastElement.setValue(null);
      count--;
      return current.getValue();
    }
  }

  /**
   * Looks at the object at the top of this stack without removing it from the stack.
   *
   * @return the object at the top of this stack
   * @throws EmptyStackException if the stack is empty
   */
  public E peek() {
    if (isEmpty()) {
      throw new EmptyStackException();
    }
    return lastElement.getValue();
  }

  /**
   * Tests if this stack is empty.
   *
   * @return true if and only if this stack contains no items; false otherwise.
   */
  public boolean isEmpty() {
    return (count == 0);
  }

  /**
   * Deletes all objects in the stack.
   */
  public void clear() {
    if (isEmpty()) {
      return;
    } else {
      do {
        current = firstElement;
        current.setNext(current);
      }
      while (current.getNext() != null);
    }
    count = 0;
  }

  /**
   * Contains size of the stack.
   *
   * @return the size of the stack
   */
  public int getSize() {
    return count;
  }
}
