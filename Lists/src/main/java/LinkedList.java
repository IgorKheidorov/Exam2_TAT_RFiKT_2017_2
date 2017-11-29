/**
 * This class is linked list with add and remove methods.
 */
public class LinkedList {
  private Node head, tail;
  private int size;

  public LinkedList() {
    this.head = null;
    this.tail = null;
    this.size = 0;
  }

  /**
   * This function is added Car data to linked list.
   * @param data is Car data.
   */
  public void add(Car data) {
    if (!isEmpty()) {
      Node current = this.tail;
      this.tail = new Node(data, null);
      current.next = this.tail;
    } else {
      this.tail = new Node(data, null);
      this.head = this.tail;
    }
    size++;
  }

  /**
   * This function removes data
   *
   * @param data removing data
   */
  public void remove(Car data) {
    if (isEmpty()) {
      throw new IllegalStateException("Your linked list is empty");
    }
    Node previous = this.head;
    Node current = this.head;
    while (current.next != null || current == this.tail) {
      if (current.data.equals(data)) {
        if (size == 1) {
          this.head = null;
          this.tail = null;
        } else if (current.equals(this.head)) {
          this.head = this.head.next;
        } else if (current.equals(this.tail)) {
          this.tail = previous;
          this.tail.next = null;
        } else {
          previous.next = current.next;
        }
        size--;
        break;
      }
      previous = current;
      current = previous.next;
    }
  }

  /**
   * This function determines if list is empty.
   * @return true if linked list is empty, false in other case.
   */
  private boolean isEmpty() {
    return size == 0;
  }

  /**
   * This function returns start of the linked list
   * @return start of the list.
   */
  public Node getHead() {
    return this.head;
  }

  /**
   * This function returns end of the linked list
   * @return end of the list.
   */
  public Node getTail() {
    return this.tail;
  }

  /**
   * This function returns size of the linked list.
   * @return size of the list.
   */
  public int getSize() {
    return size;
  }
}