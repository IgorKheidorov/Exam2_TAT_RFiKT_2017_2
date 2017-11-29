/**
 * This class is node for single linked list.
 */
public class Node {
  Node next = null;
  Car data;
  public Node(Car data, Node next) {
    this.next = next;
    this.data = data;
  }
  public Node getNext() {
    return next;
  }
  public Car getData() {
    return data;
  }
  public void setNext(Node next) {
    this.next = next;
  }
  public void setData(Car data) {
    this.data = data;
  }
}
