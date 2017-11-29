import static org.junit.Assert.*;

public class SinglyLinkedListTest {
  private Pen pen1 = new Pen(15, "green");
  private Pen pen2 = new Pen(10, "red");
  private Pen pen3 = new Pen(155, "black");
  private Pen pen4 = new Pen(1, "yellow");

  @org.junit.Test
  public void sizePositiveTest() throws Exception {
    SinglyLinkedList list = new SinglyLinkedList();
    list.addBack(pen1);
    list.addBack(pen2);
    list.addBack(pen3);
    assertEquals(3, list.size());
  }

  @org.junit.Test
  public void sizeNegativeTest() throws Exception {
    SinglyLinkedList list = new SinglyLinkedList();
    list.addBack(pen1);
    list.addBack(pen2);
    list.addBack(pen3);
    list.addBack(pen4);
    assertNotEquals(2, list.size());
  }

  @org.junit.Test
  public void getNextElementTest() throws Exception {
    SinglyLinkedList list = new SinglyLinkedList();
    Node node1 = new Node();
    Node node2 = new Node();
    node1.setValue(pen1);
    node2.setValue(pen2);
    list.addBack(pen1);
    list.addBack(pen2);
    list.assignFirstToCurrent();
    list.getNextElement();

    assertEquals(node1,  list.getNextElement().getValue());
    assertEquals(node1, list.getNextElement().getNext());
  }
}
