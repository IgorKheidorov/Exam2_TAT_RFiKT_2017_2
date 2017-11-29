import org.junit.Test;

import static org.junit.Assert.*;

public class SinglyLinkedListTest {
  private Pen pen1 = new Pen(15, "green");
  private Pen pen2 = new Pen(10, "red");
  private Pen pen3 = new Pen(155, "black");
  private Pen pen4 = new Pen(1, "yellow");

  @Test
  public void addElementsPositiveTests() throws Exception {
    //assertArrayEquals(new Pen(15, "green"), new SinglyLinkedList().addBack(new Pen(15, "green")));
  }

  @Test
  public void sizePositiveTests() throws Exception {
    SinglyLinkedList list = new SinglyLinkedList();
    list.addBack(pen1);
    list.addBack(pen2);
    list.addBack(pen3);
    assertEquals(3, list.size());
  }

  @Test
  public void sizeNegativeTests() throws Exception {
    SinglyLinkedList list = new SinglyLinkedList();
    list.addBack(pen1);
    list.addBack(pen2);
    list.addBack(pen3);
    list.addBack(pen4);
    assertNotEquals(2, list.size());
  }
}
