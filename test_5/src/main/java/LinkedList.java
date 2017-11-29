/**
 * This class is doubly connected Linked List.
 */
public class LinkedList {
  private Node first;
  private Node current;
  private Node last;
  private int numElements;

  /**
   * This is constructor of doubly Linked List
   */
  public LinkedList() {
    this.first = null;
    this.last = null;
    this.numElements = 0;
    this.current = null;
  }

  /**
   * This class is a node for doubly Linked List
   */
  private class Node {
    Node next;
    Node previous;
    Object data;
  }

  /**
   * Checks if list has next element.
   * @return true if element has next, false otherwise.
   */
  public boolean hasNext() {
    return (current != null && current.next != null);
  }

  /**
   * This function return next element.
   * @return next element.
   */
  public Object next() {
    if (!this.hasNext()) {
      throw new IllegalStateException("No next");
    }
    current = current.next;
    return current.data;
  }

  /**
   * This function determine if list has previous element
   * @return true if has previous element, false otherwise
   */
  public boolean hasPrevious() {
    return (current != null && current.previous != null);
  }

  /**
   * This function return previous element.
   * @return previous element.
   */
  public Object previous() {
    if (!this.hasPrevious()) {
      throw new IllegalStateException("No previous");
    }
    current = current.previous;
    return current.data;
  }

  /**
   * This function set data
   * @param data data which must be set
   */
  public void set(Object data) {
    if (this.current == null) {
      throw new IllegalStateException("No node found, cannot set.");
    }
    current.data = data;
  }

  /**
   * This function  returns size of list
   * @return size of list
   */
  public int size() {
    return numElements;
  }

  /**
   * This function add element
   * @param transferredData
   */
  public void add(Object transferredData) {
    Node newNode = new Node();
    newNode.data = transferredData;
    if (first == null) {
      first = newNode;
      last = newNode;
      newNode.next = null;
    } else if (first != null) {
      if (current == null) {
        newNode.previous = null;
        newNode.next = first;
        first.previous = newNode;
        first = newNode;
      } else if (current == last) {
        newNode.previous = current;
        newNode.next = null;
        current.next = newNode;
        last = newNode;
      } else {
        newNode.previous = current;
        newNode.next = current.next;
        current.next.previous = newNode;
        current.next = newNode;
      }
    }
    current = newNode;
    numElements++;
  }

  /**
   * This function removes data
   */
  public void remove() {
    if (current != null) {
      if (current == first && current == last) {
        first = null;
        last = null;
      } else if (current == last) {
        current.previous = null;
        last = current.previous;
      } else if (current == last) {
        current.previous.next = null;
        last = current.previous;
      } else {
        current.previous.next = current.next;
        current.next.previous = current.previous;
      }
      current = current.next;
      numElements--;
    }
  }
}
