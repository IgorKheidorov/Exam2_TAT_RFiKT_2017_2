/**
 * This class is node for stack.
 * @param <E>
 */
public class Node<E> {
  private Node<E> next = null;
  private E value;

  public Node(E value, Node next) {
    this.value = value;
    this.next = next;
  }
  public Node getNext(){
    return next;
  }
  public void setNext(Node next) {
    this.next = next;
  }
  public void setData(E value) {
    this.value = value;
  }
  public E getData() {
    return value;
  }
}