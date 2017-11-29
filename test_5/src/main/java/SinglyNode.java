/**
 * This class is a single Node
 */
public class SinglyNode<E> {
  E data;
  SinglyNode <E> next;

  public SinglyNode(E data, SinglyNode<E> next) {
    this.data = data;
    this.next = next;
  }

  public E getData() {
    return data;
  }

  public void setData(E data) {
    this.data = data;
  }

  /**
   * This function get next element
   * @return next element
   */
  public SinglyNode<E> getNext() {
    return next;
  }

  /**
   * This function set next element
   * @param next is a next element for set
   */
  public void setNext(SinglyNode<E> next) {
    this.next = next;
  }

}


