package DoublyLinked;

import java.util.Iterator;
import java.util.NoSuchElementException;
/**
 * Doubly linked list.
 */
public class DoublyLinkedList<T> implements Iterable<T>{
  private Element<T> first;
  private Element<T> last;
  private int numberOfElements;

  /**
   * An element containing a link to a next element and to a previous.
   */
  public class Element<T> {
    private T item;
    private Element<T> next;
    private Element<T> previous;
  }

  /**
   * Initializes an empty queue.
   */
  public DoublyLinkedList() {
    first = null;
    last = null;
    numberOfElements = 0;
  }

  /**
   * Returns the number of items in this queue.
   */
  public int size() {
    return numberOfElements;
  }

  /**
   * Adds an element to the end of list.
   * @param gottenElement element we are adding.
   */
  public void add(T gottenElement) {
    Element<T> oldlast = last;
    last = new Element<>();
    last.item = gottenElement;
    last.next = null;
    last.previous = oldlast;
    if (numberOfElements == 0) {
      first = last;
    }
    else {
      oldlast.next = last;
    }
    numberOfElements++;
  }

  /**
   * Returns and removes first element from the list.
   */
  public Element poll() {
    if (numberOfElements == 0) throw new NoSuchElementException("List underflow");
    Element<T> item = first;
    first = first.next;
    first.previous = null;
    numberOfElements--;
    if (numberOfElements == 0) {
      last = null;
    }
    return item;
  }

  /**
   * Returns an iterator that iterates over the items in this list.
   */
  public Iterator<T> iterator()  {
    return new ListIterator<T>(first);
  }

  /**
   * Sets first element as current.
   */
  private class ListIterator<T> implements Iterator<T> {
    private Element<T> current;

    public ListIterator(Element<T> first) {
      current = first;
    }

    /**
     * Checks whether the list has next element.
     */
    public boolean hasNext()  {
      return current != null;
    }

    public boolean hasPrevious()  {
      return current != null;
    }

    /**
     * Returns the value of next element.
     */
    public T previous() {
      if (!hasPrevious()) throw new NoSuchElementException();
      T item = current.item;
      current = current.previous;
      return item;
    }

    public T next() {
      if (!hasNext()) throw new NoSuchElementException();
      T item = current.item;
      current = current.next;
      return item;
    }
  }
}
