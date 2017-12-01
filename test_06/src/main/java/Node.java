/**
 * This class is node for My Stack
 */
class Node<E> {
  private E data;
  private Node<E> next;

  /**
   * This is constructor.
   */
  public Node(E inputData, Node inputLink) {
    data = inputData;
    next = inputLink;
  }
  /**
   * Function to set next to next Node
   */
  public void setNext(Node<E> inputLink) {
    next = inputLink;
  }

  /**
   * Function to set data to current Node
   */
  public void setData(E inputData) {
    data = inputData;
  }

  /**
   * Function to get next node
   */
  public Node<E> getNext() {
    return next;
  }

  /**
   * Function to get data from current Node
   */
  public E getData() {
    return data;
  }
}

