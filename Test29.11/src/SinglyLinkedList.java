/**
 * This class works with simply linked list.
 */
public class SinglyLinkedList {
  private Node firstElement;
  private Node lastElement;
  private int count = 0;
  Node current = new Node();

  /**
   * Adds element in the front of the list.
   *
   * @param pen the element that will be added
   */
  public void addFront(Pen pen) {
    Node node = new Node();
    node.setValue(pen);
    if (firstElement == null) {
      firstElement = node;
      lastElement = node;
    } else {
      node.setNext(lastElement);
      firstElement = node;
    }
    count++;
  }

  /**
   * Adds element in the back of the list.
   *
   * @param pen the element that will be added
   */
  public void addBack(Pen pen) {
    Node node = new Node();
    node.setValue(pen);
    if (lastElement == null) {
      firstElement = node;
      lastElement = node;
    } else {
      node.setNext(firstElement);
      lastElement = node;
    }
    count++;
  }

  /**
   * Gets the link from the current element to the next element.
   *
   * @return the link to the next element
   */
  public Node getNextElement() {
    while (current.getNext() != null) {
      current = current.getNext();
      return current.getNext();
    }
    return null;
  }

  /**
   * Contains size of the list.
   *
   * @return the size of the list
   */
  public int size() {
    return count;
  }

  /**
   * Assigns the first element to the current.
   */
  public void assignFirstToCurrent() {
    current = firstElement;
  }
}
