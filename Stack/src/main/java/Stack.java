
import java.util.NoSuchElementException;

/**
 * Created by siarhey on 01.12.17.
 */
public class Stack {

  private Element top;
  private int numberOfElements;

  /**
   * Creats an empty stack and sets {@link Stack#numberOfElements} equal 0.
   */
  public Stack() {
    numberOfElements = 0;
  }

  /**
   * Pushes gotten item on the op of the stack.
   * @param gottenItem item we are pushing.
   */
  public void push(Object gottenItem) {
    Element oldTop = top;
    top = new Element ();
    top.setItem(gottenItem);
    top.setPrevious(oldTop);
    numberOfElements++;
  }

  /**
   * Returns the object at the top of this stack without removing it from the stack.
   * If the stack is empty returns -1.
   */
  public Object peek() {
    if(numberOfElements > 0) {
      return top.getItem();
    } else {
      return -1;
    }
  }

  /**
   * Removes the object at the top of this stack and returns that object as the value of this method.
   */
  public Object pop() {
    Object item;
    if (numberOfElements == 0) {
      throw new NoSuchElementException("Stack underflow");
    }
    if (numberOfElements == 1) {
      item = top.getItem();
      top = null;
      numberOfElements--;
      return item;
    }
    top = top.getPrevious();
    numberOfElements--;
    return top.getItem();
  }

  /**
   * Returns true if the stack is empty and false if it is not.
   */
  public boolean isEmpty() {
    return numberOfElements == 0;
  }

  /**
   * Returns number of elements in stack.
   */
  public int getNumberOfElements() {
    return numberOfElements;
  }

  /**
   * Returns the index of item we are are searching for.
   * If there is no such element returns -1.
   * @param item item we are searching.
   */
  public int search(Object item) {
    Element temp = top;
    if (top.getItem() == item) {
      return numberOfElements - 1;
    } else {
      int index = numberOfElements - 2;
      while (temp.getPrevious() != null) {
        temp = temp.getPrevious();
        if (temp.getItem() == item) {
          return index;
        }
        index--;
      }
      return -1;
    }
  }

  public void clear() {
    while (numberOfElements > 0) {
      pop();
    }
  }
}


