/**
 * This class is realisation of singly Linked List
 */
public class SinglyLinkedList<E> {
  private SinglyNode<E> head, tail;
  private int size;

  /**
   * This is constructor. From start list is empty.
   */
  public SinglyLinkedList() {
    super();
    this.head = null;
    this.tail = null;
    this.size = 0;
  }

  /**
   * This function is added subsequent data to list. If data added size grows
   * @param data is transferred data.
   */
  public void add(E data) {
    if (data == null) {
      throw new NullPointerException("Cannot add null data!!");
    }
    if (!isEmpty()) {
      SinglyNode<E> current = this.tail;
      this.tail = new SinglyNode<E>(data, null);
      current.next = this.tail;
    } else { // adding the first node
      this.tail = new SinglyNode<E>(data, null);
      this.head = this.tail;
    }
    size++;
  }

  /**
   * This function removes data
   * @param data removing data
   * @return true if element was removed, false otherwise.
   */
  public boolean remove(E data) {
    if (isEmpty()) {
      throw new IllegalStateException("Cannot remove() from an empty list!!");
    }
    boolean hasRemoved = false;
    SinglyNode<E> previous = this.head;
    SinglyNode<E> current = this.head;
    while (current.next != null || current == this.tail) {
      if (current.data.equals(data)) {
        if (size == 1) {
          this.head = null;
          this.tail = null;
        }
        else if (current.equals(this.head)) {
          this.head = this.head.next;
        } else if (current.equals(this.tail)) {
          this.tail = previous;
          this.tail.next = null;
        } else {
          previous.next = current.next;
        }
        size--;
        hasRemoved = true;
        break;
      }
      previous = current;
      current = previous.next;
    }
    return hasRemoved;
  }

  /**
   * This function determines if list is empty.
   * @return true if list is empty, false otherwise.
   */
  private boolean isEmpty() {
    return size == 0;
  }

  /**
   * This function returns start of the list
   * @return start of the list.
   */
  public SinglyNode<E> getHead() {
    return head;
  }

  /**
   * This function returns end of the list
   * @return end of the list.
   */
  public SinglyNode<E> getTail() {
    return tail;
  }

  /**
   * This function returns size of the list
   * @return size of the list.
   */
  public int getSize() {
    return size;
  }
}