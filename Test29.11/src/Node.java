/**
 * This class creates a node.
 */
public class Node {
  private Pen value;
  private Node next;
  private Node previous;

  public Pen getValue() {
    return value;
  }

  public void setValue(Pen value) {
    this.value = value;
  }

  public Node getNext() {
    return next;
  }

  public void setNext(Node next) {
    this.next = next;
  }
}
